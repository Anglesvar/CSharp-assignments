using System;
using System.Collections.Generic;
using System.Text;

namespace day3
{
    interface IUserRepository
    {
        public List<Users> Users();
        public Users GetUser(int id);
        public List<Users> DeleteUser(int id);
        public List<Users> ActiveUsers();

        public List<Users> AddUser(Users user);

    }
}
