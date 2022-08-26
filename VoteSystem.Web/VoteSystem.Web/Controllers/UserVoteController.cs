using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using VoteSystem.Model;

namespace VoteSystem.Web.Controllers
{
    public class UserVoteController : Controller
    {
        private readonly VoteSystem.Services.IUserService m_UserService;

        public UserVoteController(VoteSystem.Services.IUserService userService)
        {
            m_UserService = userService;
        }

        public IActionResult Index(int Id)//歌手Id
        {
            //第一步：判断用户是否登录：查看Session里面是否有用户Id
            if (HttpContext.Session.GetString("userId") != null)
            {
                //把存session里的strign类型的Id转化成int类型
                int userId =Convert.ToInt32(HttpContext.Session.GetString("userId"));
                int matchId = 1;
                //先判断用户还有没有投票权
                bool votePower = m_UserService.GetUserByID(userId).Ticket;
                if (votePower==true)//有投票权就往数据库插入数据
                {
                    //调用插入数据到用户和歌手中间表的方法
                    m_UserService.SaveJiLu(Id,userId,matchId);
                }
                else
                {
                    return Content("对不起，您已投票，本场比赛不能在投票！！！");
                }

                
                
                return Redirect("~/SingerInfo/Index");
            }
            else //点投票没登录，就转到投票界面
            {
                return RedirectToAction("RedirectLoginPage", "Account");
            }

            
        }
    }
}
