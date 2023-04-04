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
     * Description: This class hadles the address, it has properties such as street, city and
     *              country for the address. It has three different constructors where we use chain
     *              calling for the constructor with three parameters to reduce code. The address
     *              can be copied and be returned as a string.
     *******************************************************************************************/
    class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        public string Street
        {
            get { return street; }
            set {
                if (!String.IsNullOrEmpty(value))
                    street = value;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    city = value;
            }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    zipCode = value;
            }
        }
        public Countries Country
        {
            get { return country; }
            set
            {
                 country = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Address()
        {
            Initialize();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aStreet"></param>
        /// <param name="aCity"></param>
        /// <param name="aZipCode"></param>
        public Address(string aStreet, string aCity, string aZipCode): this(aStreet, aCity, aZipCode, Countries.Sweden)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aStreet"></param>
        /// <param name="aCity"></param>
        /// <param name="aZipCode"></param>
        /// <param name="aCountry"></param>
        public Address(string aStreet, string aCity, string aZipCode, Countries aCountry)
        {
            Initialize();
            street = aStreet;
            city = aCity;
            zipCode = aZipCode;
            country = aCountry;
        }
        /// <summary>
        /// 
        /// </summary>
        private void Initialize()
        {
            street = string.Empty;
            city = string.Empty;
            zipCode = string.Empty;
            country = Countries.Sweden;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0, 30} {1, 6} {2, 18} {3, 18}\n", Street, ZipCode, City, Country.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Address copy()
        {
            Address newAddress = new Address();
            newAddress.Street = Street;
            newAddress.City = City;
            newAddress.ZipCode = ZipCode;
            newAddress.Country = Country;
            return newAddress;
        }
    }
}
