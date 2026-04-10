using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class van
    {
        private bool isElectric;




        public van() : base()
        {
            isElectric = true;
        }

        public van (string n, int id, double spd, double mc, double cl, bool ia, bool ie)
            : base (n,id, spd, mc, cl, ia)
        {
            isElectric = ie;
        }



        //public van(string name, bool isElectric)
        //{
        //    this.name = name;
        //    this.isElectric = isElectric;
        //}

    }
}
