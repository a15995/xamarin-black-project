using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int x = 32;
            List<int> evenNumbers = new List<int>();
            ArrayList old = new ArrayList();
            Dictionary<int, bool> isEvenNumberDict = new Dictionary<int, bool>();
            
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0) // Hvis restværdi ved division med 2 er nul
                {
                    evenNumbers.Add(i); // Tilføj til listen over lige numre
                    old.Add(i);
                    isEvenNumberDict.Add(i, true); // Skriv true til, at tallet på listen er lige
                }
                else
                {
                    isEvenNumberDict.Add(i, false); // Skriv false til, at tallet på listen er lige
                }
            }

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            foreach (var entry in isEvenNumberDict)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }

            Console.WriteLine("First item on list: " + evenNumbers[0]);
            Console.WriteLine("Is 3 an even number? " + isEvenNumberDict[3]);

            Console.ReadKey();
        }
    }
}
