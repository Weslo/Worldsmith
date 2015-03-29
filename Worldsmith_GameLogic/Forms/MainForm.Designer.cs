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
            System.Windows.Forms.Label skillClassRestrictionLabel;
            System.Windows.Forms.Label skillActionCostLabel;
            System.Windows.Forms.Label skillNameLabel;
            System.Windows.Forms.Label skillEnergyCostLabel;
            System.Windows.Forms.Label skillTargetTypeLabel;
            System.Windows.Forms.Label skillTargetOptionsLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label skillRangeLabel;
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
            this.skillRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skillRequiresLineOfSightCheckBox = new System.Windows.Forms.CheckBox();
            this.skillTargetOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.skillTargetTypeComboBox = new System.Windows.Forms.ComboBox();
            this.skillEnergyCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skillActionCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skillClassRestrictionComboBox = new System.Windows.Forms.ComboBox();
            this.skillNameTextBox = new System.Windows.Forms.TextBox();
            this.newActionButton = new System.Windows.Forms.Button();
            this.skillsListBox = new System.Windows.Forms.ListBox();
            this.saveDataSourceDialog = new System.Windows.Forms.SaveFileDialog();
            formMenuStrip = new System.Windows.Forms.MenuStrip();
            skillClassRestrictionLabel = new System.Windows.Forms.Label();
            skillActionCostLabel = new System.Windows.Forms.Label();
            skillNameLabel = new System.Windows.Forms.Label();
            skillEnergyCostLabel = new System.Windows.Forms.Label();
            skillTargetTypeLabel = new System.Windows.Forms.Label();
            skillTargetOptionsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            skillRangeLabel = new System.Windows.Forms.Label();
            formMenuStrip.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.skillsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillEnergyCostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillActionCostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // formMenuStrip
            // 
            formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            formMenuStrip.Location = new System.Drawing.Point(0, 0);
            formMenuStrip.Name = "formMenuStrip";
            formMenuStrip.Size = new System.Drawing.Size(376, 24);
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
            // skillClassRestrictionLabel
            // 
            skillClassRestrictionLabel.AutoSize = true;
            skillClassRestrictionLabel.Location = new System.Drawing.Point(129, 35);
            skillClassRestrictionLabel.Name = "skillClassRestrictionLabel";
            skillClassRestrictionLabel.Size = new System.Drawing.Size(85, 13);
            skillClassRestrictionLabel.TabIndex = 5;
            skillClassRestrictionLabel.Text = "Class Restriction";
            // 
            // skillActionCostLabel
            // 
            skillActionCostLabel.AutoSize = true;
            skillActionCostLabel.Location = new System.Drawing.Point(129, 61);
            skillActionCostLabel.Name = "skillActionCostLabel";
            skillActionCostLabel.Size = new System.Drawing.Size(61, 13);
            skillActionCostLabel.TabIndex = 7;
            skillActionCostLabel.Text = "Action Cost";
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
            // skillEnergyCostLabel
            // 
            skillEnergyCostLabel.AutoSize = true;
            skillEnergyCostLabel.Location = new System.Drawing.Point(129, 87);
            skillEnergyCostLabel.Name = "skillEnergyCostLabel";
            skillEnergyCostLabel.Size = new System.Drawing.Size(64, 13);
            skillEnergyCostLabel.TabIndex = 9;
            skillEnergyCostLabel.Text = "Energy Cost";
            // 
            // skillTargetTypeLabel
            // 
            skillTargetTypeLabel.AutoSize = true;
            skillTargetTypeLabel.Location = new System.Drawing.Point(129, 114);
            skillTargetTypeLabel.Name = "skillTargetTypeLabel";
            skillTargetTypeLabel.Size = new System.Drawing.Size(65, 13);
            skillTargetTypeLabel.TabIndex = 11;
            skillTargetTypeLabel.Text = "Target Type";
            // 
            // skillTargetOptionsLabel
            // 
            skillTargetOptionsLabel.AutoSize = true;
            skillTargetOptionsLabel.Location = new System.Drawing.Point(129, 141);
            skillTargetOptionsLabel.Name = "skillTargetOptionsLabel";
            skillTargetOptionsLabel.Size = new System.Drawing.Size(77, 13);
            skillTargetOptionsLabel.TabIndex = 13;
            skillTargetOptionsLabel.Text = "Target Options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(129, 171);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 13);
            label1.TabIndex = 14;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataSourceTextBox.Enabled = false;
            this.dataSourceTextBox.Location = new System.Drawing.Point(0, 24);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.ReadOnly = true;
            this.dataSourceTextBox.Size = new System.Drawing.Size(376, 20);
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
            this.mainFormTabControl.Size = new System.Drawing.Size(376, 314);
            this.mainFormTabControl.TabIndex = 4;
            // 
            // skillsTabPage
            // 
            this.skillsTabPage.Controls.Add(skillRangeLabel);
            this.skillsTabPage.Controls.Add(this.skillRangeNumericUpDown);
            this.skillsTabPage.Controls.Add(this.skillRequiresLineOfSightCheckBox);
            this.skillsTabPage.Controls.Add(label1);
            this.skillsTabPage.Controls.Add(skillTargetOptionsLabel);
            this.skillsTabPage.Controls.Add(this.skillTargetOptionsComboBox);
            this.skillsTabPage.Controls.Add(skillTargetTypeLabel);
            this.skillsTabPage.Controls.Add(this.skillTargetTypeComboBox);
            this.skillsTabPage.Controls.Add(skillEnergyCostLabel);
            this.skillsTabPage.Controls.Add(this.skillEnergyCostNumericUpDown);
            this.skillsTabPage.Controls.Add(skillActionCostLabel);
            this.skillsTabPage.Controls.Add(this.skillActionCostNumericUpDown);
            this.skillsTabPage.Controls.Add(skillClassRestrictionLabel);
            this.skillsTabPage.Controls.Add(this.skillClassRestrictionComboBox);
            this.skillsTabPage.Controls.Add(skillNameLabel);
            this.skillsTabPage.Controls.Add(this.skillNameTextBox);
            this.skillsTabPage.Controls.Add(this.newActionButton);
            this.skillsTabPage.Controls.Add(this.skillsListBox);
            this.skillsTabPage.Location = new System.Drawing.Point(4, 22);
            this.skillsTabPage.Name = "skillsTabPage";
            this.skillsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.skillsTabPage.Size = new System.Drawing.Size(368, 288);
            this.skillsTabPage.TabIndex = 0;
            this.skillsTabPage.Text = "Skills";
            this.skillsTabPage.UseVisualStyleBackColor = true;
            // 
            // skillRangeNumericUpDown
            // 
            this.skillRangeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillRangeNumericUpDown.Enabled = false;
            this.skillRangeNumericUpDown.Location = new System.Drawing.Point(174, 165);
            this.skillRangeNumericUpDown.Name = "skillRangeNumericUpDown";
            this.skillRangeNumericUpDown.Size = new System.Drawing.Size(188, 20);
            this.skillRangeNumericUpDown.TabIndex = 16;
            // 
            // skillRequiresLineOfSightCheckBox
            // 
            this.skillRequiresLineOfSightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillRequiresLineOfSightCheckBox.AutoSize = true;
            this.skillRequiresLineOfSightCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skillRequiresLineOfSightCheckBox.Enabled = false;
            this.skillRequiresLineOfSightCheckBox.Location = new System.Drawing.Point(232, 191);
            this.skillRequiresLineOfSightCheckBox.Name = "skillRequiresLineOfSightCheckBox";
            this.skillRequiresLineOfSightCheckBox.Size = new System.Drawing.Size(130, 17);
            this.skillRequiresLineOfSightCheckBox.TabIndex = 15;
            this.skillRequiresLineOfSightCheckBox.Text = "Requires Line of Sight";
            this.skillRequiresLineOfSightCheckBox.UseVisualStyleBackColor = true;
            // 
            // skillTargetOptionsComboBox
            // 
            this.skillTargetOptionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillTargetOptionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillTargetOptionsComboBox.Enabled = false;
            this.skillTargetOptionsComboBox.FormattingEnabled = true;
            this.skillTargetOptionsComboBox.Items.AddRange(new object[] {
            "None"});
            this.skillTargetOptionsComboBox.Location = new System.Drawing.Point(212, 138);
            this.skillTargetOptionsComboBox.Name = "skillTargetOptionsComboBox";
            this.skillTargetOptionsComboBox.Size = new System.Drawing.Size(150, 21);
            this.skillTargetOptionsComboBox.TabIndex = 12;
            // 
            // skillTargetTypeComboBox
            // 
            this.skillTargetTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillTargetTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillTargetTypeComboBox.Enabled = false;
            this.skillTargetTypeComboBox.FormattingEnabled = true;
            this.skillTargetTypeComboBox.Items.AddRange(new object[] {
            "None",
            "Entity",
            "Tile"});
            this.skillTargetTypeComboBox.Location = new System.Drawing.Point(200, 111);
            this.skillTargetTypeComboBox.Name = "skillTargetTypeComboBox";
            this.skillTargetTypeComboBox.Size = new System.Drawing.Size(162, 21);
            this.skillTargetTypeComboBox.TabIndex = 10;
            // 
            // skillEnergyCostNumericUpDown
            // 
            this.skillEnergyCostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillEnergyCostNumericUpDown.Enabled = false;
            this.skillEnergyCostNumericUpDown.Location = new System.Drawing.Point(199, 85);
            this.skillEnergyCostNumericUpDown.Name = "skillEnergyCostNumericUpDown";
            this.skillEnergyCostNumericUpDown.Size = new System.Drawing.Size(163, 20);
            this.skillEnergyCostNumericUpDown.TabIndex = 8;
            // 
            // skillActionCostNumericUpDown
            // 
            this.skillActionCostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillActionCostNumericUpDown.Enabled = false;
            this.skillActionCostNumericUpDown.Location = new System.Drawing.Point(196, 59);
            this.skillActionCostNumericUpDown.Name = "skillActionCostNumericUpDown";
            this.skillActionCostNumericUpDown.Size = new System.Drawing.Size(166, 20);
            this.skillActionCostNumericUpDown.TabIndex = 6;
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
            this.skillClassRestrictionComboBox.Size = new System.Drawing.Size(142, 21);
            this.skillClassRestrictionComboBox.TabIndex = 4;
            // 
            // skillNameTextBox
            // 
            this.skillNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillNameTextBox.Enabled = false;
            this.skillNameTextBox.Location = new System.Drawing.Point(192, 6);
            this.skillNameTextBox.Name = "skillNameTextBox";
            this.skillNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.skillNameTextBox.TabIndex = 2;
            // 
            // newActionButton
            // 
            this.newActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newActionButton.Location = new System.Drawing.Point(3, 257);
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
            this.skillsListBox.Size = new System.Drawing.Size(120, 251);
            this.skillsListBox.TabIndex = 0;
            // 
            // saveDataSourceDialog
            // 
            this.saveDataSourceDialog.CheckPathExists = false;
            this.saveDataSourceDialog.CreatePrompt = true;
            this.saveDataSourceDialog.DefaultExt = "txt";
            this.saveDataSourceDialog.Filter = "Text files (.txt)|*.txt";
            // 
            // skillRangeLabel
            // 
            skillRangeLabel.AutoSize = true;
            skillRangeLabel.Location = new System.Drawing.Point(129, 167);
            skillRangeLabel.Name = "skillRangeLabel";
            skillRangeLabel.Size = new System.Drawing.Size(39, 13);
            skillRangeLabel.TabIndex = 17;
            skillRangeLabel.Text = "Range";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 358);
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
            ((System.ComponentModel.ISupportInitialize)(this.skillRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillEnergyCostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillActionCostNumericUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown skillActionCostNumericUpDown;
        private System.Windows.Forms.ComboBox skillClassRestrictionComboBox;
        private System.Windows.Forms.TextBox skillNameTextBox;
        private System.Windows.Forms.NumericUpDown skillEnergyCostNumericUpDown;
        private System.Windows.Forms.ComboBox skillTargetTypeComboBox;
        private System.Windows.Forms.ComboBox skillTargetOptionsComboBox;
        private System.Windows.Forms.NumericUpDown skillRangeNumericUpDown;
        private System.Windows.Forms.CheckBox skillRequiresLineOfSightCheckBox;


    }
}

