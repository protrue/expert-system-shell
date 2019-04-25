namespace ExpertSystemShell.Gui
{
    partial class ConsultationForm
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
            this.listViewQuestion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxQuestions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.comboBoxAnswers = new System.Windows.Forms.ComboBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelResult = new System.Windows.Forms.TableLayoutPanel();
            this.labelVariable = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelEquals = new System.Windows.Forms.Label();
            this.tableLayoutPanelExplain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExplain = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.groupBoxQuestions.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxAnswer.SuspendLayout();
            this.tableLayoutPanelAnswer.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.tableLayoutPanelResult.SuspendLayout();
            this.tableLayoutPanelExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewQuestion
            // 
            this.listViewQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewQuestion.FullRowSelect = true;
            this.listViewQuestion.GridLines = true;
            this.listViewQuestion.Location = new System.Drawing.Point(2, 15);
            this.listViewQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.listViewQuestion.Name = "listViewQuestion";
            this.listViewQuestion.Size = new System.Drawing.Size(484, 331);
            this.listViewQuestion.TabIndex = 0;
            this.listViewQuestion.UseCompatibleStateImageBehavior = false;
            this.listViewQuestion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Вопрос";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ответ";
            this.columnHeader2.Width = 150;
            // 
            // groupBoxQuestions
            // 
            this.groupBoxQuestions.Controls.Add(this.listViewQuestion);
            this.groupBoxQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQuestions.Location = new System.Drawing.Point(2, 2);
            this.groupBoxQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQuestions.Name = "groupBoxQuestions";
            this.groupBoxQuestions.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQuestions.Size = new System.Drawing.Size(488, 348);
            this.groupBoxQuestions.TabIndex = 1;
            this.groupBoxQuestions.TabStop = false;
            this.groupBoxQuestions.Text = "Вопросы";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxQuestions, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxAnswer, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxResult, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelExplain, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(492, 483);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.tableLayoutPanelAnswer);
            this.groupBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAnswer.Location = new System.Drawing.Point(2, 354);
            this.groupBoxAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAnswer.Size = new System.Drawing.Size(488, 43);
            this.groupBoxAnswer.TabIndex = 2;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Ответ";
            // 
            // tableLayoutPanelAnswer
            // 
            this.tableLayoutPanelAnswer.ColumnCount = 2;
            this.tableLayoutPanelAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelAnswer.Controls.Add(this.buttonAnswer, 1, 0);
            this.tableLayoutPanelAnswer.Controls.Add(this.comboBoxAnswers, 0, 0);
            this.tableLayoutPanelAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAnswer.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanelAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelAnswer.Name = "tableLayoutPanelAnswer";
            this.tableLayoutPanelAnswer.RowCount = 1;
            this.tableLayoutPanelAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAnswer.Size = new System.Drawing.Size(484, 26);
            this.tableLayoutPanelAnswer.TabIndex = 0;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnswer.Location = new System.Drawing.Point(411, 2);
            this.buttonAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(71, 22);
            this.buttonAnswer.TabIndex = 0;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.ButtonAnswerClick);
            // 
            // comboBoxAnswers
            // 
            this.comboBoxAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAnswers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnswers.FormattingEnabled = true;
            this.comboBoxAnswers.Location = new System.Drawing.Point(2, 2);
            this.comboBoxAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnswers.Name = "comboBoxAnswers";
            this.comboBoxAnswers.Size = new System.Drawing.Size(405, 21);
            this.comboBoxAnswers.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tableLayoutPanelResult);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult.Location = new System.Drawing.Point(2, 401);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Size = new System.Drawing.Size(488, 38);
            this.groupBoxResult.TabIndex = 3;
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
            this.tableLayoutPanelResult.Size = new System.Drawing.Size(484, 21);
            this.tableLayoutPanelResult.TabIndex = 0;
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVariable.Location = new System.Drawing.Point(2, 0);
            this.labelVariable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(213, 21);
            this.labelVariable.TabIndex = 0;
            this.labelVariable.Text = "Цель консультации";
            this.labelVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Location = new System.Drawing.Point(267, 0);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(215, 21);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "?";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEquals.Location = new System.Drawing.Point(219, 0);
            this.labelEquals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(44, 21);
            this.labelEquals.TabIndex = 2;
            this.labelEquals.Text = "=";
            this.labelEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelExplain
            // 
            this.tableLayoutPanelExplain.ColumnCount = 3;
            this.tableLayoutPanelExplain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelExplain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelExplain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelExplain.Controls.Add(this.buttonExplain, 2, 0);
            this.tableLayoutPanelExplain.Controls.Add(this.buttonRestart, 0, 0);
            this.tableLayoutPanelExplain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelExplain.Location = new System.Drawing.Point(2, 443);
            this.tableLayoutPanelExplain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelExplain.Name = "tableLayoutPanelExplain";
            this.tableLayoutPanelExplain.RowCount = 1;
            this.tableLayoutPanelExplain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelExplain.Size = new System.Drawing.Size(488, 38);
            this.tableLayoutPanelExplain.TabIndex = 4;
            // 
            // buttonExplain
            // 
            this.buttonExplain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExplain.Location = new System.Drawing.Point(326, 2);
            this.buttonExplain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplain.Name = "buttonExplain";
            this.buttonExplain.Size = new System.Drawing.Size(160, 34);
            this.buttonExplain.TabIndex = 1;
            this.buttonExplain.Text = "Объяснить";
            this.buttonExplain.UseVisualStyleBackColor = true;
            this.buttonExplain.Click += new System.EventHandler(this.ButtonExplainClick);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRestart.Location = new System.Drawing.Point(3, 3);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(156, 32);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Начать заново";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestartClick);
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 483);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Консультация";
            this.Load += new System.EventHandler(this.ConsultationFormLoad);
            this.Resize += new System.EventHandler(this.ConsultationFormResize);
            this.groupBoxQuestions.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxAnswer.ResumeLayout(false);
            this.tableLayoutPanelAnswer.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.tableLayoutPanelResult.ResumeLayout(false);
            this.tableLayoutPanelResult.PerformLayout();
            this.tableLayoutPanelExplain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewQuestion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBoxQuestions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAnswer;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.ComboBox comboBoxAnswers;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResult;
        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExplain;
        private System.Windows.Forms.Button buttonExplain;
        private System.Windows.Forms.Button buttonRestart;
    }
}