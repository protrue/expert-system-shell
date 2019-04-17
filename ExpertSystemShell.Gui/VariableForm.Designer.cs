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
            this.groupBoxMain.Location = new System.Drawing.Point(28, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(636, 545);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Редактирование переменной";
            // 
            // buttonAddDomain
            // 
            this.buttonAddDomain.Location = new System.Drawing.Point(577, 133);
            this.buttonAddDomain.Name = "buttonAddDomain";
            this.buttonAddDomain.Size = new System.Drawing.Size(33, 33);
            this.buttonAddDomain.TabIndex = 6;
            this.buttonAddDomain.Text = "+";
            this.buttonAddDomain.UseVisualStyleBackColor = true;
            this.buttonAddDomain.Click += new System.EventHandler(this.ButtonAddDomainClick);
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Location = new System.Drawing.Point(47, 409);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(511, 96);
            this.richTextBoxQuestion.TabIndex = 5;
            this.richTextBoxQuestion.Text = "";
            this.richTextBoxQuestion.Leave += new System.EventHandler(this.RichTextBoxQuestionLeave);
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(220, 133);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(338, 33);
            this.comboBoxDomain.TabIndex = 1;
            this.comboBoxDomain.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDomainSelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(220, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(338, 31);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNameKeyDown);
            this.textBoxName.Leave += new System.EventHandler(this.TextBoxNameLeave);
            // 
            // groupBoxVariableKind
            // 
            this.groupBoxVariableKind.Controls.Add(this.radioButtonDeductibleRequested);
            this.groupBoxVariableKind.Controls.Add(this.radioButtonRequested);
            this.groupBoxVariableKind.Controls.Add(this.radioButtonDeductible);
            this.groupBoxVariableKind.Location = new System.Drawing.Point(36, 195);
            this.groupBoxVariableKind.Name = "groupBoxVariableKind";
            this.groupBoxVariableKind.Size = new System.Drawing.Size(522, 158);
            this.groupBoxVariableKind.TabIndex = 3;
            this.groupBoxVariableKind.TabStop = false;
            this.groupBoxVariableKind.Text = "Тип переменной";
            // 
            // radioButtonDeductibleRequested
            // 
            this.radioButtonDeductibleRequested.AutoSize = true;
            this.radioButtonDeductibleRequested.Location = new System.Drawing.Point(18, 115);
            this.radioButtonDeductibleRequested.Name = "radioButtonDeductibleRequested";
            this.radioButtonDeductibleRequested.Size = new System.Drawing.Size(314, 29);
            this.radioButtonDeductibleRequested.TabIndex = 3;
            this.radioButtonDeductibleRequested.TabStop = true;
            this.radioButtonDeductibleRequested.Text = "Выводимо-запрашиваемая";
            this.radioButtonDeductibleRequested.UseVisualStyleBackColor = true;
            this.radioButtonDeductibleRequested.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonRequested
            // 
            this.radioButtonRequested.AutoSize = true;
            this.radioButtonRequested.Location = new System.Drawing.Point(18, 79);
            this.radioButtonRequested.Name = "radioButtonRequested";
            this.radioButtonRequested.Size = new System.Drawing.Size(206, 29);
            this.radioButtonRequested.TabIndex = 2;
            this.radioButtonRequested.TabStop = true;
            this.radioButtonRequested.Text = "Запрашиваемая";
            this.radioButtonRequested.UseVisualStyleBackColor = true;
            this.radioButtonRequested.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonDeductible
            // 
            this.radioButtonDeductible.AutoSize = true;
            this.radioButtonDeductible.Location = new System.Drawing.Point(18, 43);
            this.radioButtonDeductible.Name = "radioButtonDeductible";
            this.radioButtonDeductible.Size = new System.Drawing.Size(157, 29);
            this.radioButtonDeductible.TabIndex = 1;
            this.radioButtonDeductible.TabStop = true;
            this.radioButtonDeductible.Text = "Выводимая";
            this.radioButtonDeductible.UseVisualStyleBackColor = true;
            this.radioButtonDeductible.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(42, 372);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(157, 25);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Текст вопроса";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(42, 136);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(79, 25);
            this.labelDomain.TabIndex = 1;
            this.labelDomain.Text = "Домен";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(395, 588);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 45);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(181, 588);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(155, 45);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // VariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 662);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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