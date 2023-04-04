using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
    /*******************************************************************************************
     * Author: Vilhelm Park
     * Date: 2020-11-06
     * Description: This class handles the main form and handles the events that should occur
     * when buttons are pressed on the form.
     *******************************************************************************************/
    public partial class MainForm : Form
    {
        private ContactManager contactManager;
        private Contact contact;
        /// <summary>
        /// Initialize the form and the contact manager and a specific contact.
        /// </summary>
        public MainForm()
        {
            contactManager = new ContactManager();
            contact = new Contact();
            InitializeComponent();
            Initialize();
        }
        /// <summary>
        /// Initialize the form text and combobox options.
        /// </summary>
        private void Initialize()
        {
            this.Text = "Contact registry";
            groupBoxName.Text = "Name";
            labelFirstName.Text = "First name";
            labelLastName.Text = "Last name";
            groupBoxAddress.Text = "Address";
            labelStreet.Text = "Street";
            labelCity.Text = "City";
            labelZipCode.Text = "Zip code";
            labelCountry.Text = "Country";
            comboBoxCountries.Items.Add(Countries.Denmark);
            comboBoxCountries.Items.Add(Countries.Finland);
            comboBoxCountries.Items.Add(Countries.France);
            comboBoxCountries.Items.Add(Countries.Great_Britain);
            comboBoxCountries.Items.Add(Countries.Norway);
            comboBoxCountries.Items.Add(Countries.Sweden);
            comboBoxCountries.Items.Add(Countries.United_states_of_america);
            comboBoxCountries.SelectedIndex = 0;
            buttonAdd.Text = "Add";
            buttonChange.Text = "Change";
            buttonDelete.Text = "Delete";
            labelNumRegistredRecords.Text = "No. of registred records";
            labelNumRecordsRegistredCounter.Text = contactManager.Count.ToString();
        }
        /// <summary>
        /// Update the listbox content and the counter for how many contacts there are in the listbox.
        /// </summary>
        private void updateGui()
        {
            listBoxRegistredRecords.Items.Clear();
            listBoxRegistredRecords.Items.AddRange(contactManager.getContactInfo());
            labelNumRecordsRegistredCounter.Text = contactManager.Count.ToString();
        }
        /// <summary>
        /// Checks if the input in the textboxes are valid and then create a contact with the values in the textbox.
        /// Then add the contact to the contact manager list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(checkInput())
            {
                createContact();
                contactManager.addContact(contact);
                updateGui();
            }
        }
        /// <summary>
        /// Check if the index is valid for the listbox, if it is create contact with the current values we have input
        /// and then change the content in the contact. Then reset the contact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = listBoxRegistredRecords.SelectedIndex;
            createContact();
            //If index is correct change the contact and update listbox.
            if (contactManager.changeContact(index, contact))
            {
                updateGui();
            }

            contact.Initialize();
        }
        /// <summary>
        /// Check if index is valid in the listbox. If it is delete the contact on that index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxRegistredRecords.SelectedIndex;
            //If index is correct change the contact and update listbox.
            if (contactManager.deleteContact(index))
            {
                updateGui();
            }
        }

        /// <summary>
        /// Check the input in the textfields and see if they are okay.
        /// </summary>
        /// <returns></returns>
        private bool checkInput()
        {
            bool firstNameOk = string.IsNullOrEmpty(textBoxFirstName.Text);
            bool lastNameOk = string.IsNullOrEmpty(textBoxLastName.Text);
            bool streetOk = string.IsNullOrEmpty(textBoxStreet.Text);
            bool cityOk = string.IsNullOrEmpty(textBoxCity.Text);
            bool zipCodeOk = string.IsNullOrEmpty(textBoxStreet.Text);

            if (!firstNameOk && !lastNameOk && !streetOk && !cityOk && !zipCodeOk)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Read the combobox and see what value the contact should get.
        /// </summary>
        private void readCountry()
        {
            Countries tempCategory = (Countries)comboBoxCountries.SelectedItem;

            if (tempCategory.Equals(Countries.Denmark))
            {
                contact.Address.Country = Countries.Denmark;
            }
            else if (tempCategory.Equals(Countries.Finland))
            {
                contact.Address.Country = Countries.Finland;
            }
            else if (tempCategory.Equals(Countries.France))
            {
                contact.Address.Country = Countries.France;
            }
            else if (tempCategory.Equals(Countries.Great_Britain))
            {
                contact.Address.Country = Countries.Great_Britain;
            }
            else if (tempCategory.Equals(Countries.Norway))
            {
                contact.Address.Country = Countries.Norway;
            }
            else if (tempCategory.Equals(Countries.Sweden))
            {
                contact.Address.Country = Countries.Sweden;
            }
            else
            {
                contact.Address.Country = Countries.United_states_of_america;
            }
        }
        /// <summary>
        /// Create a contact with the current values that the user has input in the form.
        /// </summary>
        private void createContact()
        {
            contact.FirstName = textBoxFirstName.Text;
            contact.LastName = textBoxLastName.Text;
            contact.Address.Street = textBoxStreet.Text;
            contact.Address.City = textBoxCity.Text;
            contact.Address.ZipCode = textBoxZipCode.Text;
            readCountry();
        }
    }
}
