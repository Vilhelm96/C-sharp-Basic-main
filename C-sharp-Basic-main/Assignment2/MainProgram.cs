using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************************************************************
 * Author: Vilhelm Park
 * Date: 2020-09-23
 * Description: This class use the TemperatureConverter class to display the applications 
 *              functions.
 *******************************************************************************************/

namespace Assignment2
{
    class MainProgram
    {
        static void Main(string [] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Title = "Temperature converter";
            TemperatureConverter temperatureConverter = new TemperatureConverter(); //Calls for the TemperatureConverter class.
            temperatureConverter.Start();   //Runs the application.
            Console.ReadLine();

        }
    }
}
