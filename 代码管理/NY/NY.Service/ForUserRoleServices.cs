using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NY.Model;
using NY.Server.Utility;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace NY.Service
{
    /// <summary>
    /// Author:xxp
    /// Remark:用户角色服务(业务逻辑)
    /// CreateDate:20160816
    /// </summary>
    public class ForUserRoleServices
    {
        private UADSystemEntities db = new UADSystemEntities();

        #region 操作员

        /// <summary>
        /// 保存操作员
        /// </summary>
        /// <param name="strOperate">操作说明:Add/Eidt</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public CommonResult SaveUser(string strOperate, UAD_User model)
        {
            var result = new CommonResult();
            try
            {
                if (strOperate.Equals("Add"))
                {
                    db.UAD_User.Add(model);
                }
                else if (strOperate.Equals("Edit"))
                {
                    db.UAD_User.Attach(model);
                }
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.StackTrace = ex.StackTrace;
                result.Message = ex.ToString();
            }
            return result;
        }

        /// <summary>
        /// 获取用户对象
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        public UAD_User GetUserById(string strId)
        {
            var data = db.UAD_User.Where(t => t.cUser_Id == strId).FirstOrDefault();
            return data;
        }

        public List<UAD_User> GetUserList()
        {
            var data = db.UAD_User.ToList();
            return data;
        }


        #endregion

        #region 角色

        /// <summary>
        /// 保存操作员
        /// </summary>
        /// <param name="strOperate">操作说明:Add/Eidt</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public CommonResult SaveRole(string strOperate, UAD_Role model)
        {
            var result = new CommonResult();
            try
            {
                if (strOperate.Equals("Add"))
                {
                    db.UAD_Role.Add(model);
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();
                }
                else if (strOperate.Equals("Edit"))
                {
                    db.UAD_Role.Attach(model);
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                result.IsSuccess = true;
            }
            catch (DbEntityValidationException dbEx)
            {
 
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.StackTrace = ex.StackTrace;
                result.Message = ex.ToString();
            }
            return result;
        }

        /// <summary>
        /// 获取用户对象
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        public UAD_Role GetRoleById(string strId)
        {
            var data = db.UAD_Role.Where(t => t.cRole_Id == strId).FirstOrDefault();
            return data;
        }

        public List<UAD_Role> GetRoleList()
        {
            var data = db.UAD_Role.ToList();
            return data;
        }

        #endregion

    }
}
