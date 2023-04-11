using Microsoft.VisualStudio.TestTools.UnitTesting;
using NishatLinen__POM_.Address;
using NishatLinen__POM_.Login;
using NishatLinen__POM_.Luxury;
using NishatLinen__POM_.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NishatLinen__POM_
{
    [TestClass]
    public class ExecutionClass
    {

        //TestContext TestContext { get; set; }

        //public TestContext TestContext { get; set; }
        [AssemblyInitialize]

        public static void AssemblyStart(TestContext TestContext)
        {
            Login_Locators log = new Login_Locators();

            //string user = TestContext.DataRow["User"].ToString();
            //string pass = TestContext.DataRow["Pass"].ToString();
            BaseClass.Driver("Chrome");
            BaseClass.driver.Navigate().GoToUrl("https://nishatlinen.com/");
            //Object.login("TestProject@mailinator.com","bootcamp123");
            log.loginExe("m.abubakar.ji@gmail.com", "qwerty123");

        }
        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
            BaseClass.Close();
        }


        [TestMethod]
        public void RunAddress()
        {

            Address_Methods address = new Address_Methods();
            address.Address();
            Thread.Sleep(1000);
        }


        [TestMethod]
        public void RunLuxury()
        {
            Luxury_Methods luxury = new Luxury_Methods();
            luxury.Luxury();
            Thread.Sleep(1000);

        }

        [TestMethod]
        public void RunSearch()
        {
            Search_Methods search = new Search_Methods();
            search.Search();
            Thread.Sleep(1000);

        }

    }
}
