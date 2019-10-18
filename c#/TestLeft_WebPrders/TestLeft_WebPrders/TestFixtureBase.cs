using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Linq;
using System.Text;
using SmartBear.TestLeft;

namespace TestLeft_WebPrders
{
    public class TestFixtureBase
    {
        static private IDriver _driver;

        static TestFixtureBase()
        {
            //Create a local Driver object
            _driver = new LocalDriver();

            //Use line below instead of the above to create a remote Driver
            //_driver = new RemoteDriver("myhost", "userName", "password");

            //Uncomment the line below to perform additional checks during code execution
            //_driver.Options.Debug.RuntimeChecks = SmartBear.TestLeft.Options.RuntimeChecks.All;
        }

        protected static IDriver Driver
        {
            get
            {
                return _driver;
            }
        }

        [OneTimeSetUp]
        public void InitializeFixture()
        {
            _driver.Log.OpenFolder(TestContext.CurrentContext.Test.FullName);
        }

        [OneTimeTearDown]
        public void FinalizeFixture()
        {
            _driver.Log.CloseFolder();
            _driver.Log.Save(TestContext.CurrentContext.TestDirectory + @"\TestResults", Log.Format.Html);
        }

        [SetUp]
        public void TestSetUp()
        {
            _driver.Log.OpenFolder(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TestTearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != NUnit.Framework.Interfaces.TestStatus.Passed)
                _driver.Log.Error("The test failed. See the Additional Info page below.", String.Format("Error message:\n{0}\nStack trace:\n{1}", TestContext.CurrentContext.Result.Message, TestContext.CurrentContext.Result.StackTrace));

            _driver.Log.CloseFolder();
        }
    }
}
