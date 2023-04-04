namespace Assignmen3v2
{
    partial class MainForm
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
            this.bmiBox = new System.Windows.Forms.GroupBox();
            this.calculatorBMI = new System.Windows.Forms.Button();
            this.buttonUsUnit = new System.Windows.Forms.RadioButton();
            this.buttonMetricUnit = new System.Windows.Forms.RadioButton();
            this.inputHeight = new System.Windows.Forms.TextBox();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.outputWeight = new System.Windows.Forms.Label();
            this.outputHeight = new System.Windows.Forms.Label();
            this.outputYourName = new System.Windows.Forms.Label();
            this.resultFuelBox = new System.Windows.Forms.GroupBox();
            this.showConsumptionLitKm = new System.Windows.Forms.Label();
            this.showConsumptionLitMetric = new System.Windows.Forms.Label();
            this.showConsumptionLitSwe = new System.Windows.Forms.Label();
            this.showCostPerKm = new System.Windows.Forms.Label();
            this.showConsumptionKmLit = new System.Windows.Forms.Label();
            this.outputCostPerKm = new System.Windows.Forms.Label();
            this.outputConsumptionLitSwedish = new System.Windows.Forms.Label();
            this.outputConsumptionLitMetric = new System.Windows.Forms.Label();
            this.outputConsumptionLitKm = new System.Windows.Forms.Label();
            this.outputConsumptionKmLit = new System.Windows.Forms.Label();
            this.resultBmiBox = new System.Windows.Forms.GroupBox();
            this.normalBMI = new System.Windows.Forms.Label();
            this.outputNormalBMI = new System.Windows.Forms.Label();
            this.showWeightCategory = new System.Windows.Forms.Label();
            this.showBMI = new System.Windows.Forms.Label();
            this.outputWeightCategory = new System.Windows.Forms.Label();
            this.outputBMI = new System.Windows.Forms.Label();
            this.fuelBox = new System.Windows.Forms.GroupBox();
            this.inputCurrentAmountFuelTanked = new System.Windows.Forms.TextBox();
            this.inputPricePerLiter = new System.Windows.Forms.TextBox();
            this.inputPreviousOdometer = new System.Windows.Forms.TextBox();
            this.inputCurrentOdometer = new System.Windows.Forms.TextBox();
            this.calculatorFuel = new System.Windows.Forms.Button();
            this.outputPricePerLiter = new System.Windows.Forms.Label();
            this.outputCurrentAmountOfFuel = new System.Windows.Forms.Label();
            this.outputPreviousOdometer = new System.Windows.Forms.Label();
            this.outputCurrentOdometer = new System.Windows.Forms.Label();
            this.bmiBox.SuspendLayout();
            this.resultFuelBox.SuspendLayout();
            this.resultBmiBox.SuspendLayout();
            this.fuelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiBox
            // 
            this.bmiBox.Controls.Add(this.calculatorBMI);
            this.bmiBox.Controls.Add(this.buttonUsUnit);
            this.bmiBox.Controls.Add(this.buttonMetricUnit);
            this.bmiBox.Controls.Add(this.inputHeight);
            this.bmiBox.Controls.Add(this.inputWeight);
            this.bmiBox.Controls.Add(this.inputName);
            this.bmiBox.Controls.Add(this.outputWeight);
            this.bmiBox.Controls.Add(this.outputHeight);
            this.bmiBox.Controls.Add(this.outputYourName);
            this.bmiBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bmiBox.Location = new System.Drawing.Point(403, 12);
            this.bmiBox.Name = "bmiBox";
            this.bmiBox.Size = new System.Drawing.Size(427, 171);
            this.bmiBox.TabIndex = 8;
            this.bmiBox.TabStop = false;
            // 
            // calculatorBMI
            // 
            this.calculatorBMI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.calculatorBMI.Location = new System.Drawing.Point(140, 129);
            this.calculatorBMI.Name = "calculatorBMI";
            this.calculatorBMI.Size = new System.Drawing.Size(186, 32);
            this.calculatorBMI.TabIndex = 8;
            this.calculatorBMI.UseVisualStyleBackColor = true;
            this.calculatorBMI.Click += new System.EventHandler(this.calculatorBMI_Click);
            // 
            // buttonUsUnit
            // 
            this.buttonUsUnit.AutoSize = true;
            this.buttonUsUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUsUnit.Location = new System.Drawing.Point(253, 87);
            this.buttonUsUnit.Name = "buttonUsUnit";
            this.buttonUsUnit.Size = new System.Drawing.Size(21, 20);
            this.buttonUsUnit.TabIndex = 7;
            this.buttonUsUnit.TabStop = true;
            this.buttonUsUnit.UseVisualStyleBackColor = true;
            this.buttonUsUnit.CheckedChanged += new System.EventHandler(this.buttonUsUnit_CheckedChanged);
            // 
            // buttonMetricUnit
            // 
            this.buttonMetricUnit.AutoSize = true;
            this.buttonMetricUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMetricUnit.Location = new System.Drawing.Point(253, 55);
            this.buttonMetricUnit.Name = "buttonMetricUnit";
            this.buttonMetricUnit.Size = new System.Drawing.Size(21, 20);
            this.buttonMetricUnit.TabIndex = 6;
            this.buttonMetricUnit.TabStop = true;
            this.buttonMetricUnit.UseVisualStyleBackColor = true;
            this.buttonMetricUnit.CheckedChanged += new System.EventHandler(this.buttonMetricUnit_CheckedChanged);
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(140, 53);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(100, 26);
            this.inputHeight.TabIndex = 5;
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(140, 85);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(100, 26);
            this.inputWeight.TabIndex = 4;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(140, 21);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(239, 26);
            this.inputName.TabIndex = 3;
            // 
            // outputWeight
            // 
            this.outputWeight.AutoSize = true;
            this.outputWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputWeight.Location = new System.Drawing.Point(12, 91);
            this.outputWeight.Name = "outputWeight";
            this.outputWeight.Size = new System.Drawing.Size(0, 20);
            this.outputWeight.TabIndex = 2;
            // 
            // outputHeight
            // 
            this.outputHeight.AutoSize = true;
            this.outputHeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputHeight.Location = new System.Drawing.Point(12, 59);
            this.outputHeight.Name = "outputHeight";
            this.outputHeight.Size = new System.Drawing.Size(0, 20);
            this.outputHeight.TabIndex = 1;
            // 
            // outputYourName
            // 
            this.outputYourName.AutoSize = true;
            this.outputYourName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputYourName.Location = new System.Drawing.Point(12, 29);
            this.outputYourName.Name = "outputYourName";
            this.outputYourName.Size = new System.Drawing.Size(0, 20);
            this.outputYourName.TabIndex = 0;
            // 
            // resultFuelBox
            // 
            this.resultFuelBox.Controls.Add(this.showConsumptionLitKm);
            this.resultFuelBox.Controls.Add(this.showConsumptionLitMetric);
            this.resultFuelBox.Controls.Add(this.showConsumptionLitSwe);
            this.resultFuelBox.Controls.Add(this.showCostPerKm);
            this.resultFuelBox.Controls.Add(this.showConsumptionKmLit);
            this.resultFuelBox.Controls.Add(this.outputCostPerKm);
            this.resultFuelBox.Controls.Add(this.outputConsumptionLitSwedish);
            this.resultFuelBox.Controls.Add(this.outputConsumptionLitMetric);
            this.resultFuelBox.Controls.Add(this.outputConsumptionLitKm);
            this.resultFuelBox.Controls.Add(this.outputConsumptionKmLit);
            this.resultFuelBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultFuelBox.Location = new System.Drawing.Point(-6, 248);
            this.resultFuelBox.Name = "resultFuelBox";
            this.resultFuelBox.Size = new System.Drawing.Size(372, 193);
            this.resultFuelBox.TabIndex = 7;
            this.resultFuelBox.TabStop = false;
            // 
            // showConsumptionLitKm
            // 
            this.showConsumptionLitKm.AutoSize = true;
            this.showConsumptionLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showConsumptionLitKm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showConsumptionLitKm.Location = new System.Drawing.Point(261, 64);
            this.showConsumptionLitKm.Name = "showConsumptionLitKm";
            this.showConsumptionLitKm.Size = new System.Drawing.Size(2, 22);
            this.showConsumptionLitKm.TabIndex = 9;
            // 
            // showConsumptionLitMetric
            // 
            this.showConsumptionLitMetric.AutoSize = true;
            this.showConsumptionLitMetric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showConsumptionLitMetric.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showConsumptionLitMetric.Location = new System.Drawing.Point(260, 98);
            this.showConsumptionLitMetric.Name = "showConsumptionLitMetric";
            this.showConsumptionLitMetric.Size = new System.Drawing.Size(2, 22);
            this.showConsumptionLitMetric.TabIndex = 8;
            // 
            // showConsumptionLitSwe
            // 
            this.showConsumptionLitSwe.AutoSize = true;
            this.showConsumptionLitSwe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showConsumptionLitSwe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showConsumptionLitSwe.Location = new System.Drawing.Point(260, 130);
            this.showConsumptionLitSwe.Name = "showConsumptionLitSwe";
            this.showConsumptionLitSwe.Size = new System.Drawing.Size(2, 22);
            this.showConsumptionLitSwe.TabIndex = 7;
            // 
            // showCostPerKm
            // 
            this.showCostPerKm.AutoSize = true;
            this.showCostPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showCostPerKm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showCostPerKm.Location = new System.Drawing.Point(261, 162);
            this.showCostPerKm.Name = "showCostPerKm";
            this.showCostPerKm.Size = new System.Drawing.Size(2, 22);
            this.showCostPerKm.TabIndex = 6;
            // 
            // showConsumptionKmLit
            // 
            this.showConsumptionKmLit.AutoSize = true;
            this.showConsumptionKmLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showConsumptionKmLit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showConsumptionKmLit.Location = new System.Drawing.Point(261, 32);
            this.showConsumptionKmLit.Name = "showConsumptionKmLit";
            this.showConsumptionKmLit.Size = new System.Drawing.Size(2, 22);
            this.showConsumptionKmLit.TabIndex = 5;
            // 
            // outputCostPerKm
            // 
            this.outputCostPerKm.AutoSize = true;
            this.outputCostPerKm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputCostPerKm.Location = new System.Drawing.Point(15, 164);
            this.outputCostPerKm.Name = "outputCostPerKm";
            this.outputCostPerKm.Size = new System.Drawing.Size(0, 20);
            this.outputCostPerKm.TabIndex = 4;
            // 
            // outputConsumptionLitSwedish
            // 
            this.outputConsumptionLitSwedish.AutoSize = true;
            this.outputConsumptionLitSwedish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputConsumptionLitSwedish.Location = new System.Drawing.Point(15, 130);
            this.outputConsumptionLitSwedish.Name = "outputConsumptionLitSwedish";
            this.outputConsumptionLitSwedish.Size = new System.Drawing.Size(0, 20);
            this.outputConsumptionLitSwedish.TabIndex = 3;
            // 
            // outputConsumptionLitMetric
            // 
            this.outputConsumptionLitMetric.AutoSize = true;
            this.outputConsumptionLitMetric.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputConsumptionLitMetric.Location = new System.Drawing.Point(15, 100);
            this.outputConsumptionLitMetric.Name = "outputConsumptionLitMetric";
            this.outputConsumptionLitMetric.Size = new System.Drawing.Size(0, 20);
            this.outputConsumptionLitMetric.TabIndex = 2;
            // 
            // outputConsumptionLitKm
            // 
            this.outputConsumptionLitKm.AutoSize = true;
            this.outputConsumptionLitKm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputConsumptionLitKm.Location = new System.Drawing.Point(15, 66);
            this.outputConsumptionLitKm.Name = "outputConsumptionLitKm";
            this.outputConsumptionLitKm.Size = new System.Drawing.Size(0, 20);
            this.outputConsumptionLitKm.TabIndex = 1;
            // 
            // outputConsumptionKmLit
            // 
            this.outputConsumptionKmLit.AutoSize = true;
            this.outputConsumptionKmLit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputConsumptionKmLit.Location = new System.Drawing.Point(15, 34);
            this.outputConsumptionKmLit.Name = "outputConsumptionKmLit";
            this.outputConsumptionKmLit.Size = new System.Drawing.Size(0, 20);
            this.outputConsumptionKmLit.TabIndex = 0;
            // 
            // resultBmiBox
            // 
            this.resultBmiBox.Controls.Add(this.normalBMI);
            this.resultBmiBox.Controls.Add(this.outputNormalBMI);
            this.resultBmiBox.Controls.Add(this.showWeightCategory);
            this.resultBmiBox.Controls.Add(this.showBMI);
            this.resultBmiBox.Controls.Add(this.outputWeightCategory);
            this.resultBmiBox.Controls.Add(this.outputBMI);
            this.resultBmiBox.Location = new System.Drawing.Point(403, 186);
            this.resultBmiBox.Name = "resultBmiBox";
            this.resultBmiBox.Size = new System.Drawing.Size(427, 246);
            this.resultBmiBox.TabIndex = 6;
            this.resultBmiBox.TabStop = false;
            // 
            // normalBMI
            // 
            this.normalBMI.AutoSize = true;
            this.normalBMI.Location = new System.Drawing.Point(160, 166);
            this.normalBMI.Name = "normalBMI";
            this.normalBMI.Size = new System.Drawing.Size(0, 20);
            this.normalBMI.TabIndex = 5;
            // 
            // outputNormalBMI
            // 
            this.outputNormalBMI.AutoSize = true;
            this.outputNormalBMI.Location = new System.Drawing.Point(190, 149);
            this.outputNormalBMI.Name = "outputNormalBMI";
            this.outputNormalBMI.Size = new System.Drawing.Size(0, 20);
            this.outputNormalBMI.TabIndex = 4;
            // 
            // showWeightCategory
            // 
            this.showWeightCategory.AutoSize = true;
            this.showWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showWeightCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showWeightCategory.Location = new System.Drawing.Point(227, 96);
            this.showWeightCategory.Name = "showWeightCategory";
            this.showWeightCategory.Size = new System.Drawing.Size(2, 22);
            this.showWeightCategory.TabIndex = 3;
            // 
            // showBMI
            // 
            this.showBMI.AutoSize = true;
            this.showBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showBMI.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showBMI.Location = new System.Drawing.Point(227, 60);
            this.showBMI.Name = "showBMI";
            this.showBMI.Size = new System.Drawing.Size(2, 22);
            this.showBMI.TabIndex = 2;
            // 
            // outputWeightCategory
            // 
            this.outputWeightCategory.AutoSize = true;
            this.outputWeightCategory.Location = new System.Drawing.Point(32, 96);
            this.outputWeightCategory.Name = "outputWeightCategory";
            this.outputWeightCategory.Size = new System.Drawing.Size(0, 20);
            this.outputWeightCategory.TabIndex = 1;
            // 
            // outputBMI
            // 
            this.outputBMI.AutoSize = true;
            this.outputBMI.Location = new System.Drawing.Point(32, 60);
            this.outputBMI.Name = "outputBMI";
            this.outputBMI.Size = new System.Drawing.Size(0, 20);
            this.outputBMI.TabIndex = 0;
            // 
            // fuelBox
            // 
            this.fuelBox.Controls.Add(this.inputCurrentAmountFuelTanked);
            this.fuelBox.Controls.Add(this.inputPricePerLiter);
            this.fuelBox.Controls.Add(this.inputPreviousOdometer);
            this.fuelBox.Controls.Add(this.inputCurrentOdometer);
            this.fuelBox.Controls.Add(this.calculatorFuel);
            this.fuelBox.Controls.Add(this.outputPricePerLiter);
            this.fuelBox.Controls.Add(this.outputCurrentAmountOfFuel);
            this.fuelBox.Controls.Add(this.outputPreviousOdometer);
            this.fuelBox.Controls.Add(this.outputCurrentOdometer);
            this.fuelBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fuelBox.Location = new System.Drawing.Point(1, 9);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(377, 227);
            this.fuelBox.TabIndex = 5;
            this.fuelBox.TabStop = false;
            // 
            // inputCurrentAmountFuelTanked
            // 
            this.inputCurrentAmountFuelTanked.Location = new System.Drawing.Point(280, 102);
            this.inputCurrentAmountFuelTanked.Name = "inputCurrentAmountFuelTanked";
            this.inputCurrentAmountFuelTanked.Size = new System.Drawing.Size(91, 26);
            this.inputCurrentAmountFuelTanked.TabIndex = 8;
            // 
            // inputPricePerLiter
            // 
            this.inputPricePerLiter.Location = new System.Drawing.Point(280, 138);
            this.inputPricePerLiter.Name = "inputPricePerLiter";
            this.inputPricePerLiter.Size = new System.Drawing.Size(91, 26);
            this.inputPricePerLiter.TabIndex = 7;
            // 
            // inputPreviousOdometer
            // 
            this.inputPreviousOdometer.Location = new System.Drawing.Point(248, 70);
            this.inputPreviousOdometer.Name = "inputPreviousOdometer";
            this.inputPreviousOdometer.Size = new System.Drawing.Size(123, 26);
            this.inputPreviousOdometer.TabIndex = 6;
            // 
            // inputCurrentOdometer
            // 
            this.inputCurrentOdometer.Location = new System.Drawing.Point(248, 31);
            this.inputCurrentOdometer.Name = "inputCurrentOdometer";
            this.inputCurrentOdometer.Size = new System.Drawing.Size(123, 26);
            this.inputCurrentOdometer.TabIndex = 5;
            // 
            // calculatorFuel
            // 
            this.calculatorFuel.Location = new System.Drawing.Point(35, 180);
            this.calculatorFuel.Name = "calculatorFuel";
            this.calculatorFuel.Size = new System.Drawing.Size(230, 29);
            this.calculatorFuel.TabIndex = 4;
            this.calculatorFuel.UseVisualStyleBackColor = true;
            this.calculatorFuel.Click += new System.EventHandler(this.calculatorFuel_Click);
            // 
            // outputPricePerLiter
            // 
            this.outputPricePerLiter.AutoSize = true;
            this.outputPricePerLiter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputPricePerLiter.Location = new System.Drawing.Point(6, 141);
            this.outputPricePerLiter.Name = "outputPricePerLiter";
            this.outputPricePerLiter.Size = new System.Drawing.Size(0, 20);
            this.outputPricePerLiter.TabIndex = 3;
            // 
            // outputCurrentAmountOfFuel
            // 
            this.outputCurrentAmountOfFuel.AutoSize = true;
            this.outputCurrentAmountOfFuel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputCurrentAmountOfFuel.Location = new System.Drawing.Point(6, 107);
            this.outputCurrentAmountOfFuel.Name = "outputCurrentAmountOfFuel";
            this.outputCurrentAmountOfFuel.Size = new System.Drawing.Size(0, 20);
            this.outputCurrentAmountOfFuel.TabIndex = 2;
            // 
            // outputPreviousOdometer
            // 
            this.outputPreviousOdometer.AutoSize = true;
            this.outputPreviousOdometer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputPreviousOdometer.Location = new System.Drawing.Point(6, 76);
            this.outputPreviousOdometer.Name = "outputPreviousOdometer";
            this.outputPreviousOdometer.Size = new System.Drawing.Size(0, 20);
            this.outputPreviousOdometer.TabIndex = 1;
            // 
            // outputCurrentOdometer
            // 
            this.outputCurrentOdometer.AutoSize = true;
            this.outputCurrentOdometer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputCurrentOdometer.Location = new System.Drawing.Point(6, 37);
            this.outputCurrentOdometer.Name = "outputCurrentOdometer";
            this.outputCurrentOdometer.Size = new System.Drawing.Size(0, 20);
            this.outputCurrentOdometer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.bmiBox);
            this.Controls.Add(this.resultFuelBox);
            this.Controls.Add(this.resultBmiBox);
            this.Controls.Add(this.fuelBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.bmiBox.ResumeLayout(false);
            this.bmiBox.PerformLayout();
            this.resultFuelBox.ResumeLayout(false);
            this.resultFuelBox.PerformLayout();
            this.resultBmiBox.ResumeLayout(false);
            this.resultBmiBox.PerformLayout();
            this.fuelBox.ResumeLayout(false);
            this.fuelBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bmiBox;
        private System.Windows.Forms.Button calculatorBMI;
        private System.Windows.Forms.RadioButton buttonUsUnit;
        private System.Windows.Forms.RadioButton buttonMetricUnit;
        private System.Windows.Forms.TextBox inputHeight;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label outputWeight;
        private System.Windows.Forms.Label outputHeight;
        private System.Windows.Forms.Label outputYourName;
        private System.Windows.Forms.GroupBox resultFuelBox;
        private System.Windows.Forms.Label showConsumptionLitKm;
        private System.Windows.Forms.Label showConsumptionLitMetric;
        private System.Windows.Forms.Label showConsumptionLitSwe;
        private System.Windows.Forms.Label showCostPerKm;
        private System.Windows.Forms.Label showConsumptionKmLit;
        private System.Windows.Forms.Label outputCostPerKm;
        private System.Windows.Forms.Label outputConsumptionLitSwedish;
        private System.Windows.Forms.Label outputConsumptionLitMetric;
        private System.Windows.Forms.Label outputConsumptionLitKm;
        private System.Windows.Forms.Label outputConsumptionKmLit;
        private System.Windows.Forms.GroupBox resultBmiBox;
        private System.Windows.Forms.Label normalBMI;
        private System.Windows.Forms.Label outputNormalBMI;
        private System.Windows.Forms.Label showWeightCategory;
        private System.Windows.Forms.Label showBMI;
        private System.Windows.Forms.Label outputWeightCategory;
        private System.Windows.Forms.Label outputBMI;
        private System.Windows.Forms.GroupBox fuelBox;
        private System.Windows.Forms.TextBox inputCurrentAmountFuelTanked;
        private System.Windows.Forms.TextBox inputPricePerLiter;
        private System.Windows.Forms.TextBox inputPreviousOdometer;
        private System.Windows.Forms.TextBox inputCurrentOdometer;
        private System.Windows.Forms.Button calculatorFuel;
        private System.Windows.Forms.Label outputPricePerLiter;
        private System.Windows.Forms.Label outputCurrentAmountOfFuel;
        private System.Windows.Forms.Label outputPreviousOdometer;
        private System.Windows.Forms.Label outputCurrentOdometer;
    }
}

