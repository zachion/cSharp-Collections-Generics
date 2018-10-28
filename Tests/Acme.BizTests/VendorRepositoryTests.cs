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
            
            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC", Email = "abc@gmail.com" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "DFG", Email = "dfg@gmail.com" });

            var actual = repository.Retrieve();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}