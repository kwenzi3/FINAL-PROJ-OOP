using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{

    internal class Package
    {

        private int id;
        private double weight;
        private int priorityLevel;
        private string destination;
        private string status;

        public Package()
        {
            id=0; 
            weight=0;
            priorityLevel=1;
            destination="***";
            status = "***";

        }
    

        public Package(int id, double w, int pl, string d, string s)
        {
            if (w < 0)
                throw new InvalidDataException("The wight should not be below 0!");

            if (pl <1 || pl >5)
                throw new InvalidDataException("The priority level can only be between 1 to 5");

            if (string.IsNullOrEmpty(d))
                throw new InvalidDataException("The destination can't be null or empty!");

            this.id = id;
            weight = w;
            priorityLevel = pl;
            destination = d;
            status = s;
        }

        public int getId() 
        { 
            return id; 
        }

        public void setID(int id)
        {
            if (id == 0)
                throw new InvalidDataException("The id should be valid");
            this.id = id;
        }

        public double getWeight() 
        {
            return weight; 
        }

        public void SetWeight(double w)
        {
            if (w < 0)
                throw new InvalidDataException("The wight should not be below 0!");
            weight = w;
        }
        public int getPriorityLevel() 
        {
            return priorityLevel; 
        }
        public void SetPriorityLevel(int pl)
        {
            if (pl < 0 || pl > 5)
                throw new InvalidDataException("The priority level must be between 1 to 5");
            priorityLevel = pl;
        }
        public string getDestination() 
        {
            return destination; 
        }

        public void SetDestination(string d)
        {
            if (string.IsNullOrEmpty(d))
                throw new InvalidDataException("THE DESTINATION CANNOT REMAIN NULL OR EMTYY");
            destination = d;
        }
        public string getStatus() //CHECK THIS
        {
            return status; 
        }   

        public void setStatus(string S)  // CHECK THIS AGAIN PLEASE
        {
            status = S; 
        }

        public double CalculateotyScoreouble ()
        {
            return; //create formula
        }

        public void UpdateStatus (string newStatus) //edit this
        {
            if (newStatus != "pending" && newStatus != "assigned" && newStatus != "delivery")
                throw new InvalidDataException("The status can only be --> (pending/assigned/delivery)");



            status = newStatus;
        }
        

        public bool IsHeavy() // edit this
        {

        }
    }
}
