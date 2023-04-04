using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.ContactFiles;
namespace Assignment5.ContactFiles
{
    /*******************************************************************************************
     * Author: Vilhelm Park
     * Date: 2020-11-06
     * Description: This class handles a contact and has properties for all the fields needed.
     *              Contact can be copied and return the contact to a string.
     *******************************************************************************************/
    class Contact
    {
        private string firstName;
        private string lastName;
        private Address address;

        public string FirstName
        {
            get { return firstName; }
            set {
                if (!string.IsNullOrEmpty(value))
                    firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lastName = value;
            }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        /// <summary>
        /// Default contact.
        /// </summary>
        public Contact()
        {
            Initialize();
        }
        /// <summary>
        /// Default values for the contact.
        /// </summary>
        public void Initialize()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            address = new Address();
        }
        /// <summary>
        /// Returns the contact as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0, 8} {1, 8} {2, 60}\n", LastName + ", ", FirstName, Address.ToString());
        }
        /// <summary>
        /// Copy the current properties in the contact into a new contact with new address and then return the contact.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public Contact copy()
        {
            Contact copyContact = new Contact();
            Address copyAddress = new Address();
            copyContact.FirstName = FirstName;
            copyContact.LastName = LastName;
            copyContact.Address = Address.copy();
            return copyContact;
        }
    }
}
