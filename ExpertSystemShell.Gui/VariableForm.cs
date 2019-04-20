using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class VariableForm : Form
    {
        public IndexedList<Domain> Domains { get; set; }
        public IndexedList<Variable> Variables { get; set; }
        public Variable Variable { get; set; }

        private Variable _variable;

        private bool _setNameSuccess = false;

        public VariableForm()
        {
            InitializeComponent();
        }

        private void VariableFormLoad(object sender, EventArgs e)
        {
            if (Domains == null)
                Domains = new IndexedList<Domain>();

            if (Variables == null)
                Variables = new IndexedList<Variable>();

            if (Variable != null)
            {
                _variable = new Variable(_variable.Name);
                _variable.Name = Variable.Name;
                _variable.Domain = Variable.Domain;
                _variable.VariableKind = Variable.VariableKind;
                _variable.Question = Variable.Question;
            }
            else
            {
                _variable = new Variable($"Переменная {Variables.Count + 1}", VariableKind.Deductible);
            }

            textBoxName.Text = _variable.Name;
            textBoxName.Select();
            textBoxName.Focus();

            foreach (var domain in Domains)
                comboBoxDomain.Items.Add(domain);

            if (comboBoxDomain.Items.Count > 0 && Variable == null)
                comboBoxDomain.SelectedIndex = 0;

            comboBoxDomain.SelectedItem = _variable.Domain;
            radioButtonDeductible.Checked = true;

            richTextBoxQuestion.Text = _variable.Question;
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (Variables.Contains(_variable) && Variable == null)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Переменная с таким именем уже есть");
                textBoxName.Focus();
                textBoxName.Select();
            }
            else
            {
                if (Variable == null)
                    Variable = new Variable(_variable.Name);

                Variable.Domain = _variable.Domain;
                Variable.VariableKind = _variable.VariableKind;
                Variable.Question = _variable.Question;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {

        }

        private void ComboBoxDomainSelectedIndexChanged(object sender, EventArgs e)
        {
            _variable.Domain = (Domain)comboBoxDomain.SelectedItem;
        }

        private void TextBoxNameLeave(object sender, EventArgs e)
        {
            try
            {
                _variable.Name = textBoxName.Text;
                _setNameSuccess = true;
            }
            catch (Exception exception)
            {
                _setNameSuccess = false;
                textBoxName.Text = _variable.Name;
                textBoxName.Select();
                textBoxName.Focus();
                MessageBox.Show(exception.Message);
            }
        }

        private void ButtonAddDomainClick(object sender, EventArgs e)
        {
            var domainForm = new DomainForm();
            domainForm.Domains = Domains;
            var dialogResult = domainForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Domains.Add(domainForm.Domain);
                comboBoxDomain.Items.Add(domainForm.Domain);
                comboBoxDomain.SelectedItem = domainForm.Domain;
            }
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeductible.Checked)
            {
                _variable.VariableKind = VariableKind.Deductible;
                richTextBoxQuestion.Enabled = false;
            }

            if (radioButtonRequested.Checked)
            {
                _variable.VariableKind = VariableKind.Requested;
                richTextBoxQuestion.Enabled = true;
            }

            if (radioButtonDeductibleRequested.Checked)
            {
                _variable.VariableKind = VariableKind.DeductibleRequested;
                richTextBoxQuestion.Enabled = true;
            }
        }

        private void RichTextBoxQuestionLeave(object sender, EventArgs e)
        {
            _variable.Question = richTextBoxQuestion.Text;
        }

        private void TextBoxNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxDomain.Select();

                if (!_setNameSuccess)
                {
                    textBoxName.Select();
                    textBoxName.Focus();
                }

                comboBoxDomain.Focus();
            }
        }
    }
}
