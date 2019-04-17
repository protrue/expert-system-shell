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
            this.groupBoxFact.Controls.Add(this.comboBoxValue);
            this.groupBoxFact.Controls.Add(this.comboBoxVariable);
            this.groupBoxFact.Controls.Add(this.labelValue);
            this.groupBoxFact.Controls.Add(this.labelVariable);
            this.groupBoxFact.Location = new System.Drawing.Point(27, 35);
            this.groupBoxFact.Name = "groupBoxFact";
            this.groupBoxFact.Size = new System.Drawing.Size(490, 263);
            this.groupBoxFact.TabIndex = 0;
            this.groupBoxFact.TabStop = false;
            this.groupBoxFact.Text = "Факт";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(29, 184);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(400, 33);
            this.comboBoxValue.TabIndex = 3;
            this.comboBoxValue.SelectedIndexChanged += new System.EventHandler(this.ComboBoxValueSelectedIndexChanged);
            // 
            // comboBoxVariable
            // 
            this.comboBoxVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariable.FormattingEnabled = true;
            this.comboBoxVariable.Location = new System.Drawing.Point(29, 85);
            this.comboBoxVariable.Name = "comboBoxVariable";
            this.comboBoxVariable.Size = new System.Drawing.Size(400, 33);
            this.comboBoxVariable.TabIndex = 2;
            this.comboBoxVariable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVariableSelectedIndexChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(24, 156);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(108, 25);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Значение";
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.Location = new System.Drawing.Point(24, 57);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(137, 25);
            this.labelVariable.TabIndex = 0;
            this.labelVariable.Text = "Переменная";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(146, 336);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 40);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(315, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 40);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddVariable
            // 
            this.buttonAddVariable.Location = new System.Drawing.Point(462, 120);
            this.buttonAddVariable.Name = "buttonAddVariable";
            this.buttonAddVariable.Size = new System.Drawing.Size(33, 33);
            this.buttonAddVariable.TabIndex = 3;
            this.buttonAddVariable.Text = "+";
            this.buttonAddVariable.UseVisualStyleBackColor = true;
            this.buttonAddVariable.Click += new System.EventHandler(this.ButtonAddVariableClick);
            // 
            // FactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 407);
            this.Controls.Add(this.buttonAddVariable);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxFact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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