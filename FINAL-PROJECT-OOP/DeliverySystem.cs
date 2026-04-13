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








        //   allPackages = new List<Package>();
        //}

        public List<Warehouse> GetWarehouses()
        {
            return warehouses;
        }




        public List<Package> GetallPackages()
        {

        }

        public List<Package> GetallPackages()

        {
            return allPackages;
        }



    }
}

