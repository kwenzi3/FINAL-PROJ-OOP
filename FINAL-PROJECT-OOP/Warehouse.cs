using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class Warehouse
    {
        private string name;
        private List<Worker> workers;   
        private List<Vehicle> vehicles;
        private List<package> packages;

        public Warehouse()
        {
            name = string.Empty;
            workers = new List<Worker>();
            vehicles = new List<Vehicle>();
            packages = new List<package>();
        }

        public Warehouse(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Warehouse name cannot be null or empty.");
            name = n;
            workers = new List<Worker>();
            vehicles = new List<Vehicle>();
            packages = new List<package>();
        }

        public string GetName() { return name; }
        public List<Worker> GetWorkers() { return workers; }
        public List <Vehicle> GetVehicles() { return vehicles; }
        
        public List<package> GetPackages() { return packages; }

        public void SetName(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Warehouse name cannot be null or empty.");
            name = n;
        }
        public void SetWorkers(List<Worker> w) { workers = w; }
        public void SetVehicles(List<Vehicle> v) { vehicles = v; }
        public void SetPackages(List<package> p) { packages = p; }

        public void AddPackage(package package)
        {
            if(package == null)
                throw new IndexOutOfRangeException("Package cannot be null.");
            packages.Add(package);
        }

        public void RemovePackage(int pacckageId)
        {
            package packageToRemove = null;

            foreach (var package in packages)
            {
                if (package.GetId() == pacckageId)
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
        public Vehicle FindBestVehicle(List<Vehicle> vehicles)
        {
            if (vehicles == null || vehicles.Count == 0)
                throw new InvalidDataException("Vehicle list cannot be null or empty.");
            Vehicle bestVehicle = null;
            double bestResult = bestResult.getMaxCapacity() + bestResult.CalculatedEfficiency();
            foreach (var vehicle in vehicles)
            {
                double result = vehicle.getMaxCapacity() / vehicle.CalculatedEfficiency();
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
        public Worker AssignWorker(List<Worker> workers)
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
        public List<package> getPendingPackages()
        {
            
            List<package> pendingPackages = new List<package>();
            foreach (var package in packages)
            {
                if (package.GetStatus() == "Pending")
                { 
                
                    pendingPackages.Add(package);
                }
            }
            return pendingPackages;
        }



          


    }
}
