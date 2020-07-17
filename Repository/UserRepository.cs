using Day_4_CodeFIrstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_4_CodeFIrstApproach.Repository
{
    class UserRepository : IUserRepository
    {
        //ApplicationDbContext _db = new ApplicationDbContext();
        
            /*User p = new User();
            Console.WriteLine("Enter Name");
            p.Name = Console.ReadLine();

            Console.WriteLine("Enter Location");
            p.Location = Console.ReadLine();
            p.email = "angle@gmail.com";    
            Console.WriteLine("Enter Address");
            p.Address = Console.ReadLine();
            p.IsActive = true;
            

            _db.Users.Add(p);
            _db.SaveChanges();*/
        
        private readonly ApplicationDbContext _db;
        public UserRepository()
        {
            _db = new ApplicationDbContext();
        }
        public List<User> GetAllUsers()
        {
            var users = _db.Users.ToList();
            return users;
        }

        public User GetUser(int id)
        {
            var selectedUser = _db.Users.Where(a => a.Id == id).FirstOrDefault();
            return selectedUser;
        }

        public List<User> AddUser(User userRecord)
        {
            //Console.WriteLine(userRecord);
            var _db = new ApplicationDbContext();
            var users = _db.Users.ToList();
            return users;
        }
        public List<User> ActiveUsers()
        {
            
            var users = _db.Users.Where(a => a.IsActive == true).ToList();

            return users;
        }
        public void DeleteUser(int id)
        {
            
            var user = _db.Users.Where(a => a.Id == id).FirstOrDefault();

            //_db.Users.RemoveAll(user);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }
        
        

    }
}
