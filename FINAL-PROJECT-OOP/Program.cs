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

        static void AddVehicle()
        {
            try
            {
                StreamWriter writer = new StreamWriter(FILENAME, true);



                Console.WriteLine("Enter the vehicle id: ");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the vehicle type(Truck/Van/Drone): ");
                string type = Console.ReadLine();

                Console.WriteLine("Enter the vehicle Capacity: ");
                string capacity = Console.ReadLine();

                writer.WriteLine($"VEHICLE | V{id} | {type} | {capacity}");
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }



        static void AddWorker()
        {
            try
            {
                StreamWriter writer = new StreamWriter(FILENAME, true);


                Console.WriteLine("Enter the worker id: ");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the worker role: ");
                string role = Console.ReadLine();

                Console.WriteLine("Enter the worker Experience: ");
                string experience = Console.ReadLine();

                writer.WriteLine($"WORKER | W{id} | {role} | {experience}");
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }





        static void undo()
        {
            
        }

        static void SaveAndLoad()
        {
            
        }
    }

 
}


