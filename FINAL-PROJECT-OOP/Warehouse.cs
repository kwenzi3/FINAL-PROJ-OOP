using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class Warehouse
    {
        private string name;
        private List<Worker> workers;   
        private List<Vehicle> vehicles;
        private List<Package> packages;

        public Warehouse()
        {
            name = string.Empty;
            workers = new List<Worker>();
            vehicles = new List<Vehicle>();
            packages = new List<Package>();
        }

        public Warehouse(string n, List<Worker> w, List<Vehicle> v, List<Package> p)
        {

            if (string.IsNullOrEmpty(n) || w == null || v == null || p == null)
            {
                throw new EmptyStructureException("Warehouse attribute cannot be null or empty.");
            }

                name = n;
                workers = new List<Worker>(w);
                vehicles = new List<Vehicle>(v);
                packages = new List<Package>(p);
           

        }

        public string GetName() { return name; }
        public List<Worker> GetWorkers() { return workers; }
        public List <Vehicle> GetVehicles() { return vehicles; }
        
        public List<Package> GetPackages() { return packages; }

        public void SetName(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Warehouse name cannot be null or empty.");
            name = n;
        }
        public void SetWorkers(List<Worker> w) 
        {
            if (w == null)
                throw new InvalidDataException("Worker list cannot be null.");

            workers = new List<Worker>(w);
        }
        public void SetVehicles(List<Vehicle> v)
        {
            if (v == null)
                throw new InvalidDataException("Vehicle list cannot be null.");

            vehicles = new List<Vehicle>(v); 
        }
        public void SetPackages(List<Package> p) 
        {
            if (p == null)
                throw new InvalidDataException("Packages list cannot be null.");

            packages = new List<Package>(p);
        }

        public void AddPackage(Package package)
        {
            if(package == null)
                throw new InvalidDataException("Package cannot be null.");
            packages.Add(package);
        }

        public void RemovePackage(int packageId)
        {
            Package packageToRemove = null;

            foreach (var package in packages)
            {
                if (package.getId() == packageId)
                {
                    packageToRemove = package;
                    break;
                }
            }
            if (packageToRemove != null)
            {
                packages.Remove(packageToRemove);
                Console.WriteLine("Package Removed"); 
            }
            else
            {
                Console.WriteLine("Package not found");
            }

        }
        public Vehicle FindBestVehicle(Package p)
        {
            if(p == null)
                throw new InvalidDataException("Package cannot be null.");  
            if (vehicles == null || vehicles.Count == 0)
                throw new InvalidDataException("Vehicle list cannot be null or empty.");

            Vehicle bestVehicle = null;
            double bestResult = double.MinValue;

            foreach (var vehicle in vehicles)
            {
                if(vehicle.getRemainingCapacity() < p.getWeight() || !vehicle.getisAvailable())
                {
                    continue;
                }
                double efficiency = vehicle.CalculatedEfficiency();
                double result = vehicle.getMaxCapacity() / efficiency;
                if (result > bestResult)
                {
                    bestResult = result;
                    bestVehicle = vehicle;
                }
            }
            if(bestVehicle != null)
            {
                Console.WriteLine("Best Vehicle: " + bestVehicle.getName());

            }
            else
            {
                Console.WriteLine("No Vehicle found");
            }
            return bestVehicle;
        }
        public Worker AssignWorker()
        {
            Console.WriteLine("--Available Workers--");
            foreach (var worker in workers)
            {
                if(worker.getIsAvailable())
                {
                    worker.setIsAvailable(false);
                    Console.WriteLine(worker.getName());
                    return worker;
                }
            }
            return null;

        }
        public List<Package> getPendingPackages()
        {
            
            List<Package> pendingPackages = new List<Package>();
            foreach (var package in packages)
            {
                if (package.getStatus() == "Pending")
                { 
                
                    pendingPackages.Add(package);
                }
            }
            return pendingPackages;
        }



          


    }
}
