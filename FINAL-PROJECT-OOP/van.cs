using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class Van : Vehicle
    {
        private bool isElectric;




        public Van() : base()
        {
            isElectric = true;
        }

        public Van (string n, int id, double spd, double mc, double cl, bool ia, bool ie)
            : base (n,id, spd, mc, cl, ia)
        {
            isElectric = ie;
        }

        public bool GetisElectric()
        {
            return isElectric;
        }

        public void SetisElectric(bool ie)
        {
            isElectric = ie;
        }

        public override void AssignDelivery(List<Package> packages)
        {
           Console.WriteLine("The van's handle medium deiveries!");
        }



        //public van(string name, bool isElectric)
        //{
        //    this.name = name;
        //    this.isElectric = isElectric;
        //}

    }
}
