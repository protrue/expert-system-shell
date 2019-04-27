using System;
using System.Linq;
using System.Windows.Forms;
using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class FactForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }
        public Fact Fact;
        public bool IsConclusion { get; set; }
        private Fact _fact;

        public FactForm()
        {
            InitializeComponent();
        }

        private void FactFormLoad(object sender, EventArgs e)
        {
            foreach (var variable in KnowledgeBase.Variables.Where(v => IsConclusion && v.VariableKind == VariableKind.Deductible || !IsConclusion))
            {
                comboBoxVariable.Items.Add(variable);
            }

            if (Fact != null)
            {
                foreach (var domainValue in Fact.Variable.Domain.Values)
                {
                    comboBoxValue.Items.Add(domainValue);
                }

                //_fact = (Fact) Fact.Clone();
                _fact = new Fact();
                _fact.Variable = Fact.Variable;
                _fact.Value = Fact.Value;
                comboBoxVariable.SelectedItem = Fact.Variable;
                comboBoxValue.SelectedItem = Fact.Value;
            }
            else
            {
                _fact = new Fact();
                comboBoxVariable.SelectedIndex = 0;
                _fact.Variable = (Variable)comboBoxVariable.SelectedItem;
                _fact.Value = (IndexedNamedItem)comboBoxValue.SelectedItem;
            }
        }

        private void ComboBoxVariableSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVariable.SelectedItem == null)
                return;

            _fact.Variable = (Variable)comboBoxVariable.SelectedItem;

            comboBoxValue.Items.Clear();
            foreach (var domainValue in _fact.Variable.Domain.Values)
            {
                comboBoxValue.Items.Add(domainValue);
            }
            comboBoxValue.SelectedIndex = 0;
        }

        private void ComboBoxValueSelectedIndexChanged(object sender, EventArgs e)
        {
            _fact.Value = (IndexedNamedItem)comboBoxValue.SelectedItem;
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (Fact == null)
                Fact = new Fact();
            Fact.Variable = _fact.Variable;
            Fact.Value = _fact.Value;
        }

        private void ButtonAddVariableClick(object sender, EventArgs e)
        {
            var variableForm = new VariableForm();
            variableForm.KnowledgeBase = KnowledgeBase;
            var dialogResult = variableForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                KnowledgeBase.Variables.Add(variableForm.Variable);
                if (variableForm.Variable.VariableKind != VariableKind.Requested && IsConclusion || !IsConclusion)
                {
                    var addedIndex = comboBoxVariable.Items.Add(variableForm.Variable);
                    comboBoxVariable.SelectedIndex = addedIndex;
                }
            }
        }
    }
}
