
namespace ERogersProgram10
{
    partial class Program10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numLandSqFt = new System.Windows.Forms.NumericUpDown();
            this.numBuildingSqFt = new System.Windows.Forms.NumericUpDown();
            this.txtbxOwnersName = new System.Windows.Forms.TextBox();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.lblLandSqFt = new System.Windows.Forms.Label();
            this.lblBuildingSqFt = new System.Windows.Forms.Label();
            this.lblOwnersName = new System.Windows.Forms.Label();
            this.grbxPropertyLocation = new System.Windows.Forms.GroupBox();
            this.rbtnRural = new System.Windows.Forms.RadioButton();
            this.rbtnSuburb = new System.Windows.Forms.RadioButton();
            this.rbtnCity = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreatePropertyTax = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLandSqFt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuildingSqFt)).BeginInit();
            this.grbxPropertyLocation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(271, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Property Tax Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numLandSqFt);
            this.groupBox1.Controls.Add(this.numBuildingSqFt);
            this.groupBox1.Controls.Add(this.txtbxOwnersName);
            this.groupBox1.Controls.Add(this.lblYearBuilt);
            this.groupBox1.Controls.Add(this.lblLandSqFt);
            this.groupBox1.Controls.Add(this.lblBuildingSqFt);
            this.groupBox1.Controls.Add(this.lblOwnersName);
            this.groupBox1.Controls.Add(this.grbxPropertyLocation);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Data:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(212, 170);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1850,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numLandSqFt
            // 
            this.numLandSqFt.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numLandSqFt.Location = new System.Drawing.Point(212, 126);
            this.numLandSqFt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLandSqFt.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLandSqFt.Name = "numLandSqFt";
            this.numLandSqFt.Size = new System.Drawing.Size(150, 27);
            this.numLandSqFt.TabIndex = 7;
            this.numLandSqFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLandSqFt.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numBuildingSqFt
            // 
            this.numBuildingSqFt.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBuildingSqFt.Location = new System.Drawing.Point(212, 82);
            this.numBuildingSqFt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBuildingSqFt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBuildingSqFt.Name = "numBuildingSqFt";
            this.numBuildingSqFt.Size = new System.Drawing.Size(150, 27);
            this.numBuildingSqFt.TabIndex = 6;
            this.numBuildingSqFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBuildingSqFt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtbxOwnersName
            // 
            this.txtbxOwnersName.Location = new System.Drawing.Point(212, 36);
            this.txtbxOwnersName.Name = "txtbxOwnersName";
            this.txtbxOwnersName.Size = new System.Drawing.Size(248, 27);
            this.txtbxOwnersName.TabIndex = 5;
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(22, 177);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(80, 20);
            this.lblYearBuilt.TabIndex = 4;
            this.lblYearBuilt.Text = "Year Built:";
            // 
            // lblLandSqFt
            // 
            this.lblLandSqFt.AutoSize = true;
            this.lblLandSqFt.Location = new System.Drawing.Point(22, 133);
            this.lblLandSqFt.Name = "lblLandSqFt";
            this.lblLandSqFt.Size = new System.Drawing.Size(160, 20);
            this.lblLandSqFt.TabIndex = 3;
            this.lblLandSqFt.Text = "Land Square Footage:";
            // 
            // lblBuildingSqFt
            // 
            this.lblBuildingSqFt.AutoSize = true;
            this.lblBuildingSqFt.Location = new System.Drawing.Point(22, 84);
            this.lblBuildingSqFt.Name = "lblBuildingSqFt";
            this.lblBuildingSqFt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBuildingSqFt.Size = new System.Drawing.Size(184, 20);
            this.lblBuildingSqFt.TabIndex = 2;
            this.lblBuildingSqFt.Text = "Building Square Footage:";
            // 
            // lblOwnersName
            // 
            this.lblOwnersName.AutoSize = true;
            this.lblOwnersName.Location = new System.Drawing.Point(22, 43);
            this.lblOwnersName.Name = "lblOwnersName";
            this.lblOwnersName.Size = new System.Drawing.Size(115, 20);
            this.lblOwnersName.TabIndex = 1;
            this.lblOwnersName.Text = "Owner\'s Name:";
            // 
            // grbxPropertyLocation
            // 
            this.grbxPropertyLocation.Controls.Add(this.rbtnRural);
            this.grbxPropertyLocation.Controls.Add(this.rbtnSuburb);
            this.grbxPropertyLocation.Controls.Add(this.rbtnCity);
            this.grbxPropertyLocation.Location = new System.Drawing.Point(22, 233);
            this.grbxPropertyLocation.Name = "grbxPropertyLocation";
            this.grbxPropertyLocation.Size = new System.Drawing.Size(286, 81);
            this.grbxPropertyLocation.TabIndex = 0;
            this.grbxPropertyLocation.TabStop = false;
            this.grbxPropertyLocation.Text = "Property Location:";
            // 
            // rbtnRural
            // 
            this.rbtnRural.AutoSize = true;
            this.rbtnRural.Location = new System.Drawing.Point(196, 41);
            this.rbtnRural.Name = "rbtnRural";
            this.rbtnRural.Size = new System.Drawing.Size(67, 24);
            this.rbtnRural.TabIndex = 2;
            this.rbtnRural.TabStop = true;
            this.rbtnRural.Text = "Rural";
            this.rbtnRural.UseVisualStyleBackColor = true;
            // 
            // rbtnSuburb
            // 
            this.rbtnSuburb.AutoSize = true;
            this.rbtnSuburb.Location = new System.Drawing.Point(86, 41);
            this.rbtnSuburb.Name = "rbtnSuburb";
            this.rbtnSuburb.Size = new System.Drawing.Size(80, 24);
            this.rbtnSuburb.TabIndex = 1;
            this.rbtnSuburb.TabStop = true;
            this.rbtnSuburb.Text = "Suburb";
            this.rbtnSuburb.UseVisualStyleBackColor = true;
            this.rbtnSuburb.UseWaitCursor = true;
            // 
            // rbtnCity
            // 
            this.rbtnCity.AutoSize = true;
            this.rbtnCity.Location = new System.Drawing.Point(6, 41);
            this.rbtnCity.Name = "rbtnCity";
            this.rbtnCity.Size = new System.Drawing.Size(57, 24);
            this.rbtnCity.TabIndex = 0;
            this.rbtnCity.TabStop = true;
            this.rbtnCity.Text = "City";
            this.rbtnCity.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnCreatePropertyTax);
            this.groupBox3.Location = new System.Drawing.Point(535, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(126, 69);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 69);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCreatePropertyTax
            // 
            this.btnCreatePropertyTax.Location = new System.Drawing.Point(19, 26);
            this.btnCreatePropertyTax.Name = "btnCreatePropertyTax";
            this.btnCreatePropertyTax.Size = new System.Drawing.Size(210, 37);
            this.btnCreatePropertyTax.TabIndex = 0;
            this.btnCreatePropertyTax.Text = "&Create Property Tax";
            this.btnCreatePropertyTax.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(535, 206);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(250, 209);
            this.lblResults.TabIndex = 3;
            // 
            // Program10
            // 
            this.AcceptButton = this.btnCreatePropertyTax;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Program10";
            this.Text = "Program10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLandSqFt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuildingSqFt)).EndInit();
            this.grbxPropertyLocation.ResumeLayout(false);
            this.grbxPropertyLocation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numLandSqFt;
        private System.Windows.Forms.NumericUpDown numBuildingSqFt;
        private System.Windows.Forms.TextBox txtbxOwnersName;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Label lblLandSqFt;
        private System.Windows.Forms.Label lblBuildingSqFt;
        private System.Windows.Forms.Label lblOwnersName;
        private System.Windows.Forms.GroupBox grbxPropertyLocation;
        private System.Windows.Forms.RadioButton rbtnRural;
        private System.Windows.Forms.RadioButton rbtnSuburb;
        private System.Windows.Forms.RadioButton rbtnCity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreatePropertyTax;
        private System.Windows.Forms.Label lblResults;
    }
}