﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApplication
{
    class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter a width for the window to be calculated: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter a height for the window to be calculated: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            return;
        }
    }
}
