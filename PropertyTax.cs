using System;
using System.Collections.Generic;
using System.Text;

namespace ERogersProgram10
{
    #region "Enumeration"
    public enum LocationType
    {
        City = 1,
        Suburb = 2,
        Rural = 3
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
            CalculateTotalPropertyTax();
   
        }

        #endregion

        #region "Instance Methods"

        private void CalculateBuildingTax(int buildingSqFt)
        {
            decimal BuildingTax; 

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
            decimal LandTax;

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

        private void CalculateBuildingTaxDeduction(int BuildingAge, decimal BuildingTax)
        {
         
            decimal BuildingTaxDeduction; 

            if (BuildingAge > 12)
            {
                BuildingTaxDeduction = BuildingAge * ((decimal)(Convert.ToDouble(.005)) * BuildingTax);
            }
            else
            {
                BuildingTaxDeduction = 0;
            }

        }

        private void CalculateLandTaxDeduction(decimal landSqFt, decimal LandTax)
        {
            if (PropertyLocation == LocationType.Rural)
            {
                if (landSqFt <= 25000)
                {
                    LandTaxDeduction = (decimal)(Convert.ToDouble(.0235)) * LandTax;
                }
                else if (landSqFt > 25000)
                {
                    LandTaxDeduction = (decimal)(Convert.ToDouble(.0165)) * LandTax; 
                }
                else
                {
                    LandTaxDeduction = 0;
                }
            }

        }

        private decimal CalculateTotalPropertyTax()
        {
            

        }

        #endregion
    }
}
