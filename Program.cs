using Day_4_CodeFIrstApproach.Models;
using Day_4_CodeFIrstApproach.Repository;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Day_4_CodeFIrstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ApplicationDbContext _db = new ApplicationDbContext();
            UserRepository user = new UserRepository();
            //var person = _db.Users.ToList();
            //Console.WriteLine("askjasmk");
            Console.WriteLine("\n||||||||||||||||||||||........................ CODE FIRST APPROACH ...................................|||||||||||\n");

            Console.WriteLine("\n-----------------------------------------UserData Insertion----------------------------------------------");
            InsertData(_db);

            Console.WriteLine("\n-----------------------------------------Display AllUser Records-------------------------------------------");
            DisplayData(_db);

            //Display record with id = 1
            var userWithId = _db.Users.Where(a => a.Id == 1).FirstOrDefault();
           
            Console.WriteLine("\n-*--*--*--*--*--*--*--*--*--*--*-*--*--*--Record whose ID = 1 -*--*--*--*--*--*--*--*--*--*--*--*-");
            if (userWithId != null)
            {
                Console.WriteLine(userWithId.Id + " \t", userWithId.Name + "\t", userWithId.email + "\t", userWithId.Location + "\t\t", userWithId.Address + "\t", userWithId.IsActive);
            }
            //Displaying updated Data
            DisplayData(_db);


            Console.WriteLine("\n----------------------------------------Get Customer Details after updation-------------------------------------");

            Console.WriteLine("Please Enter an ID to update email as emailisupdated@gmail.com");
            int id = Convert.ToInt32(Console.ReadLine());

            //Update a record
            var updateUser = _db.Users.Where(a => a.Id == id).FirstOrDefault();
            if (updateUser != null)
            {
                updateUser.email = "emailisupdated@gmail.com";
                _db.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is no user in the id which you entered!!. Sorry!!");
            }
            DisplayData(_db);

            Console.WriteLine("\n-*--*--*--*--*--*--*--*--*--*--*--*-Table after deletion-*--*--*--*--*--*--*--*--*--*--*--*--*-");


            Console.WriteLine("Please Enter Id to delete");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User details after deleting record with id: ",id);
            
            user.DeleteUser(id);
            DisplayData(_db);

            Console.WriteLine();
            Console.WriteLine("-*--*--*--*--*--*--*--*--*--*--*--*--*-Active User Records-*--*--*--*--*--*--*--*--*--*--*--*--*-");


            Console.WriteLine("Active Users ");
            user.ActiveUsers();
            DisplayData(_db);

            Console.WriteLine();
            Console.WriteLine("-*--*--*--*--*--*--*--*--*--*--*--*--*-User Details after appending new row-*--*--*--*--*--*--*--*--*--*--*--*--*-");


            
            User newUser = new User();
            newUser.Name = "Angle";
            newUser.email = "angle@gmail.com";
            newUser.Location = "Madurai";
            newUser.Address = "Madurai";
            newUser.IsActive = true;
            Console.WriteLine();
            user.AddUser(newUser);

            //Displaying Data
            DisplayData(_db);

            static void InsertData(ApplicationDbContext _db)
            {
                User user = new User();
                Console.WriteLine("Enter Name");
                user.Name = Console.ReadLine();

                Console.WriteLine("Enter location");
                user.Location = Console.ReadLine();


                Console.WriteLine("Enter Address");
                user.Address = Console.ReadLine();


                user.email = "123@gmail.com";
                user.IsActive = true;


                _db.Users.Add(user);
                _db.SaveChanges();
            }

            static void DisplayData(ApplicationDbContext _db)
            {

                var userTable = _db.Users.ToList();
                Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Location\t" + "Address\t" + "IsActive\t");
                if (userTable.Any())
                {
                    foreach (var item in userTable)
                    {
                        Console.WriteLine(item.Id + " \t" + item.Name + "\t " + item.email + "\t\t" + item.Location + "\t\t" + item.Address + "\t" + item.IsActive);
                    }
                }
                else
                {
                    Console.WriteLine("No records present!!");
                }
            }

            Console.WriteLine();


        }


    }
}
