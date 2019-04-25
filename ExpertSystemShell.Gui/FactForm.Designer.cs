namespace ExpertSystemShell.Gui
{
    partial class FactForm
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
            this.groupBoxFact = new System.Windows.Forms.GroupBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxVariable = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelVariable = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddVariable = new System.Windows.Forms.Button();
            this.groupBoxFact.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFact
            // 
            this.groupBoxFact.Controls.Add(this.buttonAddVariable);
            this.groupBoxFact.Controls.Add(this.comboBoxValue);
            this.groupBoxFact.Controls.Add(this.comboBoxVariable);
            this.groupBoxFact.Controls.Add(this.labelValue);
            this.groupBoxFact.Controls.Add(this.labelVariable);
            this.groupBoxFact.Location = new System.Drawing.Point(14, 18);
            this.groupBoxFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFact.Name = "groupBoxFact";
            this.groupBoxFact.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFact.Size = new System.Drawing.Size(255, 137);
            this.groupBoxFact.TabIndex = 0;
            this.groupBoxFact.TabStop = false;
            this.groupBoxFact.Text = "Факт";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(14, 96);
            this.comboBoxValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(202, 21);
            this.comboBoxValue.TabIndex = 3;
            this.comboBoxValue.SelectedIndexChanged += new System.EventHandler(this.ComboBoxValueSelectedIndexChanged);
            // 
            // comboBoxVariable
            // 
            this.comboBoxVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariable.FormattingEnabled = true;
            this.comboBoxVariable.Location = new System.Drawing.Point(14, 44);
            this.comboBoxVariable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVariable.Name = "comboBoxVariable";
            this.comboBoxVariable.Size = new System.Drawing.Size(202, 21);
            this.comboBoxVariable.TabIndex = 2;
            this.comboBoxVariable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVariableSelectedIndexChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 81);
            this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(55, 13);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Значение";
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.Location = new System.Drawing.Point(12, 30);
            this.labelVariable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(71, 13);
            this.labelVariable.TabIndex = 0;
            this.labelVariable.Text = "Переменная";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(73, 175);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(50, 21);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(158, 175);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddVariable
            // 
            this.buttonAddVariable.Location = new System.Drawing.Point(225, 44);
            this.buttonAddVariable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddVariable.Name = "buttonAddVariable";
            this.buttonAddVariable.Size = new System.Drawing.Size(24, 21);
            this.buttonAddVariable.TabIndex = 3;
            this.buttonAddVariable.Text = "+";
            this.buttonAddVariable.UseVisualStyleBackColor = true;
            this.buttonAddVariable.Click += new System.EventHandler(this.ButtonAddVariableClick);
            // 
            // FactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 212);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxFact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Факт";
            this.Load += new System.EventHandler(this.FactFormLoad);
            this.groupBoxFact.ResumeLayout(false);
            this.groupBoxFact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFact;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxVariable;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddVariable;
    }
}