using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class MyExtensions
    {
        public static int Times1000(this int myThousands) // Method extension - defineres med "this"
        {
            int x = (myThousands * 1000);
            return x;             
        }
    }
}
