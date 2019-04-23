using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;
using Newtonsoft.Json;
using Rule = System.Data.Rule;

namespace ExpertSystemShell.Gui
{
    public partial class MainForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }

        private string _currentPath;

        private ListViewItem _draggedItem;
        private int _draggedIndex;
        private bool dragDropDone = false;

        public MainForm()
        {
            InitializeComponent();
            KnowledgeBase = new KnowledgeBase();
        }

        private ListViewItem CreateListViewItem(Domain domain)
        {
            return
                new ListViewItem
                {
                    Text = domain.Name,
                    SubItems = { string.Join(", ", domain.Values) },
                    Tag = domain
                };
        }

        private ListViewItem CreateListViewItem(Variable variable)
        {
            return
                new ListViewItem
                {
                    Text = variable.Name,
                    SubItems = { variable.Domain.Name, Constants.VariableKinds[variable.VariableKind], variable.Question },
                    Tag = variable
                };
        }

        private ListViewItem CreateListViewItem(Model.Rule rule)
        {
            return
                new ListViewItem
                {
                    Text = rule.Name,
                    SubItems = { string.Join(", ", rule.Premise), string.Join(", ", rule.Conclusion), rule.Reason },
                    Tag = rule
                };
        }

        private void FillListView()
        {
            listView.Items.Clear();

            if(radioButtonDomains.Checked)
            {
                foreach(var domain in KnowledgeBase.Domains)
                {
                    listView.Items.Add(CreateListViewItem(domain));
                }
            }
            else
            if(radioButtonVariables.Checked)
            {
                foreach(var variable in KnowledgeBase.Variables)
                {
                    listView.Items.Add(CreateListViewItem(variable));
                }
            }
            else
            if(radioButtonRules.Checked)
            {
                foreach(var rule in KnowledgeBase.Rules)
                {
                    listView.Items.Add(CreateListViewItem(rule));
                }
            }

            if(listView.Items.Count > 0)
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            else
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if(radioButtonDomains.Checked)
            {
                var domainForm = new DomainForm();
                domainForm.Domains = KnowledgeBase.Domains;
                var dialogResult = domainForm.ShowDialog();
                if(dialogResult != DialogResult.OK)
                    return;

                if(listView.SelectedIndices.Count > 0)
                {
                    KnowledgeBase.Domains.Insert(listView.SelectedIndices[0], domainForm.Domain);
                    listView.Items.Insert(listView.SelectedIndices[0], CreateListViewItem(domainForm.Domain));
                }
                else
                {
                    KnowledgeBase.Domains.Add(domainForm.Domain);
                    listView.Items.Add(CreateListViewItem(domainForm.Domain));
                    listView.SelectedIndices.Add(listView.Items.Count - 1);
                }
            }

            if(radioButtonVariables.Checked)
            {
                var variableForm = new VariableForm();
                variableForm.Domains = KnowledgeBase.Domains;
                variableForm.Variables = KnowledgeBase.Variables;
                var dialogResult = variableForm.ShowDialog();
                if(dialogResult != DialogResult.OK)
                    return;

                if(listView.SelectedIndices.Count > 0)
                {
                    KnowledgeBase.Variables.Insert(listView.SelectedIndices[0], variableForm.Variable);
                    listView.Items.Insert(listView.SelectedIndices[0], CreateListViewItem(variableForm.Variable));
                }
                else
                {
                    KnowledgeBase.Variables.Add(variableForm.Variable);
                    listView.Items.Add(CreateListViewItem(variableForm.Variable));
                    listView.SelectedIndices.Add(listView.Items.Count - 1);
                }
            }

            if(radioButtonRules.Checked)
            {
                var ruleForm = new RuleForm();
                ruleForm.Rules = KnowledgeBase.Rules;
                ruleForm.Variables = KnowledgeBase.Variables;
                ruleForm.Domains = KnowledgeBase.Domains;
                var dialogResult = ruleForm.ShowDialog();
                if(dialogResult != DialogResult.OK)
                    return;

                if(listView.SelectedIndices.Count > 0)
                {
                    KnowledgeBase.Rules.Insert(listView.SelectedIndices[0], ruleForm.Rule);
                    listView.Items.Insert(listView.SelectedIndices[0], CreateListViewItem(ruleForm.Rule));
                }
                else
                {
                    KnowledgeBase.Rules.Add(ruleForm.Rule);
                    listView.Items.Add(CreateListViewItem(ruleForm.Rule));
                    listView.SelectedIndices.Add(listView.Items.Count - 1);
                }
            }
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            if(radioButtonDomains.Checked)
            {
                var domainForm = new DomainForm();
                domainForm.Domains = KnowledgeBase.Domains;
                domainForm.Domain = KnowledgeBase.Domains[listView.SelectedIndices[0]];
                var dialogResult = domainForm.ShowDialog();
                KnowledgeBase.Domains[listView.SelectedIndices[0]] = domainForm.Domain;
                listView.Items[listView.SelectedIndices[0]] = CreateListViewItem(domainForm.Domain);
            }

            if(radioButtonVariables.Checked)
            {
                var variableForm = new VariableForm();
                variableForm.Variables = KnowledgeBase.Variables;
                variableForm.Domains = KnowledgeBase.Domains;
                variableForm.Variable = KnowledgeBase.Variables[listView.SelectedIndices[0]];
                var dialogResult = variableForm.ShowDialog();
                KnowledgeBase.Variables[listView.SelectedIndices[0]] = variableForm.Variable;
                listView.Items[listView.SelectedIndices[0]] = CreateListViewItem(variableForm.Variable);
            }

            if(radioButtonRules.Checked)
            {
                var ruleForm = new RuleForm();
                ruleForm.Rules = KnowledgeBase.Rules;
                ruleForm.Variables = KnowledgeBase.Variables;
                ruleForm.Domains = KnowledgeBase.Domains;
                ruleForm.Rule = KnowledgeBase.Rules[listView.SelectedIndices[0]];
                var dialogResult = ruleForm.ShowDialog();
                KnowledgeBase.Rules[listView.SelectedIndices[0]] = ruleForm.Rule;
                listView.Items[listView.SelectedIndices[0]] = CreateListViewItem(ruleForm.Rule);
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            var indicesToDelete = listView.SelectedItems.Cast<int>().ToArray();

            foreach(var indexToDelete in indicesToDelete)
            {
                if(radioButtonDomains.Checked)
                {
                    KnowledgeBase.Domains.Delete(indexToDelete);
                }

                if(radioButtonVariables.Checked)
                {
                    KnowledgeBase.Variables.Delete(indexToDelete);
                }

                if(radioButtonRules.Checked)
                {
                    KnowledgeBase.Rules.Delete(indexToDelete);
                }

                listView.Items.RemoveAt(indexToDelete);
            }

            if(listView.Items.Count > 0)
            {
                listView.SelectedIndices.Clear();
                listView.SelectedIndices.Add(indicesToDelete[0] - 1 >= 0 ? indicesToDelete[0] - 1 : 0);
            }
        }

        private void SetListViewColumnsForDomains()
        {
            listView.Columns.Add("Название");
            listView.Columns.Add("Значения");
        }

        private void SetListViewColumnsForVariables()
        {
            listView.Columns.Add("Название");
            listView.Columns.Add("Домен");
            listView.Columns.Add("Тип");
            listView.Columns.Add("Текст вопроса");
        }

        private void SetListViewColumnsForRules()
        {
            listView.Columns.Add("Название");
            listView.Columns.Add("Посылка");
            listView.Columns.Add("Заключение");
            listView.Columns.Add("Причина");
        }

        private void SetListViewColumns()
        {
            if(radioButtonDomains.Checked)
            {
                SetListViewColumnsForDomains();
            }

            if(radioButtonVariables.Checked)
            {
                SetListViewColumnsForVariables();
            }

            if(radioButtonRules.Checked)
            {
                SetListViewColumnsForRules();
            }
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            listView.Columns.Clear();
            listView.Items.Clear();

            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;

            SetListViewColumns();

            FillListView();
        }

        private void ListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = listView.SelectedItems.Count == 1;
            buttonDelete.Enabled = listView.SelectedItems.Count > 0;
        }

        private void LoadKnowledgeBase(string path)
        {
            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(path, FileMode.Open);
            KnowledgeBase = (KnowledgeBase)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
        }

        private void SaveKnowledgeBase(string path)
        {
            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(path, FileMode.Create);
            binaryFormatter.Serialize(fileStream, KnowledgeBase);
            fileStream.Close();
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(_currentPath == null)
            {
                var dialogResult = saveFileDialog.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    _currentPath = saveFileDialog.FileName;
                    SaveKnowledgeBase(_currentPath);
                }
            }
        }

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                _currentPath = openFileDialog.FileName;
                LoadKnowledgeBase(_currentPath);
                FillListView();
            }
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Сохранить изменения?", string.Empty, MessageBoxButtons.YesNoCancel);

            if(dialogResult == DialogResult.Yes)
            {
                if(_currentPath != null)
                    SaveKnowledgeBase(_currentPath);
                else
                    SaveToolStripMenuItemClick(this, EventArgs.Empty);
            }

            if(dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void ListViewMouseDown(object sender, MouseEventArgs e)
        {
            //_draggedItem = listView.GetItemAt(e.X, e.Y);

            //if (_draggedItem == null)
            //    return;

            //_draggedIndex = listView.Items.IndexOf(_draggedItem);
            //listView.DoDragDrop(_draggedItem, DragDropEffects.Move);
        }

        private void ListBoxValuesDragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ListBoxValuesDragDrop(object sender, DragEventArgs e)
        {
            var point = listView.PointToClient(new Point(e.X, e.Y));
            var insertItem = listView.GetItemAt(point.X, point.Y);
            var insertIndex = listView.Items.IndexOf(insertItem);
            if(insertIndex < 0)
                insertIndex = listView.Items.Count - 1;

            if(radioButtonDomains.Checked)
            {
                KnowledgeBase.Domains.Swap(_draggedIndex, insertIndex);
            }

            if(radioButtonVariables.Checked)
            {
                KnowledgeBase.Variables.Swap(_draggedIndex, insertIndex);
            }

            if(radioButtonRules.Checked)
            {
                KnowledgeBase.Rules.Swap(_draggedIndex, insertIndex);
            }

            var draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            listView.Items.Remove(_draggedItem);
            listView.Items.Insert(insertIndex, _draggedItem);

            dragDropDone = true;
        }

        private void ListViewMouseUp(object sender, MouseEventArgs e)
        {
            //if (dragDropDone)
            //{
            //    dragDropDone = false;

            //    listView.SelectedIndices.Clear();
            //}
        }

        private void ConsultToolStripMenuItemClick(object sender, EventArgs e)
        {
            var consultationForm = new ConsultationForm();
            var dialogResult = consultationForm.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {

            }
        }

        private void ListViewMouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                _draggedItem = listView.GetItemAt(e.X, e.Y);

                if(_draggedItem == null)
                    return;

                _draggedIndex = listView.Items.IndexOf(_draggedItem);
                listView.DoDragDrop(_draggedItem, DragDropEffects.Move);
            }
        }

        private void CreateToolStripMenuItemClick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Сохранить изменения?", string.Empty, MessageBoxButtons.YesNoCancel);

            if(dialogResult == DialogResult.Yes)
            {
                if(_currentPath != null)
                    SaveKnowledgeBase(_currentPath);
                else
                    SaveToolStripMenuItemClick(this, EventArgs.Empty);
            }

            KnowledgeBase = new KnowledgeBase();
            FillListView();
        }

        private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                _currentPath = saveFileDialog.FileName;
                SaveKnowledgeBase(_currentPath);
            }
        }
    }
}
