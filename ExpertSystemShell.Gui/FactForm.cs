using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class FactForm : Form
    {
        public IndexedList<Domain> Domains { get; set; }
        public IndexedList<Variable> Variables { get; set; }
        public Fact Fact;

        private Fact _fact;

        public FactForm()
        {
            InitializeComponent();
        }

        private void FactFormLoad(object sender, EventArgs e)
        {
            if (Variables == null || Variables.Count == 0)
                return;

            foreach (var variable in Variables)
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
            variableForm.Domains = Domains;
            variableForm.Variables = Variables;
            var dialogResult = variableForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var addedIndex = comboBoxVariable.Items.Add(variableForm.Variable);
                comboBoxVariable.SelectedIndex = addedIndex;
            }
        }
    }
}
