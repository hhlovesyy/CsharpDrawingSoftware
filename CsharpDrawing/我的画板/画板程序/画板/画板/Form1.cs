using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 画板
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DrawTools dt;//绘图工具
        private int lineWidth;//设置线条宽度
        private string sType;//绘图样式
        private string sFilename;//如果需要打开文件,要打开文件的文件名
        private bool bReSize = false;//判断是否改变画布大小
        private Size DefaultPicSize;//储存原始画布大小，用来新建文件时使用
        

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();//以上两句是为了设置控件样式为双缓冲，这可以有效减少图片闪烁的问题
            Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));
            g.Dispose();
            dt = new DrawTools(this.pbImg.CreateGraphics(), Color.Black, bmp,3);//实例化工具类
            DefaultPicSize = pbImg.Size;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbImg.Size = DefaultPicSize;//pictureBox大小为原始画布大小
            this.panel1.AutoScrollPosition = new Point(0, 0);//初始化自动滚动的位置
            Bitmap bmp = new Bitmap(DefaultPicSize.Width, DefaultPicSize.Height);
            Graphics g = Graphics.FromImage(bmp);//初始化画板
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, DefaultPicSize.Width, DefaultPicSize.Height);
            g.Dispose();
            g = pbImg.CreateGraphics();//绘制图像
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            reSize.Location = new Point(DefaultPicSize.Width, DefaultPicSize.Height);//将resize大小初始化
            dt.OrginalImg = bmp;
            sFilename = null;//新建时默认没有文件名
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();//发出一个打开文件的对话框
            oFile.Filter = "图像(*.bmp;*.jpg;*.ico;*.wmf;*.cur)|*.bmp;*.jpg;*.ico;*.wmf;*.cur";//文件类型筛选
            oFile.Multiselect = false;//不允许选择多个文件
            if(oFile.ShowDialog()==DialogResult.OK)
            {
                Bitmap bmpfrom = new Bitmap(oFile.FileName);
                panel2.AutoScrollPosition = new Point(0,0);
                pbImg.Size = bmpfrom.Size;//pictureBox大小初始化

                reSize.Location = new Point(bmpfrom.Width, bmpfrom.Height);//resize位置初始化,用来手动调节画板大小
                dt.DrawTools_Graphics = pbImg.CreateGraphics();
                //由于在初始化时空白画布大小有限，"打开"操作可能引起画板大小改变，所以要将画板重新传入工具类
                Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));
                //不使用上面这句话，那么这个bmp的背景就是透明的
                g.DrawImage(bmpfrom, 0, 0, bmpfrom.Width, bmpfrom.Height);
                g.Dispose();//释放画板所占资源
                bmpfrom.Dispose();
                //不直接使用pbImg.Image = Image.FormFile(ofd.FileName)是因为这样会让图片一直处于打开状态，也就无法保存修改后的图片
                g = pbImg.CreateGraphics();
                g.DrawImage(bmp, 0, 0);
                g.Dispose(); 
                dt.OrginalImg = bmp;
                bmp.Dispose();
                sFilename = oFile.FileName;//储存打开的图片文件的详细路径，用来稍后能覆盖这个文件
                oFile.Dispose();
            }
        }

  

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sFilename != null)
            {
                if (MessageBox.Show("是否保存文件", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dt.OrginalImg.Save(sFilename);
                }
            }
            else 
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "图像(*.bmp;*.jpg;*.ico;*.wmf;*.cur)|*.bmp;*.jpg;*.ico;*.wmf;*.cur";
                if(saveDialog.ShowDialog()==DialogResult.OK)
                {
                    dt.OrginalImg.Save(saveDialog.FileName);
                    sFilename = saveDialog.FileName;
                }
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "图像(*.bmp;*.jpg;*.ico;*.wmf;*.cur)|*.bmp;*.jpg;*.ico;*.wmf;*.cur";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                dt.OrginalImg.Save(sfd.FileName);
                sFilename = sfd.FileName;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定要退出软件？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dt.clearVar();
                Application.Exit();
            }
            
        }

        //窗口移动、最小化、最大化等造成的pbimg重画时间处理
        private void pbImg_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(dt.OrginalImg, 0, 0);
        
        }

        //＂绘图工具选用＂事件处理方法
        private void tool_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            if (tsb != null)
            {
                sType = tsb.Name;
                currentDrawType.Text = tsb.Text;
                switch (sType)
                {
                    case "Dot":
                        pbImg.Cursor =Cursors.Hand;
                        break;
                    case "mouse":
                        pbImg.Cursor = Cursors.Default;
                        break;
                    case "Eraser":
                        pbImg.Cursor = new Cursor(Application.StartupPath + @"\pb.cur");
                        break;
                    default:
                        pbImg.Cursor = Cursors.Cross;
                        break;

                }
            }
        }

        
        private void pbImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dt != null)
                {
                    dt.startDraw = true;//相当于所选工具被激活，可以开始绘图
                    dt.startPoint = new PointF(e.X, e.Y);
                    
                }
            }
        }

       
        private void pbImg_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(6);//减少cpu占用率
            mouseposition.Text = "鼠标位置" + e.Location.ToString();
            toolStripStatusLabel2.Text = "图像大小: " + pbImg.Height + "px"+"*" + pbImg.Width + "px";
            if (dt.startDraw)
            {
                switch (sType)
                {
                    case "Dot": dt.DrawDot(e); break;
                    case "Eraser": dt.Eraser(e); break;
                    default: dt.Draw(e, sType); break;

                }
            }
        }

        
        private void pbImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (dt != null)
            {
                dt.EndDraw();
            }
        }

        private void reSize_MouseDown(object sender, MouseEventArgs e)
        {
            bReSize = true;//当鼠标按下时，说明要开始调节大小
        }

        private void reSize_MouseMove(object sender, MouseEventArgs e)
        {
            if (bReSize)
            {
                reSize.Location = new Point(reSize.Location.X + e.X, reSize.Location.Y + e.Y);

            }
        }

        private void reSize_MouseUp(object sender, MouseEventArgs e)
        {
            bReSize = false;//大小改变结束
            //重新定义画板位置
            pbImg.Size = new Size(reSize.Location.X - (this.panel1.AutoScrollPosition.X), reSize.Location.Y - (this.panel1.AutoScrollPosition.Y));
            dt.DrawTools_Graphics = pbImg.CreateGraphics();//因为画板的大小被改变所以必须重新赋值
            //另外画布也被改变所以也要重新赋值
            Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pbImg.Width, pbImg.Height);
            g.DrawImage(dt.OrginalImg, 0, 0);
            g.Dispose();
            g = pbImg.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            dt.OrginalImg = bmp;

            bmp.Dispose();
        }

        private void 清除图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newpic = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(newpic);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pbImg.Width, pbImg.Height);
            g.Dispose();
            g = pbImg.CreateGraphics();
            g.DrawImage(newpic, 0, 0);
            g.Dispose();
            dt.OrginalImg = newpic;
        }

        

        #region
        //颜色板
        private void tsY_Click(object sender, EventArgs e)
        {
            if (tsY.Checked)//如果处于按下状态,则改变颜色
            {
                tsY.Checked = true;
            }
            else //否则不会改变颜色
            {
                tsY.Checked = false;
            }
            //对于其他的颜色,如果未被选择则并不需要,例如在选择黄色时是不需要其他颜色的
            tsDp.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsO.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsY.BackColor;//选择颜色后,提示画具颜色的框会变成选择的颜色
            dt.Drawcolor = tsY.BackColor;//调整画图工具的颜色
        }

        private void tsB_Click(object sender, EventArgs e)
        {
            if (tsB.Checked)
            {
                tsB.Checked = true;
            }
            else
            {
                tsB.Checked = false;
            }
            tsDp.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsO.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsY.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsB.BackColor;
            dt.Drawcolor = tsB.BackColor;
        }

        private void tsBlue_Click(object sender, EventArgs e)
        {
            if (tsBlue.Checked)
            {
                tsBlue.Checked = true;
            }
            else
            {
                tsBlue.Checked = false;
            }
            tsDp.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsO.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsB.Checked = false;
            tsY.Checked = false;
            tsbtForeColor.BackColor = tsBlue.BackColor;
            dt.Drawcolor = tsBlue.BackColor;
        }

        private void tsDp_Click(object sender, EventArgs e)
        {
            if (tsDp.Checked)
            {
                tsDp.Checked = true;
            }
            else
            {
                tsDp.Checked = false;
            }
            tsY.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsO.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsDp.BackColor;
            dt.Drawcolor = tsDp.BackColor;
        }

        private void tsO_Click(object sender, EventArgs e)
        {
            if (tsO.Checked)
            {
                tsO.Checked = true;
            }
            else
            {
                tsO.Checked = false;
            }
            tsY.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsDp.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsO.BackColor;
            dt.Drawcolor = tsO.BackColor;
        }

        private void tsW_Click(object sender, EventArgs e)
        {
            if (tsW.Checked)
            {
                tsW.Checked = true;
            }
            else
            {
                tsW.Checked = false;
            }
            tsY.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsDp.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsO.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsW.BackColor;
            dt.Drawcolor = tsW.BackColor;
        }

        private void tsR_Click(object sender, EventArgs e)
        {
            if (tsR.Checked)
            {
                tsR.Checked = true;
            }
            else
            {
                tsR.Checked = false;
            }
            tsY.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsDp.Checked = false;
            tsP.Checked = false;
            tsW.Checked = false;
            tsO.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsR.BackColor;
            dt.Drawcolor = tsR.BackColor;
        }

        private void tsM_Click(object sender, EventArgs e)
        {
            if (tsM.Checked)
            {
                tsM.Checked = true;
            }
            else
            {
                tsM.Checked = false;
            }
            tsY.Checked = false;
            tsG.Checked = false;
            tsR.Checked = false;
            tsDp.Checked = false;
            tsP.Checked = false;
            tsW.Checked = false;
            tsO.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsM.BackColor;
            dt.Drawcolor = tsM.BackColor;
        }

        private void tsG_Click(object sender, EventArgs e)
        {
            if (tsG.Checked)
            {
                tsG.Checked = true;
            }
            else
            {
                tsG.Checked = false;
            }
            tsY.Checked = false;
            tsR.Checked = false;
            tsM.Checked = false;
            tsDp.Checked = false;
            tsP.Checked = false;
            tsW.Checked = false;
            tsO.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsG.BackColor;
            dt.Drawcolor = tsG.BackColor;
        }

        private void tsP_Click(object sender, EventArgs e)
        {
            if (tsP.Checked)
            {
                tsP.Checked = true;
            }
            else
            {
                tsP.Checked = false;
            }
            tsY.Checked = false;
            tsG.Checked = false;
            tsM.Checked = false;
            tsDp.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsO.Checked = false;
            tsB.Checked = false;
            tsBlue.Checked = false;
            tsbtForeColor.BackColor = tsP.BackColor;
            dt.Drawcolor = tsP.BackColor;
        }
        #endregion

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            ColorDialog cDia = new ColorDialog();//颜色调控对话框
            if (cDia.ShowDialog(this) == DialogResult.OK)
            {
                tsbtForeColor.BackColor = cDia.Color;
                dt.Drawcolor = cDia.Color;
            }
            Refresh();
        }

        private void 极细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineWidth = 1;
            dt.LineWidth = lineWidth;
        }

        private void 正常ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineWidth = 5;
            dt.LineWidth = lineWidth;
        }

     

        private void 自定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineDesign lDesign = new LineDesign();
            lDesign.StartPosition = FormStartPosition.CenterParent;
            if (lDesign.ShowDialog() == DialogResult.OK)
            {
                if (lDesign.textBox1.Text != "") 
                {
                    lineWidth = Convert.ToInt32(lDesign.textBox1.Text);
                    dt.LineWidth = lineWidth;
                }
            }
        }

        private void 编辑颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDia = new ColorDialog();
            if (cDia.ShowDialog(this) == DialogResult.OK)
            {
                tsbtForeColor.BackColor = cDia.Color;
                dt.Drawcolor = cDia.Color;
            }
            Refresh();
        }

 

        private void 说明文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + "\\画图.doc");
        }

        private void 工具箱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.工具箱ToolStripMenuItem.Checked)
            {
                this.工具箱ToolStripMenuItem.Checked = true;
                this.panel1.Visible = true;
            }
            else
            {
                this.工具箱ToolStripMenuItem.Checked =false;
                this.panel1.Visible = false;
 
            }
        }

        private void 颜料库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.颜料库ToolStripMenuItem.Checked)
            {
                this.颜料库ToolStripMenuItem.Checked = true;
                this.toolStrip2.Visible = true;
            }
            else 
            {
                this.颜料库ToolStripMenuItem.Checked = false;
                this.toolStrip2.Visible = false;
            }

        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.状态栏ToolStripMenuItem.Checked)
            {
                this.状态栏ToolStripMenuItem.Checked = true;
                this.statusStrip1.Visible = true;
            }
            else 
            {
                this.状态栏ToolStripMenuItem.Checked = false;
                this.statusStrip1.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lineWidth = 1;
            dt.LineWidth = lineWidth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lineWidth = 3;
            dt.LineWidth = lineWidth;
        }

        private void 粗细ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
