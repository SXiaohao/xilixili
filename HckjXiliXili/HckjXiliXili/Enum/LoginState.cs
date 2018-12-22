using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Utility
{
    public enum LoginState
    {
        /// <summary>
        /// 用户不存在
        /// </summary>
        noexist = 0,
        /// <summary>
        /// 登陆成功
        /// </summary>
        sucess = 1,
        /// <summary>
        /// 密码错误
        /// </summary>
        pwderror = 2,
        /// <summary>
        /// 未连接网络
        /// </summary>
        error = 3,
        /// <summary>
        /// 手机号为空
        /// </summary>
        phoneempty = 4,
        /// <summary>
        /// 密码为空
        /// </summary>
        pwdempty=5,
        
    }
}
