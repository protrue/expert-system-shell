namespace ExpertSystemShell.Gui
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.tlpSwitch = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonDomains = new System.Windows.Forms.RadioButton();
            this.radioButtonVariables = new System.Windows.Forms.RadioButton();
            this.radioButtonRules = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxListView = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.tlpSwitch.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.groupBoxListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Location = new System.Drawing.Point(0, 844);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1606, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1606, 40);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(83, 38);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.showLastToolStripMenuItem});
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(399, 38);
            this.startToolStripMenuItem.Text = "Начать";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.ConsultToolStripMenuItemClick);
            // 
            // showLastToolStripMenuItem
            // 
            this.showLastToolStripMenuItem.Name = "showLastToolStripMenuItem";
            this.showLastToolStripMenuItem.Size = new System.Drawing.Size(399, 38);
            this.showLastToolStripMenuItem.Text = "Просмотреть последнюю";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Controls.Add(this.groupBoxOperations, 1, 0);
            this.tlpMain.Controls.Add(this.groupBoxListView, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 40);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1606, 804);
            this.tlpMain.TabIndex = 2;
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.tlpSide);
            this.groupBoxOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOperations.Location = new System.Drawing.Point(1287, 3);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(316, 798);
            this.groupBoxOperations.TabIndex = 0;
            this.groupBoxOperations.TabStop = false;
            // 
            // tlpSide
            // 
            this.tlpSide.ColumnCount = 1;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSide.Controls.Add(this.groupBoxMode, 0, 0);
            this.tlpSide.Controls.Add(this.tableLayoutPanelButtons, 0, 1);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.Location = new System.Drawing.Point(3, 27);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 3;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.Size = new System.Drawing.Size(310, 768);
            this.tlpSide.TabIndex = 0;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.tlpSwitch);
            this.groupBoxMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMode.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(304, 250);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            // 
            // tlpSwitch
            // 
            this.tlpSwitch.ColumnCount = 1;
            this.tlpSwitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSwitch.Controls.Add(this.radioButtonDomains, 0, 0);
            this.tlpSwitch.Controls.Add(this.radioButtonVariables, 0, 1);
            this.tlpSwitch.Controls.Add(this.radioButtonRules, 0, 2);
            this.tlpSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSwitch.Location = new System.Drawing.Point(3, 27);
            this.tlpSwitch.Name = "tlpSwitch";
            this.tlpSwitch.RowCount = 3;
            this.tlpSwitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSwitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSwitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSwitch.Size = new System.Drawing.Size(298, 220);
            this.tlpSwitch.TabIndex = 0;
            // 
            // radioButtonDomains
            // 
            this.radioButtonDomains.AutoSize = true;
            this.radioButtonDomains.Location = new System.Drawing.Point(3, 3);
            this.radioButtonDomains.Name = "radioButtonDomains";
            this.radioButtonDomains.Size = new System.Drawing.Size(125, 29);
            this.radioButtonDomains.TabIndex = 0;
            this.radioButtonDomains.TabStop = true;
            this.radioButtonDomains.Text = "Домены";
            this.radioButtonDomains.UseVisualStyleBackColor = true;
            this.radioButtonDomains.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonVariables
            // 
            this.radioButtonVariables.AutoSize = true;
            this.radioButtonVariables.Location = new System.Drawing.Point(3, 76);
            this.radioButtonVariables.Name = "radioButtonVariables";
            this.radioButtonVariables.Size = new System.Drawing.Size(172, 29);
            this.radioButtonVariables.TabIndex = 1;
            this.radioButtonVariables.TabStop = true;
            this.radioButtonVariables.Text = "Переменные";
            this.radioButtonVariables.UseVisualStyleBackColor = true;
            this.radioButtonVariables.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioButtonRules
            // 
            this.radioButtonRules.AutoSize = true;
            this.radioButtonRules.Location = new System.Drawing.Point(3, 149);
            this.radioButtonRules.Name = "radioButtonRules";
            this.radioButtonRules.Size = new System.Drawing.Size(129, 29);
            this.radioButtonRules.TabIndex = 2;
            this.radioButtonRules.TabStop = true;
            this.radioButtonRules.Text = "Правила";
            this.radioButtonRules.UseVisualStyleBackColor = true;
            this.radioButtonRules.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonEdit, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonDelete, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(304, 250);
            this.tableLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(298, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit.Location = new System.Drawing.Point(3, 86);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(298, 50);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete.Location = new System.Drawing.Point(3, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(298, 50);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // groupBoxListView
            // 
            this.groupBoxListView.Controls.Add(this.listView);
            this.groupBoxListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListView.Location = new System.Drawing.Point(3, 3);
            this.groupBoxListView.Name = "groupBoxListView";
            this.groupBoxListView.Size = new System.Drawing.Size(1278, 798);
            this.groupBoxListView.TabIndex = 1;
            this.groupBoxListView.TabStop = false;
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 27);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1272, 768);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.ListViewSelectedIndexChanged);
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxValuesDragDrop);
            this.listView.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBoxValuesDragOver);
            this.listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseDown);
            this.listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseMove);
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "kb";
            this.openFileDialog.FileName = "knowledgeBase";
            this.openFileDialog.Filter = "Файл базы знаний|*.kb";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "kb";
            this.saveFileDialog.FileName = "knowledgeBase";
            this.saveFileDialog.Filter = "Файл базы знаний|*.kb";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1606, 866);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оболочка экспертной системы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.groupBoxOperations.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.groupBoxMode.ResumeLayout(false);
            this.tlpSwitch.ResumeLayout(false);
            this.tlpSwitch.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.groupBoxListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.TableLayoutPanel tlpSwitch;
        private System.Windows.Forms.RadioButton radioButtonDomains;
        private System.Windows.Forms.RadioButton radioButtonVariables;
        private System.Windows.Forms.RadioButton radioButtonRules;
        private System.Windows.Forms.GroupBox groupBoxListView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLastToolStripMenuItem;
    }
}

