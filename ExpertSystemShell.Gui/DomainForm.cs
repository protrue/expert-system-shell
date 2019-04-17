using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class DomainForm : Form
    {
        public IndexedList<Domain> Domains { get; set; }
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
            if (Domains == null)
                Domains = new IndexedList<Domain>();

            if (Domain != null)
                _domain = (Domain)Domain.Clone();
            else
                _domain = new Domain($"Домен {Domains.Count + 1}");

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
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Домен должен иметь хотя бы одно значение");
                textBoxValue.Select();
                textBoxValue.Focus();
            }

            if (Domains.Contains(_domain) && Domain?.Index != _domain.Index)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Домен с таким именем уже есть");
                textBoxName.Select();
                textBoxName.Focus();
            }
            else
            {
                Domain = _domain;
            }
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

        private void ButtonCancelClick(object sender, EventArgs e)
        {

        }

        private void ListBoxValuesMouseDown(object sender, MouseEventArgs e)
        {
            //listBoxValues.SelectedIndex = listBoxValues.IndexFromPoint(e.X, e.Y);

            //if (this.listBoxValues.SelectedItem == null) return;
            //this.listBoxValues.DoDragDrop(this.listBoxValues.SelectedItem, DragDropEffects.Move);
        }

        private void ListBoxValuesDragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ListBoxValuesDragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxValues.PointToClient(new Point(e.X, e.Y));
            int insertIndex = this.listBoxValues.IndexFromPoint(point);
            if (insertIndex < 0) insertIndex = this.listBoxValues.Items.Count - 1;
            if (insertIndex == listBoxValues.SelectedIndex) return;
            _domain.Values.Swap(listBoxValues.SelectedIndex, insertIndex);
            object data = e.Data.GetData(typeof(IndexedNamedItem));
            listBoxValues.Items.Remove(data);
            listBoxValues.Items.Insert(insertIndex, data);
            listBoxValues.SelectedIndex = insertIndex;
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

        private void listBoxValues_DragEnter(object sender, DragEventArgs e)
        {
            //if (this.listBoxValues.SelectedItem == null) return;
            //this.listBoxValues.DoDragDrop(this.listBoxValues.SelectedItem, DragDropEffects.Move);
        }

        private void listBoxValues_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.listBoxValues.SelectedItem == null) return;
                this.listBoxValues.DoDragDrop(this.listBoxValues.SelectedItem, DragDropEffects.Move);
            }
        }
    }
}
