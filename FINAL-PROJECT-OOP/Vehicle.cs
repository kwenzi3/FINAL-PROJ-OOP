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

        public Vehicle(string n, int id, double spd, double mc, double cl, bool ia)
        : base(n, id)

        {
            if (spd < 0)
                throw new InvalidDataException("The speed can't be below 0!");
            if (mc < 0)
                throw new InvalidDataException("The maximum load can't be below 0!");
            if (cl < 0)
                throw new InvalidDataException("The current load can't be below 0!");

            speed = spd;
            maxCapacity = mc;
            currentLoad = cl;
            isAvailable = ia;
        }

        //getters setters
        public double getSpeed() { return speed; }

        public void setSpeed(double spd)
        {
            if (spd < 0)
                throw new InvalidDataException("The speed can't be below 0!");
            speed = spd;
        }

        public double getMaxCapacity() { return maxCapacity; }

        public void setMaxCapacity(double mc)
        {
            if (mc < 0)
                throw new InvalidDataException("The Maximum Capacity can't be below 0!");
            maxCapacity = mc;
        }

        public double getCurrentLoad() { return currentLoad; }

        public void setCurrentLoad(double cl)
        {
            if (cl < 0)
                throw new InvalidDataException("The current load can't be below 0!");
            currentLoad = cl;
        }
        public bool getisAvailable() { return isAvailable; }

        public void setisAvailable(bool ia)
        {
            isAvailable = ia;
        }


        public void SetCapacity(double capacity)
        {
            if (capacity == 0)
                throw new InvalidDataException("capacity must be >0");
        }

        public double getRemainingCapacity()
        {
            return maxCapacity - currentLoad;
        }

        public virtual double CalculatedEfficiency()
        {
            if (speed > 50 )
            {
                Console.WriteLine("This Vehicle is efficient!");
                return speed - currentLoad;
            }

            else
            {
                Console.WriteLine("This vehicle is not efficient");
                return speed;
            }
        }

        public abstract void AssignDelivery(List<Package> packages);

        public override void Display()
        {
            Console.WriteLine("Name of the vehicle : " + getName());
            Console.WriteLine("Vehicle" + getId());
            Console.WriteLine("Speed of the vehicle is : " + getSpeed());
            Console.WriteLine("The maximum capacity is : " + getMaxCapacity());
            Console.WriteLine("The current load is : " + getCurrentLoad());
            Console.WriteLine("Is is available? : " + getisAvailable());
        }

    }
}
