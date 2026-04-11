using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    public interface IFilehandler
    {
        void save(string path);

        void load(string path);

    }
}
