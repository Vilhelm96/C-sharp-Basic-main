using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3v2
{
    /// <summary>
    /// Class that calculates the BMI algorithm according to the Metric units and the US units. Also stores
    /// name, height and weight of the user.
    /// </summary>
    class CalorieCalculator
    {
        private String name = "No name";
        private double height;
        private double weight;

        public void setName (String name)
        {
            this.name = name;
        }
        public String getName ()
        {
            return name;
        }

        public void setHeight (double height)
        {
            this.height = height;
        }
        public double getHeight ()
        {
            return height;
        }

        public void setWeight (double weight)
        {
            this.weight = weight;
        }
        public double getWeight ()
        {
            return weight;
        }

        /// <summary>
        /// Calculates the BMI according to the metric units. Round of the BMI to two decimals using
        /// Math.Round.
        /// </summary>
        /// <returns></returns>
        public double bmiAlgorithmMetricUnits()
        {
            return Math.Round((getWeight() / Math.Pow(getHeight(), 2)), 2);
        }

        /// <summary>
        /// Calculates the BMI according to the Us units. Round of the BMI to two decimals using
        /// Math.Round.
        /// </summary>
        /// <returns></returns>
        public double bmiAlgorithmUsUnits()
        {
            return Math.Round((getWeight() / Math.Pow(getHeight(), 2) * 703.0), 2);
        }
    }
}
