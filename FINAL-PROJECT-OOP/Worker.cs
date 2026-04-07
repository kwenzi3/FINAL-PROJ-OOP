using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public abstract class Worker : Entity
    {
        private int experienceYars;
        private int taskCompleted;
        private bool isAvailable;

        public Worker() : base()
        {
            experienceYars = 0;
            taskCompleted = 0;
            isAvailable = true;
        }
        public Worker(int id, string n, int ey, int tc, bool ia) : base(id, n)
        {
            if (ey < 0)
                throw new InvalidDataException("Experience years cannot be negative.");
            if (tc < 0)
                throw new InvalidDataException("Task completed cannot be negative.");
            experienceYars = ey;
            taskCompleted = tc;
            isAvailable = ia;
        }

        public int getExperienceYears() { return experienceYars; } 
        public int getTaskCompleted() { return taskCompleted; }
        public bool getIsAvailable() { return isAvailable; }

        public void setExperienceYears(int ey)
        {
            if (ey < 0)
                throw new InvalidDataException("Experience years cannot be negative.");
            experienceYars = ey;
        }
        public void setTaskCompleted(int tc)
        {
            if (tc < 0)
                throw new InvalidDataException("Experience years cannot be negative.");
            experienceYars = tc;

        }
        public void setIsAvailable(bool ia) { isAvailable = ia; }

        public void AddTask()
        {
            taskCompleted++;
        }
        public virtual double CalculatePerformance()
        {
            if (experienceYars == 0)
            { 
                return 0;
            }
            else
            {
                return taskCompleted / experienceYars;
            }
        }
        public abstract void PerformTask();
        public override bool Validate()
        {
            if (base.Validate() && experienceYars >= 0 && taskCompleted >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
