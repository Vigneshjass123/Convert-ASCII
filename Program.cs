﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                char c;
                Console.WriteLine("Enter a character: ");
                c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
                Console.ReadKey();
            }
        }
    }
}
       
        

    
    

