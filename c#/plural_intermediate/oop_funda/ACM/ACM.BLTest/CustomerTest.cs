using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
          //---Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
          //--Act
            string actual = customer.FullName;

          //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
          Customer customer = new Customer();
          customer.LastName = "Baggins";
          string expected = "Baggins";

          string actual = customer.FullName;

          Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
          Customer customer = new Customer();
          customer.FirstName = "Bilbo";
          string expected = "Bilbo";

          string actual = customer.FullName;

          Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "Frod";
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;
            //Act


            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }


        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbagins@gmail.com";

            var expected = true;

            //Act
            var actual = customer.Validate();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer();
            customer.EmailAddress = "fbagins@gmail.com";
            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }


    }

}
