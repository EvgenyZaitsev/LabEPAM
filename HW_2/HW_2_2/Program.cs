﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some data (numbers, strings).");
            Console.WriteLine("If you don't want to enter data anymore, tape /e");
            DoSomeMagic();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void DoSomeMagic()
        {
            Text text = new Text();
            text.Read();
            text.SetType();
            text.PrintInteger();
            text.PrintDouble();
            text.PrintString();
        }
    }
}