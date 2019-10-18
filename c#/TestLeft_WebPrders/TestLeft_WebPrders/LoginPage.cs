using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using SmartBear.TestLeft;
using SmartBear.TestLeft.TestObjects;
using SmartBear.TestLeft.TestObjects.Web;

namespace TestLeft_WebPrders
{
    [TestFixture]
    public class LoginPage : TestFixtureBase
    {
        IDriver driver;
        ITextEdit username_input;
        ITextEdit password_input;
        IButton submitButton;
        IWebBrowser browser;


        //constructor
        public LoginPage()
        {
            //Why can't I initialize (?) inside this constructor?
            driver = new LocalDriver();

            username_input = driver.Find<IWebBrowser>(new WebBrowserPattern()
            {
                ObjectIdentifier = "chrome"
            }).Find<IWebPage>(new WebPagePattern()
            {
                URL = "http://secure.smartbearsoftware.com/samples/testcomplete11/WebOrders/login.aspx"
            }).Find<IWebElement>(new WebElementPattern()
            {
                ObjectType = "Form",
                idStr = "aspnetForm"
            }).Find<ITextEdit>(new WebElementPattern()
            {
                ObjectType = "Textbox"
            }, 2);

            password_input = driver.Find<IWebBrowser>(new WebBrowserPattern()
            {
                ObjectIdentifier = "chrome"
            }).Find<IWebPage>(new WebPagePattern()
            {
                URL = "http://secure.smartbearsoftware.com/samples/testcomplete11/WebOrders/login.aspx"
            }).Find<IWebElement>(new WebElementPattern()
            {
                ObjectType = "Form",
                idStr = "aspnetForm"
            }).Find<ITextEdit>(new WebElementPattern()
            {
                ObjectType = "PasswordBox"
            }, 2);


            submitButton = driver.Find<IWebBrowser>(new WebBrowserPattern()
            {
                ObjectIdentifier = "chrome"
            }).Find<IWebPage>(new WebPagePattern()
            {
                URL = "http://secure.smartbearsoftware.com/samples/testcomplete11/WebOrders/login.aspx"
            }).Find<IWebElement>(new WebElementPattern()
            {
                ObjectType = "Form",
                idStr = "aspnetForm"
            }).Find<IButton>(new WebElementPattern()
            {
                ObjectType = "SubmitButton"
            }, 2);


        }


    [SetUp]
        public void Init()
        {
            //browser = Driver.Applications.RunBrowser(BrowserType.Chrome, "http://secure.smartbearsoftware.com/samples/testcomplete11/WebOrders/login.aspx");

            /*ITopLevelWindow window = browser.Find<ITopLevelWindow>(new WindowPattern()
            {
                WndClass="Chrome"
            });
            */

            //Once i commented this out, stuff worked.....but only after I seperated stuff from login method...why tho

           // window.Keys("stufffff");

        }

        [Test]
        public void Login()
        {
 



            //var logob = new LoginPage();


            username_input.Keys("Tester");
            password_input.Keys("test");
            submitButton.Click();

        }
    }
   
}
