using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public abstract  class Vehicle : Entity
    {
        private double speed;
        double maxCapacity;
        private double currentLoad;
        private bool isAvailable;

        public Vehicle(): base ()

        {
            speed = 0;
            maxCapacity = 0;
            currentLoad = 0;
            isAvailable = true;
        }


        public void SetCapacity(double capacity)
        {
            if (capacity == 0)
                throw new InvalidDataException("capacity must be >0");
        }


    }
}
