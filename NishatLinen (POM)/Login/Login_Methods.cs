using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Login
{
    [TestClass]
    public class Login_Methods : BaseClass
    {
        Login_Locators loginObject = new Login_Locators();
        [TestMethod]
        public void Login()
        {
            loginObject.loginExe("m.abubakar.ji@gmail.com", "qwerty123");
        }
    }
}