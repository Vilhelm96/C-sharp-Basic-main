using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmen3v2
{
    public partial class MainForm : Form
    {
        private CalorieCalculator calorieCalculator = new CalorieCalculator();
        private FuelCalculator fuelCalculator = new FuelCalculator();
        private BodyMassIndex bodyMassIndex = new BodyMassIndex();
        private UnitTypes unitTypes;

        /// <summary>
        /// Main form of the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initialize the Form.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Universal Calulator";
            fuelBox.Text = "Fuel";
            outputCurrentOdometer.Text = "Current odometer reading (km)";
            outputPreviousOdometer.Text = "Previous odometer reading (km)";
            outputCurrentAmountOfFuel.Text = "Current amount of fuel tanked (liters)";
            outputPricePerLiter.Text = "Price per liter";
            calculatorFuel.Text = "Calculate";

            resultFuelBox.Text = "Results";
            outputConsumptionKmLit.Text = "Fuel consumption (km/lit)";
            outputConsumptionLitKm.Text = "Fuel consumption (lit/km)";
            outputConsumptionLitMetric.Text = "Fuel consumption (lit/metric mile)";
            outputConsumptionLitSwedish.Text = "Fuelconsumption (lit/Swe mil)";
            outputCostPerKm.Text = "Cost per kilometer";

            bmiBox.Text = "BMI";
            outputYourName.Text = "Your name";
            outputHeight.Text = "Height (cm)";
            outputWeight.Text = "Weight (kg)";
            buttonMetricUnit.Text = "Metric Unit (kg, cm)";
            buttonMetricUnit.Checked = true;
            buttonUsUnit.Text = "US Unit (lb, inch)";
            calculatorBMI.Text = "Calculate";

            resultBmiBox.Text = "Results for " + calorieCalculator.getName();
            outputBMI.Text = "Your BMI";
            outputWeightCategory.Text = "Weight Category";
        }

        /// <summary>
        /// If user clicks button check if inputs are valid if they are ouput the fuel and cost values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculatorFuel_Click(object sender, EventArgs e)
        {
            bool ok = readInputFuel();

            if(ok)
            {
                showConsumptionKmLit.Text = fuelCalculator.getConsumptionKmPerLiter().ToString();
                showConsumptionLitKm.Text = fuelCalculator.getConsumptionLiterPerKm().ToString();
                showConsumptionLitMetric.Text = fuelCalculator.getConsumptionLiterPerMetricMile().ToString();
                showConsumptionLitSwe.Text = fuelCalculator.getConsumptionLiterPerSwedishMile().ToString();
                showCostPerKm.Text = fuelCalculator.getCostPerKm().ToString();
            }
        }

        /// <summary>
        /// If user clicks button check if inputs are valid if they are ouput the BMI and weight category of the
        /// user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculatorBMI_Click(object sender, EventArgs e)
        {
            bool ok = readInputBMI();

            if (ok)
            {
                resultBmiBox.Text = "Results for " + calorieCalculator.getName();

                if (unitTypes.Equals(UnitTypes.Metric))
                {

                    showBMI.Text = calorieCalculator.bmiAlgorithmMetricUnits().ToString();
                    bodyMassIndex.setWeightCategory(calorieCalculator.bmiAlgorithmMetricUnits());
                    showWeightCategory.Text = bodyMassIndex.getWeightCategory().ToString();
                }
                else if(unitTypes.Equals(UnitTypes.American))
                {
                    showBMI.Text = calorieCalculator.bmiAlgorithmUsUnits().ToString();
                    bodyMassIndex.setWeightCategory(calorieCalculator.bmiAlgorithmUsUnits());
                    showWeightCategory.Text = bodyMassIndex.getWeightCategory().ToString();
                }
            }
        }

        /// <summary>
        /// Checks if the US unit radio button is pressed if it is set the enumeration to American and change the 
        /// output for height and weight to be accurate to the US unit system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            outputHeight.Text = "Height (feet)";
            outputWeight.Text = "Weight (lbs)";
            unitTypes = UnitTypes.American;
        }

        /// <summary>
        /// Checks if the metric unit radio button is pressed if it is set the enumeration to Metric and change the 
        /// output for height and weight to be accurate to the metric system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMetricUnit_CheckedChanged(object sender, EventArgs e)
        {
            outputHeight.Text = "Height (cm)";
            outputWeight.Text = "Weight (kg)";
            unitTypes = UnitTypes.Metric;
        }

        /// <summary>
        /// Checks the input for current and previous odometer and see if it is accurate.
        /// If it is set the distance.
        /// </summary>
        /// <returns></returns>
        private bool readInputOdometers()
        {
            double currentOdometer;
            double previousOdometer;
            bool ok1 = double.TryParse(inputCurrentOdometer.Text, out currentOdometer);
            bool ok2 = double.TryParse(inputPreviousOdometer.Text, out previousOdometer);

            if (ok1 && ok2)
            {
                if (currentOdometer > 0 && previousOdometer >= 0)
                {
                    fuelCalculator.setDistance(currentOdometer, previousOdometer);
                    return ok1;
                }
                else
                {
                    ok1 = false;
                }
            }
          
            return ok1;
        }

        /// <summary>
        /// Checks if input for current amount of fuel is accurate if it is set multiple different consumption values
        /// that varies depending on what algorithm we are using.
        /// </summary>
        /// <returns></returns>
        private bool readInputCurrentAmountFuel()
        {
            double currentFuel;
            bool ok = double.TryParse(inputCurrentAmountFuelTanked.Text, out currentFuel);
            if (ok)
            {
                if (currentFuel > 0)
                {
                    fuelCalculator.setConsumptionLiterPerKm(fuelCalculator.getDistance(), currentFuel);
                    fuelCalculator.setConsumptionKmPerLiter(fuelCalculator.getDistance(), currentFuel);
                    fuelCalculator.setConsumptionLiterPerMetricMile(currentFuel);
                    fuelCalculator.setConsumptionLiterPerSwedishMile(currentFuel);
                    return ok;
                }
                else
                {
                    ok = false;
                }
            }
            
            return ok;
        }

        /// <summary>
        /// Checks if input for cost per liter is valid and sets the cost per kilometer if it is.
        /// </summary>
        /// <returns></returns>
        private bool readInputPricePerLiter()
        {
            double pricePerLiter;
            bool ok = double.TryParse(inputPricePerLiter.Text, out pricePerLiter);

            if (ok)
            {
                if (pricePerLiter > 0)
                {
                    fuelCalculator.setCostPerKm(pricePerLiter);
                    return ok;
                }
                else
                {
                    ok = false;
                }
            }
            
            return ok;
        }

        /// <summary>
        /// Checks if the inputs in fuel box is valid.
        /// </summary>
        /// <returns></returns>
        private bool readInputFuel()
        {
            bool ok;
            if (readInputOdometers() && readInputCurrentAmountFuel() && readInputPricePerLiter())
            {
                ok = true;
            }
            else
            {
                ok = false;
            }

            if(!ok)
            {
                MessageBox.Show("Invalid inputs in fuel, try again!", "Error");
            }

            return ok;
        }

        /// <summary>
        /// Reads the input for height and checks if it is a valid value.
        /// </summary>
        /// <returns></returns>
        private bool readInputHeight ()
        {
            double height;
            bool ok = double.TryParse(inputHeight.Text, out height);

            if(ok)
            {
                if(height > 0)
                {
                    if(unitTypes.Equals(UnitTypes.Metric))
                    {
                        calorieCalculator.setHeight(Math.Round((height / 100), 2));
                    }
                    else
                    {
                        calorieCalculator.setHeight(Math.Round((height * 12.0), 2));
                    }
                }
                else
                {
                    ok = false;
                }
            }

            return ok;
        }

        /// <summary>
        /// Reads the input for weight and checks if it is a valid value.
        /// </summary>
        /// <returns></returns>
        private bool readInputWeight()
        {
            double weight;
            bool ok = double.TryParse(inputWeight.Text, out weight);

            if (ok)
            {
                if (weight > 0)
                {
                    calorieCalculator.setWeight(weight);                    
                }
                else
                {
                    ok = false;
                }
            }

            return ok;
        }

        /// <summary>
        /// Sets the name for the user.
        /// </summary>
        private void readInputName()
        {
            String name = inputName.Text.ToString();
            calorieCalculator.setName(name);
        }

        /// <summary>
        /// Checks if the inputs are accurate.
        /// </summary>
        /// <returns></returns>
        private bool readInputBMI()
        {
            bool ok;
            readInputName();

            if (readInputHeight() && readInputWeight())
            { 
                ok = true;
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid inputs in BMI, try again!", "Error");
            }

            return ok;
        }
    }
}
