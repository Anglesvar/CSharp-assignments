using System;
using System.Collections.Generic;
using System.Linq;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------*WITHOUT USING LINQ*---------------------------------");
            UserRepository obj = new UserRepository();
            List<Users> user = new List<Users>();

            user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \tLocation \tAddress\tActiveStatus");
            foreach (Users users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t\t" + users.address + "\t  " + users.isActive);
            }
            
            Users getUser = new Users();
            getUser = obj.GetUser(1);
            if (getUser.id!=null)
            {
                Console.WriteLine("\nRecord which matched the given userId");
                Console.WriteLine("Id \t Name \t Email \t \tLocation \t Address \t ActiveStatus");
                Console.WriteLine(getUser.id + "\t" + getUser.name + "\t" + getUser.email + "\t" + getUser.location + "\t\t" + getUser.address + "\t\t" + getUser.isActive);
            }

            Console.WriteLine("\n");
            Console.WriteLine("List of Users after Deleting record with ID = 2 without using LINQ");
            List<Users> listafterDeletion = new List<Users>();
            listafterDeletion = obj.DeleteUser(2);
            Console.WriteLine("Id \t Name \t Email \t \t\tLocation \tAddress\tActiveStatus");
            foreach (Users users in listafterDeletion)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }



            Console.WriteLine("\n");
            List<Users> activeUser = new List<Users>();
            activeUser = obj.ActiveUsers();
            Console.WriteLine("List of Active Users without using LINQ");

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\tActiveStatus");
            foreach (Users users in activeUser)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }



            Console.WriteLine("\n");
            Users newUser = new Users();
            newUser.id = 100;
            newUser.name = "Angle";
            newUser.email = "Angle@gmail.com";
            newUser.location = "Madurai";
            newUser.address = "TN";
            newUser.isActive = true;

            Console.WriteLine("After addition of new user in List");
            obj.AddUser(newUser);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress \tActiveStatus");
            foreach (Users users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t\t" + users.address + "\t\t " + users.isActive);
            }
            Console.WriteLine("\n");


            Console.WriteLine("\n*****************************************************USING LINQ********************************************************\n");
            var getIdUser = user.Where(users => users.id == 3);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (Users users in getIdUser)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t\t" + users.address + "\t\t  " + users.isActive);
            }

            Console.WriteLine("\n");

            user.RemoveAll(x => x.id == 4);

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (Users users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t\t" + users.address + "\t\t" + users.isActive);
            }




            var activeUserUsingLinq = user.Where(users => users.isActive == true);

            Console.WriteLine();
            Console.WriteLine("List of Active Users using LINQ");

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");

            foreach (Users users in activeUserUsingLinq)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t\t" + users.address + "\t\t  " + users.isActive);
            }
            Console.WriteLine("\n");


            Users newUserData = new Users();

            user.Add(new Users() { id = 99, name = "Cheenu", email = "cheen@gmail.com", location = "Madurai", address = "TN", isActive = false});

            Console.WriteLine("After addition of new user in List");
            //obj.AddUser(newUserData);
            //user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (Users users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t\t" + users.address + "\t\t " + users.isActive);
            }
        }
    }
}
