using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    internal interface IQuequeable<T>
    {
        void Enqueue(T item);

        T Dequeque();

        T Peek();

        bool IsEmpty();
    
            
    }
}
