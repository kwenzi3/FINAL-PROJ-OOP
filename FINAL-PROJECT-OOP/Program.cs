using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    class Program
    {   
        static string FILENAME = "entities.txt";    

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
                        deliverySystem.ProcecesDeliveries();
                        break;

                    case 3:
                        deliverySystem.SortPackagesById();
                        break;

                    case 4:
<<<<<<< HEAD
                        SearchPackageById();
=======
                        Console.WriteLine("Enter the package ID to search: ");
                        int id = int.Parse(Console.ReadLine());
                        var package = deliverySystem.SearchPackageById(id);
                        if (package != null)
                        {
                            Console.WriteLine($"Package ID: {package.getId()}, Status: {package.getStatus()}");
                        }
                        else
                        {
                            Console.WriteLine("Package not found.");
                        }
>>>>>>> 1f21d545dc99bce4979400fef9777dc44414e99c
                        break;

                    case 5:
                        deliverySystem.SimulateDay();
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

       


<<<<<<< HEAD
        //}



        static void EntitiesMenu()
        {
            Console.WriteLine("*****What would you like to add?*****");
            Console.WriteLine("1. Package");
            Console.WriteLine("2. Vehicle");
            Console.WriteLine("3. Worker");
         
            Console.WriteLine("What is your choice? : ");
            int choice = int.Parse(Console.ReadLine());
            //string choice = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    AddPackage();
                    break;

                case 2:
                    AddVehicle();
                    break;

                case 3:
                    AddWorker();
                    break;

                default:
                    Console.WriteLine("Please enter your choice! :");
                    break;
=======
        static void AddVehicle()
         {
            try
            {
                StreamWriter writer = new StreamWriter(FILENAME, true);



                Console.WriteLine("Enter the vehicle id: ");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the vehicle type(Truck/Van/Drone): ");
                string type = Console.ReadLine();
>>>>>>> 1f21d545dc99bce4979400fef9777dc44414e99c

                Console.WriteLine("Enter the vehicle Capacity: ");
                string capacity = Console.ReadLine();
            }
            catch 
            {
            }

        }

        static void AddPackage()

        {
            try
            {
                StreamWriter writer = new StreamWriter(FILENAME, true);

                Console.WriteLine("Enter the package id : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the package weight : ");
                string weight = Console.ReadLine();

                Console.WriteLine("Enter the package priority level : ");
                string priorityLevel = Console.ReadLine();

                Console.WriteLine("What's the package's destination : ");
                string destination = Console.ReadLine();

                Console.WriteLine("What is the status of the package? :");
                string status = Console.ReadLine();

                writer.WriteLine($"PACKAGE | {weight} | {priorityLevel} | {destination} | {status} ");
                writer.Close();

<<<<<<< HEAD
            }
=======
           
            truck t = new truck(name, fuelconsump);
>>>>>>> 1f21d545dc99bce4979400fef9777dc44414e99c

            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            //Package p = new Package();

            //Console.WriteLine("The Package has been added!!");

        }

<<<<<<< HEAD
    
     
=======
        public static void AddVan()

        {
            Console.WriteLine("Enter the van's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Is this van electric? : ");
            bool isElectric = Console.ReadLine().ToLower() == "yes";

            van v = new van(name, isElectric);

            Console.WriteLine("Van has been added!!");

        }

        public static void AddDrone()

        {

            Console.WriteLine("Enter the drone's name : ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the maximum distance? : ");
            double maxdistance = double.Parse(Console.ReadLine());

            drone d = new drone(name, maxdistance);

            Console.WriteLine("Drone has been added!!");
        }



        public static void AddDriver()

        {
            Console.WriteLine(" Enter the driver's name : ");
            string name = Console.ReadLine();

              
                Console.WriteLine("Enter the worker id: ");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the worker role: ");
                string role = Console.ReadLine();

                Console.WriteLine("Enter the worker Experience: ");
                string experience  = Console.ReadLine();



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




>>>>>>> 1f21d545dc99bce4979400fef9777dc44414e99c

       




<<<<<<< HEAD
        }

        static void SearchPackageById()
        {
           
                 
        }

        static void runStimulation()
        {

        }
=======
        
>>>>>>> 1f21d545dc99bce4979400fef9777dc44414e99c

        static void undo()
        {
            
        }

        static void SaveAndLoad()
        {
           
        }
    }

 
}


