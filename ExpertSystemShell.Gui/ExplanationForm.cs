using System;
using System.Linq;
using System.Windows.Forms;
using ExpertSystemShell.Core;

namespace ExpertSystemShell.Gui
{
    public partial class ExplanationForm : Form
    {
        public WorkingMemory WorkingMemory { get; set; }

        public ExplanationForm()
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

        private void FillTreeView()
        {
            foreach (var inferenceEvent in WorkingMemory.InferenceHistory)
            {
                if (!string.IsNullOrWhiteSpace(inferenceEvent.Text))
                {
                    treeViewTrace.Nodes.Add(inferenceEvent.Text);
                }

                if (inferenceEvent.Goal != null && radioButtonTraceAll.Checked)
                {
                    treeViewTrace.Nodes.Add($"Цель: {inferenceEvent.Goal}");
                }

                if (inferenceEvent.Fact != null)
                {
                    treeViewTrace.Nodes.Add($"Факт: {inferenceEvent.Fact}" + (inferenceEvent.IsFactRequested ? " (запрошено)" : " (выведено)"));
                }

                if (inferenceEvent.Rule != null)
                {
                    if (radioButtonTraceNeeded.Checked && !inferenceEvent.IsRuleFired)
                        continue;
                    treeViewTrace.Nodes.Add(inferenceEvent.Rule.ToString());
                }
            }
        }

        private void FillListView()
        {
            foreach (var resolvedFact in WorkingMemory.ResolvedFacts)
            {
                listViewVariables.Items.Add(
                    new ListViewItem()
                    {
                        Text = resolvedFact.Variable.Name,
                        SubItems = { resolvedFact.Value.Name }
                    });
            }
        }

        private void ExplanationFormLoad(object sender, EventArgs e)
        {
            FillTreeView();

            FillListView();

            labelVariable.Text = WorkingMemory.Goal.Name;

            if (WorkingMemory.Result != null)
            {
                labelResult.Text = WorkingMemory.Result.Value.Name;
            }

            SetListViewColumnsWidth(listViewVariables, 50, 50);
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            treeViewTrace.Nodes.Clear();
            FillTreeView();
        }

        private void ExplanationFormResize(object sender, EventArgs e)
        {
            SetListViewColumnsWidth(listViewVariables, 50, 50);
        }
    }
}
