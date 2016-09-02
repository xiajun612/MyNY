using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace NY
{
    /// <summary>
    /// [ToolboxBitmap(typeof(MyOpaqueLayer))]
    /// 用于指定当把你做好的自定义控件添加到工具栏时，工具栏显示的图标。正确写法应该是
    ///[ToolboxBitmap(typeof(XXXXControl),"xxx.bmp")]
    ///其中XXXXControl是你的自定义控件，"xxx.bmp"是你要用的图标名称。
    /// </summary>
    [ToolboxBitmap(typeof(OpaqueLayer))]
    public class OpaqueLayer : System.Windows.Forms.UserControl
    {
        /// <summary>
        /// 是否使用透明
        /// </summary>
        private bool _transparentBG = true;

        /// <summary>
        ///  [Category("myOpaqueLayer"), Description("是否使用透明,默认为True")]
        /// 一般用于说明你自定义控件的属性（Property）。
        /// Category用于说明该属性属于哪个分类，Description自然就是该属性的含义解释。
        /// </summary>
        [Category("OpaqueLayer"), Description("是否使用透明，默认为True")]
        public bool TransparentBG
        {
            get { return _transparentBG; }
            set
            {
                _transparentBG = value;
                //this.Invalidate();
            }
        }
        /// <summary>
        /// 设置透明度
        /// </summary>
        private int _alpha = 125;
        private Button button1;
        /// <summary>
        /// 设置透明度
        /// </summary>
        [Category("MyOpaqueLayer"), Description("设置透明度")]
        public int Alpha
        {
            get { return _alpha; }
            set
            {
                _alpha = value;
                //this.Invalidate();
            }
        }

        private System.ComponentModel.Container components = new System.ComponentModel.Container();
        public OpaqueLayer() { }
       // public OpaqueLayer() : this(125, true) { }
        //public OpaqueLayer(int _alpha, bool _isShowLoadingImage)
        //{
        //    //SetStyle(ControlStyles.Opaque,true);
        //    //this.CreateControl();
        //    //this._alpha = _alpha;
        //    //if (_isShowLoadingImage)
        //    //{
        //    //    PictureBox pic_Loading = new PictureBox();
        //    //    pic_Loading.BackColor = Color.White;
        //    //    //pic_Loading.Image = Properties.Resources.loading;
        //    //    pic_Loading.Name = "pic_Loading";
        //    //    pic_Loading.Size = new Size(48, 48);
        //    //    pic_Loading.SizeMode = PictureBoxSizeMode.AutoSize;
        //    //    Point location = new Point(this.Location.X + (this.Width - pic_Loading.Width) / 2, this.Location.Y + (this.Height - pic_Loading.Height) / 2); //居中运算
        //    //    pic_Loading.Location = location;
        //    //    pic_Loading.Anchor = AnchorStyles.None;
        //    //    this.Controls.Add(pic_Loading);
        //    //}
        //}
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!((components == null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        ///// <summary>
        ///// 自定义绘制窗体
        ///// </summary>
        ///// <param name="e"></param>
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    //float vlblControlWidth;
        //    //float vlblControlHeight;

        //    //Pen labelBorderPen;
        //    //SolidBrush labelBackColorBruch;

        //    //if (_transparentBG)
        //    //{
        //    //    Color drawColor = Color.FromArgb(this._alpha, this.BackColor);
        //    //    labelBorderPen = new Pen(drawColor, 0);
        //    //    labelBackColorBruch = new SolidBrush(drawColor);
        //    //}
        //    //else
        //    //{
        //    //    labelBorderPen = new Pen(this.BackColor, 0);
        //    //    labelBackColorBruch = new SolidBrush(this.BackColor);
        //    //}
        //    base.OnPaint(e);
        //    //vlblControlWidth = this.Size.Width;
        //    //vlblControlHeight = this.Size.Height;
        //    //e.Graphics.DrawRectangle(labelBorderPen, 0, 0, vlblControlWidth, vlblControlHeight);
        //    //e.Graphics.FillRectangle(labelBackColorBruch, 0, 0, vlblControlWidth, vlblControlHeight);
        //}

        //protected override CreateParams CreateParams
        //{
        //    //get
        //    //{
        //    //    CreateParams cp = base.CreateParams;
        //    //    cp.ExStyle |= 0x00000020; //开启WS_EX_TRANSPARENT,使控件支持透明
        //    //    return cp;
        //    //}
        //}

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OpaqueLayer
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.button1);
            this.Name = "OpaqueLayer";
            this.Size = new System.Drawing.Size(252, 199);
            this.ResumeLayout(false);

        }
    }
}
