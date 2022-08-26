using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoteSystem.Model;

namespace VoteSystem.Services
{
    public interface ISingerService
    {
        IQueryable<SingerAndSocreViewModel> GetSingers();


        public Singer GetSingerByID(int id);


        public bool SaveSinger(Singer singer);


        public bool RemoveSinger(int singerId);
    }
}
