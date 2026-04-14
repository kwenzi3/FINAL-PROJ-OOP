using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class DeliverySystem
    {
        private List<Warehouse> warehouses;

        private List<Package> allPackages;



        public DeliverySystem()
        {
            warehouses = new List<Warehouse>();

            allPackages = new List<Package>();
        }

        public DeliverySystem(List<Warehouse> w, List<Package> p)
        {
            if (w == null || p == null)
                throw new InvalidDataException("Warehouses and packages cannot be null.");

            warehouses = new List<Warehouse>(w);
            allPackages = new List<Package>(p);
        }
        public void SortPackacgesByStatus()
        {

            for (int i = 0; i < allPackages.Count; i++)
            {
                for (int j = 0; j < allPackages.Count -i - 1; j++)
                {
                    if(allPackages[j].getStatus().CompareTo(allPackages[j + 1].getStatus()) < 0)
                    {
                 
                        Package temp = allPackages[j];
                        allPackages[j] = allPackages[j + 1];
                        allPackages[j + 1] = temp;
                    }

                }

            }
            
        }
        public void ProcecesDeliveries()
        {
            if(warehouses == null || warehouses.Count == 0)
                throw new InvalidOperationException("No warehouses available to process deliveries.");

            foreach (var warehouse in warehouses)
            {
                var pendingPackages = warehouse.getPendingPackages();
                if (pendingPackages == null || pendingPackages.Count == 0)

                    foreach (var package in pendingPackages)
                    {
                        var bestVehicle = warehouse.FindBestVehicle(package);
                        if (bestVehicle != null)
                         continue;

                        var worker = warehouse.AssignWorker();
                        if (worker != null)
                          continue;

                        bestVehicle.setCurrentLoad(bestVehicle.getCurrentLoad() + package.getWeight()); 

                        bestVehicle.setisAvailable(false);

                        package.setStatus("In Transir");  
                        
                        Console.WriteLine($"Package ID: {package.getId()} is assigned to Vehicle {bestVehicle.getId()} delivered by " +
                            $"worker {worker.getId()} ");

                    }

                    
            }

    

        }
        public void SimulateDay()
        {

            Console.WriteLine("Simulating a day in the delivery system");
            try
            {
                ProcecesDeliveries();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error during simulation: " + e.Message);

            }
            Console.WriteLine("Day simulation completed.");
        }   

        public List<Warehouse> GetWarehouses()
        {
            return warehouses;
        }

        public void SetWarehouses(List<Warehouse> wh)
        {
            if (wh == null)
                throw new InvalidDataException("Warehouses list cannot be null.");

            warehouses = new List<Warehouse>(wh);
        }



        public List<Package> GetallPackages()
        {
            return allPackages;
        }

        public void SetallPackages(List<Package> ap)
        {
            if (ap == null)
                throw new InvalidDataException("Packages list cannot be null."); 

             allPackages = new List<Package>(ap);
        }

        public void AddWarehouse(Warehouse w)
        {
            if (w == null)
                throw new InvalidDataException("The warhouse can'y be null");

            warehouses.Add(w);
        }

        public void AddPackage(Package p)
        {
            if (p == null)
                throw new InvalidDataException("The package can't be null or empty");

            allPackages.Add(p);
        }

        public Package SearchPackageById(int id)
        {
            foreach (Package p in allPackages)
            {
                if (p.getId() == id) 
                    return p;
            }
            return null;
        }



    }
}

