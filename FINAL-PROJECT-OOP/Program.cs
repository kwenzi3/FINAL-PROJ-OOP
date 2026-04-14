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
                        SearchPackageById();
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


        //static void displaymenu()
        //{


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

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            //Package p = new Package();

            //Console.WriteLine("The Package has been added!!");

        }

    
     

       


        static void AssignDeliveries()
        {
            Console.WriteLine("Assigning Deliveries to : ");
           
        }

        static void Sort()
        {

        }

        static void SearchPackageById()
        {
           
                 
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


