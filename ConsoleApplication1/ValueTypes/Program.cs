﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main()
        {
            MyNumber x = new MyNumber();
            x.value = 3;

            AddTo(x, 1); // Allokerer stackplads til metoden

            Console.WriteLine("AddTo MyNumber(3), 1 = " + x);
            Console.ReadKey();
        }

        static void AddTo(MyNumber x, int y) // Pegepind til MyNumber som kommer ned på stacken
        {
            x.value += y;
        }
    }

    public struct MyNumber
    {
        public int value;

        public override string ToString()
        {
            return value.ToString();
        }
    }

}