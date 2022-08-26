using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VTMS.Models;
using VTMS.Service;

namespace VTMS.UI.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    public class UserController : Controller
    {
        private readonly IUserService m_User;

        public UserController(IUserService userService)
        {
            m_User = userService;
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var users = m_User.GetUsers();

            return View(users);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns></returns>
        public IActionResult Edit(int? id = null)
        {
            User user = null;
            if (id.HasValue)
            {
                user = m_User.GeTUserById(id.Value);
            }

            return View(user);
        }

        /// <summary>
        /// 保存用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SaveUser([FromForm] User user)
        {
            if (this.ModelState.IsValid)
            {
                if (m_User.SaveUser(user))
                {
                    return Redirect("~/User/Index");
                }
                else
                {
                    return View("Edit", user);
                }
            }
            return View("Edit");
        }

        public IActionResult Remove(int id)
        {
            if(m_User.RemoveUser(id))
            {
                return Redirect("~/User/Index");
            }
            else
            {
                return Content("删除用户失败，转向错误信息");
            }
        }
    }
}
