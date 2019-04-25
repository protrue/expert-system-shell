namespace ExpertSystemShell.Gui
{
    partial class ExplanationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewTrace = new System.Windows.Forms.TreeView();
            this.groupBoxTrace = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTrace = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTraceMode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTraceMode = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonTraceAll = new System.Windows.Forms.RadioButton();
            this.radioButtonTraceNeeded = new System.Windows.Forms.RadioButton();
            this.groupBoxVariables = new System.Windows.Forms.GroupBox();
            this.listViewVariables = new System.Windows.Forms.ListView();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelResult = new System.Windows.Forms.TableLayoutPanel();
            this.labelVariable = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelEquals = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTrace.SuspendLayout();
            this.tableLayoutPanelTrace.SuspendLayout();
            this.groupBoxTraceMode.SuspendLayout();
            this.tableLayoutPanelTraceMode.SuspendLayout();
            this.groupBoxVariables.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.tableLayoutPanelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewTrace
            // 
            this.treeViewTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTrace.Location = new System.Drawing.Point(2, 54);
            this.treeViewTrace.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewTrace.Name = "treeViewTrace";
            this.treeViewTrace.Size = new System.Drawing.Size(360, 308);
            this.treeViewTrace.TabIndex = 0;
            // 
            // groupBoxTrace
            // 
            this.groupBoxTrace.Controls.Add(this.tableLayoutPanelTrace);
            this.groupBoxTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTrace.Location = new System.Drawing.Point(2, 2);
            this.groupBoxTrace.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTrace.Name = "groupBoxTrace";
            this.groupBoxTrace.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTrace.Size = new System.Drawing.Size(368, 381);
            this.groupBoxTrace.TabIndex = 1;
            this.groupBoxTrace.TabStop = false;
            this.groupBoxTrace.Text = "Ход вывода";
            // 
            // tableLayoutPanelTrace
            // 
            this.tableLayoutPanelTrace.ColumnCount = 1;
            this.tableLayoutPanelTrace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrace.Controls.Add(this.treeViewTrace, 0, 1);
            this.tableLayoutPanelTrace.Controls.Add(this.groupBoxTraceMode, 0, 0);
            this.tableLayoutPanelTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrace.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanelTrace.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelTrace.Name = "tableLayoutPanelTrace";
            this.tableLayoutPanelTrace.RowCount = 2;
            this.tableLayoutPanelTrace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelTrace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrace.Size = new System.Drawing.Size(364, 364);
            this.tableLayoutPanelTrace.TabIndex = 1;
            // 
            // groupBoxTraceMode
            // 
            this.groupBoxTraceMode.Controls.Add(this.tableLayoutPanelTraceMode);
            this.groupBoxTraceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTraceMode.Location = new System.Drawing.Point(2, 2);
            this.groupBoxTraceMode.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTraceMode.Name = "groupBoxTraceMode";
            this.groupBoxTraceMode.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTraceMode.Size = new System.Drawing.Size(360, 48);
            this.groupBoxTraceMode.TabIndex = 1;
            this.groupBoxTraceMode.TabStop = false;
            this.groupBoxTraceMode.Text = "Режим";
            // 
            // tableLayoutPanelTraceMode
            // 
            this.tableLayoutPanelTraceMode.ColumnCount = 2;
            this.tableLayoutPanelTraceMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTraceMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTraceMode.Controls.Add(this.radioButtonTraceAll, 0, 0);
            this.tableLayoutPanelTraceMode.Controls.Add(this.radioButtonTraceNeeded, 1, 0);
            this.tableLayoutPanelTraceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTraceMode.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanelTraceMode.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelTraceMode.Name = "tableLayoutPanelTraceMode";
            this.tableLayoutPanelTraceMode.RowCount = 1;
            this.tableLayoutPanelTraceMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTraceMode.Size = new System.Drawing.Size(356, 31);
            this.tableLayoutPanelTraceMode.TabIndex = 2;
            // 
            // radioButtonTraceAll
            // 
            this.radioButtonTraceAll.AutoSize = true;
            this.radioButtonTraceAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTraceAll.Location = new System.Drawing.Point(2, 2);
            this.radioButtonTraceAll.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTraceAll.Name = "radioButtonTraceAll";
            this.radioButtonTraceAll.Size = new System.Drawing.Size(174, 27);
            this.radioButtonTraceAll.TabIndex = 0;
            this.radioButtonTraceAll.Text = "Все";
            this.radioButtonTraceAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonTraceNeeded
            // 
            this.radioButtonTraceNeeded.AutoSize = true;
            this.radioButtonTraceNeeded.Checked = true;
            this.radioButtonTraceNeeded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTraceNeeded.Location = new System.Drawing.Point(180, 2);
            this.radioButtonTraceNeeded.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTraceNeeded.Name = "radioButtonTraceNeeded";
            this.radioButtonTraceNeeded.Size = new System.Drawing.Size(174, 27);
            this.radioButtonTraceNeeded.TabIndex = 1;
            this.radioButtonTraceNeeded.TabStop = true;
            this.radioButtonTraceNeeded.Text = "Сработавшие";
            this.radioButtonTraceNeeded.UseVisualStyleBackColor = true;
            this.radioButtonTraceNeeded.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // groupBoxVariables
            // 
            this.groupBoxVariables.Controls.Add(this.listViewVariables);
            this.groupBoxVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVariables.Location = new System.Drawing.Point(374, 2);
            this.groupBoxVariables.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVariables.Name = "groupBoxVariables";
            this.groupBoxVariables.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxVariables.Size = new System.Drawing.Size(244, 381);
            this.groupBoxVariables.TabIndex = 2;
            this.groupBoxVariables.TabStop = false;
            this.groupBoxVariables.Text = "Переменные";
            // 
            // listViewVariables
            // 
            this.listViewVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVariables.FullRowSelect = true;
            this.listViewVariables.GridLines = true;
            this.listViewVariables.HideSelection = false;
            this.listViewVariables.Location = new System.Drawing.Point(2, 15);
            this.listViewVariables.Margin = new System.Windows.Forms.Padding(2);
            this.listViewVariables.Name = "listViewVariables";
            this.listViewVariables.Size = new System.Drawing.Size(240, 364);
            this.listViewVariables.TabIndex = 0;
            this.listViewVariables.UseCompatibleStateImageBehavior = false;
            this.listViewVariables.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxTrace, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxVariables, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(620, 385);
            this.tableLayoutPanelTop.TabIndex = 3;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxResult, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tableLayoutPanelResult);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult.Location = new System.Drawing.Point(2, 391);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Size = new System.Drawing.Size(620, 48);
            this.groupBoxResult.TabIndex = 4;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // tableLayoutPanelResult
            // 
            this.tableLayoutPanelResult.ColumnCount = 3;
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelResult.Controls.Add(this.labelVariable, 0, 0);
            this.tableLayoutPanelResult.Controls.Add(this.labelResult, 2, 0);
            this.tableLayoutPanelResult.Controls.Add(this.labelEquals, 1, 0);
            this.tableLayoutPanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResult.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanelResult.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelResult.Name = "tableLayoutPanelResult";
            this.tableLayoutPanelResult.RowCount = 1;
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResult.Size = new System.Drawing.Size(616, 31);
            this.tableLayoutPanelResult.TabIndex = 0;
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVariable.Location = new System.Drawing.Point(2, 0);
            this.labelVariable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(273, 31);
            this.labelVariable.TabIndex = 0;
            this.labelVariable.Text = "Цель консультации";
            this.labelVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Location = new System.Drawing.Point(340, 0);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(274, 31);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "?";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEquals.Location = new System.Drawing.Point(279, 0);
            this.labelEquals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(57, 31);
            this.labelEquals.TabIndex = 2;
            this.labelEquals.Text = "=";
            this.labelEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Переменная";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            // 
            // ExplanationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExplanationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Объяснение";
            this.Load += new System.EventHandler(this.ExplanationFormLoad);
            this.Resize += new System.EventHandler(this.ExplanationFormResize);
            this.groupBoxTrace.ResumeLayout(false);
            this.tableLayoutPanelTrace.ResumeLayout(false);
            this.groupBoxTraceMode.ResumeLayout(false);
            this.tableLayoutPanelTraceMode.ResumeLayout(false);
            this.tableLayoutPanelTraceMode.PerformLayout();
            this.groupBoxVariables.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.tableLayoutPanelResult.ResumeLayout(false);
            this.tableLayoutPanelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewTrace;
        private System.Windows.Forms.GroupBox groupBoxTrace;
        private System.Windows.Forms.GroupBox groupBoxVariables;
        private System.Windows.Forms.ListView listViewVariables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResult;
        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrace;
        private System.Windows.Forms.GroupBox groupBoxTraceMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTraceMode;
        private System.Windows.Forms.RadioButton radioButtonTraceAll;
        private System.Windows.Forms.RadioButton radioButtonTraceNeeded;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}