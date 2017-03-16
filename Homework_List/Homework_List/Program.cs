using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool display = true;
            while (display)
            {
                display = MainMenu();
            }



            Console.ReadLine();

        }

        public static bool MainMenu()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Create new Manager");
            Console.WriteLine("2) Choose Manager");
            Console.WriteLine("3) Exit");
            Console.WriteLine("====================");

            string result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    CreateManager();
                    return true;
                case "2":
                    ChooseManager();
                    return true;
                case "3":
                    return false;
                default:
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("");
                    return true;
            }
        }


        public static void CreateManager()
        { 
            Manager manager = new Manager();
            List<Manager> managerList = new List<Manager>();

            Console.Write("Enter ID: ");
            manager.ID = Console.ReadLine();
            Console.Write("Enter first name: ");
            manager.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            manager.LastName = Console.ReadLine();
            Console.Write("Enter department: ");
            manager.Department = Console.ReadLine();

            managerList.Add(manager);


        }

        public static void ChooseManager()
        {
            //How to access manager class from here?
           
        }


    }
}
