using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************************************************************
 * Author: Vilhelm Park
 * Date: 2020-09-07
 * Description: This application calls for the plant object and input values to it and then
 *              outputs the values.
 *******************************************************************************************/

namespace PlantApplication
{
    class PlantMain
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Plant owner";
            Plant plant = new Plant();
            plant.inputPlantValues();
            plant.outputPlant();
            plant.plantToString();  //Just to show how it might be input in a database such as a text document.
            Console.Write("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
