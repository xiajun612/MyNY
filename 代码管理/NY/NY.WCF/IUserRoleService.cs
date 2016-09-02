using NY.Server.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NY.Model;

namespace NY.WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserRoleService”。
    [ServiceContract]
    public interface IUserRoleService
    {
        #region 操作员

        [OperationContract]
        CommonResult AddUser(UAD_User model);


        [OperationContract]
        CommonResult EditUser(UAD_User model);

        [OperationContract]
        UAD_User GetUserById(string strId);

        [OperationContract]
        List<UAD_User> GetUserList();

        #endregion

        #region 角色

        [OperationContract]
        CommonResult AddRole(UAD_Role model);


        [OperationContract]
        CommonResult EditRole(UAD_Role model);

        [OperationContract]
        UAD_Role GetRoleById(string strId);

        [OperationContract]
        List<UAD_Role> GetRoleList();

        #endregion
    }
}
