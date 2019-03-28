using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using SmartBear.TestLeft.TestObjects;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLeft_WebPrders
{
    [TestFixture]
    public class TestLeftTest : TestFixtureBase
    {
        #region Test setup
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
        }
        #endregion


        [Test]
        public void HelloWorldTest()
        {
            IProcess process = Driver.Applications.Run("notepad.exe");

            // Get the top-level window of Notepad.
            // You can get object identification code from the TestLeft UI Spy panel:
            // From the main menu, select View -> TestLeft UI Spy.
            ITopLevelWindow window = process.Find<ITopLevelWindow>(new WindowPattern()
            {
                WndClass = "Notepad"
            });

            window.Keys("Hello world!!"); // Simulate text input
        }

    }
}
