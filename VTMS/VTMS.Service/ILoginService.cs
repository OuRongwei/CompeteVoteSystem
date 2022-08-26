using System;
using System.Collections.Generic;
using System.Text;
using VTMS.Models;

namespace VTMS.Service
{
    /// <summary>
    /// 登录管理接口
    /// </summary>
    public interface ILoginService
    {
        // 通过账号获取管理员
        public Admin GetAdmin(string account);
    }
}
