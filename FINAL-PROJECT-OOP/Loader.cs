using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    internal class Loader : Worker
    {
        private double Maxliftweight;


        public Loader() : base()
        {
            Maxliftweight = 0.0;
        }

        public Loader (string n,int id, int ey, int tc, bool ia, string lt, double mw) :
            base( n,id, ey, tc, ia)
        {
            if (mw <= 0)
                throw new EmptyStructureException("License type cannot be null or empty.");

            Maxliftweight = mw;
        }

        public double GetMaxLiftWeight() { return Maxliftweight; }
        
        public void SetMaxliftweight(double mw) 
        {

            if (mw <= 0)
                throw new EmptyStructureException("License type cannot be null or empty.");


            Maxliftweight = mw; 
        }


        public override void PerformTask()
        {
            Console.WriteLine("Loading/unload packages");   
        }
    }
}
