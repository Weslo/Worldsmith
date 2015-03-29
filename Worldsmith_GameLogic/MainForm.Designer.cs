namespace Worldsmith.GameLogic
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
            System.Windows.Forms.MenuStrip formMenuStrip;
            System.Windows.Forms.Label classRestrictionLabel;
            System.Windows.Forms.Label actionCostLabel;
            System.Windows.Forms.Label skillNameLabel;
            System.Windows.Forms.Label energyCostLabel;
            System.Windows.Forms.Label targetTypeLabel;
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.openDataSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainFormTabControl = new System.Windows.Forms.TabControl();
            this.skillsTabPage = new System.Windows.Forms.TabPage();
            this.targetTypeComboBox = new System.Windows.Forms.ComboBox();
            this.energyCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.skillClassRestrictionComboBox = new System.Windows.Forms.ComboBox();
            this.skillNameTextBox = new System.Windows.Forms.TextBox();
            this.newActionButton = new System.Windows.Forms.Button();
            this.skillsListBox = new System.Windows.Forms.ListBox();
            this.saveDataSourceDialog = new System.Windows.Forms.SaveFileDialog();
            formMenuStrip = new System.Windows.Forms.MenuStrip();
            classRestrictionLabel = new System.Windows.Forms.Label();
            actionCostLabel = new System.Windows.Forms.Label();
            skillNameLabel = new System.Windows.Forms.Label();
            energyCostLabel = new System.Windows.Forms.Label();
            targetTypeLabel = new System.Windows.Forms.Label();
            formMenuStrip.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.skillsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energyCostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            this.SuspendLayout();
            // 
            // formMenuStrip
            // 
            formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            formMenuStrip.Location = new System.Drawing.Point(0, 0);
            formMenuStrip.Name = "formMenuStrip";
            formMenuStrip.Size = new System.Drawing.Size(371, 24);
            formMenuStrip.TabIndex = 3;
            formMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // classRestrictionLabel
            // 
            classRestrictionLabel.AutoSize = true;
            classRestrictionLabel.Location = new System.Drawing.Point(129, 35);
            classRestrictionLabel.Name = "classRestrictionLabel";
            classRestrictionLabel.Size = new System.Drawing.Size(85, 13);
            classRestrictionLabel.TabIndex = 5;
            classRestrictionLabel.Text = "Class Restriction";
            // 
            // actionCostLabel
            // 
            actionCostLabel.AutoSize = true;
            actionCostLabel.Location = new System.Drawing.Point(129, 61);
            actionCostLabel.Name = "actionCostLabel";
            actionCostLabel.Size = new System.Drawing.Size(61, 13);
            actionCostLabel.TabIndex = 7;
            actionCostLabel.Text = "Action Cost";
            // 
            // skillNameLabel
            // 
            skillNameLabel.AutoSize = true;
            skillNameLabel.Location = new System.Drawing.Point(129, 9);
            skillNameLabel.Name = "skillNameLabel";
            skillNameLabel.Size = new System.Drawing.Size(57, 13);
            skillNameLabel.TabIndex = 3;
            skillNameLabel.Text = "Skill Name";
            // 
            // energyCostLabel
            // 
            energyCostLabel.AutoSize = true;
            energyCostLabel.Location = new System.Drawing.Point(129, 87);
            energyCostLabel.Name = "energyCostLabel";
            energyCostLabel.Size = new System.Drawing.Size(64, 13);
            energyCostLabel.TabIndex = 9;
            energyCostLabel.Text = "Energy Cost";
            // 
            // targetTypeLabel
            // 
            targetTypeLabel.AutoSize = true;
            targetTypeLabel.Location = new System.Drawing.Point(129, 114);
            targetTypeLabel.Name = "targetTypeLabel";
            targetTypeLabel.Size = new System.Drawing.Size(65, 13);
            targetTypeLabel.TabIndex = 11;
            targetTypeLabel.Text = "Target Type";
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataSourceTextBox.Enabled = false;
            this.dataSourceTextBox.Location = new System.Drawing.Point(0, 24);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.ReadOnly = true;
            this.dataSourceTextBox.Size = new System.Drawing.Size(371, 20);
            this.dataSourceTextBox.TabIndex = 0;
            // 
            // openDataSourceDialog
            // 
            this.openDataSourceDialog.DefaultExt = "txt";
            this.openDataSourceDialog.Filter = "Text files (.txt)|*.txt";
            // 
            // mainFormTabControl
            // 
            this.mainFormTabControl.Controls.Add(this.skillsTabPage);
            this.mainFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTabControl.Location = new System.Drawing.Point(0, 44);
            this.mainFormTabControl.Name = "mainFormTabControl";
            this.mainFormTabControl.SelectedIndex = 0;
            this.mainFormTabControl.Size = new System.Drawing.Size(371, 402);
            this.mainFormTabControl.TabIndex = 4;
            // 
            // skillsTabPage
            // 
            this.skillsTabPage.Controls.Add(targetTypeLabel);
            this.skillsTabPage.Controls.Add(this.targetTypeComboBox);
            this.skillsTabPage.Controls.Add(energyCostLabel);
            this.skillsTabPage.Controls.Add(this.energyCostNumericUpDown);
            this.skillsTabPage.Controls.Add(actionCostLabel);
            this.skillsTabPage.Controls.Add(this.x);
            this.skillsTabPage.Controls.Add(classRestrictionLabel);
            this.skillsTabPage.Controls.Add(this.skillClassRestrictionComboBox);
            this.skillsTabPage.Controls.Add(skillNameLabel);
            this.skillsTabPage.Controls.Add(this.skillNameTextBox);
            this.skillsTabPage.Controls.Add(this.newActionButton);
            this.skillsTabPage.Controls.Add(this.skillsListBox);
            this.skillsTabPage.Location = new System.Drawing.Point(4, 22);
            this.skillsTabPage.Name = "skillsTabPage";
            this.skillsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.skillsTabPage.Size = new System.Drawing.Size(363, 376);
            this.skillsTabPage.TabIndex = 0;
            this.skillsTabPage.Text = "Skills";
            this.skillsTabPage.UseVisualStyleBackColor = true;
            // 
            // targetTypeComboBox
            // 
            this.targetTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetTypeComboBox.Enabled = false;
            this.targetTypeComboBox.FormattingEnabled = true;
            this.targetTypeComboBox.Items.AddRange(new object[] {
            "None",
            "Entity",
            "Tile"});
            this.targetTypeComboBox.Location = new System.Drawing.Point(200, 111);
            this.targetTypeComboBox.Name = "targetTypeComboBox";
            this.targetTypeComboBox.Size = new System.Drawing.Size(157, 21);
            this.targetTypeComboBox.TabIndex = 10;
            // 
            // energyCostNumericUpDown
            // 
            this.energyCostNumericUpDown.Enabled = false;
            this.energyCostNumericUpDown.Location = new System.Drawing.Point(199, 85);
            this.energyCostNumericUpDown.Name = "energyCostNumericUpDown";
            this.energyCostNumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.energyCostNumericUpDown.TabIndex = 8;
            // 
            // x
            // 
            this.x.Enabled = false;
            this.x.Location = new System.Drawing.Point(196, 59);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(161, 20);
            this.x.TabIndex = 6;
            // 
            // skillClassRestrictionComboBox
            // 
            this.skillClassRestrictionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillClassRestrictionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillClassRestrictionComboBox.Enabled = false;
            this.skillClassRestrictionComboBox.FormattingEnabled = true;
            this.skillClassRestrictionComboBox.Items.AddRange(new object[] {
            "None",
            "Warrior",
            "Rogue",
            "Mage",
            "Cleric"});
            this.skillClassRestrictionComboBox.Location = new System.Drawing.Point(220, 32);
            this.skillClassRestrictionComboBox.Name = "skillClassRestrictionComboBox";
            this.skillClassRestrictionComboBox.Size = new System.Drawing.Size(137, 21);
            this.skillClassRestrictionComboBox.TabIndex = 4;
            // 
            // skillNameTextBox
            // 
            this.skillNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillNameTextBox.Enabled = false;
            this.skillNameTextBox.Location = new System.Drawing.Point(192, 6);
            this.skillNameTextBox.Name = "skillNameTextBox";
            this.skillNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.skillNameTextBox.TabIndex = 2;
            // 
            // newActionButton
            // 
            this.newActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newActionButton.Location = new System.Drawing.Point(3, 345);
            this.newActionButton.Name = "newActionButton";
            this.newActionButton.Size = new System.Drawing.Size(120, 23);
            this.newActionButton.TabIndex = 1;
            this.newActionButton.Text = "New";
            this.newActionButton.UseVisualStyleBackColor = true;
            // 
            // skillsListBox
            // 
            this.skillsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skillsListBox.FormattingEnabled = true;
            this.skillsListBox.Location = new System.Drawing.Point(3, 3);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.Size = new System.Drawing.Size(120, 329);
            this.skillsListBox.TabIndex = 0;
            // 
            // saveDataSourceDialog
            // 
            this.saveDataSourceDialog.CheckPathExists = false;
            this.saveDataSourceDialog.CreatePrompt = true;
            this.saveDataSourceDialog.DefaultExt = "txt";
            this.saveDataSourceDialog.Filter = "Text files (.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 446);
            this.Controls.Add(this.mainFormTabControl);
            this.Controls.Add(this.dataSourceTextBox);
            this.Controls.Add(formMenuStrip);
            this.MainMenuStrip = formMenuStrip;
            this.Name = "MainForm";
            this.Text = "Worldsmith Game Design";
            formMenuStrip.ResumeLayout(false);
            formMenuStrip.PerformLayout();
            this.mainFormTabControl.ResumeLayout(false);
            this.skillsTabPage.ResumeLayout(false);
            this.skillsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energyCostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.OpenFileDialog openDataSourceDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TabControl mainFormTabControl;
        private System.Windows.Forms.TabPage skillsTabPage;
        private System.Windows.Forms.ListBox skillsListBox;
        private System.Windows.Forms.Button newActionButton;
        private System.Windows.Forms.SaveFileDialog saveDataSourceDialog;
        private System.Windows.Forms.NumericUpDown x;
        private System.Windows.Forms.ComboBox skillClassRestrictionComboBox;
        private System.Windows.Forms.TextBox skillNameTextBox;
        private System.Windows.Forms.NumericUpDown energyCostNumericUpDown;
        private System.Windows.Forms.ComboBox targetTypeComboBox;


    }
}

