using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Model;

namespace VoteSystem.Services
{
    public interface IUserService
    {

        public User GetUserByID(int id);

        public bool SaveJiLu(int singerId, int userId,int matchId);
    }
}
