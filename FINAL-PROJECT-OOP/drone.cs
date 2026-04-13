using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class drone : Vehicle
    {
        private double maxdistance;
        

        public drone()
        {
            maxdistance = 0;
        }

        public drone (string n, int id, double spd, double mc, double cl, bool ia, double md)
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

        //public override assigndeliveries with the lists - yet to do

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




