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


        public Vendor[] RetrieveArray()
        {
            var vendors = new Vendor[2]
            {
                new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@gmail.com" },
                new Vendor() { VendorId = 2, CompanyName = "Antisom", Email = "abc@gmail.com" }
            };
            return vendors;
        }

        public List<Vendor> Retrieve()
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

        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                {"ABC", new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@gmail.com" } },
                {"ANT", new Vendor(){ VendorId = 2, CompanyName = "Antisom", Email = "abc@gmail.com" }},
                {"XYZ", new Vendor()  { VendorId = 3, CompanyName = "XYZ Corp", Email = "abc@gmail.com" }}
            };

            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;

                Console.WriteLine($"key: {key} Value: {vendor}");
            }

            //foreach (var vendor in vendors.Values)
            //{
            //    Console.WriteLine(vendor);
            //}

            //foreach (var companyName in vendors.Keys)
            //{
            //    Console.WriteLine(vendors[companyName]);
            //}

            //Vendor vendor;

            //if (vendors.TryGetValue("ANT", out vendor))
            //{
            //    Console.WriteLine(vendor);
            //}

            return vendors;
        }


    }
}
