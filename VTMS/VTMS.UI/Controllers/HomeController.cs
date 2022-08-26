using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VTMS.DbManager;
using VTMS.Models;
using VTMS.UI.Models;

namespace VTMS.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VoteContext m_Db;

        public HomeController(ILogger<HomeController> logger, VoteContext voteContext)
        {
            _logger = logger;
            m_Db = voteContext;
        }

        public IActionResult Index()
        {
            // 创建数据库，插入数据
            //InitDb();
            //InitData();

            return View();
        }

        // 创建数据库
        public void InitDb()
        {
            m_Db.Database.EnsureDeleted();
            m_Db.Database.EnsureCreated();
        }

        // 添加数据
        public void InitData()
        {

            #region 初始化数据

            #region 初始化管理员信息
            Admin admin = new Admin() { Account = "admin", Password = "123456", State = 1 };
            #endregion

            #region 初始化歌手信息
            Singer singer1 = new Singer()
            {
                Name = "秦诚",
                Title = "高音天王",
                Age = 30,
                Marry = 0,
                Brief = "代表作《掀起波澜》，他的高音是全世界最高的高音，比任何人的高音都要高",
                ImageUrl = ""
            };
            Singer singer2 = new Singer()
            {
                Name = "杜健",
                Title = "海豚音",
                Age = 18,
                Marry = 1,
                Brief = "代表作《烤面筋》，他的一首《烤面筋》加上魔性的舞蹈与声线，堪称一绝，年纪轻轻能歌善舞，是个歌唱奇才",
                ImageUrl = ""
            };
            Singer singer3 = new Singer()
            {
                Name = "虚位以待..",
                Title = "",
                Age = 0,
                Marry = 0,
                Brief = "期待大家的报名..",
                ImageUrl = ""
            };
            #endregion

            #region 初始化用户信息
            User user1 = new User() { PhoneNo = "13101014505", Password = "123456" };
            User user2 = new User() { PhoneNo = "18883509542", Password = "000000" };
            User user3 = new User() { PhoneNo = "11122223333", Password = "111111" };
            #endregion

            #region 初始化比赛信息
            Compete compete1 = new Compete()
            {
                Name = "快乐男声第一季",
                Brief = "有秦诚、杜键等多位大咖参与比赛，大家赶快来围观投票，机不可失失不再来",
                StartTime = new DateTime(2021, 11, 4, 7, 0, 0),
                EndTime = new DateTime(2022, 7, 9, 20, 0, 0),
                ImageUrl = ""
            };
            Compete compete2 = new Compete()
            {
                Name = "快乐女声第一季",
                Brief = "在快乐男生结束后，秦诚和杜键一起去泰国游玩，回国正好赶上了快乐女生，大家快来给他们打call",
                StartTime = new DateTime(2022, 7, 10, 9, 0, 0),
                EndTime = new DateTime(2022, 11, 3, 19, 0, 0),
                ImageUrl = ""
            };
            Compete compete3 = new Compete()
            {
                Name = "中国好声硬",
                Brief = "有秦诚、杜键等多位大咖参与比赛，大家赶快来围观投票，机不可失失不再来",
                StartTime = new DateTime(2022, 7, 4, 8, 30, 0),
                EndTime = new DateTime(2022, 7, 13, 17, 40, 0),
                ImageUrl = ""
            };
            #endregion

            #endregion

            #region 做多对多关系数据的插入：歌手和比赛中间表插入数据

            #region 歌手参加比赛
            // 三个歌手均参加第一场比赛
            singer1.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete1
            });
            singer2.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete1
            });
            singer3.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete1
            });

            // 三个歌手均参加了第二场比赛
            singer1.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete2
            });
            singer2.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete2
            });
            singer3.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete2
            });

            // 第一个和第三个歌手参加了第三场比赛
            singer1.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete3
            });
            singer3.CompeteAndSingers.Add(new CompeteAndSinger()
            {
                Compete = compete3
            });
            #endregion

            #region 初始化歌手给选手投票的记录
            
            #region 第一场比赛
            // 第一个歌手有第一个和第二个人为其投票
            singer1.VoteLists.Add(new VoteList()
            {
                User = user1,
                Compete = compete1
            });
            singer1.VoteLists.Add(new VoteList()
            {
                User = user2,
                Compete = compete1
            });

            // 第二个歌手有第二个和第三个用户为其投票
            singer2.VoteLists.Add(new VoteList()
            {
                User = user2,
                Compete = compete1
            });
            singer2.VoteLists.Add(new VoteList()
            {
                User = user3,
                Compete = compete1
            });
            #endregion

            #region 第二场比赛
            // 第一个歌手有第三个用户为其投票
            singer1.VoteLists.Add(new VoteList()
            {
                User = user3,
                Compete = compete2
            });
            #endregion

            #region 第三场比赛

            #endregion

            #endregion

            #endregion

            m_Db.Singers.AddRange(singer1, singer2, singer3);
            m_Db.Admins.AddRange(admin);

            m_Db.SaveChanges();
        }


        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
