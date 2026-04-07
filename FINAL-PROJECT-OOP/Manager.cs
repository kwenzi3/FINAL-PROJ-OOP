using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public  class Manager : Worker
    {
        private int teamSize;


        public Manager()
        {
                teamSize = 0;
        }

        public Manager(string n,int id, int ey, int tc, bool ia, int ts) : base( n, id, ey, tc, ia)
        {
            if (ts < 0)
                throw new InvalidDataException("Team size cannot be negative.");
            teamSize = ts ;
        }

        public int GetTeamSize() { return teamSize; }   
        public void SetTeamSize(int ts)
        {
            if (ts < 0)
                throw new InvalidDataException("Team size cannot be negative.");
            teamSize = ts;
        }   

        public override void PerformTask()
        {
            Console.WriteLine("Assign tasks to workers");
           
        }

        public string FindBestWorker(List<Worker> workers)
        {
            if (workers == null || workers.Count == 0)
                throw new EmptyStructureException("Worker list cannot be null or empty.");


            Worker bestWorker = workers[0];
            double bestPerformance = 0;

            foreach (var worker in workers)
            {
                double performance = worker.CalculatePerformance();
                if (performance > bestPerformance)
                {
                    bestPerformance = performance;
                    bestWorker = worker;
                }
            }

            if (bestWorker != null)
            {

                Console.WriteLine("\n--Best worker--");
                bestWorker.Display();
                return "Best worker: " + bestWorker.getName() +
                    "\nPerformance: " + bestPerformance;



            }
            else
            {
                return "Best worker is not found!";
            }
        }
    }
}
