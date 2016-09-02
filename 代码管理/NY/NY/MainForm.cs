using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraPrinting;

namespace NY
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private OpaqueCommand comand = new OpaqueCommand();
        private OpaqueLayer picWaiting = new OpaqueLayer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void navBarItem1_ItemChanged(object sender, EventArgs e)
        {

        }

        private void WatingPic(Boolean bStatus, Control c)
        {
            picWaiting.Visible = bStatus;
            if (bStatus)
                comand.ShowOpaqueLayer(c, 75, bStatus);
            else comand.HideOpaqueLayer();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //DockPanel panelX = new DockPanel();

            //panelX = this.dockManager1.AddPanel(DockingStyle.Right);

            //Form frmX = new Form();

            //frmX.Show(panelX);

            //frmX.Dock = DockStyle.Fill;

            //frmX.TopLevel = false;

            //frmX.FormBorderStyle = FormBorderStyle.None;

            //panelX.Text = frmX.Text;

            //panelX.TabText = frmX.Text;

            //panelX.Controls.Add(frmX);
            var nn = new UserControl1();

            foreach (var item in tabbedView1.Documents)
            {
                if (nn.GetType() == item.Control.GetType() && nn.bText == item.Caption)
                {
                    tabbedView1.ActivateDocument(item.Control);
                    return;
                }
            }
            var myWork1 = tabbedView1.AddDocument(nn);
            myWork1.Caption = nn.bText;
            tabbedView1.ActivateDocument(nn);



            //foreach (Form frm in this.MdiChildren)
            //{
            //    if (frm.GetType() == childForm.GetType() && frm.Text == childForm.Text)
            //    {
            //        frm.BringToFront();
            //        if (frm.WindowState == FormWindowState.Minimized)
            //        {
            //            frm.WindowState = FormWindowState.Normal;
            //        }
            //        return;
            //    }
            //}

            //childForm.MdiParent = this;
            //childForm.Show();
            //childForm.Activate();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (picWaiting.Visible == false)
                WatingPic(true, tabbedView1.ActiveDocument.Control);
            else
                WatingPic(false, tabbedView1.ActiveDocument.Control);
        }

        Form1 childForm = null;
        private void MainForm_Load(object sender, EventArgs e)
        {
            childForm = new Form1();
            var childForm1 = new Form1();

            childForm1.Text = "我的桌面";
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == childForm1.GetType() && frm.Text == childForm1.Text)
                {
                    frm.BringToFront();
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                    return;
                }
            }
            if (this.MdiChildren.Length == 0)
            {
                childForm1.WindowState = FormWindowState.Minimized;
                childForm1.WindowState = FormWindowState.Maximized;
            }
            childForm1.MdiParent = this;
            childForm1.Show();
            childForm1.Activate();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

       
    }
}