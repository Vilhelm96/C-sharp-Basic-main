using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************************************************************
 * Author: Vilhelm Park
 * Date: 2020-09-23
 * Description: This class has multiple methods which handles the convertion from celsius to
 *              fahrenheit and vice versa. This class also includes some methods which
 *              handles the output of some convertions from fahrenheit to celsius and vice
 *              versa. Then finally we have a menu method which displays the options for the 
 *              application and controls so that the values can only be within the parameter
 *              0-2.
 *******************************************************************************************/
namespace Assignment2
{
    class TemperatureConverter
    {
        /// <summary>
        /// This method displays the convertion from celsius to fahrenheit with the celsius values being 0-100, 
        /// we will only see the output with 5 celsius gap. So we have 0 celsius then 5, then 10 so on so forth.
        /// </summary>
        private void CalculateCelsiusToFahrenheit()
        {
            for(double celsius = 0.00; celsius <= 100.00; celsius += 5)
            {
                //Format the string so that it has a tab in the beginning then we have the two double values with 2 decimals.
                String temperatureString = String.Format("\t {0:N} C = {1:N} F", celsius, CelsiusToFahrenheit(celsius));
                Console.WriteLine(temperatureString);
            }

            Console.WriteLine();
        }
        /// <summary>
        /// This method displays the convertion from fahrenheit to celsius with the fahrenheit values being between 32-212, 
        /// we will only see the output with 9 fahrenheit gap. So we have 32 fahrenheit then 41, then 50 so on so forth.
        /// </summary>
        private void CalculateFahrenheitToCelsius()
        {
            for (double fahrenheit = 32.00; fahrenheit <= 212.00; fahrenheit += 9)
            {
                //Format the string so that it has a tab in the beginning then we have the two double values with 2 decimals.
                String temperatureString = String.Format("\t {0:N} F = {1:N} C", fahrenheit, FahrenheitToCelsius(fahrenheit));
                Console.WriteLine(temperatureString);
            }

            Console.WriteLine();

        }

        /// <summary>
        /// This method calculates the convertion from celsius to fahrenheit.
        /// </summary>
        /// <param name="celsius">The celsius value to convert to fahrenheit.</param>
        /// <returns>The fahrenheit value.</returns>
        private double CelsiusToFahrenheit(double celsius)
        {
            return (9.00 / 5.00) * celsius + 32.00;
        }

        /// <summary>
        /// Displays the menu for the application, the menu is in a loop which will continue until the user choose to exit the 
        /// application by inputing 0. We use the Input class that was given to us this assignment to make sure that the user input
        /// a integer value and that the value is between the acceptable parameter 0-2. Then depending on the input from the user
        /// we call on either CalculateCelsiusToFahrenheit or CalculateFahrenheitToCelsius or simply write a exit message when the
        /// user choose to exit the application.
        /// </summary>
        private void DisplayMenu()
        {
            int menuOption;

            do
            {


                Console.Write("********************************************\n" +
                              "                 MAIN MENU\n" +
                              "********************************************\n" +
                              "Convert Fahrenheit to Celsius: 1\n" +
                              "Convert Celsius to Fahrenheit: 2\n" +
                              "Exit the Converter           : 0\n" +
                              "********************************************\n");
                do
                {
                    menuOption = Input.ReadIntegerConsole("Your choice: ");

                } while (menuOption < 0 || menuOption > 2);

                if (menuOption == 1)
                {
                    CalculateFahrenheitToCelsius();
                }
                else if(menuOption == 2)
                {
                    CalculateCelsiusToFahrenheit();
                }
                else
                {
                    Console.WriteLine("Exiting application");
                }
                
            } while (menuOption != 0);
        }
        /// <summary>
        /// This method calculates the convertion from fahrenheit to celsius.
        /// </summary>
        /// <param name="fahrenheit">The fahrenheit value to convert to celsius.</param>
        /// <returns>The celsius value.</returns>
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (5.00 / 9.00) * (fahrenheit - 32.00);
        }
        
        public void Start()
        {
            DisplayMenu();
        }
    }
}
