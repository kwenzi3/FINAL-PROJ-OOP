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
                

            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Warehouse name cannot be null or empty.");
            name = n;
            workers = new List<Worker>();
            vehicles = new List<Vehicle>();
            packages = new List<Package>();

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
        public void SetWorkers(List<Worker> w) { workers = w; }
        public void SetVehicles(List<Vehicle> v) { vehicles = v; }
        public void SetPackages(List<Package> p) { packages = p; }

        public void AddPackage(Package package)
        {
            if(package == null)
                throw new IndexOutOfRangeException("Package cannot be null.");
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
        public Vehicle FindBestVehicle(List<Vehicle> vehicles)
        {
            if (vehicles == null || vehicles.Count == 0)
                throw new InvalidDataException("Vehicle list cannot be null or empty.");
            Vehicle bestVehicle = null;
            double bestResult = double.MinValue;

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
