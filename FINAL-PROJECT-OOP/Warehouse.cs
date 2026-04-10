using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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

        public Warehouse(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Warehouse cannot be null or empty");

            name = n;
            workers = new List<Worker>();
            vehicles = new List<Vehicle>();
            packages = new List<Package>(); ;

        }

        public string getName() { return name; }
        public void setName(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Warehouse cannot be null or empty");

            name = n;
        }

        public List<Worker> GetWorkers() { return workers; }
        public List<Vehicle> GetVehicle() { return vehicles; }
        public List<Package> GetPackage() { return packages; }


        public void AddPackage(Package package)
        {
            if (package == null)
                throw new InvalidDataException("Package cannot be null or empty");
            packages.Add(package);
        }

        public void RemovePackage(int packageId)
        {

            Package packagetoRemove = null;

            foreach (Package package in packages)
            {
                if (package.GetId() == packageId)
                {
                    packagetoRemove = package;
                    break;
                }

            }
            if (packagetoRemove != null)
            {
                packages.Remove(packagetoRemove);
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
                throw new InvalidDataException("Vehicle list cannot be null or empty");

            Vehicle bestVehicle = vehicles[0];
            double bestresult = bestVehicle.getMaxCapacity() + bestVehicle.Calculatedeffiency();

            foreach (var vehicle in vehicles)
            {
                double result = vehicle.getMaxCapacity() + vehicle.Calculatedeffiency();
     
                if (result > bestresult)
                {
                    bestresult = result;
                    bestVehicle = vehicle;

                }


            }
            if (bestVehicle != null)
            {
                Console.WriteLine("Best Vehicle found: " + bestVehicle.getName());
               
            }
            else
            {
                Console.WriteLine("No suitable vehicle found for the package.");
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
            List<Package> getPendingPackages = new List<Package>();

            foreach(vasr in packages)
            {
                if packahe.GetStatus() == "Pending")
                {
                    getPendingPackages.Add(package);
                }
            }
            return getPendingPackages;
        }
        






               


    }
}
