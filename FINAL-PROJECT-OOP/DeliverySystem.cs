using System;
using System.Collections.Generic;
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

