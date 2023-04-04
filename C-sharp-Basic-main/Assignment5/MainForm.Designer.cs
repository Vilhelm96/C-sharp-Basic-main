namespace Assignment5
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
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.listBoxRegistredRecords = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelNumRegistredRecords = new System.Windows.Forms.Label();
            this.labelNumRecordsRegistredCounter = new System.Windows.Forms.Label();
            this.groupBoxName.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxName
            // 
            this.groupBoxName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxName.Controls.Add(this.textBoxLastName);
            this.groupBoxName.Controls.Add(this.textBoxFirstName);
            this.groupBoxName.Controls.Add(this.labelLastName);
            this.groupBoxName.Controls.Add(this.labelFirstName);
            this.groupBoxName.Location = new System.Drawing.Point(19, 26);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(345, 122);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(129, 75);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(199, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(129, 34);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 26);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 81);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(0, 20);
            this.labelLastName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 40);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(0, 20);
            this.labelFirstName.TabIndex = 0;
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxAddress.Controls.Add(this.labelCountry);
            this.groupBoxAddress.Controls.Add(this.labelZipCode);
            this.groupBoxAddress.Controls.Add(this.labelCity);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.comboBoxCountries);
            this.groupBoxAddress.Controls.Add(this.textBoxZipCode);
            this.groupBoxAddress.Controls.Add(this.textBoxCity);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Location = new System.Drawing.Point(19, 154);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(345, 163);
            this.groupBoxAddress.TabIndex = 0;
            this.groupBoxAddress.TabStop = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(24, 131);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(0, 20);
            this.labelCountry.TabIndex = 7;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(24, 97);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(0, 20);
            this.labelZipCode.TabIndex = 6;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(24, 65);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(0, 20);
            this.labelCity.TabIndex = 5;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(24, 26);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(0, 20);
            this.labelStreet.TabIndex = 4;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(140, 123);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCountries.TabIndex = 3;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(140, 91);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(100, 26);
            this.textBoxZipCode.TabIndex = 2;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(140, 59);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 26);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(140, 26);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(188, 26);
            this.textBoxStreet.TabIndex = 0;
            // 
            // listBoxRegistredRecords
            // 
            this.listBoxRegistredRecords.FormattingEnabled = true;
            this.listBoxRegistredRecords.ItemHeight = 20;
            this.listBoxRegistredRecords.Location = new System.Drawing.Point(25, 336);
            this.listBoxRegistredRecords.Name = "listBoxRegistredRecords";
            this.listBoxRegistredRecords.Size = new System.Drawing.Size(763, 224);
            this.listBoxRegistredRecords.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(412, 88);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 39);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(412, 142);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(87, 41);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(412, 200);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 39);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelNumRegistredRecords
            // 
            this.labelNumRegistredRecords.AutoSize = true;
            this.labelNumRegistredRecords.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumRegistredRecords.Location = new System.Drawing.Point(543, 306);
            this.labelNumRegistredRecords.Name = "labelNumRegistredRecords";
            this.labelNumRegistredRecords.Size = new System.Drawing.Size(0, 20);
            this.labelNumRegistredRecords.TabIndex = 6;
            // 
            // labelNumRecordsRegistredCounter
            // 
            this.labelNumRecordsRegistredCounter.AutoSize = true;
            this.labelNumRecordsRegistredCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumRecordsRegistredCounter.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumRecordsRegistredCounter.Location = new System.Drawing.Point(727, 304);
            this.labelNumRecordsRegistredCounter.Name = "labelNumRecordsRegistredCounter";
            this.labelNumRecordsRegistredCounter.Size = new System.Drawing.Size(2, 22);
            this.labelNumRecordsRegistredCounter.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.labelNumRecordsRegistredCounter);
            this.Controls.Add(this.labelNumRegistredRecords);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxRegistredRecords);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.ListBox listBoxRegistredRecords;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelNumRegistredRecords;
        private System.Windows.Forms.Label labelNumRecordsRegistredCounter;
    }
}

