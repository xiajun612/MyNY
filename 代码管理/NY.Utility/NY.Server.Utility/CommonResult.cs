using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY.Server.Utility
{
    /// <summary>
    /// Author:xxp
    /// Remark:返回对象信息
    /// CreateDate:20160816
    /// </summary>
    public class CommonResult
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CommonResult()
        {
            RetData = new Dictionary<string, object>();
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回给客户端的信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 错误堆栈
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// 附属结果
        /// </summary>
        public IDictionary<string, object> RetData { get; set; }
    }
}
