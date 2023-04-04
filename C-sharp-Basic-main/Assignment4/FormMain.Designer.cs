namespace Assignment4
{
    partial class FormMain
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
            this.labelNameOfRecipe = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAddIngredients = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRecipeDescription = new System.Windows.Forms.TextBox();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.groupBoxAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberOfIngredients = new System.Windows.Forms.Label();
            this.labelCategoryRecipe = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxRecipeSummary = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameOfRecipe
            // 
            this.labelNameOfRecipe.AutoSize = true;
            this.labelNameOfRecipe.Location = new System.Drawing.Point(6, 42);
            this.labelNameOfRecipe.Name = "labelNameOfRecipe";
            this.labelNameOfRecipe.Size = new System.Drawing.Size(0, 20);
            this.labelNameOfRecipe.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(6, 78);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(0, 20);
            this.labelCategory.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(125, 82);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(171, 28);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // buttonAddIngredients
            // 
            this.buttonAddIngredients.Location = new System.Drawing.Point(340, 78);
            this.buttonAddIngredients.Name = "buttonAddIngredients";
            this.buttonAddIngredients.Size = new System.Drawing.Size(148, 35);
            this.buttonAddIngredients.TabIndex = 4;
            this.buttonAddIngredients.UseVisualStyleBackColor = true;
            this.buttonAddIngredients.Click += new System.EventHandler(this.buttonAddIngredients_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(363, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxRecipeDescription
            // 
            this.textBoxRecipeDescription.Location = new System.Drawing.Point(10, 130);
            this.textBoxRecipeDescription.Name = "textBoxRecipeDescription";
            this.textBoxRecipeDescription.Size = new System.Drawing.Size(478, 26);
            this.textBoxRecipeDescription.TabIndex = 6;
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddRecipe.Location = new System.Drawing.Point(44, 390);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(508, 35);
            this.buttonAddRecipe.TabIndex = 7;
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // groupBoxAddNewRecipe
            // 
            this.groupBoxAddNewRecipe.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddNewRecipe.Controls.Add(this.labelCategory);
            this.groupBoxAddNewRecipe.Controls.Add(this.textBoxRecipeDescription);
            this.groupBoxAddNewRecipe.Controls.Add(this.textBoxName);
            this.groupBoxAddNewRecipe.Controls.Add(this.labelNameOfRecipe);
            this.groupBoxAddNewRecipe.Controls.Add(this.buttonAddIngredients);
            this.groupBoxAddNewRecipe.Location = new System.Drawing.Point(44, 12);
            this.groupBoxAddNewRecipe.Name = "groupBoxAddNewRecipe";
            this.groupBoxAddNewRecipe.Size = new System.Drawing.Size(508, 359);
            this.groupBoxAddNewRecipe.TabIndex = 8;
            this.groupBoxAddNewRecipe.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(592, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 9;
            // 
            // labelNumberOfIngredients
            // 
            this.labelNumberOfIngredients.AutoSize = true;
            this.labelNumberOfIngredients.Location = new System.Drawing.Point(738, 41);
            this.labelNumberOfIngredients.Name = "labelNumberOfIngredients";
            this.labelNumberOfIngredients.Size = new System.Drawing.Size(0, 20);
            this.labelNumberOfIngredients.TabIndex = 10;
            // 
            // labelCategoryRecipe
            // 
            this.labelCategoryRecipe.AutoSize = true;
            this.labelCategoryRecipe.Location = new System.Drawing.Point(875, 41);
            this.labelCategoryRecipe.Name = "labelCategoryRecipe";
            this.labelCategoryRecipe.Size = new System.Drawing.Size(0, 20);
            this.labelCategoryRecipe.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(984, 41);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 20);
            this.labelDescription.TabIndex = 12;
            // 
            // listBoxRecipeSummary
            // 
            this.listBoxRecipeSummary.FormattingEnabled = true;
            this.listBoxRecipeSummary.ItemHeight = 20;
            this.listBoxRecipeSummary.Location = new System.Drawing.Point(601, 83);
            this.listBoxRecipeSummary.Name = "listBoxRecipeSummary";
            this.listBoxRecipeSummary.Size = new System.Drawing.Size(504, 284);
            this.listBoxRecipeSummary.TabIndex = 13;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(621, 388);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(104, 35);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(974, 388);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 35);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxRecipeSummary);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCategoryRecipe);
            this.Controls.Add(this.labelNumberOfIngredients);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxAddNewRecipe);
            this.Controls.Add(this.buttonAddRecipe);
            this.Name = "FormMain";
            this.groupBoxAddNewRecipe.ResumeLayout(false);
            this.groupBoxAddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOfRecipe;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAddIngredients;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRecipeDescription;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.GroupBox groupBoxAddNewRecipe;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberOfIngredients;
        private System.Windows.Forms.Label labelCategoryRecipe;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxRecipeSummary;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}

