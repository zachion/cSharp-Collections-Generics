﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        //public ICollection<Vendor> Retrieve()
        public IEnumerable<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@gmail.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "Antisom", Email = "abc@gmail.com" });
            }

            for (int i = 0; i < vendors.Count(); i++)
            {
                Console.WriteLine(vendors[i]);
            }

            foreach (var vendor in vendors)
            {
                //Console.WriteLine(vendor);
            }

            return vendors;
        }

        public IEnumerable<Vendor> RetrieveAll()
        {

            var vendors = new List<Vendor>() {
                            new Vendor(){ VendorId = 1, CompanyName = "ABC Corp", Email="abc@gmail.com" },
                            new Vendor(){ VendorId = 2, CompanyName = "Antisom", Email = "abc@gmail.com"},
                            new Vendor(){ VendorId = 3, CompanyName = "EFG Ltd", Email="efg@gmail.com" },
                            new Vendor(){ VendorId = 4, CompanyName = "HIJ AG", Email="hij@gmail.com" },
                            new Vendor(){ VendorId = 5, CompanyName = "Amalgamated", Email="amal@gmail.com" },
                            new Vendor() { VendorId = 6, CompanyName = "Toy Blocks Inc", Email = "toy@gmail.com" },
                            new Vendor() { VendorId = 7, CompanyName = "Home Toys Inc", Email = "home@gmail.com" },
                            new Vendor() { VendorId = 8, CompanyName = "Car Toys", Email = "car@abc.com" },
                            new Vendor() { VendorId = 9, CompanyName = "Toys for Fun", Email = "fun@abc.com" }
            };
            return vendors;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            //call the database to retrieve the value
            //If no value is returned, return the default value

            T value = defaultValue;

            return value;
        }
        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }

        /// <summary>
        /// Retrieves all of the apporoved vendors, one at a time
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            //Get data from the database
            this.Retrieve();

            foreach (var vendor in vendors)
            {
                Console.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }


    }
}
