using Day_4_CodeFIrstApproach.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_CodeFIrstApproach.Repository
{
    interface IUserRepository
    {

        public List<User> GetAllUsers();
        public User GetUser(int id);
        public void DeleteUser(int id);
        public List<User> ActiveUsers();
        public List<User> AddUser(User user);


    }
}
