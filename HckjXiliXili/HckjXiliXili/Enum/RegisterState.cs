using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Enum
{
    public enum RegisterState
    {
        /// <summary>
        /// 手机号格式错误
        /// </summary>
        phoneerror = 0,
        /// <summary>
        /// 注册成功
        /// </summary>
        sucess = 1,      
        /// <summary>
        /// 密码与重复密码不一致
        /// </summary>
        inconformity=2,
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
        pwdempty = 5,
    }
}
