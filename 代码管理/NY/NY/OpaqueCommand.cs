using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NY
{
    public class OpaqueCommand
    {
        private OpaqueLayer m_OpaqueLayer = null;//半透明蒙板层

        /// <summary>
        /// 显示遮罩层
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="Alpha">透明度</param>
        /// <param name="IsShowLoadingImage">是否显示图标</param>
        public OpaqueLayer ShowOpaqueLayer(Control control, int Alpha, bool IsShowLoadingImage)
        {
            try
            {
                if (this.m_OpaqueLayer == null)
                {
                    //this.m_OpaqueLayer = new OpaqueLayer(Alpha, IsShowLoadingImage);
                    this.m_OpaqueLayer = new OpaqueLayer();
                    control.Controls.Add(this.m_OpaqueLayer);
                    this.m_OpaqueLayer.Dock = DockStyle.Fill;
                    
                    this.m_OpaqueLayer.BringToFront();
                }
                //this.m_OpaqueLayer.Enabled = true;
                this.m_OpaqueLayer.Visible = true;
                m_OpaqueLayer.BackColor = System.Drawing.Color.Blue;
            }
            catch
            { }
            return m_OpaqueLayer;
        }
        /// <summary>
        /// 隐藏遮罩层
        /// </summary>
        public void HideOpaqueLayer()
        {
            try
            {
                if (this.m_OpaqueLayer!=null)
                {
                    this.m_OpaqueLayer.Visible = false;
                    this.m_OpaqueLayer.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
