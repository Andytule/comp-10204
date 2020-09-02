namespace Lab_4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTab = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTab = new System.Windows.Forms.ToolStripMenuItem();
            this.processTab = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTag = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.htmlText = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTab,
            this.processTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTab
            // 
            this.fileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTab,
            this.exitTab});
            this.fileTab.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTab.Name = "fileTab";
            this.fileTab.Size = new System.Drawing.Size(40, 20);
            this.fileTab.Text = "File";
            // 
            // loadTab
            // 
            this.loadTab.Name = "loadTab";
            this.loadTab.ShortcutKeyDisplayString = "Ctrl + L";
            this.loadTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadTab.Size = new System.Drawing.Size(188, 22);
            this.loadTab.Text = "Load File ...";
            this.loadTab.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitTab
            // 
            this.exitTab.Name = "exitTab";
            this.exitTab.ShortcutKeyDisplayString = "Ctrl + Q ";
            this.exitTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitTab.Size = new System.Drawing.Size(188, 22);
            this.exitTab.Text = "Exit ";
            this.exitTab.Click += new System.EventHandler(this.exitTab_Click);
            // 
            // processTab
            // 
            this.processTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTag});
            this.processTab.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTab.Name = "processTab";
            this.processTab.ShortcutKeyDisplayString = "";
            this.processTab.Size = new System.Drawing.Size(64, 20);
            this.processTab.Text = "Process";
            // 
            // checkTag
            // 
            this.checkTag.Enabled = false;
            this.checkTag.Name = "checkTag";
            this.checkTag.ShortcutKeyDisplayString = "Ctrl + C";
            this.checkTag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.checkTag.Size = new System.Drawing.Size(190, 22);
            this.checkTag.Text = "Check Tags";
            this.checkTag.Click += new System.EventHandler(this.checkTagsToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(360, 25);
            this.label.TabIndex = 1;
            this.label.Text = "No File Loaded";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // htmlText
            // 
            this.htmlText.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlText.FormattingEnabled = true;
            this.htmlText.ItemHeight = 17;
            this.htmlText.Location = new System.Drawing.Point(12, 81);
            this.htmlText.Name = "htmlText";
            this.htmlText.Size = new System.Drawing.Size(360, 344);
            this.htmlText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.htmlText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTab;
        private System.Windows.Forms.ToolStripMenuItem loadTab;
        private System.Windows.Forms.ToolStripMenuItem exitTab;
        private System.Windows.Forms.ToolStripMenuItem processTab;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox htmlText;
        private System.Windows.Forms.ToolStripMenuItem checkTag;
    }
}

