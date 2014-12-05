namespace Worldsmith
{
    partial class ApplicationForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapTabControl = new System.Windows.Forms.TabControl();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mapContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createLandmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectFileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.closeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mapContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.wToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(794, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newWorldToolStripMenuItem.Text = "New World...";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.newWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openWorldToolStripMenuItem.Text = "Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.openWorldToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveAllToolStripMenuItem.Text = "Save";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.mapToolStripMenuItem.Text = "World";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // wToolStripMenuItem
            // 
            this.wToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMapToolStripMenuItem,
            this.addImageToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeMapToolStripMenuItem});
            this.wToolStripMenuItem.Name = "wToolStripMenuItem";
            this.wToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.wToolStripMenuItem.Text = "Map";
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Enabled = false;
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addImageToolStripMenuItem.Text = "Add Image...";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // mapTabControl
            // 
            this.mapTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTabControl.Location = new System.Drawing.Point(0, 24);
            this.mapTabControl.Name = "mapTabControl";
            this.mapTabControl.SelectedIndex = 0;
            this.mapTabControl.Size = new System.Drawing.Size(794, 535);
            this.mapTabControl.TabIndex = 1;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openImageDialogue_FileOk);
            // 
            // projectFolderBrowserDialog
            // 
            this.projectFolderBrowserDialog.Description = "Select the root folder of the Worldsmith project.";
            // 
            // mapContextMenuStrip
            // 
            this.mapContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLandmarkToolStripMenuItem});
            this.mapContextMenuStrip.Name = "mapContextMenuStrip";
            this.mapContextMenuStrip.Size = new System.Drawing.Size(165, 26);
            this.mapContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.mapContextMenuStrip_Opening);
            // 
            // createLandmarkToolStripMenuItem
            // 
            this.createLandmarkToolStripMenuItem.Name = "createLandmarkToolStripMenuItem";
            this.createLandmarkToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createLandmarkToolStripMenuItem.Text = "Create Landmark";
            this.createLandmarkToolStripMenuItem.Click += new System.EventHandler(this.createLandmarkToolStripMenuItem_Click);
            // 
            // projectFileBrowserDialog
            // 
            this.projectFileBrowserDialog.Filter = "Worldsmith Files (.ws)|*.ws";
            // 
            // closeMapToolStripMenuItem
            // 
            this.closeMapToolStripMenuItem.Enabled = false;
            this.closeMapToolStripMenuItem.Name = "closeMapToolStripMenuItem";
            this.closeMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeMapToolStripMenuItem.Text = "Close";
            this.closeMapToolStripMenuItem.Click += new System.EventHandler(this.closeMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutMapToolStripMenuItem
            // 
            this.aboutMapToolStripMenuItem.Enabled = false;
            this.aboutMapToolStripMenuItem.Name = "aboutMapToolStripMenuItem";
            this.aboutMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMapToolStripMenuItem.Text = "About...";
            this.aboutMapToolStripMenuItem.Click += new System.EventHandler(this.aboutMapToolStripMenuItem_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 559);
            this.Controls.Add(this.mapTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "ApplicationForm";
            this.Text = "Worldsmith";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mapContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl mapTabControl;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog projectFolderBrowserDialog;
        private System.Windows.Forms.ContextMenuStrip mapContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createLandmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog projectFileBrowserDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMapToolStripMenuItem;
    }
}

