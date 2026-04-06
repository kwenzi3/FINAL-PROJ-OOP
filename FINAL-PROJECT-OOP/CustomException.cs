using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
   public class InvalidDataException : Exception
   {
        public InvalidDataException() : base() { }

        public InvalidDataException(string message) : base(message) { }
       
   }
    public class OverCapacityException : Exception
    {
        public OverCapacityException() : base() { }

        public OverCapacityException(string message) : base(message) { }

    }
    public class EmptyStructureException : Exception
    {
        public EmptyStructureException() : base() { }

        public EmptyStructureException(string message) : base(message) { }

    }
}
