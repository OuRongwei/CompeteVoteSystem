using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VTMS.Models;

namespace VTMS.Service
{
    /// <summary>
    /// 用户操作接口
    /// </summary>
    public interface IUserService
    {
        // 获取所有用户信息
        IQueryable<User> GetUsers();

        // 通过Id获取单个用户信息
        public User GeTUserById(int id);

        // 保存用户信息
        public bool SaveUser(User user);

        // 通过Id删除用户
        public bool RemoveUser(int userId);
    }
}
