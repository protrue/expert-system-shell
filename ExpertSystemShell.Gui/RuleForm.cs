using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;
using Rule = ExpertSystemShell.Model.Rule;

namespace ExpertSystemShell.Gui
{
    public partial class RuleForm : Form
    {
        public IndexedList<Domain> Domains { get; set; }

        public IndexedList<Variable> Variables { get; set; }

        public IndexedList<Model.Rule> Rules { get; set; }

        public Model.Rule Rule { get; set; }

        private Model.Rule _rule;
        private bool _setNameSuccess;

        public RuleForm()
        {
            InitializeComponent();
        }

        private void RuleFormLoad(object sender, EventArgs e)
        {
            if (Rules == null)
                Rules = new IndexedList<Rule>();

            if (Rule != null)
            {
                //_rule = (Model.Rule) Rule.Clone();
                _rule = new Rule(Rule.Name);
                _rule.Name = Rule.Name;
                _rule.Premise = Rule.Premise;
                _rule.Conclusion = Rule.Conclusion;
                _rule.Reason = Rule.Reason;
            }
            else
            {
                _rule = new Model.Rule($"Правило {Rules.Count + 1}");
            }

            textBoxName.Text = _rule.Name;

            foreach (var fact in _rule.Premise)
            {
                listBoxPremise.Items.Add(fact);
            }

            foreach (var fact in _rule.Conclusion)
            {
                listBoxConclusion.Items.Add(fact);
            }

            richTextBoxReason.Text = _rule.Reason;

            buttonChangePremise.Enabled = false;
            buttonDeletePremise.Enabled = false;

            buttonChangeConclusion.Enabled = false;
            buttonDeleteConclusion.Enabled = false;
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (_rule.Premise.Count == 0)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("В посылке должен быть хотя бы один факт");
                buttonAddPremise.Select();
                buttonAddPremise.Focus();
                return;
            }

            if (_rule.Premise.Count == 0)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("В заключении должен быть хотя бы один факт");
                buttonAddConclusion.Select();
                buttonAddConclusion.Focus();
                return;
            }

            if (Rules.Contains(_rule) && Rule == null)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Правило с таким именем уже есть");
                textBoxName.Focus();
                textBoxName.Select();
                return;
            }

            if (Rule == null)
                Rule = new Rule(_rule.Name);

            Rule.Premise = _rule.Premise;
            Rule.Conclusion = _rule.Conclusion;
            Rule.Reason = _rule.Reason;
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {

        }

        private void ButtonAddPremiseClick(object sender, EventArgs e)
        {
            var factForm = new FactForm();
            factForm.Variables = Variables;
            factForm.Domains = Domains;
            var dialogResult = factForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if (listBoxPremise.SelectedIndex >= 0)
                {
                    _rule.Premise.Insert(listBoxPremise.SelectedIndex, factForm.Fact);
                    listBoxPremise.Items.Insert(listBoxPremise.SelectedIndex, factForm.Fact);
                }
                else
                {
                    _rule.Premise.Add(factForm.Fact);
                    listBoxPremise.Items.Add(factForm.Fact);
                }
            }
        }

        private void ButtonChangePremiseClick(object sender, EventArgs e)
        {
            var factForm = new FactForm();
            factForm.Variables = Variables;
            factForm.Domains = Domains;
            factForm.Fact = (Fact)listBoxPremise.SelectedItem;
            var dialogResult = factForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _rule.Premise[listBoxPremise.SelectedIndex] = factForm.Fact;
                listBoxPremise.Items[listBoxPremise.SelectedIndex] = factForm.Fact;
            }
        }

        private void ButtonDeletePremiseClick(object sender, EventArgs e)
        {
            var indicesToDelete = listBoxPremise.SelectedIndices.Cast<int>().ToArray();

            foreach (var indexToDelete in indicesToDelete)
            {
                _rule.Premise.RemoveAt(indexToDelete);
                listBoxPremise.Items.RemoveAt(indexToDelete);
            }
        }

        private void ButtonAddConclusionClick(object sender, EventArgs e)
        {
            var factForm = new FactForm();
            factForm.Variables = Variables;
            factForm.Domains = Domains;
            var dialogResult = factForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if (listBoxConclusion.SelectedIndex >= 0)
                {
                    _rule.Conclusion.Insert(listBoxConclusion.SelectedIndex, factForm.Fact);
                    listBoxConclusion.Items.Insert(listBoxConclusion.SelectedIndex, factForm.Fact);
                }
                else
                {
                    _rule.Conclusion.Add(factForm.Fact);
                    listBoxConclusion.Items.Add(factForm.Fact);
                }
            }
        }

        private void ButtonChangeConclusionClick(object sender, EventArgs e)
        {
            var factForm = new FactForm();
            factForm.Variables = Variables;
            factForm.Domains = Domains;
            factForm.Fact = (Fact)listBoxConclusion.SelectedItem;
            var dialogResult = factForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _rule.Conclusion[listBoxConclusion.SelectedIndex] = factForm.Fact;
                listBoxConclusion.Items[listBoxConclusion.SelectedIndex] = factForm.Fact;
            }
        }

        private void ButtonDeleteConclusionClick(object sender, EventArgs e)
        {
            var indicesToDelete = listBoxConclusion.SelectedIndices.Cast<int>().ToArray();

            foreach (var indexToDelete in indicesToDelete)
            {
                _rule.Conclusion.RemoveAt(indexToDelete);
                listBoxConclusion.Items.RemoveAt(indexToDelete);
            }
        }

        private void ListBoxPremiseSelectedIndexChanged(object sender, EventArgs e)
        {
            buttonChangePremise.Enabled = listBoxPremise.SelectedIndex > -1;
            buttonDeletePremise.Enabled = listBoxPremise.SelectedIndex > -1;
        }

        private void ListBoxConclusionSelectedIndexChanged(object sender, EventArgs e)
        {
            buttonChangeConclusion.Enabled = listBoxConclusion.SelectedIndex > -1;
            buttonDeleteConclusion.Enabled = listBoxConclusion.SelectedIndex > -1;
        }

        private void RichTextBoxReasonLeave(object sender, EventArgs e)
        {
            _rule.Reason = richTextBoxReason.Text;
        }

        private void TextBoxNameLeave(object sender, EventArgs e)
        {
            try
            {
                _rule.Name = textBoxName.Text;
                _setNameSuccess = true;
            }
            catch (Exception exception)
            {
                _setNameSuccess = false;
                textBoxName.Text = _rule.Name;
                textBoxName.Select();
                textBoxName.Focus();
                MessageBox.Show(exception.Message);
            }
        }
    }
}
