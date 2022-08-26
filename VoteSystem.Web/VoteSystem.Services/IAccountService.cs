using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Model;

namespace VoteSystem.Services
{
    public interface IAccountService
    {
        public User GetOneUser(string phone);

        public bool RegisterUser(User user);
    }
}
