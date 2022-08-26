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
    /// 歌手控制器
    /// </summary>
    public class SingerController : Controller
    {
        private readonly ISingerService m_Singer;

        public SingerController(ISingerService singerService)
        {
            m_Singer = singerService;
        }

        /// <summary>
        /// 歌手信息列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var singer = m_Singer.GetSingers();
            return View(singer);
        }

        /// <summary>
        /// 修改歌手信息
        /// </summary>
        /// <param name="id">歌手Id</param>
        /// <returns></returns>
        public IActionResult Edit(int? id = null)
        {
            Singer singer = null;
            if (id.HasValue)
            {
                singer = m_Singer.GetSingerById(id.Value);
            }

            return View(singer);
        }

        /// <summary>
        /// 保存歌手信息
        /// </summary>
        /// <param name="singer">歌手信息</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SaveSinger([FromForm] Singer singer)
        {
            //if (this.ModelState.IsValid)
            //{
            //    if(m_Singer.SaveSinger(singer))
            //    {
            //        return Redirect("~/Singer/Index");
            //    }
            //    else
            //    {
            //        return View("Edit", singer);
            //    }
            //}
            //return View("Edit");

            if (this.ModelState.IsValid)
            {

                if (m_Singer.SaveSinger(singer))
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
                                singer.ImageUrl = $"{now.Ticks}{fs.Extension}";
                                m_Singer.SaveSinger(singer);
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
                    return Redirect("~/Singer/Index");
                }
                else
                {
                    return View("Edit", singer);
                }
            }

            return View("Edit");
        }

        /// <summary>
        /// 删除歌手信息
        /// </summary>
        /// <param name="id">歌手Id</param>
        /// <returns></returns>
        public IActionResult Remove(int id)
        {
            if (m_Singer.RemovesSinger(id))
            {
                return Redirect("~/Singer/Index");
            }
            else
            {
                return Content("删除歌手失败，转向错误信息");
            }
        }
    }
}