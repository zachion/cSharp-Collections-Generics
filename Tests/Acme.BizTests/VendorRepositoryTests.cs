using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = 42;

            //Act 
            var actual = repository.RetrieveValue<int>("Select ...", 42);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            var repository = new VendorRepository();
            var expected = new List<Vendor>();

            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@gmail.com" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "Antisom", Email = "abc@gmail.com" });

            var actual = repository.Retrieve();



            CollectionAssert.AreEqual(expected, actual.ToList());
        }


        [TestMethod()]
        public void RetrieveWithIteratorTest()
        {
            var repository = new VendorRepository();
            var expected = new List<Vendor>() {
                new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@gmail.com" },
                new Vendor() { VendorId = 2, CompanyName = "Antisom", Email = "abc@gmail.com" }
            };

            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var item in vendorIterator)
            {
                Console.WriteLine(item);
            }
            var actual = vendorIterator.ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveAllTest()
        {
            var repository = new VendorRepository();
            var expected = new List<Vendor>();

            expected.Add(new Vendor() { VendorId = 6, CompanyName = "Toy Blocks Inc", Email = "toy@gmail.com" });
            expected.Add(new Vendor() { VendorId = 7, CompanyName = "Home Toys Inc", Email = "home@gmail.com" });
            expected.Add(new Vendor() { VendorId = 8, CompanyName = "Car Toys", Email = "car@abc.com" });
            expected.Add(new Vendor() { VendorId = 9, CompanyName = "Toys for Fun", Email = "fun@abc.com" });

            var vendors = repository.RetrieveAll();

            var vendorQuery = from v in vendors
                              where v.CompanyName.Contains("Toy")
                              orderby v.CompanyName
                              select v;

            var vendorQuery2 = vendors.Where(v => v.CompanyName.Contains("Toy")).OrderBy(o => o.CompanyName);

            CollectionAssert.AreEqual(expected, vendorQuery2.ToList());
        }
    }
}