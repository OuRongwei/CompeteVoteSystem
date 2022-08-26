using System;
using System.Linq;
using VTMS.Models;

namespace VTMS.Service
{
    // 歌手操作接口
    public interface ISingerService
    {
        // 获取所有歌手信息
        IQueryable<Singer> GetSingers();

        // 通过Id获取某个歌手信息
        public Singer GetSingerById(int id);

        // 保存歌手信息
        public bool SaveSinger(Singer singer);

        // 通过Id删除歌手
        public bool RemovesSinger(int singerId);
    }
}
