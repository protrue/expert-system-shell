using System;
using System.Drawing;
using System.Windows.Forms;
using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class DomainForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }
        public Domain Domain { get; set; }

        private Domain _domain;
        private object _listBoxValueDraggedItem;

        private bool _setNameSuccess = false;

        public DomainForm()
        {
            InitializeComponent();
        }

        private bool TrySetIndexedNamedItem(Action setAction)
        {
            var isSuccess = false;

            try
            {
                setAction.Invoke();
                isSuccess = true;
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                MessageBox.Show(argumentOutOfRangeException.Message);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }

            return isSuccess;
        }

        private void DomainFormLoad(object sender, EventArgs e)
        {
            if (Domain != null)
                _domain = (Domain)Domain.Clone();
            else
                _domain = new Domain($"Домен {KnowledgeBase.Domains.Count + 1}");

            textBoxName.Text = _domain.Name;
            textBoxName.Select();
            textBoxName.Focus();

            foreach (var item in _domain.Values)
                listBoxValues.Items.Add(item);
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            TrySetIndexedNamedItem(() =>
            {
                var domainValue = new IndexedNamedItem(textBoxValue.Text);
                _domain.Values.Add(domainValue);
                listBoxValues.Items.Add(domainValue);
                listBoxValues.SelectedIndex = -1;
                textBoxValue.Text = string.Empty;
            });
        }

        private void ButtonChangeClick(object sender, EventArgs e)
        {
            var selectedIndex = listBoxValues.SelectedIndex;
            if (selectedIndex < 0)
                return;

            TrySetIndexedNamedItem(() =>
            {
                _domain.Values[selectedIndex].Name = textBoxValue.Text;
                listBoxValues.Items[selectedIndex] = _domain.Values[selectedIndex];
            });
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            var selectedIndex = listBoxValues.SelectedIndex;
            Domain.Values.Delete(selectedIndex);
            listBoxValues.Items.RemoveAt(selectedIndex);
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (_domain.Values.Count == 0)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Домен должен иметь хотя бы одно значение");
                textBoxValue.Select();
                textBoxValue.Focus();
                return;
            }

            if (KnowledgeBase.Domains.Contains(_domain) && Domain?.Index != _domain.Index)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Домен с таким именем уже есть");
                textBoxName.Select();
                textBoxName.Focus();
                return;
            }

            if (Domain == null)
                Domain = new Domain(_domain.Name);
            Domain.Name = _domain.Name;
            Domain.Values = _domain.Values;
        }

        private void ListBoxValuesSelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValue.Text =
                listBoxValues.SelectedIndex >= 0
                    ? listBoxValues.SelectedItem.ToString()
                    : string.Empty;
            buttonChange.Enabled = listBoxValues.SelectedIndex >= 0;
            buttonDelete.Enabled = listBoxValues.SelectedIndex >= 0;
        }

        private void TextBoxNameLeave(object sender, EventArgs e)
        {
            try
            {
                _domain.Name = textBoxName.Text;
                _setNameSuccess = true;
            }
            catch (Exception exception)
            {
                _setNameSuccess = false;
                textBoxName.Text = _domain.Name;
                textBoxName.Select();
                textBoxName.Focus();
                MessageBox.Show(exception.Message);
            }
        }

        private void ListBoxValuesDragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ListBoxValuesDragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxValues.PointToClient(new Point(e.X, e.Y));
            int insertIndex = listBoxValues.IndexFromPoint(point);
            if (insertIndex < 0) insertIndex = listBoxValues.Items.Count - 1;
            if (insertIndex == listBoxValues.SelectedIndex) return;
            _domain.Values.Swap(listBoxValues.SelectedIndex, insertIndex);
            object data = e.Data.GetData(typeof(IndexedNamedItem));
            listBoxValues.Items.Remove(data);
            listBoxValues.Items.Insert(insertIndex, data);
            listBoxValues.SelectedIndex = insertIndex;
        }

        private void ListBoxValuesMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (listBoxValues.SelectedItem == null) return;
            listBoxValues.DoDragDrop(listBoxValues.SelectedItem, DragDropEffects.Move);
        }

        private void TextBoxValueKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonAddClick(this, EventArgs.Empty);
        }

        private void TextBoxNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxValue.Focus();

                if (!_setNameSuccess)
                {
                    textBoxName.Select();
                    textBoxName.Focus();
                    return;
                }

                textBoxValue.Select();
            }
        }
    }
}
