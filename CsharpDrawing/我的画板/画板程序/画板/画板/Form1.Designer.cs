namespace 画板
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具箱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜料库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线条ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.极细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.极粗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentDrawType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mouseposition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtForeColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsY = new System.Windows.Forms.ToolStripButton();
            this.tsB = new System.Windows.Forms.ToolStripButton();
            this.tsBlue = new System.Windows.Forms.ToolStripButton();
            this.tsDp = new System.Windows.Forms.ToolStripButton();
            this.tsO = new System.Windows.Forms.ToolStripButton();
            this.tsW = new System.Windows.Forms.ToolStripButton();
            this.tsR = new System.Windows.Forms.ToolStripButton();
            this.tsM = new System.Windows.Forms.ToolStripButton();
            this.tsG = new System.Windows.Forms.ToolStripButton();
            this.tsP = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Dot = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.Square = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.FillRectangle = new System.Windows.Forms.ToolStripButton();
            this.FillCircle = new System.Windows.Forms.ToolStripButton();
            this.FillSquare = new System.Windows.Forms.ToolStripButton();
            this.Eraser = new System.Windows.Forms.ToolStripButton();
            this.mouse = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reSize = new System.Windows.Forms.PictureBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.图像ToolStripMenuItem,
            this.线条ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.CheckOnClick = true;
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具箱ToolStripMenuItem,
            this.颜料库ToolStripMenuItem,
            this.状态栏ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 工具箱ToolStripMenuItem
            // 
            this.工具箱ToolStripMenuItem.Checked = true;
            this.工具箱ToolStripMenuItem.CheckOnClick = true;
            this.工具箱ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.工具箱ToolStripMenuItem.Name = "工具箱ToolStripMenuItem";
            this.工具箱ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.工具箱ToolStripMenuItem.Text = "工具箱";
            this.工具箱ToolStripMenuItem.Click += new System.EventHandler(this.工具箱ToolStripMenuItem_Click);
            // 
            // 颜料库ToolStripMenuItem
            // 
            this.颜料库ToolStripMenuItem.Checked = true;
            this.颜料库ToolStripMenuItem.CheckOnClick = true;
            this.颜料库ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.颜料库ToolStripMenuItem.Name = "颜料库ToolStripMenuItem";
            this.颜料库ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.颜料库ToolStripMenuItem.Text = "颜料库";
            this.颜料库ToolStripMenuItem.Click += new System.EventHandler(this.颜料库ToolStripMenuItem_Click);
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.Checked = true;
            this.状态栏ToolStripMenuItem.CheckOnClick = true;
            this.状态栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.状态栏ToolStripMenuItem.Text = "状态栏";
            this.状态栏ToolStripMenuItem.Click += new System.EventHandler(this.状态栏ToolStripMenuItem_Click);
            // 
            // 图像ToolStripMenuItem
            // 
            this.图像ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除图像ToolStripMenuItem});
            this.图像ToolStripMenuItem.Name = "图像ToolStripMenuItem";
            this.图像ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.图像ToolStripMenuItem.Text = "图像";
            // 
            // 清除图像ToolStripMenuItem
            // 
            this.清除图像ToolStripMenuItem.Name = "清除图像ToolStripMenuItem";
            this.清除图像ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.清除图像ToolStripMenuItem.Text = "清除图像";
            this.清除图像ToolStripMenuItem.Click += new System.EventHandler(this.清除图像ToolStripMenuItem_Click);
            // 
            // 线条ToolStripMenuItem
            // 
            this.线条ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粗细ToolStripMenuItem,
            this.自定义ToolStripMenuItem});
            this.线条ToolStripMenuItem.Name = "线条ToolStripMenuItem";
            this.线条ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.线条ToolStripMenuItem.Text = "线条";
            // 
            // 粗细ToolStripMenuItem
            // 
            this.粗细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.极细ToolStripMenuItem,
            this.正常ToolStripMenuItem,
            this.极粗ToolStripMenuItem});
            this.粗细ToolStripMenuItem.Name = "粗细ToolStripMenuItem";
            this.粗细ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.粗细ToolStripMenuItem.Text = "粗细";
            this.粗细ToolStripMenuItem.Click += new System.EventHandler(this.粗细ToolStripMenuItem_Click);
            // 
            // 极细ToolStripMenuItem
            // 
            this.极细ToolStripMenuItem.Name = "极细ToolStripMenuItem";
            this.极细ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.极细ToolStripMenuItem.Text = "极细";
            this.极细ToolStripMenuItem.Click += new System.EventHandler(this.极细ToolStripMenuItem_Click);
            // 
            // 正常ToolStripMenuItem
            // 
            this.正常ToolStripMenuItem.Name = "正常ToolStripMenuItem";
            this.正常ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.正常ToolStripMenuItem.Text = "正常";
            this.正常ToolStripMenuItem.Click += new System.EventHandler(this.正常ToolStripMenuItem_Click);
            // 
            // 极粗ToolStripMenuItem
            // 
            this.极粗ToolStripMenuItem.Name = "极粗ToolStripMenuItem";
            this.极粗ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            // 
            // 自定义ToolStripMenuItem
            // 
            this.自定义ToolStripMenuItem.Name = "自定义ToolStripMenuItem";
            this.自定义ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.自定义ToolStripMenuItem.Text = "自定义";
            this.自定义ToolStripMenuItem.Click += new System.EventHandler(this.自定义ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑颜色ToolStripMenuItem});
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.颜色ToolStripMenuItem.Text = "颜色";
            // 
            // 编辑颜色ToolStripMenuItem
            // 
            this.编辑颜色ToolStripMenuItem.Name = "编辑颜色ToolStripMenuItem";
            this.编辑颜色ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.编辑颜色ToolStripMenuItem.Text = "编辑颜色";
            this.编辑颜色ToolStripMenuItem.Click += new System.EventHandler(this.编辑颜色ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明文档ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 说明文档ToolStripMenuItem
            // 
            this.说明文档ToolStripMenuItem.Name = "说明文档ToolStripMenuItem";
            this.说明文档ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.说明文档ToolStripMenuItem.Text = "说明文档";
            this.说明文档ToolStripMenuItem.Click += new System.EventHandler(this.说明文档ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentDrawType,
            this.toolStripStatusLabel3,
            this.mouseposition,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(953, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // currentDrawType
            // 
            this.currentDrawType.Name = "currentDrawType";
            this.currentDrawType.Size = new System.Drawing.Size(69, 20);
            this.currentDrawType.Text = "绘图工具";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel3.Text = "                        ";
            // 
            // mouseposition
            // 
            this.mouseposition.Name = "mouseposition";
            this.mouseposition.Size = new System.Drawing.Size(69, 20);
            this.mouseposition.Text = "鼠标位置";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(245, 20);
            this.toolStripStatusLabel1.Text = "                                                           ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel2.Text = "图像属性";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtForeColor,
            this.toolStripLabel1,
            this.tsY,
            this.tsB,
            this.tsBlue,
            this.tsDp,
            this.tsO,
            this.tsW,
            this.tsR,
            this.tsM,
            this.tsG,
            this.tsP,
            this.toolStripButton16});
            this.toolStrip2.Location = new System.Drawing.Point(0, 534);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(953, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtForeColor
            // 
            this.tsbtForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbtForeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtForeColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtForeColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtForeColor.Image")));
            this.tsbtForeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtForeColor.Name = "tsbtForeColor";
            this.tsbtForeColor.Size = new System.Drawing.Size(73, 24);
            this.tsbtForeColor.Text = "画具颜色";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel1.Text = "调色板";
            // 
            // tsY
            // 
            this.tsY.BackColor = System.Drawing.Color.Yellow;
            this.tsY.CheckOnClick = true;
            this.tsY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsY.Image = ((System.Drawing.Image)(resources.GetObject("tsY.Image")));
            this.tsY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsY.Name = "tsY";
            this.tsY.Size = new System.Drawing.Size(23, 24);
            this.tsY.Text = "黄色";
            this.tsY.Click += new System.EventHandler(this.tsY_Click);
            // 
            // tsB
            // 
            this.tsB.BackColor = System.Drawing.Color.Black;
            this.tsB.CheckOnClick = true;
            this.tsB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsB.Image = ((System.Drawing.Image)(resources.GetObject("tsB.Image")));
            this.tsB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsB.Name = "tsB";
            this.tsB.Size = new System.Drawing.Size(23, 24);
            this.tsB.Text = "黑色";
            this.tsB.Click += new System.EventHandler(this.tsB_Click);
            // 
            // tsBlue
            // 
            this.tsBlue.BackColor = System.Drawing.Color.Blue;
            this.tsBlue.CheckOnClick = true;
            this.tsBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsBlue.Image = ((System.Drawing.Image)(resources.GetObject("tsBlue.Image")));
            this.tsBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBlue.Name = "tsBlue";
            this.tsBlue.Size = new System.Drawing.Size(23, 24);
            this.tsBlue.Text = "蓝色";
            this.tsBlue.Click += new System.EventHandler(this.tsBlue_Click);
            // 
            // tsDp
            // 
            this.tsDp.BackColor = System.Drawing.Color.DeepPink;
            this.tsDp.CheckOnClick = true;
            this.tsDp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsDp.Image = ((System.Drawing.Image)(resources.GetObject("tsDp.Image")));
            this.tsDp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDp.Name = "tsDp";
            this.tsDp.Size = new System.Drawing.Size(23, 24);
            this.tsDp.Text = "深粉色";
            this.tsDp.Click += new System.EventHandler(this.tsDp_Click);
            // 
            // tsO
            // 
            this.tsO.BackColor = System.Drawing.Color.Orange;
            this.tsO.CheckOnClick = true;
            this.tsO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsO.Image = ((System.Drawing.Image)(resources.GetObject("tsO.Image")));
            this.tsO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsO.Name = "tsO";
            this.tsO.Size = new System.Drawing.Size(23, 24);
            this.tsO.Text = "橙色";
            this.tsO.Click += new System.EventHandler(this.tsO_Click);
            // 
            // tsW
            // 
            this.tsW.BackColor = System.Drawing.Color.Snow;
            this.tsW.CheckOnClick = true;
            this.tsW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsW.Image = ((System.Drawing.Image)(resources.GetObject("tsW.Image")));
            this.tsW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsW.Name = "tsW";
            this.tsW.Size = new System.Drawing.Size(23, 24);
            this.tsW.Text = "雪白";
            this.tsW.Click += new System.EventHandler(this.tsW_Click);
            // 
            // tsR
            // 
            this.tsR.BackColor = System.Drawing.Color.Red;
            this.tsR.CheckOnClick = true;
            this.tsR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsR.Image = ((System.Drawing.Image)(resources.GetObject("tsR.Image")));
            this.tsR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsR.Name = "tsR";
            this.tsR.Size = new System.Drawing.Size(23, 24);
            this.tsR.Text = "红色";
            this.tsR.Click += new System.EventHandler(this.tsR_Click);
            // 
            // tsM
            // 
            this.tsM.BackColor = System.Drawing.Color.Maroon;
            this.tsM.CheckOnClick = true;
            this.tsM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsM.Image = ((System.Drawing.Image)(resources.GetObject("tsM.Image")));
            this.tsM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsM.Name = "tsM";
            this.tsM.Size = new System.Drawing.Size(23, 24);
            this.tsM.Text = "栗色";
            this.tsM.Click += new System.EventHandler(this.tsM_Click);
            // 
            // tsG
            // 
            this.tsG.BackColor = System.Drawing.Color.Gold;
            this.tsG.CheckOnClick = true;
            this.tsG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsG.Image = ((System.Drawing.Image)(resources.GetObject("tsG.Image")));
            this.tsG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsG.Name = "tsG";
            this.tsG.Size = new System.Drawing.Size(23, 24);
            this.tsG.Text = "金黄";
            this.tsG.Click += new System.EventHandler(this.tsG_Click);
            // 
            // tsP
            // 
            this.tsP.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tsP.CheckOnClick = true;
            this.tsP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsP.Image = ((System.Drawing.Image)(resources.GetObject("tsP.Image")));
            this.tsP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsP.Name = "tsP";
            this.tsP.Size = new System.Drawing.Size(23, 24);
            this.tsP.Text = "淡菊黄色";
            this.tsP.Click += new System.EventHandler(this.tsP_Click);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton16.Text = "更多颜色";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 506);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(4, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(88, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "线条";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 18);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(88, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "画板";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line,
            this.Dot,
            this.Rectangle,
            this.Circle,
            this.Square,
            this.Ellipse,
            this.FillRectangle,
            this.FillCircle,
            this.FillSquare,
            this.Eraser,
            this.mouse});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(12, 21);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(65, 200);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(24, 24);
            this.Line.Text = "直线";
            this.Line.Click += new System.EventHandler(this.tool_Click);
            // 
            // Dot
            // 
            this.Dot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dot.Image = ((System.Drawing.Image)(resources.GetObject("Dot.Image")));
            this.Dot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(24, 24);
            this.Dot.Text = "钢笔";
            this.Dot.Click += new System.EventHandler(this.tool_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(24, 24);
            this.Rectangle.Text = "矩形";
            this.Rectangle.Click += new System.EventHandler(this.tool_Click);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(24, 24);
            this.Circle.Text = "圆";
            this.Circle.Click += new System.EventHandler(this.tool_Click);
            // 
            // Square
            // 
            this.Square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Square.Image = ((System.Drawing.Image)(resources.GetObject("Square.Image")));
            this.Square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(24, 24);
            this.Square.Text = "正方形";
            this.Square.ToolTipText = "Square";
            this.Square.Click += new System.EventHandler(this.tool_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(24, 24);
            this.Ellipse.Text = "椭圆";
            this.Ellipse.Click += new System.EventHandler(this.tool_Click);
            // 
            // FillRectangle
            // 
            this.FillRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillRectangle.Image = ((System.Drawing.Image)(resources.GetObject("FillRectangle.Image")));
            this.FillRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillRectangle.Name = "FillRectangle";
            this.FillRectangle.Size = new System.Drawing.Size(24, 24);
            this.FillRectangle.Text = "实心矩形";
            this.FillRectangle.Click += new System.EventHandler(this.tool_Click);
            // 
            // FillCircle
            // 
            this.FillCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillCircle.Image = ((System.Drawing.Image)(resources.GetObject("FillCircle.Image")));
            this.FillCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillCircle.Name = "FillCircle";
            this.FillCircle.Size = new System.Drawing.Size(24, 24);
            this.FillCircle.Text = "实心圆";
            this.FillCircle.Click += new System.EventHandler(this.tool_Click);
            // 
            // FillSquare
            // 
            this.FillSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillSquare.Image = ((System.Drawing.Image)(resources.GetObject("FillSquare.Image")));
            this.FillSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillSquare.Name = "FillSquare";
            this.FillSquare.Size = new System.Drawing.Size(24, 24);
            this.FillSquare.Text = "实心正方形";
            this.FillSquare.Click += new System.EventHandler(this.tool_Click);
            // 
            // Eraser
            // 
            this.Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(24, 24);
            this.Eraser.Text = "橡皮";
            this.Eraser.Click += new System.EventHandler(this.tool_Click);
            // 
            // mouse
            // 
            this.mouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mouse.Image = ((System.Drawing.Image)(resources.GetObject("mouse.Image")));
            this.mouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(24, 24);
            this.mouse.Text = "指针";
            this.mouse.Click += new System.EventHandler(this.tool_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.reSize);
            this.panel2.Controls.Add(this.pbImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(101, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 506);
            this.panel2.TabIndex = 10;
            // 
            // reSize
            // 
            this.reSize.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.reSize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.reSize.Location = new System.Drawing.Point(764, 426);
            this.reSize.Margin = new System.Windows.Forms.Padding(4);
            this.reSize.Name = "reSize";
            this.reSize.Size = new System.Drawing.Size(32, 30);
            this.reSize.TabIndex = 1;
            this.reSize.TabStop = false;
            this.reSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reSize_MouseDown);
            this.reSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reSize_MouseMove);
            this.reSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reSize_MouseUp);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Margin = new System.Windows.Forms.Padding(4);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(764, 429);
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImg_Paint);
            this.pbImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseDown);
            this.pbImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseMove);
            this.pbImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseUp);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "画图";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具箱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜料库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线条ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 极细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 极粗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明文档ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentDrawType;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtForeColor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel mouseposition;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsY;
        private System.Windows.Forms.ToolStripButton tsB;
        private System.Windows.Forms.ToolStripButton tsBlue;
        private System.Windows.Forms.ToolStripButton tsDp;
        private System.Windows.Forms.ToolStripButton tsO;
        private System.Windows.Forms.ToolStripButton tsW;
        private System.Windows.Forms.ToolStripButton tsR;
        private System.Windows.Forms.ToolStripButton tsM;
        private System.Windows.Forms.ToolStripButton tsG;
        private System.Windows.Forms.ToolStripButton tsP;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Dot;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripButton Square;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripButton FillRectangle;
        private System.Windows.Forms.ToolStripButton FillCircle;
        private System.Windows.Forms.ToolStripButton Eraser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.PictureBox reSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton FillSquare;
        private System.Windows.Forms.ToolStripButton mouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

