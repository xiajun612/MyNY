using NY.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NY.Framework;
using NY.Framework.Voucher;

namespace NY.UADP
{
    public partial class frmRoleList : Form
    {
        private BindingSource modelSource;
        private int EidtStatus = -1;

        public frmRoleList()
        {
            InitializeComponent();
            modelSource = new BindingSource();
            modelSource.DataSource = new SRUserRole.UAD_Role();
            VoucherDataTool.VoucherDataBindings(layoutControlGroup2, modelSource);
        }

        private void frmRoleList_Load(object sender, EventArgs e)
        {
            try
            {
                using (SRUserRole.UserRoleServiceClient client = new SRUserRole.UserRoleServiceClient())
                {
                    var resData = client.GetRoleList();
                    gridControl1.DataSource = resData;
                }
            }
            catch (Exception ex)
            {
                ClsMsg.ShowErrMsg(ex.ToString());
            }
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                switch (e.Item.Name)
                {
                    case "bbtniAdd":
                        EidtStatus = 0;
                        modelSource.DataSource = new SRUserRole.UAD_Role();
                        break;
                    case "bbtniSave":
                        SaveFun();
                        break;
                    case "bbtniDel":

                        break;
                    case "bbtniQuit":
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ClsMsg.ShowErrMsg(ex.ToString());
            }
        }

        private void SaveFun()
        {
            try
            {
                using (SRUserRole.UserRoleServiceClient client = new SRUserRole.UserRoleServiceClient())
                {
                    SRUserRole.CommonResult resData = null;
                    var model = modelSource.DataSource as SRUserRole.UAD_Role;

                    if (model != null)
                    {
                        if (EidtStatus == 0)
                        {
                            resData = client.AddRole(model);
                        }
                        else
                        {
                            resData = client.EditRole(model);
                        }
                        if (resData.IsSuccess)
                        {
                            ClsMsg.ShowInfoMsg("保存成功！");
                        }
                        else
                        {
                            ClsMsg.ShowErrMsg(resData.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClsMsg.ShowErrMsg(ex.ToString());
            }
        }
    }
}
