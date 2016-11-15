using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Swapper
    {
        static void Main(string[] args)
        {
            var minliste = new List<string>();
            minliste.Add("Sukker");
            minliste.Add("Mel");
            minliste.Add("Mælk");

            Debug.WriteLine("1: " + minliste[0] + ", 2: " + minliste[1] + ", 3: " + minliste[2]);
            var a = minliste[0];
            var b = minliste[1];
            var c = minliste[2];
            Swap<string>(ref a, ref b, ref c);
            Debug.WriteLine("1: " + a + ", 2: " + b + ", 3: " + c);

            Reverse<string>(minliste);
            Debug.WriteLine("1: " + minliste[0] + ", 2: " + minliste[1] + ", 3: " + minliste[2]);

            var strengliste = new List<string>(); // Laver generisk liste med strenge
            var talliste = new List<int>(); // Laver generisk liste med tal

            for (int i = 0; i < 5; i++) // Udskriver ...
            {
                strengliste.Add("Jul" + i);
                talliste.Add(i);
                Debug.WriteLine(strengliste[i]);
                Debug.WriteLine(talliste[i]);
            }
        }

        static void Swap<T>(ref T lhs, ref T mid, ref T rhs) // Bytter om på varerne opad
        {
            T temp;
            temp = lhs;
            lhs = mid;
            mid = rhs;
            rhs = temp;
        }
        static void Reverse<T>(List<T> oldList) // Burde vende ordenen på varerne
        {
            var newList = new List<T>();
            foreach (T t in oldList)
            {
                newList.Add(t);
            }
            oldList = newList;
        }
    }
}
