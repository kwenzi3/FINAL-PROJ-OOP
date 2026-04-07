using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public class Driver : Worker
    {
        private string licenseType;

        public Driver() : base()
        {
            licenseType = string.Empty;
        }
        public Driver(int wi, string n, int ey, int tc, bool ia, string lt) :
            base(wi, n, ey, tc, ia )
        {
            if (string.IsNullOrEmpty(lt))
                throw new EmptyStructureException("License type cannot be null or empty.");


            licenseType = lt;
        }  
        
        public string GetLicenseType() { return licenseType; }
        public void GetLicense(string lt)
        {
            if (string.IsNullOrEmpty(lt))
                throw new EmptyStructureException("License type cannot be null or empty.");

            licenseType = lt;
        }

        public override void Display() 
        { 
            base.Display();
            Console.WriteLine("License Type: " + licenseType);
        }
        
  
        public override void PerformTask()
        {
            Console.WriteLine("Driving deliveries");

        }
    }
}
