using System;
using System.Collections.Generic;
using System.Text;

namespace ERogersProgram10
{
    #region "Enumeration"
    public enum LocationType
    {
        City,
        Suburb,
        Rural
    }
    #endregion
    class PropertyTax
    {
        #region "Properties"
        public readonly string OwnerName;
        public readonly int BuildingSqFt, LandSqFt, YearBuilt;
        public readonly LocationType PropertyLocation;

        public int BuildingAge { get; private set; }
        public decimal BuildingTax { get; private set; }
        public decimal LandTax { get; private set; }
        public decimal BuildingTaxDeduction { get; private set; }
        public decimal LandTaxDeduction { get; private set; }
        public decimal TotalPropertyTax { get; private set; }

        #endregion

        #region "Constructor"

        public PropertyTax (string name, int buildingSqFt, int landSqFt, int year, LocationType location)
        {
            OwnerName = name;
            BuildingSqFt = buildingSqFt;
            LandSqFt = landSqFt;
            YearBuilt = year;
            PropertyLocation = location;

            BuildingAge = DateTime.Now.Year - year;
            TotalPropertyTax = CalculateTotalPropertyTax();
        }

        #endregion

        #region "Instance Methods"

        private void CalculateBuildingTax(int buildingSqFt)
        {

            if (buildingSqFt >= 1 && buildingSqFt <= 1000)
            {
                BuildingTax = .91M * buildingSqFt;
            }
            else if (buildingSqFt >= 1001 && buildingSqFt <= 2000)
            {
                BuildingTax = 910M + .93M * (buildingSqFt - 1000);
            }
            else if (buildingSqFt >= 2001 && buildingSqFt <= 3000)
            {
                BuildingTax = 1840M + .95M * (buildingSqFt - 2000);
            }
            else if (buildingSqFt >= 3001 && buildingSqFt <= 4000)
            {
                BuildingTax = 2790M + .97M * (buildingSqFt - 3000);
            }
            else
            {
                BuildingTax = 3760M + 1.01M * (buildingSqFt - 4000);
            }

        }

        private void CalculateLandTax (int landSqFt)
        {
            
            if (landSqFt >= 1 && landSqFt <= 10000)
            {
                LandTax = .06M * landSqFt;
            }
            else if (landSqFt >= 10001 && landSqFt <= 20000)
            {
                LandTax = 600M + .08M * (landSqFt - 10000);
            }
            else if (landSqFt >= 20001 && landSqFt <= 30000)
            {
                LandTax = 1400M + .1M * (landSqFt - 20000); 
            }
            else if (landSqFt >= 30001 && landSqFt <= 40000)
            {
                LandTax = 2400M + .12M * (landSqFt - 30000); 
            }
            else
            {
                LandTax = 3600M + .15M * (landSqFt - 40000);
            }

        }

        private void CalculateBuildingTaxDeduction(int buildingAge, decimal buildingTax)
        {
         

            if (BuildingAge > 12)
            {
                BuildingTaxDeduction = buildingAge * ((decimal)(Convert.ToDouble(.005)) * buildingTax);
            }
            else
            {
                BuildingTaxDeduction = 0;
            }

        }

        private void CalculateLandTaxDeduction(decimal landSqFt, decimal landTax)
        {
            if (PropertyLocation == LocationType.Rural)
            {
                if (landSqFt <= 25000)
                {
                    LandTaxDeduction = (decimal)(Convert.ToDouble(.0235)) * landTax;
                }
                else if (landSqFt > 25000)
                {
                    LandTaxDeduction = (decimal)(Convert.ToDouble(.0165)) * landTax; 
                }
                else
                {
                    LandTaxDeduction = 0;
                }
            }

        }
        private decimal CalculateTotalPropertyTax()
        {
         
            // we are asked to, in this method do the following which I'm not sure how to do: 
            //To call the private methods that calculate and set the building and land taxes 
            //To conditionally (i.e., if the building age > 12) call the method that calculates and sets the building tax deduction 
            //To conditionally (i.e., if the property’s location is rural) call the method that calculates and sets the land tax deduction 
            //To calculate and set the total property tax (building tax + land tax – building tax deduction – land tax deduction).  
            
            TotalPropertyTax = BuildingTax + LandTax - BuildingTaxDeduction - LandTaxDeduction;

            return TotalPropertyTax;
        }

        #endregion
    }
}
