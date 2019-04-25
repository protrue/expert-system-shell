namespace ExpertSystemShell.Gui
{
    partial class VariableForm
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
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonAddDomain = new System.Windows.Forms.Button();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxVariableKind = new System.Windows.Forms.GroupBox();
            this.radioButtonDeductibleRequested = new System.Windows.Forms.RadioButton();
            this.radioButtonRequested = new System.Windows.Forms.RadioButton();
            this.radioButtonDeductible = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxVariableKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonAddDomain);
            this.groupBoxMain.Controls.Add(this.richTextBoxQuestion);
            this.groupBoxMain.Controls.Add(this.comboBoxDomain);
            this.groupBoxMain.Controls.Add(this.textBoxName);
            this.groupBoxMain.Controls.Add(this.groupBoxVariableKind);
            this.groupBoxMain.Controls.Add(this.labelQuestion);
            this.groupBoxMain.Controls.Add(this.labelDomain);
            this.groupBoxMain.Controls.Add(this.labelName);
            this.groupBoxMain.Location = new System.Drawing.Point(14, 6);
            this.groupBoxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMain.Size = new System.Drawing.Size(318, 283);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Редактирование переменной";
            // 
            // buttonAddDomain
            // 
            this.buttonAddDomain.Location = new System.Drawing.Point(288, 69);
            this.buttonAddDomain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddDomain.Name = "buttonAddDomain";
            this.buttonAddDomain.Size = new System.Drawing.Size(21, 21);
            this.buttonAddDomain.TabIndex = 6;
            this.buttonAddDomain.Text = "+";
            this.buttonAddDomain.UseVisualStyleBackColor = true;
            this.buttonAddDomain.Click += new System.EventHandler(this.ButtonAddDomainClick);
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Location = new System.Drawing.Point(24, 213);
            this.richTextBoxQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(258, 52);
            this.richTextBoxQuestion.TabIndex = 5;
            this.richTextBoxQuestion.Text = "";
            this.richTextBoxQuestion.Leave += new System.EventHandler(this.RichTextBoxQuestionLeave);
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(110, 69);
            this.comboBoxDomain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(171, 21);
            this.comboBoxDomain.TabIndex = 1;
            this.comboBoxDomain.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDomainSelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 29);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(171, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNameKeyDown);
            this.textBoxName.Leave += new System.EventHandler(this.TextBoxNameLeave);
            // 
            // groupBoxVariableKind
            // 
            this.groupBoxVariableKind.Controls.Add(this.radioButtonDeductibleRequested);
            this.groupBoxVariableKind.Controls.Add(this.radioButtonRequested);
            this.groupBoxVariableKind.Controls.Add(this.radioButtonDeductible);
            this.groupBoxVariableKind.Location = new System.Drawing.Point(18, 101);
            this.groupBoxVariableKind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxVariableKind.Name = "groupBoxVariableKind";
            this.groupBoxVariableKind.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxVariableKind.Size = new System.Drawing.Size(261, 82);
            this.groupBoxVariableKind.TabIndex = 3;
            this.groupBoxVariableKind.TabStop = false;
            this.groupBoxVariableKind.Text = "Тип переменной";
            // 
            // radioButtonDeductibleRequested
            // 
            this.radioButtonDeductibleRequested.AutoSize = true;
            this.radioButtonDeductibleRequested.Location = new System.Drawing.Point(9, 60);
            this.radioButtonDeductibleRequested.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDeductibleRequested.Name = "radioButtonDeductibleRequested";
            this.radioButtonDeductibleRequested.Size = new System.Drawing.Size(163, 17);
            this.radioButtonDeductibleRequested.TabIndex = 3;
            this.radioButtonDeductibleRequested.TabStop = true;
            this.radioButtonDeductibleRequested.Text = "Выводимо-запрашиваемая";
            this.radioButtonDeductibleRequested.UseVisualStyleBackColor = true;
            this.radioButtonDeductibleRequested.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonRequested
            // 
            this.radioButtonRequested.AutoSize = true;
            this.radioButtonRequested.Location = new System.Drawing.Point(9, 41);
            this.radioButtonRequested.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonRequested.Name = "radioButtonRequested";
            this.radioButtonRequested.Size = new System.Drawing.Size(108, 17);
            this.radioButtonRequested.TabIndex = 2;
            this.radioButtonRequested.TabStop = true;
            this.radioButtonRequested.Text = "Запрашиваемая";
            this.radioButtonRequested.UseVisualStyleBackColor = true;
            this.radioButtonRequested.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonDeductible
            // 
            this.radioButtonDeductible.AutoSize = true;
            this.radioButtonDeductible.Location = new System.Drawing.Point(9, 22);
            this.radioButtonDeductible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDeductible.Name = "radioButtonDeductible";
            this.radioButtonDeductible.Size = new System.Drawing.Size(84, 17);
            this.radioButtonDeductible.TabIndex = 1;
            this.radioButtonDeductible.TabStop = true;
            this.radioButtonDeductible.Text = "Выводимая";
            this.radioButtonDeductible.UseVisualStyleBackColor = true;
            this.radioButtonDeductible.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(21, 193);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(82, 13);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Текст вопроса";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(21, 71);
            this.labelDomain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(42, 13);
            this.labelDomain.TabIndex = 1;
            this.labelDomain.Text = "Домен";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 30);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(198, 306);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(90, 306);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(78, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // VariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 344);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "VariableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование переменной";
            this.Load += new System.EventHandler(this.VariableFormLoad);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxVariableKind.ResumeLayout(false);
            this.groupBoxVariableKind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxVariableKind;
        private System.Windows.Forms.RadioButton radioButtonDeductible;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.RadioButton radioButtonDeductibleRequested;
        private System.Windows.Forms.RadioButton radioButtonRequested;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAddDomain;
    }
}