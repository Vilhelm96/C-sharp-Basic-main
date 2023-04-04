using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    /*******************************************************************************************
     * Author: Vilhelm Park
     * Date: 2020-11-06
     * Description: This class handles the list with contacts and can add contacts, change 
     *              contacts inside the list and then delete contacts as well. It can return 
     *              contact list to a string array and get specific contacts.
     *******************************************************************************************/
    class ContactManager
    {
        private List <Contact> contactList;

        public ContactManager()
        {
            contactList = new List<Contact>();
        }

        /// <summary>
        /// Get current amount of elements in the  list.
        /// </summary>
        public int Count
        {
            get{ return contactList.Count; }
        }
        /// <summary>
        /// Copy the contact that is in the parameter and add the copied contact in the list.
        /// </summary>
        /// <param name="contact"></param>
        public void addContact(Contact contact)
        {
            Contact newContact = contact.copy();
            contactList.Add(newContact);
        }
        /// <summary>
        /// Check if index is valid if not return false, if it is delete the contact at the index and return true.
        /// </summary>
        /// <param name="index"></param>
        public bool deleteContact(int index)
        {
            if (!checkIndex(index))
            {
                return false;
            }

            contactList.RemoveAt(index);
            return true;
        }
        /// <summary>
        /// Check if index is valid if not return false, if true delete the contact at the index and add the changed contact at the same index.
        /// Then return true.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="contact"></param>
        public bool changeContact(int index, Contact contact)
        {
            Contact newContact = contact.copy();

            if(!checkIndex(index))
            {
                return false;
            }

            contactList.RemoveAt(index);
            contactList.Insert(index, newContact);
            return true;
        }
        /// <summary>
        /// Check if index is within the index that are allowed. It's not allowed to have index below 0 and above the amount of contacts in the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool checkIndex(int index)
        {
            if(index > contactList.Count || index < 0)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Get a contact from a specific index, if index is not correct return null since no contact exist at the index.
        /// If index is valid return the contact in the specific index in the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Contact getContact(int index)
        {
            if(!checkIndex(index))
            {
                return null;
            }

            return contactList[index];
        }
        /// <summary>
        /// Return the whole contact list as a string array.
        /// </summary>
        /// <returns></returns>
        public string [] getContactInfo()
        {
            string[] contactListToString = new string [contactList.Count];

            for (int counter = 0; counter < contactList.Count; counter++)
            {
                contactListToString[counter] = contactList[counter].ToString();
            }

            return contactListToString;
        }
    }
}
