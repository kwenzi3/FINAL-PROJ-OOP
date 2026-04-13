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
                   continue;
               
                var bestVehicle = warehouse.FindBestVehicle(warehouse.GetVehicles());
                if (bestVehicle == null)
                    throw new InvalidOperationException($"No available vehicles in warehouse {warehouse.GetName()} to process deliveries.");

                var assignedWorker = warehouse.AssignWorker(warehouse.GetWorkers());
                if (assignedWorker == null)
                    throw new InvalidOperationException($"No available workers in warehouse {warehouse.GetName()} to process deliveries.");
               
                Console.WriteLine($"Processing deliveries from warehouse {warehouse.GetName()} using vehicle {bestVehicle.getId()} and worker {assignedWorker.getName()}.");
            }

            foreach (var package in allPackages)
            {
                if (package.getStatus() == "Pending")
                {
                    package.setStatus("In Transit");
                    
                }
            }

        }
        public void SimulateDay()
        {
            Console.WriteLine("Simulating a day in the delivery system");    
            ProcecesDeliveries();
            Console.WriteLine("Day simulation completed.");


        }   

        public List<Warehouse> GetWarehouses()
        {
            return warehouses;
        }

        public void SetWarehouses(List<Warehouse> warehouses)
        {
            warehouses = warehouses.ToList();
        }



        public List<Package> GetallPackages()
        {
            return allPackages;
        }

        public void SetallPackages(List<Package> allPackages)
        {
            allPackages = allPackages.ToList();
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

