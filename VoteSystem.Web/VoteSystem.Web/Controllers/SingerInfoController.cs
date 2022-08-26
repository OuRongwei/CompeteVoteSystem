using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoteSystem.Model;
using VoteSystem.Services;

namespace VoteSystem.Web.Controllers
{
    public class SingerInfoController : Controller
    {

        private readonly ISingerService m_SingerService;

        public SingerInfoController(ISingerService singerService)
        {
            m_SingerService = singerService;
        }

        public IActionResult Index()
        {
            var singers = m_SingerService.GetSingers();
            return View(singers);
        }


        public IActionResult SingerDetails(int? id = null)
        {
            Singer user = null;
            if (id.HasValue)
            {
                user = m_SingerService.GetSingerByID(id.Value);
            }

            return View(user);
        }

        public IActionResult myFun() 
        {
            ModelState.AddModelError("CredentialError", "alertInfo");
            return View();

        }

    }
}
