using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Diagnostics;

namespace ACM.BLTest
{
  [TestClass]
  public class CustomerRepositoryTest
  {




    [TestMethod]
    public void RetrieveExisting()
    {
      //Arrange
      var customerRepository = new CustomerRespository();
      var expected = new Customer(1)
      {
        EmailAddress = "fbaggins@hobbiton.me",
        FirstName = "Frodo",
        LastName = "Baggins"
      };
      // actual
      var actual = customerRepository.Retrieve(1);
      //assert

      // Assert.AreEqual(expected, actual);
      //comparing two seperate objects with matching properties

      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);

    }

  }




}
