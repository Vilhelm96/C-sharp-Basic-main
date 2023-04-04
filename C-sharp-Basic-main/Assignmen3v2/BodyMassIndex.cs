using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3v2
{
    /// <summary>
    /// Class that shows what body mass index the user belongs to.
    /// </summary>
    class BodyMassIndex
    {
        private String weightCategory;

        /// <summary>
        /// Sets what the user is according to the BMI scale.
        /// </summary>
        /// <param name="bmiValue"></param>
        public void setWeightCategory(double bmiValue)
        {
            if (bmiValue < 18.5)
            {
                this.weightCategory = "Underweight";
            }
            else if (bmiValue > 18.5 && bmiValue < 25.0)
            {
                this.weightCategory = "Normal weight";
            }
            else if (bmiValue > 25.0 && bmiValue < 30.0)
            {
                this.weightCategory = "Overweight (pre obesity)";
            }
            else if (bmiValue > 30.0 && bmiValue < 35.0)
            {
                this.weightCategory = "Obesity class I";
            }
            else if (bmiValue > 35.0 && bmiValue < 40.0)
            {
                this.weightCategory = "Obesity class II";
            }
            else
            {
                this.weightCategory = "Obesity class III";
            }
        }

        public String getWeightCategory()
        {
            return weightCategory;
        }
    }
}
