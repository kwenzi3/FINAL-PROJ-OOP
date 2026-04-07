using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public abstract class Entity
    {
        private int id;
        private string name;
        private DateTime createDate;

        public Entity()
        {
            id = 0;
            name = string.Empty;    
            createDate = DateTime.Now;
        }

        public Entity(string n)
        {
            if (id == 0)    
                throw new InvalidDataException("ID cannot be 0");
            if(string.IsNullOrEmpty(n))
                throw new InvalidDataException("Name cannot be null or empty.");

           
            name = n;
            createDate = DateTime.Now;
        }

       
        //idk if i should include this (ask teacher)
        //public int getId() { return id; }
        public string getName() { return name; }

        public void setName(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new InvalidDataException("Name cannot be null or empty.");
            name = n;
        }
        //public void setId(int id)
        //{
        //    if (id == 0)
        //        throw new InvalidDataException("ID cannot be 0");
        //    this.id = id;
        //}

        public DateTime getCreateDate() { return createDate; }

        public virtual bool Validate()
        {
            if (id == 0 && string.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

        public abstract void Display();
        
        

        
    }
}
