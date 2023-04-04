using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************************************************************
 * Author: Vilhelm Park
 * Date: 2020-09-07
 * Description: This class has getters and setters for the private fields in the plant. 
 *              We have a method that reads input and sets the values in the private fields.
 *              Then we have a method for output the private fields in a nice manner.
 *              Finally we have a method where we just return the plant values as a string,
 *              since there is a chance that a object such as this needs to be saved in a 
 *              database and just having the plant information with a method helps to save 
 *              code lines.
 *******************************************************************************************/

namespace PlantApplication
{
    class Plant
    {
        private string name;
        private string latinName;
        private string description;
        private int generalHeight;
        private bool survivesWinter;

        private void setName(string plantName)
        {
            name = plantName;
        }

        private void setLatinName(string latName)
        {
            latinName = latName;
        }

        private void setDescription(string desc)
        {
            description = desc;
        }

        private void setHeight(int height)
        {
            generalHeight = height;
        }

        private void setIfSurvivesWinter(bool surWinter)
        {
            survivesWinter = surWinter;
        }

        public string getName()
        {
            return name;
        }

        public string getLatinName()
        {
            return latinName;
        }

        public string getDescription()
        {
            return description;
        }

        public int getGeneralHeight()
        {
            return generalHeight;
        }

        public bool getSurvivesWinter()
        {
            return survivesWinter;
        }

        public void inputPlantValues()
        {
            Console.Write("What's the plants name? \nEnter name: ");
            setName(Console.ReadLine());
            Console.Write("What's the latin name of " + name + "? \nEnter latin name: ");
            setLatinName(Console.ReadLine());
            Console.Write("Give a short description of the plant? \nEnter short description: ");
            setDescription(Console.ReadLine());
            Console.Write("What's the general height of the plant " + name + "? \nEnter general height in cm: ");
            string heightString = Console.ReadLine();
            setHeight(int.Parse(heightString));
            Console.Write("Does the plant survive winter? \nYes or no: ");
            string survivingWinter = Console.ReadLine();

            if (survivingWinter == "Yes" || survivingWinter == "yes")
            {
                survivesWinter = true;
            }
            else
            {
                survivesWinter = false;
            }
        }

        public void outputPlant()
        {
            Console.WriteLine("---------------------------------");
            Console.Write("Name: " + getName() + "\nLatin name: " + getLatinName()
                + "\nShort description: " + getDescription() + "\nGeneral height (cm): " + 
                getGeneralHeight() + "\nThe plant ");

            if (getSurvivesWinter() == true)
            {
                Console.Write("does survive winters!\n---------------------------------\n");
            }
            else
            {
                Console.Write("doesn't sadly survive winters!\n---------------------------------\n");
            }
        }

        public string plantToString()
        {
            string thePlant = getName() + "--" + getLatinName() + "--" + getDescription()
                + "--" + getGeneralHeight() + "--" + getSurvivesWinter();

            return thePlant;
        }
    }
}
