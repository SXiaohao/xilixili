using HckjXiliXili.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HckjXiliXili.Utility
{
    class StateString
    {
        public static string GetLoginStateString(LoginState state)
        {
            switch (state)
            {
                case LoginState.error:
                    return "未连接网络";
                case LoginState.pwderror:
                    return "密码错误";
                case LoginState.noexist:
                    return "用户不存在";
                case LoginState.sucess:
                    return "登陆成功";
                case LoginState.phoneempty:
                    return "手机号为空";
                case LoginState.pwdempty:
                    return"密码为空";
            }
            return "";
        }
        public static string GetRegisterStateString(RegisterState state)
        {
            switch (state)
            {
                case RegisterState.error:
                    return "未连接网络";
                case RegisterState.inconformity:
                    return "密码与重复密码不一致";
                case RegisterState.phoneerror:
                    return "手机号格式错误";
                case RegisterState.sucess:
                    return "注册成功";
                case RegisterState.phoneempty:
                    return "手机号为空";
                case RegisterState.pwdempty:
                    return "密码为空";
            }
            return "";
        }
    }
}
