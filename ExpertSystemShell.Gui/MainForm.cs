using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class MainForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }

        private string _currentPath;

        private ListViewItem _draggedItem;
        private int _draggedIndex;
        private bool dragDropDone;

        public MainForm()
        {
            InitializeComponent();
            KnowledgeBase = new KnowledgeBase();
        }

        private void SetListViewColumnsWidth(ListView listView, params int[] widthes)
        {
            if (widthes.Length != listView.Columns.Count || widthes.Sum() > 100)
                throw new ArgumentException();

            for (var i = 0; i < listView.Columns.Count; i++)
                listView.Columns[i].Width = (listView.Width - 5) * widthes[i] / 100;
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
                    SubItems = { string.Join(" И ", rule.Premise), string.Join(", ", rule.Conclusion), rule.Reason },
                    Tag = rule
                };
        }

        private void SetColumnsSize()
        {
            //listView.AutoResizeColumns(listView.Items.Count > 0
            //    ? ColumnHeaderAutoResizeStyle.ColumnContent
            //    : ColumnHeaderAutoResizeStyle.HeaderSize);

            if (radioButtonDomains.Checked)
            {
                SetListViewColumnsWidth(listView, 30, 70);
            }

            if (radioButtonVariables.Checked)
            {
                SetListViewColumnsWidth(listView, 25, 25, 25, 25);
            }

            if (radioButtonRules.Checked)
            {
                SetListViewColumnsWidth(listView, 25, 25, 25, 25);
            }
        }

        private void FillListView()
        {
            listView.Items.Clear();

            if (radioButtonDomains.Checked)
            {
                foreach (var domain in KnowledgeBase.Domains)
                {
                    listView.Items.Add(CreateListViewItem(domain));
                }
            }
            else
            if (radioButtonVariables.Checked)
            {
                foreach (var variable in KnowledgeBase.Variables)
                {
                    listView.Items.Add(CreateListViewItem(variable));
                }
            }
            else
            if (radioButtonRules.Checked)
            {
                foreach (var rule in KnowledgeBase.Rules)
                {
                    listView.Items.Add(CreateListViewItem(rule));
                }
            }

            SetColumnsSize();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (radioButtonDomains.Checked)
            {
                var domainForm = new DomainForm { KnowledgeBase = KnowledgeBase };
                var dialogResult = domainForm.ShowDialog();
                if (dialogResult != DialogResult.OK)
                    return;

                if (listView.SelectedIndices.Count > 0)
                {
                    var insertIndex = listView.SelectedIndices.Cast<int>().Max() + 1;
                    KnowledgeBase.Domains.Insert(insertIndex, domainForm.Domain);
                    listView.Items.Insert(insertIndex, CreateListViewItem(domainForm.Domain));
                    listView.SelectedIndices.Clear();
                    listView.SelectedIndices.Add(insertIndex);
                }
                else
                {
                    KnowledgeBase.Domains.Add(domainForm.Domain);
                    listView.Items.Add(CreateListViewItem(domainForm.Domain));
                    listView.SelectedIndices.Add(listView.Items.Count - 1);
                }
            }

            if (radioButtonVariables.Checked)
            {
                var variableForm = new VariableForm
                {
                    KnowledgeBase = KnowledgeBase,
                };
                var dialogResult = variableForm.ShowDialog();
                if (dialogResult != DialogResult.OK)
                    return;

                if (listView.SelectedIndices.Count > 0)
                {
                    var insertIndex = listView.SelectedIndices.Cast<int>().Max() + 1;
                    KnowledgeBase.Variables.Insert(insertIndex, variableForm.Variable);
                    listView.Items.Insert(insertIndex, CreateListViewItem(variableForm.Variable));
                    listView.SelectedIndices.Clear();
                    listView.SelectedIndices.Add(insertIndex);
                }
                else
                {
                    KnowledgeBase.Variables.Add(variableForm.Variable);
                    listView.Items.Add(CreateListViewItem(variableForm.Variable));
                    listView.SelectedIndices.Add(listView.Items.Count - 1);
                }
            }

            if (radioButtonRules.Checked)
            {
                var ruleForm = new RuleForm
                { KnowledgeBase = KnowledgeBase };
                var dialogResult = ruleForm.ShowDialog();
                if (dialogResult != DialogResult.OK)
                    return;

                if (listView.SelectedIndices.Count > 0)
                {
                    var insertIndex = listView.SelectedIndices.Cast<int>().Max() + 1;
                    KnowledgeBase.Rules.Insert(insertIndex, ruleForm.Rule);
                    listView.Items.Insert(insertIndex, CreateListViewItem(ruleForm.Rule));
                    listView.SelectedIndices.Clear();
                    listView.SelectedIndices.Add(insertIndex);
                }
                else
                {
                    KnowledgeBase.Rules.Add(ruleForm.Rule);
                    listView.Items.Add(CreateListViewItem(ruleForm.Rule));
                    listView.SelectedIndices.Add(listView.Items.Count - 1);
                }
            }

            SetColumnsSize();
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            var selectedIndex = listView.SelectedIndices[0];

            if (radioButtonDomains.Checked)
            {
                var domainForm = new DomainForm
                {
                    KnowledgeBase = KnowledgeBase,
                    Domain = KnowledgeBase.Domains[listView.SelectedIndices[0]]
                };
                var dialogResult = domainForm.ShowDialog();
                KnowledgeBase.Domains[listView.SelectedIndices[0]] = domainForm.Domain;
                listView.Items[listView.SelectedIndices[0]] = CreateListViewItem(domainForm.Domain);
            }

            if (radioButtonVariables.Checked)
            {
                var variableForm = new VariableForm
                {
                    KnowledgeBase = KnowledgeBase,
                    Variable = KnowledgeBase.Variables[listView.SelectedIndices[0]]
                };
                var dialogResult = variableForm.ShowDialog();
                KnowledgeBase.Variables[listView.SelectedIndices[0]] = variableForm.Variable;
                listView.Items[listView.SelectedIndices[0]] = CreateListViewItem(variableForm.Variable);
            }

            if (radioButtonRules.Checked)
            {
                var ruleForm = new RuleForm
                {
                    KnowledgeBase = KnowledgeBase,
                    Rule = KnowledgeBase.Rules[listView.SelectedIndices[0]]
                };
                var dialogResult = ruleForm.ShowDialog();
                KnowledgeBase.Rules[listView.SelectedIndices[0]] = ruleForm.Rule;
                listView.Items[listView.SelectedIndices[0]] = CreateListViewItem(ruleForm.Rule);
            }

            listView.SelectedIndices.Add(selectedIndex);
            SetColumnsSize();
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            var indicesToDelete = listView.SelectedIndices.Cast<int>().ToArray();
            var notDeletedItems = new List<Tuple<IndexedNamedItem, List<IndexedNamedItem>>>();
            var notDeletedListViewItems = new List<ListViewItem>();
            var notDeletedIndices = new List<int>();

            foreach (var indexToDelete in indicesToDelete)
            {
                if (radioButtonDomains.Checked)
                {
                    var domainToDelete = KnowledgeBase.Domains[indexToDelete];
                    var variablesWithDeletingDomain =
                        KnowledgeBase
                            .Variables
                            .Where(v => v.Domain == domainToDelete)
                            .Cast<IndexedNamedItem>()
                            .ToList();
                    if (variablesWithDeletingDomain.Count > 0)
                    {
                        notDeletedItems.Add(Tuple.Create((IndexedNamedItem)domainToDelete, variablesWithDeletingDomain));
                        notDeletedListViewItems.Add(listView.Items[indexToDelete]);
                        notDeletedIndices.Add(indexToDelete);
                        continue;
                    }
                }

                if (radioButtonVariables.Checked)
                {
                    var variableToDelete = KnowledgeBase.Variables[indexToDelete];
                    var rulesWithDeletingVariable =
                        KnowledgeBase
                            .Rules
                            .Where(r =>
                                r.Premise.Count(f => f.Variable == variableToDelete) > 0
                                || r.Conclusion.Count(f => f.Variable == variableToDelete) > 0)
                            .Cast<IndexedNamedItem>()
                            .ToList();
                    if (rulesWithDeletingVariable.Count > 0)
                    {
                        notDeletedItems.Add(Tuple.Create((IndexedNamedItem)variableToDelete, rulesWithDeletingVariable));
                        notDeletedListViewItems.Add(listView.Items[indexToDelete]);
                        notDeletedIndices.Add(indexToDelete);
                        continue;
                    }
                }
            }

            var itemsToDelete = new List<ListViewItem>();

            foreach (var indexToDelete in indicesToDelete.Except(notDeletedIndices))
            {
                itemsToDelete.Add(listView.Items[indexToDelete]);
            }

            foreach (ListViewItem itemToDelete in itemsToDelete)
            {
                if (radioButtonDomains.Checked)
                {
                    KnowledgeBase.Domains.Delete((Domain)itemToDelete.Tag);
                }

                if (radioButtonVariables.Checked)
                {
                    KnowledgeBase.Variables.Delete((Variable)itemToDelete.Tag);
                }

                if (radioButtonRules.Checked)
                {
                    KnowledgeBase.Rules.Delete((Rule)itemToDelete.Tag);
                }

                listView.Items.Remove(itemToDelete);
            }

            if (listView.Items.Count > 0)
            {
                listView.SelectedIndices.Clear();
                if (notDeletedIndices.Count == 0)
                {
                    listView.SelectedIndices.Add(indicesToDelete.Max() + 1 >= listView.Items.Count ? listView.Items.Count - 1 : indicesToDelete.Max() + 1);
                }
                else
                {
                    foreach (var notDeletedListViewItem in notDeletedListViewItems)
                    {
                        listView.SelectedIndices.Add(listView.Items.IndexOf(notDeletedListViewItem));
                    }
                }
            }

            if (notDeletedItems.Count > 0)
            {
                MessageBox.Show($"Невозможно удалить:{Environment.NewLine}{string.Join(Environment.NewLine, notDeletedItems.Select(t => $"<{t.Item1}> из-за {string.Join(", ", t.Item2.Select(i => $"<{i.Name}>"))}"))}");
            }

            SetColumnsSize();
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
            if (radioButtonDomains.Checked)
            {
                SetListViewColumnsForDomains();
            }

            if (radioButtonVariables.Checked)
            {
                SetListViewColumnsForVariables();
            }

            if (radioButtonRules.Checked)
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

        private void ListViewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_draggedItem == null)
                    return;

                listView.DoDragDrop(_draggedItem, DragDropEffects.Move);
            }
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
            if (insertIndex < 0)
                insertIndex = listView.Items.Count - 1;

            if (radioButtonDomains.Checked)
            {
                KnowledgeBase.Domains.Swap(_draggedIndex, insertIndex);
            }

            if (radioButtonVariables.Checked)
            {
                KnowledgeBase.Variables.Swap(_draggedIndex, insertIndex);
            }

            if (radioButtonRules.Checked)
            {
                KnowledgeBase.Rules.Swap(_draggedIndex, insertIndex);
            }

            _draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            listView.Items.Remove(_draggedItem);
            listView.Items.Insert(insertIndex, _draggedItem);

            dragDropDone = true;
        }

        private void ListViewMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _draggedItem = listView.GetItemAt(e.X, e.Y);

                if (_draggedItem == null)
                    return;

                _draggedIndex = listView.Items.IndexOf(_draggedItem);
                
            }
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
            KnowledgeBase.Name = Path.GetFileNameWithoutExtension(path);
            binaryFormatter.Serialize(fileStream, KnowledgeBase);
            fileStream.Close();
        }

        private void CreateToolStripMenuItemClick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Сохранить изменения?", string.Empty, MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                SaveToolStripMenuItemClick(sender, e);
            }

            KnowledgeBase = new KnowledgeBase();
            FillListView();
        }

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _currentPath = openFileDialog.FileName;
                LoadKnowledgeBase(_currentPath);
                FillListView();
            }
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (_currentPath == null)
            {
                SaveAsToolStripMenuItemClick(sender, e);
            }
            else
            {
                SaveKnowledgeBase(_currentPath);
            }
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Сохранить изменения?", string.Empty, MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                SaveToolStripMenuItemClick(this, e);
            }

            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            saveFileDialog.FileName = KnowledgeBase.Name;
            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            _currentPath = saveFileDialog.FileName;
            SaveKnowledgeBase(_currentPath);
        }

        private void ConsultToolStripMenuItemClick(object sender, EventArgs e)
        {
            var consultationForm = new ConsultationForm();
            consultationForm.KnowledgeBase = KnowledgeBase;
            var dialogResult = consultationForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
        }

        private void MainFormResize(object sender, EventArgs e)
        {
            SetColumnsSize();
        }

        
    }
}
