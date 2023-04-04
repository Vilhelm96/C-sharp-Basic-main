using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /*******************************************************************************************
    * Author: Vilhelm Park
    * Date: 2020-11-01
    * Description: This class is the form for the ingredients. It lets the user add, change and 
    *              delete ingredients as they please.
    *******************************************************************************************/
    public partial class FormIngredients : Form
    {
        private Recipe recipe;

        public FormIngredients(Recipe currentRecipe)
        {
            //Set the current recipe so that we can change the content inside it in the class.
            recipe = currentRecipe;
            InitializeComponent();
            InitializeGui();
        }
        /// <summary>
        /// Initialize the form.
        /// </summary>
        private void InitializeGui ()
        {
            labelNumOfIngredients.Text = "Num of ingredients";
            groupBoxIngredient.Text = "Ingredient";
            buttonAdd.Text = "Add";
            buttonEdit.Text = "Edit";
            buttonDelete.Text = "Delete";
            buttonOk.Text = "Ok";
            buttonCancel.Text = "Cancel";
        }
        /// <summary>
        /// Update the listbox.
        /// </summary>
        private void updateGui()
        {
            listBoxIngredients.Items.Clear();
            listBoxIngredients.Items.AddRange(recipe.getIngredients());
        }
        /// <summary>
        /// Add a ingredient to the recipe and update listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string ingredient = textBoxIngredient.Text;
            //If there is content in the textbox add it to the ingredients in recipe.
            if(ingredient != string.Empty)
            {
                recipe.addIngredient(ingredient);
                updateGui();
            }
        }

        /// <summary>
        /// Edit a ingredient in the recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxIngredients.SelectedIndex;
            string ingredient = textBoxIngredient.Text;
            //If index is correct edit ingredient and update the listbox.
            if(recipe.changeIngredientAt(index, ingredient))
            {
                updateGui();
            }
        }
        /// <summary>
        /// Delete a ingredient in the recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxIngredients.SelectedIndex;
            //If index is correct delete the ingredient and update listbox.
            if (recipe.deleteIngredientAt(index))
            {
                updateGui();
            }
        }
        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            //If no ingredients were added show it in a messagebox so user knows.
            if (recipe.getCurrentAmountOfIngredients().Equals(0))
            {
                MessageBox.Show("Added no ingredients.");
            }
            
            this.Close();
        }
        /// <summary>
        /// Exit form and set recipe to default values so that the values that might have been
        /// added in the listbox will not be added to the recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            recipe.defaultValues();
            this.Close();
        }
    }
}
