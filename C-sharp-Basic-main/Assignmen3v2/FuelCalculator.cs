using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3v2
{
    /// <summary>
    /// Class that calculates distance that a user travel, the fuel consumption and the cost per kilometer.
    /// </summary>
    class FuelCalculator
    {
        private double distance;
        private double consumptionLiterPerKm;
        private double consumptionKmPerLiter;
        private double consumptionLiterPerMetricMile;
        private double consumptionLiterPerSwedishMile;
        private double costPerKm;

        /// <summary>
        /// Calculates the distance that is traveled.
        /// </summary>
        /// <param name="currentReading"></param>
        /// <param name="previousReading"></param>
        public void setDistance(double currentReading, double previousReading)
        {
            this.distance = Math.Round((currentReading - previousReading), 2);
        }
        public double getDistance ()
        {
            return distance;
        }

        /// <summary>
        /// Sets the consumption of fuel in liters per kilometer.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="fuelAmount"></param>
        public void setConsumptionLiterPerKm(double distance, double fuelAmount)
        {
            this.consumptionLiterPerKm = Math.Round((fuelAmount / distance), 2);
        }
        public double getConsumptionLiterPerKm()
        {
            return consumptionLiterPerKm;
        }

        /// <summary>
        /// Sets the consumption of fuel for each kilometer.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="fuelAmount"></param>
        public void setConsumptionKmPerLiter(double distance, double fuelAmount)
        {
            this.consumptionKmPerLiter = Math.Round((distance / fuelAmount), 2);
        }
        public double getConsumptionKmPerLiter()
        {
            return consumptionKmPerLiter;
        }

        /// <summary>
        /// Sets the consumption of fuel per metric mile.
        /// </summary>
        /// <param name="fuelAmount"></param>
        public void setConsumptionLiterPerMetricMile(double fuelAmount)
        {
            const double kmToMileFactor = 0.621371192;
            this.consumptionLiterPerMetricMile = Math.Round((getConsumptionLiterPerKm() / kmToMileFactor), 2);
        }
        public double getConsumptionLiterPerMetricMile()
        {
            return consumptionLiterPerMetricMile;
        }

        /// <summary>
        /// Sets the consumption of liters per swedish mile.
        /// </summary>
        /// <param name="fuelAmount"></param>
        public void setConsumptionLiterPerSwedishMile(double fuelAmount)
        {
            this.consumptionLiterPerSwedishMile = Math.Round((getConsumptionLiterPerKm() * 10), 2);
        }
        public double getConsumptionLiterPerSwedishMile()
        {
            return consumptionLiterPerSwedishMile;
        }

        /// <summary>
        /// Sets cost per travelled kilometer.
        /// </summary>
        /// <param name="pricePerLiter"></param>
        public void setCostPerKm(double pricePerLiter)
        {
            this.costPerKm = Math.Round((getConsumptionLiterPerKm() * pricePerLiter), 2);
        }
        public double getCostPerKm()
        {
            return costPerKm;
        }
    }
}
