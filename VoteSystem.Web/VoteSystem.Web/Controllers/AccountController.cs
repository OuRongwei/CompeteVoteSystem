using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using VoteSystem.Services;
using VoteSystem.Model;

namespace VoteSystem.Web.Controllers
{
    /// <summary>
    /// 登录管理的控制器
    /// </summary>
    public class AccountController : Controller
    {
        private readonly IAccountService m_AccountService;

        public AccountController(IAccountService singerService)
        {
            m_AccountService = singerService;
        }


        //跳转到登录页面
        public IActionResult RedirectLoginPage()
        {
            return View();
        }

        //登录验证
        [HttpPost]
        public IActionResult LoginChecking(User user)
        {
            var dbUser = m_AccountService.GetOneUser(user.PhoneNo);
            if (dbUser != null)
            {
                if (dbUser.Password == user.Password)
                {
                    //把登录用户Id存入session
                    HttpContext.Session.SetString("userId", dbUser.Id.ToString());

                    return Redirect("~/SingerInfo/Index");
                }
            }
            else
            {
                return Content("用户不存在！！");
            }

            
            //为啥未查询到用户时，返回user对象？  保留输入的用户名和密码信息
            return View("RedirectLoginPage", user);
        }


        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Register(User user)
        {
            //给注册用户设置投票权
            user.Ticket = true;
            if (m_AccountService.RegisterUser(user))
            {
                return Redirect("~/Account/RedirectLoginPage");
            }
            else
            {
                return Content("<script>alert('注册失败！');</script>");
            }
        }
    }
}
