using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VTMS.Models;

namespace VTMS.Service
{
    // 比赛操作接口
    public interface ICompeteService
    {
        // 获取所有比赛
        IQueryable<Compete> GetQueryable();

        // 通过Id获取比赛
        public Compete GetCompeteById(int id);

        // 保存比赛
        public bool SaveCompete(Compete compete);

        // 删除比赛
        public bool RemoveCompete(int competeId);
    }
}
