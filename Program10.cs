using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERogersProgram10
{
    public partial class Program10 : Form
    {

        public string name;
        public int buildingSqFt, landSqFt, year;
        public LocationType propertyLocation;
        public int buildingAge;
        public decimal buildingTax;
        public decimal landTax;
        public decimal buildingTaxDeduction;
        public decimal landTaxDeduction;
        public decimal TotalPropertyTax;
        private PropertyTax aPropertyTax; 

        public Program10()
        {
            InitializeComponent();
        }

        private void Program10_Load(object sender, EventArgs e)
        {
            // set the max value of Year Build to the current Year

            numYearBuilt.Maximum = DateTime.Today.Year;
        }

        private void btnCreatePropertyTax_Click(object sender, EventArgs e)
        {
            // Check owner name text box

            if (txtbxOwnersName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Owner's Name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error); txtbxOwnersName.Focus();
                return;
            }

            // call assign inputs to varialbe method

            AssignInputs();

            //instantiate object

            aPropertyTax = new PropertyTax(name, buildingSqFt, landSqFt, year, propertyLocation);

            DisplayTax();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for new inputs

            txtbxOwnersName.Clear();
            numBuildingSqFt.Value = numBuildingSqFt.Minimum;
            numLandSqFt.Value = numLandSqFt.Minimum;
            numYearBuilt.Value = numYearBuilt.Value = 2000;
            rbtnCity.Checked = true;
            rbtnSuburb.Checked = false;
            rbtnRural.Checked = false;
            lblResults.Text = null;

            //set focus
            txtbxOwnersName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignInputs()
        {
            name = txtbxOwnersName.Text;
            buildingSqFt = Convert.ToInt32(numBuildingSqFt.Value);
            landSqFt = Convert.ToInt32(numLandSqFt.Value);
            year = Convert.ToInt32(numYearBuilt.Value);

            //public LocationType propertyLocation;

            if (rbtnCity.Checked)
            {
                propertyLocation = LocationType.City;
            }
            else if (rbtnSuburb.Checked)
            {
                propertyLocation = LocationType.Suburb;
            }
            else
            {
                propertyLocation = LocationType.Rural;
            }

        }
        private void DisplayTax()
        {
            //prepare message to display

            string Tax = $"Building Age: {aPropertyTax.BuildingAge.ToString("n0")} \n Building Tax: {aPropertyTax.BuildingTax.ToString("c2")} \n Land Tax: {aPropertyTax.LandTax.ToString("c2")} \n Building Tax Deduction: {aPropertyTax.BuildingTaxDeduction.ToString("c2")} \n Land Tax Deduction: {aPropertyTax.LandTaxDeduction.ToString("c2")} \n Total Property Tax: {aPropertyTax.TotalPropertyTax.ToString("c2")}";

            //dispaly the result in lable
            lblResults.Text = Tax;
        }
    }
}
//building age, buiding tax, land tax, buiding tax deduction, land tax deduction, total property tax
