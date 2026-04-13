using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class Drone : Vehicle
    {
        private double maxdistance;
        

        public Drone()
        {
            maxdistance = 0;
        }

        public Drone (string n, int id, double spd, double mc, double cl, bool ia, double md)
            : base (n , id, spd, mc, cl, ia)
        {
            if (md < 0)
                throw new InvalidDataException("The maximum distance should not be below 0!");

            maxdistance = md;
        }


        public double Getmaxdistance()
        {
            return maxdistance;
        }

        public void   Setmaxdistance(double md)
        {

            if (md < 0)
                throw new InvalidDataException("the maximum distance should not be below 0!");

            maxdistance = md;
        }

        public override void AssignDelivery(List<Package> packages)
        {
            Console.WriteLine("The drone's handle small/light packages only!");
        }

        public override double CalculatedEfficiency()
        {
            return base.CalculatedEfficiency();
        }



        //public drone(string name, double maxdistance)
        //{
        //    this.name = name;
        //    this.maxdistance = maxdistance;
        //}


    }
}




