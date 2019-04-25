using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class ConsultationForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }

        private InferenceEngine _inferenceEngine { get; set; }

        private int _currentIndex;

        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(0, 1);

        private Variable _goal;
        private Fact _consultationResult;

        public ConsultationForm()
        {
            InitializeComponent();
        }

        private void SetListViewColumnsWidth(ListView listView, params int[] widthes)
        {
            if (widthes.Length != listView.Columns.Count || widthes.Sum() > 100)
                throw new ArgumentException();

            for (var i = 0; i < listView.Columns.Count; i++)
                listView.Columns[i].Width = (listView.Width - 5) * widthes[i] / 100;
        }

        private void ConsultationFormLoad(object sender, EventArgs e)
        {
            _currentIndex = 0;

            _inferenceEngine = new InferenceEngine(KnowledgeBase, RequestVariable);
            _inferenceEngine.DeduceEnded += InferenceEngineOnDeduceEnded;

            listViewQuestion.Items.Add(new ListViewItem() { Text = "Цель консультации?", SubItems = { string.Empty } });

            foreach (var variable in KnowledgeBase.Variables)
            {
                if (variable.VariableKind == Model.VariableKind.Deductible)
                    comboBoxAnswers.Items.Add(variable);
            }

            if (comboBoxAnswers.Items.Count > 0)
            {
                comboBoxAnswers.SelectedIndex = 0;
            }

            buttonExplain.Enabled = false;

            labelVariable.Text = "Цель консультации";
            labelResult.Text = "?";

            SetListViewColumnsWidth(listViewQuestion, 50, 50);
        }

        private void InferenceEngineOnDeduceEnded(Fact result)
        {
            BeginInvoke(new Action(() =>
            {
                if (result == null)
                {
                    MessageBox.Show($"Не удалось вывести <{_goal}>");
                }
                else
                {
                    labelVariable.Text = result.Variable.ToString();
                    labelResult.Text = result.Value.ToString();
                }

                buttonExplain.Enabled = true;
            }));
        }

        private void ButtonAnswerClick(object sender, EventArgs e)
        {
            listViewQuestion.Items[_currentIndex].SubItems[1].Text = comboBoxAnswers.SelectedItem.ToString();

            if (_currentIndex == 0)
            {
                labelResult.Text = comboBoxAnswers.SelectedItem.ToString();
                _goal = (Variable)comboBoxAnswers.SelectedItem;
                comboBoxAnswers.Enabled = false;
                buttonAnswer.Enabled = false;
                new Thread(() => _consultationResult = _inferenceEngine.Deduce(_goal)).Start();
                _currentIndex++;
                return;
            }

            comboBoxAnswers.Enabled = false;
            buttonAnswer.Enabled = false;
            _currentIndex++;

            _semaphoreSlim.Release();
        }

        private async Task<Fact> RequestVariable(Variable variable)
        {
            BeginInvoke(new Action(() =>
            {
                listViewQuestion.Items.Add(new ListViewItem() { Text = variable.Question, SubItems = { string.Empty } });
                comboBoxAnswers.Items.Clear();
                foreach (var domain in variable.Domain.Values)
                {
                    comboBoxAnswers.Items.Add(domain);
                }

                comboBoxAnswers.SelectedIndex = 0;
                comboBoxAnswers.Enabled = true;
                buttonAnswer.Enabled = true;
            }));

            await _semaphoreSlim.WaitAsync();

            IndexedNamedItem factValue = null;

            var asyncResult = BeginInvoke(new Action(() => factValue = (IndexedNamedItem)comboBoxAnswers.SelectedItem));

            asyncResult.AsyncWaitHandle.WaitOne();

            return new Fact() { Variable = variable, Value = factValue };
        }

        private void ButtonExplainClick(object sender, EventArgs e)
        {
            var explanationForm = new ExplanationForm();
            explanationForm.WorkingMemory = _inferenceEngine.WorkingMemory;
            var dialogResult = explanationForm.ShowDialog();
        }

        private void ButtonRestartClick(object sender, EventArgs e)
        {
            listViewQuestion.Items.Clear();
            comboBoxAnswers.Items.Clear();
            comboBoxAnswers.Enabled = true;
            buttonAnswer.Enabled = true;
            ConsultationFormLoad(sender, e);
            comboBoxAnswers.SelectedItem = _goal;
        }

        private void ConsultationFormResize(object sender, EventArgs e)
        {
            SetListViewColumnsWidth(listViewQuestion, 50, 50);
        }
    }
}
