using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;
//this code will initialize the project
namespace part1_programming_poe
{
    public class Program
    {

        static void Main(string[] args)
        {
            //createating an instance for voice massage class
            new voice_massage() { };
            new logo_image() { };

            

            //setting the color to br white 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=======================================================================================");

            // changing the color for AI bot
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Hi welcome to the cybersecurity awwreness bot fell free to ask e questions! ");
            //changing the color 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=======================================================================================");
           

            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}


