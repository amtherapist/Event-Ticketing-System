using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NishatLinen__POM_
{
    public class BaseClass
    {
        #region Driver&URL
        public static IWebDriver driver;
        public static IWebDriver Driver(string browser)
        {
            if (browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                driver = new ChromeDriver(options);
                driver.Url = "https://nishatlinen.com/";
                //driver.Manage().Window.FullScreen();
            }
            //else if (browser == "Firefox")
            //{
            //    FirefoxDriver options =new FirefoxOptions());
            //    options.AddArguments("--start-maximized");
            //    driver = new ChromeDriver(options);
            //    driver.Url = "https://nishatlinen.com/";
            //}
            //else if (browser == "Edge")
            //{
            //    EdgeDriver options = new EdgeDriver());
            //    options.AddArguments("--start-maximized");
            //    driver = new ChromeDriver(options);
            //    driver.Url = "https://nishatlinen.com/";
            //}
            return driver;
        }
        #endregion


        #region SendKeys
        public void SendKeys(By locator, string text)
        {
            if (driver.FindElement(locator).GetAttribute("value") != " ")
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            else
            {
                driver.FindElement(locator).SendKeys(text);
            }
        }
        #endregion

        #region Click
        public void ClickElement(By locator)
        {
            driver.FindElement(locator).Click();
        }
        #endregion


        #region DriverClose
        public static void Close()
        {
            driver.Dispose();
        }
        #endregion


        #region ClickElement
        public void ClickWebElement(IWebElement element, IWebDriver driver)
        {
            try
            {
                element.Click();
            }
            catch (WebDriverException e)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", element);
            }
        }
        #endregion


        #region FindElement
        public void FindElement(By locator, double timeoutInSeconds = 60)
        {
            if (timeoutInSeconds == 0)
            {
                driver.FindElement(locator);
                ClickElement(locator);
            }
            else
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                ClickElement(locator);
            }
        }
        #endregion

        public void SortDown(By Locator, string Value)
        {
            IWebElement sortDropdown = driver.FindElement(Locator);
            SelectElement select = new SelectElement(sortDropdown);
            select.SelectByText(Value);
            sortDropdown.Click();
        }

        #region DropDown
        public void Dropdown(By loc, string type, string value)
        {
            IWebElement element = driver.FindElement(loc);
            SelectElement dropdown = new SelectElement(element);
            if (type == "value")
            {
                dropdown.SelectByValue(value);

                element.Click();
            }
            else if (type == "text")
            {
                dropdown.SelectByText(value);
                element.Click();
            }
            else if (type == "index")
            {
                dropdown.SelectByIndex(Convert.ToInt32(value));
                element.Click();
            }
        }
        #endregion

        #region Displayed
        public bool IsElementDisplayed(By locator)
        {
            try
            {
                return driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        #endregion

        #region

        public string GetElementText(By by)
        {
            string text;
            try
            {
                text = driver.FindElement(by).Text;
            }
            catch
            {
                try
                {
                    text = driver.FindElement(by).GetAttribute("value");
                }
                catch
                {
                    text = driver.FindElement(by).GetAttribute("innerHTML");
                }
            }
            return text;
        }

        #endregion

        public void Scroll(By Locator)
        {
            var e = driver.FindElement(Locator);
            // JavaScript Executor to scroll to element
            ((IJavaScriptExecutor)driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", e);
        }


        public void search()
        {
            driver.Navigate().GoToUrl("https://nishatlinen.com/search");
        }
    }
}

