using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeopleViewer.Test
{
    [TestClass]
    public class MainViewModelTest
    {

        [TestMethod]
        public void RepositoryType_OnCreation_ReturnsFakeRepositoryString()
        {
            //Arrange//Act

            var viewModel = new MainViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            //Assert
            Assert.AreEqual(expectedStringm, viewModel.RepositoryType);
        }
    }
}
