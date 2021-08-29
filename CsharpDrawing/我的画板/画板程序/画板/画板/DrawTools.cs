using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 画板
{
    //创建画图工具类,包括钢笔(pen),直线,圆,椭圆,矩形,橡皮等
    class DrawTools
    {
        public Graphics DrawTools_Graphics; //目标绘图板
        private Pen p;//p是画笔
        private int lineWidth = 3;//划线的宽度设置为3
        private Image orginalImg;//原始画布,用来保存已经完成的绘图过程
        private Color drawColor = Color.Black;//绘图的画笔颜色初始化为黑色
        private Color backColor = Color.White;//绘图区域的背景颜色
        private Graphics newgraphics;//中间画板
        private Image finishImg;//中间画布,用来保存绘图过程中的痕迹

        //注意,必须需要有一个Image才能创建Graphics去在上面绘图
        //绘图颜色属性
        public Color Drawcolor
        {
            get { return drawColor; }
            set
            {
                drawColor = value;
                p.Color = value;//将画笔颜色也调整为所需要的颜色
            }
        }
        //背景颜色属性
        public Color Backcolor
        {
            get { return backColor; }
            set
            {
                backColor = value;
            }
        }
        //线条粗细属性
        public int LineWidth
        {
            get { return lineWidth; }
            set
            {
                lineWidth = value;
                p.Width = value;//将画笔的粗细也设置为线条宽度
            }
        }
        //创建画布
        public Image OrginalImg
        {
            get { return orginalImg; }
            set
            {
                finishImg = (Image)value.Clone();
                orginalImg = (Image)value.Clone();//创建两个副本,作为原始画布和中间画布(比如随便画的时候就要不同画布之间进行转换)
            }
        }
        //bool变量startDraw表示是否要开始绘图
        public bool startDraw = false;
        //设置绘图起点
        public PointF startPoint;
        /// <summary>
        /// 初始化绘图工具
        /// </summary>
        /// <param name="g">绘图板</param>
        /// <param name="c">绘图颜色</param>
        /// <param name="img">初始画布</param>
        /// <param name="linewidth">线条宽度</param>
        public DrawTools(Graphics g, Color c, Image img, int linewidth)
        {
            this.DrawTools_Graphics = g;
            this.drawColor = c;
            this.p = new Pen(c, linewidth);
            this.finishImg = (Image)img.Clone();
            this.OrginalImg = (Image)img.Clone();

        }
        /// <summary>
        /// 绘制直线,矩形,圆形等形状
        /// </summary>
        /// <param name="e"></param>
        /// <param name="stype"></param>
        public void Draw(MouseEventArgs e, String stype)
        {
            if (startDraw)//如果可以开始绘图
            {
                Image img = (Image)OrginalImg.Clone();//为了防止直接对原始画布进行改写
                newgraphics = Graphics.FromImage(img);//实例化中间画板
                switch (stype)
                {
                    case "Line":
                        {
                            newgraphics.DrawLine(p, startPoint, new Point(e.X, e.Y));
                            break;
                        }
                    case "Rectangle":
                        {
                            float width = Math.Abs(e.X - startPoint.X);//确定矩形的宽
                            float height = Math.Abs(e.Y - startPoint.Y);//确定矩形的高
                            PointF rectStartPoint = startPoint;//设置最终画出矩形的起始位置
                            if (e.X < rectStartPoint.X)
                            {
                                rectStartPoint.X = e.X;//如果鼠标所处位置在画图起始位置左边,就把最终起始位置赋值为鼠标位置
                            }
                            if (e.Y < rectStartPoint.Y)
                            {
                                rectStartPoint.Y = e.Y;
                            }
                            newgraphics.DrawRectangle(p, rectStartPoint.X, rectStartPoint.Y, width, height);
                            break;
                        }
                    case "Square":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            float bian = (width < height) ? width : height;
                            PointF squareStartPoint = startPoint;
                            if (e.X < startPoint.X)
                            {
                                squareStartPoint.X = startPoint.X - bian;//注意,这样设置是为了防止出现正方形到处移动的情况
                            }
                            if (e.Y < startPoint.Y)
                            {
                                squareStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.DrawRectangle(p, squareStartPoint.X, squareStartPoint.Y, bian, bian);
                            break;
                        }
                    case "Ellipse":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            float bian = (width < height) ? width : height;//获取较小者                      
                            if (e.X < startPoint.X)
                            {
                                rectStartPoint.X = startPoint.X - width;
                            }
                            if (e.Y < startPoint.Y)
                            {
                                rectStartPoint.Y = startPoint.Y - height;
                            }
                            newgraphics.DrawEllipse(p, rectStartPoint.X, rectStartPoint.Y, width, height);
                            break;
                        }
                    case "Circle":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            float bian = (width < height) ? width : height;
                            PointF squareStartPoint = startPoint;
                            if (e.X < startPoint.X)
                            {
                                squareStartPoint.X = startPoint.X - bian;//注意,这样设置是为了防止出现圆形到处移动的情况
                            }
                            if (e.Y < startPoint.Y)
                            {
                                squareStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.DrawEllipse(p, squareStartPoint.X, squareStartPoint.Y, bian, bian);//这样的话就取相等长的bian作为圆的"宽"和"高"
                            break;
                        }
                    case "FillRectangle":
                        {
                            float width = Math.Abs(e.X - startPoint.X);//确定矩形的宽
                            float height = Math.Abs(e.Y - startPoint.Y);//确定矩形的高
                            PointF rectStartPoint = startPoint;//设置最终画出矩形的起始位置
                            if (e.X < rectStartPoint.X)
                            {
                                rectStartPoint.X = e.X;//如果鼠标所处位置在画图起始位置左边,就把最终起始位置赋值为鼠标位置
                            }
                            if (e.Y < rectStartPoint.Y)
                            {
                                rectStartPoint.Y = e.Y;
                            }
                            //填充一个矩形
                            newgraphics.FillRectangle(new SolidBrush(drawColor), rectStartPoint.X, rectStartPoint.Y, width, height);
                            break;
                        }
                    case "FillSquare":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            float bian = (width < height) ? width : height;
                            PointF squareStartPoint = startPoint;
                            if (e.X < startPoint.X)
                            {
                                squareStartPoint.X = startPoint.X - bian;//注意,这样设置是为了防止出现正方形到处移动的情况
                            }
                            if (e.Y < startPoint.Y)
                            {
                                squareStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.FillRectangle(new SolidBrush(drawColor), squareStartPoint.X, squareStartPoint.Y, bian, bian);
                            break;
                        }
                    case "FillEllipse"://填充椭圆形
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            float bian = (width < height) ? width : height;//获取较小者                      
                            if (e.X < startPoint.X)
                            {
                                rectStartPoint.X = startPoint.X - width;
                            }
                            if (e.Y < startPoint.Y)
                            {
                                rectStartPoint.Y = startPoint.Y - height;
                            }
                            newgraphics.FillEllipse(new SolidBrush(drawColor), rectStartPoint.X, rectStartPoint.Y, width, height);
                            break;
                        }
                    case "FillCircle"://填充圆形
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            float bian = (width < height) ? width : height;
                            PointF squareStartPoint = startPoint;
                            if (e.X < startPoint.X)
                            {
                                squareStartPoint.X = startPoint.X - bian;//注意,这样设置是为了防止出现圆形到处移动的情况
                            }
                            if (e.Y < startPoint.Y)
                            {
                                squareStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.FillEllipse(new SolidBrush(drawColor), squareStartPoint.X, squareStartPoint.Y, bian, bian);
                            break;
                        }

                }
                newgraphics.Dispose();//绘图完成后,释放中间画板所占用的资源
                newgraphics = Graphics.FromImage(finishImg);//另外建立一个中间画板,画布为中间画布
                newgraphics.DrawImage(img, 0, 0);//从最开始开始绘制,将图片画到中间画板上
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(img, 0, 0);//在目标绘图板上绘制图片
                img.Dispose();


            }
        }
        public void EndDraw()
        {
            startDraw = false;
            //为了将完成后的绘图过程保留下来,要将中间图片绘制到原始画布上
            newgraphics = Graphics.FromImage(orginalImg);
            newgraphics.DrawImage(finishImg, 0, 0);//将中间画布绘制的内容绘制到原始画布上
            newgraphics.Dispose();
        }
        //橡皮擦
        public void Eraser(MouseEventArgs e)
        {
            if (startDraw)
            {
                newgraphics = Graphics.FromImage(finishImg);
                newgraphics.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                newgraphics.Dispose();//应该是类似于析构函数的机制?只是清除掉了堆中开辟的内存
                DrawTools_Graphics.DrawImage(finishImg, 0, 0);//将橡皮擦处理完之后的内容绘制在目标绘图板上
            }
        }
        //铅笔工具
        public void DrawDot(MouseEventArgs e)
        {
            newgraphics = Graphics.FromImage(finishImg);
            PointF currentlocate = new PointF(e.X, e.Y);//当前位置定义为鼠标此刻的位置
            newgraphics.DrawLine(p, startPoint, currentlocate);//在之前位置与当前位置之间连一条线
            startPoint = currentlocate;//重复刚才的过程,起始位置变成了当前位置,达到刷新效果
            newgraphics.Dispose();
            DrawTools_Graphics.DrawImage(finishImg, 0, 0);//将处理完之后的内容绘制在目标绘图板上

        }
        //在最后,要清除变量从而释放内存
        /// <summary>
        /// 清除变量,释放内存
        /// </summary>
        public void clearVar()
        {
            DrawTools_Graphics.Dispose();
            finishImg.Dispose();
            orginalImg.Dispose();
            p.Dispose();
        }

    }
}
