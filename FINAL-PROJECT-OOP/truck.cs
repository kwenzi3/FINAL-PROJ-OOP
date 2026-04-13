using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class Truck : Vehicle
    {
        private double fuelconsump;

        public Truck() 
            : base()
        {
            fuelconsump = 0;
        }

        public Truck (string n, int id, double spd, double mc, double cl, bool ia, double fc)
            : base (n, id, spd, mc, cl, ia)
        {
            if (fuelconsump < 0)
                throw new InvalidDataException("The fuel consumption should not be below 0!");

            fuelconsump = fc;


        }


       

        public double Getfuelconsump()
        {
            return fuelconsump;
        }

        public void Setfuelconsump(  double fc)
        {
            if (fc < 0)
                throw new InvalidDataException("The fuel consumotion should not be below 0!");

            fuelconsump = fc;
        }



        public override void AssignDelivery(List<Package>packages)
        {
            Console.WriteLine("The Truck's handle heavy packages!");
        }



        public override double CalculatedEfficiency()
        {
            return base.CalculatedEfficiency();
        }





        //public truck(string name, double fuelconsump)
        //{
        //    this.name = name;
        //    this.fuelconsump = fuelconsump;
        //}
    }
}
