using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day3
{   
   
    class UserRepository : IUserRepository
    {
        List<Users> users = new List<Users>();
     
        public UserRepository()
        {
            for(var i = 0; i < 10; i++)
            {
                if(i>5 )
                    users.Add(new Users() { id = i, name = "Name" + i, email = "Name" + i + "@gmail.com", location = "Madurai", address = "Street" + i ,isActive = true });
                else
                    users.Add(new Users() { id = i, name = "Name" + i, email = "Name" + i + "@gmail.com", location = "Madurai", address = "Street" + i, isActive = false });
            }
        }


        public List<Users> ActiveUsers()
        {
            List<Users> activeUsers = new List<Users>();
            foreach (Users person in users)
            {
                if (person.isActive)
                {
                    activeUsers.Add(person);
                }

            }
            return activeUsers;

        }

        public List<Users> AddUser(Users user)
        {
            users.Add(user);
            return users;
        }


        public List<Users> DeleteUser(int id)
        {
            foreach (Users person in users)
            {
                if (person.id == id)
                {
                    users.Remove(person);
                    break;
                }

            }
            return users;

        }

        public Users GetUser(int id)
        {
            //Users result = users.Where(user => user.id == id).FirstOrDefault();
            Users getUser = new Users();
            foreach (Users user in users)
            {
                if (user.id == id)
                    getUser = user;
            }
            return getUser;
        }

        public List<Users> Users()
        {
            return users;
        }

       
    }
}
