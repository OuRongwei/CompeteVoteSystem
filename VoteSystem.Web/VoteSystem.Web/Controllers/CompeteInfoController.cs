using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoteSystem.Model;
using VoteSystem.Services;

namespace VoteSystem.Web.Controllers
{
    public class CompeteInfoController : Controller
    {

        private readonly ICompeteService m_CompeteService;

        public CompeteInfoController(ICompeteService competeService)
        {
            m_CompeteService = competeService;
        }

        public IActionResult CompeteInfoPage()
        {
            Compete compete = m_CompeteService.GetOneCompeteInfo();

            //把当前比赛Id存入session
            HttpContext.Session.SetString("ComepteId", compete.Id.ToString());
            return View(compete);
        }
    }
}
