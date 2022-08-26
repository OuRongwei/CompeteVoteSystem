using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VTMS.Models;
using VTMS.Service;

namespace VTMS.UI.Controllers
{
    /// <summary>
    /// 比赛控制器
    /// </summary>
    public class CompeteController : Controller
    {
        private readonly ICompeteService m_Compete;

        public CompeteController(ICompeteService competeService)
        {
            m_Compete = competeService;
        }

        /// <summary>
        /// 比赛信息列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var competes = m_Compete.GetQueryable();
            return View(competes);
        }

        /// <summary>
        /// 修改比赛信息
        /// </summary>
        /// <param name="id">比赛Id</param>
        /// <returns></returns>
        public IActionResult Edit(int? id = null)
        {
            Compete compete = null;
            if (id.HasValue)
            {
                compete = m_Compete.GetCompeteById(id.Value);
            }

            return View(compete);
        }

        /// <summary>
        /// 保存比赛信息
        /// </summary>
        /// <param name="compete">比赛信息</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SaveCompete([FromForm] Compete compete)
        {
            //if (this.ModelState.IsValid)
            //{
            //    if (m_Compete.SaveCompete(compete))
            //    {
            //        return Redirect("~/Compete/Index");
            //        //return Redirect("Index");
            //    }
            //    else
            //    {
            //        return View("Edit", compete);
            //    }
            //}

            //return View("Edit");

            if (this.ModelState.IsValid)
            {

                if (m_Compete.SaveCompete(compete))
                {
                    if (Request.Form.Files.Count > 0)
                    {
                        var fileRequest = Request.Form.Files[0];
                        if (fileRequest.Length > 0)
                        {
                            using (var stream = fileRequest.OpenReadStream())
                            {
                                int len = 0;
                                var buffer = new byte[1024];
                                var fs = new FileInfo(fileRequest.FileName);
                                var now = DateTime.Now;
                                var dir = @"F:\C#\2022第一学期实训\Test\Image";
                                dir = Path.Combine(dir);
                                var filePath = Path.Combine(dir, $"{now.Ticks}{fs.Extension}");
                                compete.ImageUrl = $"{now.Ticks}{fs.Extension}";
                                m_Compete.SaveCompete(compete);
                                if (!Directory.Exists(dir))
                                {
                                    Directory.CreateDirectory(dir);
                                }
                                using (var fileStream = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
                                {
                                    while ((len = stream.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        fileStream.Write(buffer, 0, len);
                                    }
                                }
                            }
                        }
                    }
                    return Redirect("~/Compete/Index");
                }
                else
                {
                    return View("Edit", compete);
                }
            }

            return View("Edit");
        }

        /// <summary>
        /// 根据Id删除比赛
        /// </summary>
        /// <param name="id">比赛Id</param>
        /// <returns></returns>
        public IActionResult Remove(int id)
        {
            if (m_Compete.RemoveCompete(id))
            {
                return Redirect("~/Compete/Index");
            }
            else
            {
                return Content("删除比赛出错，转向错误信息");
            }
        }
    }
}
