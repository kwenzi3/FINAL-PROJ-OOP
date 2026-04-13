using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DeliverySystem deliverySystem = new DeliverySystem();

            Console.WriteLine("*****BLYTH SMART LOGISTICS AND DELIVERY SYSTEM*****");

            bool running = true;

            while (running)
            {

                Console.WriteLine("*****ENTITIES MENU*****");
                Console.WriteLine();
                Console.WriteLine("1. Add Entities(vehicle/worker)!");
                Console.WriteLine("2. Assign Delivery/Deliveries");
                Console.WriteLine("3. Sort");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Run stimulation");
                Console.WriteLine("6. Undo");
                Console.WriteLine("7. Save or Load");
                Console.WriteLine("or Exit");

                Console.WriteLine("What is your choice? : ");
                int choice = int.Parse(Console.ReadLine());



                //displaymenu();
                //string choice = Console.ReadLine();

                switch (choice)

                {
                    case 1:
                        EntitiesMenu();
                        break;

                    case 2:
                        AssignDeliveries();
                        break;

                    case 3:
                        deliverySystem.SortPackacgesByStatus();
                        break;

                    case 4:
                        search();
                        break;

                    case 5:
                        runStimulation();
                        break;

                    case 6:
                        undo();
                        break;

                    case 7:

                     SaveAndLoad();
                     break;

                    //case 8:
                    //    Load();
                    //    break;


                    default:
                        Console.WriteLine("Please enter your choice! :");
                        break;

                }

            }
        }


        //static void displaymenu()
        //{


        //}



        static void EntitiesMenu()
        {
            Console.WriteLine("*****What would you like to add?*****");
            Console.WriteLine("1. Truck");
            Console.WriteLine("2. Van");
            Console.WriteLine("3. Drone");
            Console.WriteLine("4. Driver");
            Console.WriteLine("5. Manager");
            Console.WriteLine("6. Loader");

            Console.WriteLine("What is your choice? : ");
            int choice = int.Parse(Console.ReadLine());
            //string choice = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    AddTruck();
                    break;

                case 2:
                    AddVan();
                    break;

                case 3:
                    AddDrone();
                    break;

                case 4:
                    AddDriver();
                    break;

                case 5:
                    AddManager();
                    break;

                case 6:
                    AddLoader();
                    break;

                default:
                    Console.WriteLine("Please enter your choice! :");
                    break;

            }


        }

        public static void AddTruck()

        {
            Console.WriteLine("Enter the truck's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the trucks's id : ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the truck's speed : ");
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the truck's max capacity : ");
            double mc = double.Parse(Console.ReadLine());

            Console.WriteLine("What's the truck's current load : ");
            double cl = double.Parse(Console.ReadLine());

            Console.WriteLine("Is the truck electric?? : ");
            bool ie = true;

            Console.WriteLine("Enter the truck's fuel consumption : ");
            double fuelconsump = double.Parse(Console.ReadLine());

           
            Truck t = new Truck(name, fuelconsump);

            Console.WriteLine("Truck has been added!!");

        }

        public static void AddVan()

        {
            Console.WriteLine("Enter the van's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Is this van electric? : ");
            bool isElectric = Console.ReadLine().ToLower() == "yes";

            Van v = new Van(name, isElectric);

            Console.WriteLine("Van has been added!!");

        }

        public static void AddDrone()

        {

            Console.WriteLine("Enter the drone's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the maximum distance? : ");
            double maxdistance = double.Parse(Console.ReadLine());

            Drone d = new Drone(name, maxdistance);

            Console.WriteLine("Drone has been added!!");
        }



        public static void AddDriver()

        {
            Console.WriteLine(" Enter the driver's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the liscence type? : ");
            string liscensetype = Console.ReadLine();

            Driver d = new Driver(name, liscensetype);

            Console.WriteLine("Driver has been added!!");

        }



        public static void AddManager()
        {
            Console.WriteLine("Enter the Manager's name : ");
            string name = Console.ReadLine();



            Console.WriteLine("What is the team size? : ");
            int teamsize = Console.ReadLine();

        Console.WriteLine("What is the team size? : ");
            int teamsize = int.Parse(Console.ReadLine());


        Manager m = new Manager(name, teamsize);

        Console.WriteLine("Manager has been added!!");

        }




        public static void AddLoader()
        {
            Console.WriteLine("Enter the Loader's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the Maximum Liftable weight? : ");
            double maxliftweight=double.Parse(Console.ReadLine());


            Loader l = new Loader(name, maxliftweight);

            Console.WriteLine("Loader has been added!!");


        }



        static void AssignDeliveries()
        {
            Console.WriteLine("Assigning Deliveries to : ");
           
        }

        static void Sort()
        {

        }

        static void search()
        {
            Console.WriteLine("ENter the package id: ");
            int id = int.Parse(Console.ReadLine());

            
                 
        }

        static void runStimulation()
        {

        }

        static void undo()
        {
            
        }

        static void SaveAndLoad()
        {
            
        }
    }

 
}


