using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VTMS.Models;
using VTMS.Service;

namespace VTMS.UI.Controllers
{
    public class AdminLoginController : Controller
    {
        private readonly ILoginService m_loginService;

        public AdminLoginController(ILoginService loginService)
        {
            m_loginService = loginService;
        }

        // 跳转到登录页面
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="admin">管理员信息</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult LoginChecking(Admin admin)
        {
            var dbAdmin = m_loginService.GetAdmin(admin.Account);
            if(dbAdmin != null)
            {
                if(dbAdmin.Password == admin.Password)
                {
                    return Redirect("~/Home/Index");
                }
            }
            else
            {
                return Content("<script>alert('管理员不存在！！！');window.location.href= 'Login'</script>");
            }

            return View("Index", admin);
        }
    }
}
