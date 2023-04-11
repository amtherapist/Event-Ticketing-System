using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Search
{
    public class Search_Methods:BaseClass
    {

        Search_Locators searchObject = new Search_Locators();
        [TestMethod]
        public void Search()
        {
            searchObject.searchExe();
        }

    }
}
