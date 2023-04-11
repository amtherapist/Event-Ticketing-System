using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Luxury
{
    [TestClass]
    public class Luxury_Methods:BaseClass
    {

        Luxury_Locators luxuryObject = new Luxury_Locators();
        [TestMethod]
        public void Luxury()
        {
            luxuryObject.luxuryExe();
        }

    }
}
