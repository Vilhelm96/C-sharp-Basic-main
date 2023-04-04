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
     * Description: This class is the main form for the application, it handles the input from the 
     *              user and displays it in the listbox. By pressing add ingredients button we can
     *              open another form.
     * 
     *******************************************************************************************/
    public partial class FormMain : Form
    {
        private const int maxNumberOfIngredients = 20;
        private const int maxNumberOfRecipes = 15;
        // Initialize the default recipe and recipe manager.
        private Recipe recipe = new Recipe(maxNumberOfIngredients);
        private RecipeManager recipeManager = new RecipeManager(maxNumberOfRecipes);

        public FormMain()
        {
            InitializeComponent();
            InitializeGui();
        }
        /// <summary>
        /// Initialize the form.
        /// </summary>
        private void InitializeGui()
        {
            groupBoxAddNewRecipe.Text = "Add new recipe";
            labelNameOfRecipe.Text = "Name of recipe";
            labelCategory.Text = "Category";
            comboBoxCategory.Items.Add(FoodCategory.Vegetarian);
            comboBoxCategory.Items.Add(FoodCategory.SeaFood);
            comboBoxCategory.Items.Add(FoodCategory.Meat);
            comboBoxCategory.Items.Add(FoodCategory.Fish);
            comboBoxCategory.SelectedIndex = 0;
            buttonAddIngredients.Text = "Add ingredients";
            buttonAddRecipe.Text = "Add recipe";
            labelName.Text = "Name";
            labelNumberOfIngredients.Text = "No. of ingred.";
            labelCategoryRecipe.Text = "Category";
            labelDescription.Text = "Description";
            buttonEdit.Text = "Edit";
            buttonDelete.Text = "Delete";
        }
        /// <summary>
        /// Update the listbox.
        /// </summary>
        private void updateGui()
        {
            listBoxRecipeSummary.Items.Clear();
            string[] currentRecipes = recipeManager.recipeListToString();
            listBoxRecipeSummary.Items.AddRange(currentRecipes);
        }
        /// <summary>
        /// Open new form which handles the ingredients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredients formIngredients = new FormIngredients(recipe);
            formIngredients.ShowDialog();
        }
        /// <summary>
        /// Add recipe to the recipe manager and update the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            recipe.setName(textBoxName.Text);
            readFoodCategory();
            recipe.setDescription(textBoxRecipeDescription.Text);
            recipeManager.add(recipe);
            updateGui();
            recipe.defaultValues();
        }
        /// <summary>
        /// Read the combobox and see what value the recipe should get.
        /// </summary>
        private void readFoodCategory()
        {
            FoodCategory tempCategory = (FoodCategory)comboBoxCategory.SelectedItem;
           
            if (tempCategory.Equals(FoodCategory.Vegetarian))
            {
                recipe.setCategory(FoodCategory.Vegetarian);
            }
            else if (tempCategory.Equals(FoodCategory.SeaFood))
            {
                recipe.setCategory(FoodCategory.SeaFood);
            }
            else if(tempCategory.Equals(FoodCategory.Meat))
            {
                recipe.setCategory(FoodCategory.Meat);
            }
            else
            {
                recipe.setCategory(FoodCategory.Fish);
            }
        }
        /// <summary>
        /// Edit a recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipeSummary.SelectedIndex;
            recipe.setName(textBoxName.Text);
            readFoodCategory();
            recipe.setDescription(textBoxRecipeDescription.Text);
            //If index is correct change the recipe and update listbox.
            if (recipeManager.changeRecipe(index, recipe))
            {
                updateGui();
            }
            recipe.defaultValues();
        }
        /// <summary>
        /// Delete a recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipeSummary.SelectedIndex;
            //If index is correct delete the recipe and update listbox.
            if (recipeManager.deleteRecipe(index))
            {
                updateGui();
            }
        }
    }
}
