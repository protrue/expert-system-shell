namespace ExpertSystemShell.Gui
{
    partial class RuleForm
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
            this.groupBoxRule = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.richTextBoxReason = new System.Windows.Forms.RichTextBox();
            this.groupBoxConclusion = new System.Windows.Forms.GroupBox();
            this.buttonDeleteConclusion = new System.Windows.Forms.Button();
            this.buttonChangeConclusion = new System.Windows.Forms.Button();
            this.buttonAddConclusion = new System.Windows.Forms.Button();
            this.listBoxConclusion = new System.Windows.Forms.ListBox();
            this.groupBoxPremise = new System.Windows.Forms.GroupBox();
            this.buttonDeletePremise = new System.Windows.Forms.Button();
            this.buttonChangePremise = new System.Windows.Forms.Button();
            this.buttonAddPremise = new System.Windows.Forms.Button();
            this.listBoxPremise = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxRule.SuspendLayout();
            this.groupBoxConclusion.SuspendLayout();
            this.groupBoxPremise.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRule
            // 
            this.groupBoxRule.Controls.Add(this.textBoxName);
            this.groupBoxRule.Controls.Add(this.labelName);
            this.groupBoxRule.Controls.Add(this.labelReason);
            this.groupBoxRule.Controls.Add(this.richTextBoxReason);
            this.groupBoxRule.Controls.Add(this.groupBoxConclusion);
            this.groupBoxRule.Controls.Add(this.groupBoxPremise);
            this.groupBoxRule.Location = new System.Drawing.Point(22, 25);
            this.groupBoxRule.Name = "groupBoxRule";
            this.groupBoxRule.Size = new System.Drawing.Size(1066, 687);
            this.groupBoxRule.TabIndex = 0;
            this.groupBoxRule.TabStop = false;
            this.groupBoxRule.Text = "Правило";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(39, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(489, 31);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Leave += new System.EventHandler(this.TextBoxNameLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Название";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(34, 535);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(121, 25);
            this.labelReason.TabIndex = 3;
            this.labelReason.Text = "Пояснение";
            // 
            // richTextBoxReason
            // 
            this.richTextBoxReason.Location = new System.Drawing.Point(33, 563);
            this.richTextBoxReason.MaxLength = 1000;
            this.richTextBoxReason.Name = "richTextBoxReason";
            this.richTextBoxReason.Size = new System.Drawing.Size(1006, 99);
            this.richTextBoxReason.TabIndex = 2;
            this.richTextBoxReason.Text = "";
            this.richTextBoxReason.Leave += new System.EventHandler(this.RichTextBoxReasonLeave);
            // 
            // groupBoxConclusion
            // 
            this.groupBoxConclusion.Controls.Add(this.buttonDeleteConclusion);
            this.groupBoxConclusion.Controls.Add(this.buttonChangeConclusion);
            this.groupBoxConclusion.Controls.Add(this.buttonAddConclusion);
            this.groupBoxConclusion.Controls.Add(this.listBoxConclusion);
            this.groupBoxConclusion.Location = new System.Drawing.Point(539, 137);
            this.groupBoxConclusion.Name = "groupBoxConclusion";
            this.groupBoxConclusion.Size = new System.Drawing.Size(500, 350);
            this.groupBoxConclusion.TabIndex = 1;
            this.groupBoxConclusion.TabStop = false;
            this.groupBoxConclusion.Text = "Заключение";
            // 
            // buttonDeleteConclusion
            // 
            this.buttonDeleteConclusion.Location = new System.Drawing.Point(318, 293);
            this.buttonDeleteConclusion.Name = "buttonDeleteConclusion";
            this.buttonDeleteConclusion.Size = new System.Drawing.Size(150, 40);
            this.buttonDeleteConclusion.TabIndex = 6;
            this.buttonDeleteConclusion.Text = "Удалить";
            this.buttonDeleteConclusion.UseVisualStyleBackColor = true;
            this.buttonDeleteConclusion.Click += new System.EventHandler(this.ButtonDeleteConclusionClick);
            // 
            // buttonChangeConclusion
            // 
            this.buttonChangeConclusion.Location = new System.Drawing.Point(162, 293);
            this.buttonChangeConclusion.Name = "buttonChangeConclusion";
            this.buttonChangeConclusion.Size = new System.Drawing.Size(150, 40);
            this.buttonChangeConclusion.TabIndex = 5;
            this.buttonChangeConclusion.Text = "Изменить";
            this.buttonChangeConclusion.UseVisualStyleBackColor = true;
            this.buttonChangeConclusion.Click += new System.EventHandler(this.ButtonChangeConclusionClick);
            // 
            // buttonAddConclusion
            // 
            this.buttonAddConclusion.Location = new System.Drawing.Point(6, 293);
            this.buttonAddConclusion.Name = "buttonAddConclusion";
            this.buttonAddConclusion.Size = new System.Drawing.Size(150, 40);
            this.buttonAddConclusion.TabIndex = 4;
            this.buttonAddConclusion.Text = "Добавить";
            this.buttonAddConclusion.UseVisualStyleBackColor = true;
            this.buttonAddConclusion.Click += new System.EventHandler(this.ButtonAddConclusionClick);
            // 
            // listBoxConclusion
            // 
            this.listBoxConclusion.FormattingEnabled = true;
            this.listBoxConclusion.ItemHeight = 25;
            this.listBoxConclusion.Location = new System.Drawing.Point(18, 39);
            this.listBoxConclusion.Name = "listBoxConclusion";
            this.listBoxConclusion.Size = new System.Drawing.Size(450, 229);
            this.listBoxConclusion.TabIndex = 0;
            this.listBoxConclusion.SelectedIndexChanged += new System.EventHandler(this.ListBoxConclusionSelectedIndexChanged);
            // 
            // groupBoxPremise
            // 
            this.groupBoxPremise.Controls.Add(this.buttonDeletePremise);
            this.groupBoxPremise.Controls.Add(this.buttonChangePremise);
            this.groupBoxPremise.Controls.Add(this.buttonAddPremise);
            this.groupBoxPremise.Controls.Add(this.listBoxPremise);
            this.groupBoxPremise.Location = new System.Drawing.Point(33, 137);
            this.groupBoxPremise.Name = "groupBoxPremise";
            this.groupBoxPremise.Size = new System.Drawing.Size(500, 350);
            this.groupBoxPremise.TabIndex = 0;
            this.groupBoxPremise.TabStop = false;
            this.groupBoxPremise.Text = "Посылка";
            // 
            // buttonDeletePremise
            // 
            this.buttonDeletePremise.Location = new System.Drawing.Point(318, 293);
            this.buttonDeletePremise.Name = "buttonDeletePremise";
            this.buttonDeletePremise.Size = new System.Drawing.Size(150, 40);
            this.buttonDeletePremise.TabIndex = 6;
            this.buttonDeletePremise.Text = "Удалить";
            this.buttonDeletePremise.UseVisualStyleBackColor = true;
            this.buttonDeletePremise.Click += new System.EventHandler(this.ButtonDeletePremiseClick);
            // 
            // buttonChangePremise
            // 
            this.buttonChangePremise.Location = new System.Drawing.Point(162, 293);
            this.buttonChangePremise.Name = "buttonChangePremise";
            this.buttonChangePremise.Size = new System.Drawing.Size(150, 40);
            this.buttonChangePremise.TabIndex = 5;
            this.buttonChangePremise.Text = "Изменить";
            this.buttonChangePremise.UseVisualStyleBackColor = true;
            this.buttonChangePremise.Click += new System.EventHandler(this.ButtonChangePremiseClick);
            // 
            // buttonAddPremise
            // 
            this.buttonAddPremise.Location = new System.Drawing.Point(6, 293);
            this.buttonAddPremise.Name = "buttonAddPremise";
            this.buttonAddPremise.Size = new System.Drawing.Size(150, 40);
            this.buttonAddPremise.TabIndex = 4;
            this.buttonAddPremise.Text = "Добавить";
            this.buttonAddPremise.UseVisualStyleBackColor = true;
            this.buttonAddPremise.Click += new System.EventHandler(this.ButtonAddPremiseClick);
            // 
            // listBoxPremise
            // 
            this.listBoxPremise.FormattingEnabled = true;
            this.listBoxPremise.ItemHeight = 25;
            this.listBoxPremise.Location = new System.Drawing.Point(18, 39);
            this.listBoxPremise.Name = "listBoxPremise";
            this.listBoxPremise.Size = new System.Drawing.Size(450, 229);
            this.listBoxPremise.TabIndex = 0;
            this.listBoxPremise.SelectedIndexChanged += new System.EventHandler(this.ListBoxPremiseSelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(911, 747);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 50);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(710, 747);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(150, 50);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 826);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxRule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование правила";
            this.Load += new System.EventHandler(this.RuleFormLoad);
            this.groupBoxRule.ResumeLayout(false);
            this.groupBoxRule.PerformLayout();
            this.groupBoxConclusion.ResumeLayout(false);
            this.groupBoxPremise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRule;
        private System.Windows.Forms.GroupBox groupBoxConclusion;
        private System.Windows.Forms.GroupBox groupBoxPremise;
        private System.Windows.Forms.RichTextBox richTextBoxReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.ListBox listBoxConclusion;
        private System.Windows.Forms.ListBox listBoxPremise;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonDeleteConclusion;
        private System.Windows.Forms.Button buttonChangeConclusion;
        private System.Windows.Forms.Button buttonAddConclusion;
        private System.Windows.Forms.Button buttonDeletePremise;
        private System.Windows.Forms.Button buttonChangePremise;
        private System.Windows.Forms.Button buttonAddPremise;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}