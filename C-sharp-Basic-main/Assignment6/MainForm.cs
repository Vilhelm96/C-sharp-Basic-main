using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    /*******************************************************************************************
     * Author: Vilhelm Park
     * Date: 2020-12-02
     * Description: This class handles the form for the to do list. 
     *******************************************************************************************/

    public partial class MainForm : Form
    {
        private Task task;
        private TaskManager taskManager;
        public MainForm()
        {
            task = new Task();
            taskManager = new TaskManager();
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initialize the form.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "To Do Reminder";
            fileToolStripMenuItem.Text = "File";
            newFileToolStripMenuItem.Text = "New    Ctrl+N";
            openDatafileToolStripMenuItem.Text = "Open datafile";
            saveDatafileToolStripMenuItem.Text = "Save datafile";
            exitAltToolStripMenuItem.Text = "Exit     Alt+F4";
            helpToolStripMenuItem.Text = "Help";
            aboutToolStripMenuItem.Text = "About . . .";
            labelDataTime.Text = "Date and time";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd      HH:mm";
            labelToDo.Text = "To do";
            textBoxToDo.Text = "";
            labelPriority1.Text = "Priority";
            comboBoxPriority.Items.Clear();
            comboBoxPriority.Items.Add(Priority.Less_important);
            comboBoxPriority.Items.Add(Priority.Normal);
            comboBoxPriority.Items.Add(Priority.Important);
            comboBoxPriority.Items.Add(Priority.Very_important);
            comboBoxPriority.SelectedIndex = 1;
            buttonAdd.Text = "Add";
            buttonChange.Text = "Change";
            buttonDelete.Text = "Delete";
            groupBoxToDo.Text = "To Do";
            labelDate.Text = "Date";
            labelHour.Text = "Hour";
            labelPriority2.Text = "Priority";
            labelDescription.Text = "Description";
            listBox.Items.Clear();
            labelLocalTime.Text = "";
            toolTipDate.SetToolTip(dateTimePicker, "Click to open calendar to change date, write in manually the time here.");
            taskManager.emptyList();
        }
        /// <summary>
        /// Clear the list box and update the content in the listbox.
        /// </summary>
        private void updateGUI()
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(taskManager.getTaskInfo());
        }
        /// <summary>
        /// Adds a task to the task list and update the gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           if (checkToDo())
           {
                createTask();
                taskManager.addTask(task);
                updateGUI();
           }
           else
           {
               MessageBox.Show("Fill the To do text box before adding a task!");
           }
        }

        /// <summary>
        /// Reset the Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }
        /// <summary>
        /// Shows the About box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Triggers when form is closing, showcases message box. Checks if
        /// the user press on the ok or cancel button, if they press okay 
        /// exit the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = exitFormResult();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool exitFormResult()
        {
            //Text and title in the message box and add button ok and cancel.
            String messageBoxText = "You sure you want to exit the program?";
            String messageBoxTitle = "Think twice";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
            DialogResult result;

            // Displays the MessageBox and depending if the user press ok or cancel it will return true or false.
            result = MessageBox.Show(messageBoxText, messageBoxTitle, messageBoxButtons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Check if the textbox has any content.
        /// </summary>
        /// <returns></returns>
        private bool checkToDo()
        {
            if (textBoxToDo.Text.Length.Equals(0))
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Takes the values and put it in the task.
        /// </summary>
        private void createTask()
        {
            task.Date = dateTimePicker.Value;
            task.Priority = (Priority)comboBoxPriority.SelectedItem;
            task.Description = textBoxToDo.Text;
        }
        /// <summary>
        /// Timer that updates the label with the local time every second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLocalTime_Tick(object sender, EventArgs e)
        {
            labelLocalTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
