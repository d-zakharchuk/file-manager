namespace FileManager1
{

    partial class FileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LevelUpButton1 = new System.Windows.Forms.ToolStripButton();
            this.NewFolderButton1 = new System.Windows.Forms.ToolStripButton();
            this.NewFileButton1 = new System.Windows.Forms.ToolStripButton();
            this.address1 = new System.Windows.Forms.ToolStripTextBox();
            this.RefreshButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.LevelUpButton2 = new System.Windows.Forms.ToolStripButton();
            this.NewFolderButton2 = new System.Windows.Forms.ToolStripButton();
            this.NewFileButton2 = new System.Windows.Forms.ToolStripButton();
            this.address2 = new System.Windows.Forms.ToolStripTextBox();
            this.RefreshButton2 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Menu1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.ukrainianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.CheckedChanged += new System.EventHandler(this.englishToolStripMenuItem_CheckedChanged);
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // ukrainianToolStripMenuItem
            // 
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ukrainianToolStripMenuItem.Text = "Ukrainian - Українська";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.ukrainianToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.BackColor = System.Drawing.Color.Silver;
            this.splitContainer3.Location = new System.Drawing.Point(12, 27);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer3.Panel1MinSize = 160;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer3.Panel2MinSize = 160;
            this.splitContainer3.Size = new System.Drawing.Size(835, 182);
            this.splitContainer3.SplitterDistance = 406;
            this.splitContainer3.TabIndex = 10;
            this.splitContainer3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer3_SplitterMoved);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Location = new System.Drawing.Point(2, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(405, 147);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.ItemHeight = 24;
            this.treeView1.Location = new System.Drawing.Point(0, 1);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(175, 146);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "288.ico");
            this.imageList2.Images.SetKeyName(1, "folder.png");
            this.imageList2.Images.SetKeyName(2, "245.ico");
            this.imageList2.Images.SetKeyName(3, "707.ico");
            this.imageList2.Images.SetKeyName(4, "357.ico");
            this.imageList2.Images.SetKeyName(5, "337.ico");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.Menu1;
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 146);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Menu1
            // 
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyTXTToolStripMenuItem,
            this.copyHTMLToolStripMenuItem});
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(214, 158);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyTXTToolStripMenuItem
            // 
            this.copyTXTToolStripMenuItem.Name = "copyTXTToolStripMenuItem";
            this.copyTXTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.copyTXTToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.copyTXTToolStripMenuItem.Text = "Copy TXT";
            this.copyTXTToolStripMenuItem.Click += new System.EventHandler(this.copyTXTToolStripMenuItem_Click);
            // 
            // copyHTMLToolStripMenuItem
            // 
            this.copyHTMLToolStripMenuItem.Name = "copyHTMLToolStripMenuItem";
            this.copyHTMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.copyHTMLToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.copyHTMLToolStripMenuItem.Text = "Copy HTML";
            this.copyHTMLToolStripMenuItem.Click += new System.EventHandler(this.copyHTMLToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LevelUpButton1,
            this.NewFolderButton1,
            this.NewFileButton1,
            this.address1,
            this.RefreshButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LevelUpButton1
            // 
            this.LevelUpButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LevelUpButton1.Image = ((System.Drawing.Image)(resources.GetObject("LevelUpButton1.Image")));
            this.LevelUpButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LevelUpButton1.Name = "LevelUpButton1";
            this.LevelUpButton1.Size = new System.Drawing.Size(23, 22);
            this.LevelUpButton1.Text = "Level up";
            this.LevelUpButton1.Click += new System.EventHandler(this.LevelUpButton1_Click);
            // 
            // NewFolderButton1
            // 
            this.NewFolderButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFolderButton1.Image = ((System.Drawing.Image)(resources.GetObject("NewFolderButton1.Image")));
            this.NewFolderButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFolderButton1.Name = "NewFolderButton1";
            this.NewFolderButton1.Size = new System.Drawing.Size(23, 22);
            this.NewFolderButton1.Text = "New Folder";
            this.NewFolderButton1.Click += new System.EventHandler(this.NewFolderButton1_Click);
            // 
            // NewFileButton1
            // 
            this.NewFileButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFileButton1.Image = ((System.Drawing.Image)(resources.GetObject("NewFileButton1.Image")));
            this.NewFileButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFileButton1.Name = "NewFileButton1";
            this.NewFileButton1.Size = new System.Drawing.Size(23, 22);
            this.NewFileButton1.Text = "New File";
            this.NewFileButton1.Click += new System.EventHandler(this.NewFileButton1_Click);
            // 
            // address1
            // 
            this.address1.AutoSize = false;
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(300, 25);
            this.address1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address1_KeyDown);
            // 
            // RefreshButton1
            // 
            this.RefreshButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton1.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton1.Image")));
            this.RefreshButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton1.Name = "RefreshButton1";
            this.RefreshButton1.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton1.Text = "Refresh";
            this.RefreshButton1.Click += new System.EventHandler(this.RefreshButton1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Location = new System.Drawing.Point(3, 35);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.listView2);
            this.splitContainer2.Size = new System.Drawing.Size(405, 147);
            this.splitContainer2.SplitterDistance = 174;
            this.splitContainer2.TabIndex = 10;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList2;
            this.treeView2.Indent = 19;
            this.treeView2.ItemHeight = 24;
            this.treeView2.Location = new System.Drawing.Point(0, 1);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(175, 146);
            this.treeView2.TabIndex = 4;
            this.treeView2.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView2_BeforeExpand);
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            this.treeView2.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseClick);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.ContextMenuStrip = this.Menu1;
            this.listView2.Location = new System.Drawing.Point(0, 1);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(224, 146);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView2_KeyDown);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LevelUpButton2,
            this.NewFolderButton2,
            this.NewFileButton2,
            this.address2,
            this.RefreshButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 1);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(405, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // LevelUpButton2
            // 
            this.LevelUpButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LevelUpButton2.Image = ((System.Drawing.Image)(resources.GetObject("LevelUpButton2.Image")));
            this.LevelUpButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LevelUpButton2.Name = "LevelUpButton2";
            this.LevelUpButton2.Size = new System.Drawing.Size(23, 22);
            this.LevelUpButton2.Text = "Level up";
            this.LevelUpButton2.Click += new System.EventHandler(this.LevelUpButton2_Click);
            // 
            // NewFolderButton2
            // 
            this.NewFolderButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFolderButton2.Image = ((System.Drawing.Image)(resources.GetObject("NewFolderButton2.Image")));
            this.NewFolderButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFolderButton2.Name = "NewFolderButton2";
            this.NewFolderButton2.Size = new System.Drawing.Size(23, 22);
            this.NewFolderButton2.Text = "New Folder";
            this.NewFolderButton2.Click += new System.EventHandler(this.NewFolderButton2_Click);
            // 
            // NewFileButton2
            // 
            this.NewFileButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFileButton2.Image = ((System.Drawing.Image)(resources.GetObject("NewFileButton2.Image")));
            this.NewFileButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFileButton2.Name = "NewFileButton2";
            this.NewFileButton2.Size = new System.Drawing.Size(23, 22);
            this.NewFileButton2.Text = "New File";
            this.NewFileButton2.Click += new System.EventHandler(this.NewFileButton2_Click);
            // 
            // address2
            // 
            this.address2.AutoSize = false;
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(300, 25);
            this.address2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address2_KeyDown);
            // 
            // RefreshButton2
            // 
            this.RefreshButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton2.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton2.Image")));
            this.RefreshButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton2.Name = "RefreshButton2";
            this.RefreshButton2.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton2.Text = "Refresh";
            this.RefreshButton2.Click += new System.EventHandler(this.RefreshButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "full_page.png");
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 236);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(375, 100);
            this.Name = "FileManager";
            this.Text = "File Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileManager_FormClosing);
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Menu1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LevelUpButton1;
        private System.Windows.Forms.ToolStripButton NewFolderButton1;
        private System.Windows.Forms.ToolStripButton NewFileButton1;
        private System.Windows.Forms.ToolStripTextBox address1;
        private System.Windows.Forms.ToolStripButton RefreshButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton LevelUpButton2;
        private System.Windows.Forms.ToolStripButton NewFolderButton2;
        private System.Windows.Forms.ToolStripButton NewFileButton2;
        private System.Windows.Forms.ToolStripTextBox address2;
        private System.Windows.Forms.ToolStripButton RefreshButton2;
        private System.Windows.Forms.ContextMenuStrip Menu1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyHTMLToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    }

    partial class lvp { }
}

