using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Address
{
    [TestClass]
    public class Address_Methods : BaseClass
    {
        Address_Locators addressObject = new Address_Locators();
        [TestMethod]
        public void Address()
        {
            addressObject.addressExe("Muhammad", "Abubakar","MEEM Foundation","House#1,Street#2,ABC Town.","Lahore","54000","03414459889");
        }
    }
}
