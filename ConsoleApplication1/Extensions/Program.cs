using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main()
        {
            int x = 23;
            Debug.WriteLine(x.Times1000()); // I stedet for alm. metode (kaldes i parantes) kan man kalde objektet (extension)
        }
    }
}
