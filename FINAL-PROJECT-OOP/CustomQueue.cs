using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class CustomQueue<T> : IQuequeable<T>
    {
        private T[] Qaaray;
        private int count;

        public CustomQueue(int capacity)
        {
            if (capacity <= 0) 
                throw new EmptyStructureException("Capacity must be greater than zero.");

            Qaaray = new T[capacity];
            count = 0;
        }

        public int Countt { get { return count; } }

        public void Enqueue(T item)
        {
            if (count >= Qaaray.Length)
                throw new OverCapacityException("Queue is at full capacity.");
            Qaaray[count] = item;
            count++;
        }

        public T Dequeque()
        {
            if (count == 0)
                throw new EmptyStructureException("Queue is empty.");

            T item = Qaaray[0];
            for (int i = 1; i < count; i++)
            {
                Qaaray[i - 1] = Qaaray[i];
            }
            count--;
            return item;
        }

        public T Peek()
        {
            if (count == 0)
                throw new EmptyStructureException("Queque is empty. Cannot peek");
            return Qaaray[0];
            
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
         





    }
}
