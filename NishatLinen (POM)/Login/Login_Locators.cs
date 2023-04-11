using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Login
{
    public class Login_Locators : BaseClass
    {
        By accountIcon= By.XPath("//*[@class=\"t4s-icon t4s-icon--account\"]");
        By email= By.Id("CustomerEmail");
        By password= By.Id("CustomerPassword");
        By signInButton=By.XPath("//button[contains(text(),'Sign In')]");

        #region for Assertion

        By dashboard = By.XPath("/html/body/div[2]/main/section/div/div[2]/p/a");

        #endregion


        public void loginExe(string loginId, string pass)
        {
            //BaseClass.Driver("Chrome");

            ClickElement(accountIcon);

            FindElement(email);
            SendKeys(email, loginId);

            FindElement(password);
            SendKeys(password, pass);

            ClickElement(signInButton);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(5));
            wait.Until(d => driver.Url.Contains("account"));


            IWebElement dashboardElement = driver.FindElement(dashboard);
            //string actualText = dashboardElement.Text;
            //string expectedText = actualText;
            Assert.IsTrue(dashboardElement.Displayed);

        }
    }
}
