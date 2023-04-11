using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Remove_from_Cart
{
    public class RemoveFromCart_Methods:BaseClass
    {
        RemoveFromCart_Locators removeObject = new RemoveFromCart_Locators();
        [TestMethod]
        public void RemoveFromCart()
        {
            removeObject.removeExe();
        }
    }
}
