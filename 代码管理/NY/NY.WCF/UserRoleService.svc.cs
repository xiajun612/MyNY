using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NY.Server.Utility;
using NY.Service;

namespace NY.WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“UserRoleService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 UserRoleService.svc 或 UserRoleService.svc.cs，然后开始调试。
    public class UserRoleService : IUserRoleService
    {
        #region 操作员

        public CommonResult AddUser(Model.UAD_User model)
        {
            return new ForUserRoleServices().SaveUser("Add", model);
        }

        public CommonResult EditUser(Model.UAD_User model)
        {
            return new ForUserRoleServices().SaveUser("Edit", model);
        }

        public Model.UAD_User GetUserById(string strId)
        {
            return new ForUserRoleServices().GetUserById(strId);
        }

        public List<Model.UAD_User> GetUserList()
        {
            return new ForUserRoleServices().GetUserList();
        }

        #endregion

        #region 角色
        public CommonResult AddRole(Model.UAD_Role model)
        {
            return new ForUserRoleServices().SaveRole("Add", model);
        }

        public CommonResult EditRole(Model.UAD_Role model)
        {
            return new ForUserRoleServices().SaveRole("Edit", model);
        }

        public Model.UAD_Role GetRoleById(string strId)
        {
            return new ForUserRoleServices().GetRoleById(strId);
        }

        public List<Model.UAD_Role> GetRoleList()
        {
            return new ForUserRoleServices().GetRoleList();
        }
        #endregion
    }
}
