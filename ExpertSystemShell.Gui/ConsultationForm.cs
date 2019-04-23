using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemShell.Gui
{
    public partial class ConsultationForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }

        private InferenceEngine _inferenceEngine { get; set; }

        private int _currentIndex = 0;

        private SemaphoreSlim signal = new SemaphoreSlim(0, 1);

        public ConsultationForm()
        {
            InitializeComponent();

            _inferenceEngine = new InferenceEngine();
        }

        private void ConsultationFormLoad(object sender, EventArgs e)
        {
            listViewQuestion.Items.Add(new ListViewItem() { Name = "Цель консультации?" });

            foreach(var variable in KnowledgeBase.Variables)
            {
                if(variable.VariableKind == Model.VariableKind.Deductible)
                    comboBoxAnswers.Items.Add(variable);
            }
        }

        private void ButtonAnswerClick(object sender, EventArgs e)
        {
            listViewQuestion.Items[_currentIndex].SubItems[0].Text = comboBoxAnswers.SelectedItem.ToString();

            if (_currentIndex == 0)
            {
                _inferenceEngine.Deduce(KnowledgeBase.Rules.ToList(), RequestVariable, (Variable)comboBoxAnswers.SelectedItem);
            }
                       
            signal.Release();
        }

        private async Task<Fact> RequestVariable(Variable variable)
        {
            comboBoxAnswers.Items.Clear();
            foreach(var domain in variable.Domain.Values)
            {
                comboBoxAnswers.Items.Add(domain);
            }

            await signal.WaitAsync();

            return new Fact() { Variable = variable, Value = comboBoxAnswers.SelectedItem };
        }

        private void ButtonExplainClick(object sender, EventArgs e)
        {
            
        }
    }
}
