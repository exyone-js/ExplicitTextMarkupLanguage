namespace etml_Editor
{
    partial class Editor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI 组件声明
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStrip toolStrip1;
        private RichTextBox editorTextBox;
        private SplitContainer splitContainer1;
        private WebBrowser previewWebBrowser;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private ToolStripButton underlineButton;
        private ToolStripButton strikethroughButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton headerButton;
        private ToolStripButton listButton;
        private ToolStripButton linkButton;
        private ToolStripButton codeButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton previewButton;
        private ToolStripButton metadataButton;
        private ToolStripButton styleButton;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.strikethroughButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.headerButton = new System.Windows.Forms.ToolStripButton();
            this.listButton = new System.Windows.Forms.ToolStripButton();
            this.linkButton = new System.Windows.Forms.ToolStripButton();
            this.codeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.previewButton = new System.Windows.Forms.ToolStripButton();
            this.metadataButton = new System.Windows.Forms.ToolStripButton();
            this.styleButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.editorTextBox = new System.Windows.Forms.RichTextBox();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "新建";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "另存为";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.editToolStripMenuItem.Text = "编辑";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.formatToolStripMenuItem.Text = "格式";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.strikethroughButton,
            this.toolStripSeparator1,
            this.headerButton,
            this.listButton,
            this.linkButton,
            this.codeButton,
            this.toolStripSeparator2,
            this.previewButton,
            this.metadataButton,
            this.styleButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1024, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(33, 22);
            this.boldButton.Text = "粗体";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(33, 22);
            this.italicButton.Text = "斜体";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(49, 22);
            this.underlineButton.Text = "下划线";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // strikethroughButton
            // 
            this.strikethroughButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strikethroughButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikethroughButton.Image = ((System.Drawing.Image)(resources.GetObject("strikethroughButton.Image")));
            this.strikethroughButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikethroughButton.Name = "strikethroughButton";
            this.strikethroughButton.Size = new System.Drawing.Size(49, 22);
            this.strikethroughButton.Text = "删除线";
            this.strikethroughButton.Click += new System.EventHandler(this.strikethroughButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // headerButton
            // 
            this.headerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.headerButton.Image = ((System.Drawing.Image)(resources.GetObject("headerButton.Image")));
            this.headerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.headerButton.Name = "headerButton";
            this.headerButton.Size = new System.Drawing.Size(49, 22);
            this.headerButton.Text = "标题";
            this.headerButton.Click += new System.EventHandler(this.headerButton_Click);
            // 
            // listButton
            // 
            this.listButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.listButton.Image = ((System.Drawing.Image)(resources.GetObject("listButton.Image")));
            this.listButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(49, 22);
            this.listButton.Text = "列表";
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // linkButton
            // 
            this.linkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.linkButton.Image = ((System.Drawing.Image)(resources.GetObject("linkButton.Image")));
            this.linkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(49, 22);
            this.linkButton.Text = "链接";
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // codeButton
            // 
            this.codeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.codeButton.Image = ((System.Drawing.Image)(resources.GetObject("codeButton.Image")));
            this.codeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(49, 22);
            this.codeButton.Text = "代码";
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // previewButton
            // 
            this.previewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(49, 22);
            this.previewButton.Text = "预览";
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // metadataButton
            // 
            this.metadataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.metadataButton.Image = ((System.Drawing.Image)(resources.GetObject("metadataButton.Image")));
            this.metadataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.metadataButton.Name = "metadataButton";
            this.metadataButton.Size = new System.Drawing.Size(65, 22);
            this.metadataButton.Text = "元数据";
            this.metadataButton.Click += new System.EventHandler(this.metadataButton_Click);
            // 
            // styleButton
            // 
            this.styleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.styleButton.Image = ((System.Drawing.Image)(resources.GetObject("styleButton.Image")));
            this.styleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.styleButton.Name = "styleButton";
            this.styleButton.Size = new System.Drawing.Size(65, 22);
            this.styleButton.Text = "样式";
            this.styleButton.Click += new System.EventHandler(this.styleButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editorTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.previewWebBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 601);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.TabIndex = 2;
            // 
            // editorTextBox
            // 
            this.editorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorTextBox.Location = new System.Drawing.Point(0, 0);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(512, 601);
            this.editorTextBox.TabIndex = 0;
            this.editorTextBox.Text = "";
            this.editorTextBox.TextChanged += new System.EventHandler(this.editorTextBox_TextChanged);
            this.editorTextBox.SelectionChanged += new System.EventHandler(this.editorTextBox_SelectionChanged);
            // 
            // previewWebBrowser
            // 
            this.previewWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.previewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWebBrowser.Name = "previewWebBrowser";
            this.previewWebBrowser.Size = new System.Drawing.Size(508, 601);
            this.previewWebBrowser.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(99, 17);
            this.statusLabel.Text = "行: 1, 列: 1";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 672);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "ETML编辑器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
