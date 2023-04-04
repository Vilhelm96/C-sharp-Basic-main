namespace Assignment4
{
    partial class FormIngredients
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
            this.groupBoxIngredient = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxIngredient = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.labelNumOfIngredients = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNumberOfIngredient = new System.Windows.Forms.Label();
            this.groupBoxIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngredient
            // 
            this.groupBoxIngredient.Controls.Add(this.buttonAdd);
            this.groupBoxIngredient.Controls.Add(this.buttonDelete);
            this.groupBoxIngredient.Controls.Add(this.textBoxIngredient);
            this.groupBoxIngredient.Controls.Add(this.buttonEdit);
            this.groupBoxIngredient.Controls.Add(this.listBoxIngredients);
            this.groupBoxIngredient.Location = new System.Drawing.Point(29, 72);
            this.groupBoxIngredient.Name = "groupBoxIngredient";
            this.groupBoxIngredient.Size = new System.Drawing.Size(857, 397);
            this.groupBoxIngredient.TabIndex = 0;
            this.groupBoxIngredient.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(751, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(751, 216);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 29);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxIngredient
            // 
            this.textBoxIngredient.Location = new System.Drawing.Point(18, 38);
            this.textBoxIngredient.Name = "textBoxIngredient";
            this.textBoxIngredient.Size = new System.Drawing.Size(706, 26);
            this.textBoxIngredient.TabIndex = 1;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(751, 159);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 32);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.ItemHeight = 20;
            this.listBoxIngredients.Location = new System.Drawing.Point(18, 81);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(706, 284);
            this.listBoxIngredients.TabIndex = 0;
            // 
            // labelNumOfIngredients
            // 
            this.labelNumOfIngredients.AutoSize = true;
            this.labelNumOfIngredients.Location = new System.Drawing.Point(25, 26);
            this.labelNumOfIngredients.Name = "labelNumOfIngredients";
            this.labelNumOfIngredients.Size = new System.Drawing.Size(0, 20);
            this.labelNumOfIngredients.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(45, 501);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(142, 32);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(573, 501);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNumberOfIngredient
            // 
            this.labelNumberOfIngredient.AutoSize = true;
            this.labelNumberOfIngredient.Location = new System.Drawing.Point(811, 42);
            this.labelNumberOfIngredient.Name = "labelNumberOfIngredient";
            this.labelNumberOfIngredient.Size = new System.Drawing.Size(0, 20);
            this.labelNumberOfIngredient.TabIndex = 4;
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 552);
            this.Controls.Add(this.labelNumberOfIngredient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelNumOfIngredients);
            this.Controls.Add(this.groupBoxIngredient);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.groupBoxIngredient.ResumeLayout(false);
            this.groupBoxIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngredient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxIngredient;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.Label labelNumOfIngredients;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNumberOfIngredient;
    }
}