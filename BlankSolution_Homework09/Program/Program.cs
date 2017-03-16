using BlankSolution_Homework09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        private static List<Manager> managers = new List<Manager>();
        private static Manager selectedManager;



        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Create manager");
            Console.WriteLine("2) Choose manager");
            Console.WriteLine("0) Exit");

            string result = Console.ReadLine();

            if(result == "1")
            {
                Console.WriteLine("========================================");
                if (CreateNewManager())
                {
                    Console.WriteLine("Succesfully created");
                    Console.WriteLine("Please enter to continue.");
                }
                Console.ReadLine();
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine("========================================");
                bool displaymanagerMenu = true;
                while (displaymanagerMenu)
                {
                    displaymanagerMenu = ManagersMenu();
                }

                return true;
            }
            else if (result == "0")
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool ManagersMenu()
        {
            Console.Clear();

            if (managers.Count == 0) // prevoeruvame dali veke imame nekoj manager vo listata
            {
                Console.WriteLine("Empty manager list");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

                return false;
            }

            Console.WriteLine("Please select manager");

            foreach (var manager in managers)
            {
                Console.WriteLine($"{manager.Id} {manager.FirstName} {manager.LastName}");
            }

            Console.WriteLine("Seelct 0 to go back");

            int selectedNumber = int.Parse(Console.ReadLine());

            if (selectedNumber == 0)
            {
                return false;
            }

            if (managers.Any(manager => manager.Id == selectedNumber))
            {
                selectedManager = managers.FirstOrDefault(manager => manager.Id == selectedNumber);
                bool displayManagersOptions = true;
                while (displayManagersOptions)
                {
                    displayManagersOptions = ManagersOptionsMenu();
                }
            }

            return true;

        }

        private static bool ManagersOptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("Managers menu");
            Console.WriteLine("Choose option: ");
            Console.WriteLine("1) Add new sales person");
            Console.WriteLine("2) Print managers details");
            Console.WriteLine("3) Print sales person ordered by first name");
            Console.WriteLine("4) Print sales person only female");
            Console.WriteLine("0) Back");

            string result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    Console.WriteLine("===============================");
                    Console.WriteLine("Add new sales person");

                    if (CreateNewSalesPerson())
                    {
                        Console.WriteLine("Succesfully created sales person");
                        Console.WriteLine("Press enter to continue.");
                    }

                    Console.ReadLine();
                    return true;

                case "2":
                    Console.WriteLine("===============================");
                    Console.WriteLine("Print managers details");

                    selectedManager.PrintInfo();
                    Console.ReadLine();

                    return true;

                case "3":
                    Console.WriteLine("===============================");
                    Console.WriteLine("Print sales persons ordered by first name");
                    selectedManager.PrintSalesPersonsByFirstName();
                    Console.ReadLine();

                    return true;

                case "4":
                    Console.WriteLine("===============================");
                    Console.WriteLine("Print female sales persons");
                    selectedManager.PrintFemaleSalesPersons();
                    Console.ReadLine();

                    return true;

                case "0":
                    selectedManager = null;
                    return false;

                default:
                    return true;
            }


        }


        private static bool CreateNewManager()
        {
            Console.WriteLine("Create new manager");

            Console.Write("Insert Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Insert first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Insert last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Insert department: ");
            string department = Console.ReadLine();

            Console.Write("Insert gender (M/F): ");
            string genderString = Console.ReadLine();
            Gender gender = ConvertToGender(genderString);

            Console.Write("Insert Salary: ");
            double salary = double.Parse(Console.ReadLine());

            if (AlreadyExitManager(department))
            {
                Console.WriteLine($"Already exist manage for {department} department.");
                return false;
            }

            managers.Add(new Manager(id, firstName, lastName, gender, department, salary));

            return true;

        }

        private static bool CreateNewSalesPerson()
        {
            Console.WriteLine("Create new sales person");

            Console.Write("Insert first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Insert last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Insert gender (M/F): ");
            string genderString = Console.ReadLine();

            Gender gender = ConvertToGender(genderString);

            selectedManager.SalesPersons.Add(new SalesPerson(firstName, lastName, gender));

            return true;

        }

        //proveruvame dali ima manager za toj department, posto samo eden manager moze da bide na eden department
        private static bool AlreadyExitManager (string department)
        {
            // any vraka dali bilo koj od managerite go ispolnuva uslovot.
            return managers.Any(manager => manager.Department.ToLower() == department.ToLower());
        }

        private static Gender ConvertToGender(string genderString) //vraka Gender.female ili gender.male
        {
            Gender gender = Gender.Female;

            if (genderString.ToLower() == "m") // stavame to.lower za da ni gi pretvori site inputi vo mali bukvi
            {
                gender = Gender.Male;
            }

            else if (genderString.ToLower() == "f")
            {
                gender = Gender.Female;
            }

            return gender;
        }
    }
}
