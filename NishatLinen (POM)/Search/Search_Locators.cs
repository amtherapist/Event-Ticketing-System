using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Search
{
    public class Search_Locators : BaseClass
    {
        // these locations are used in all regions
        By searchBox = By.XPath("/html/body/div[2]/main/section/div/div/div/form/div/div/input[4]");
        By searchIcon = By.XPath("/html/body/div[2]/main/section/div/div/div/form/div/button/i");
        By addToCart = By.ClassName("addToCartBundle");
        By closePopUp = By.ClassName("add-to-cart-form-modal-close");

        #region 3 piece

        By frameInScreen2 = By.CssSelector("#shopify-section-template--16149187723463__main > div > div.t4s-row > div > div.t4s_box_pr_grid.t4s-products.t4s-text-center.t4s_ratio2_3.t4s_position_8.t4s_cover.t4s-row.t4s-justify-content-center.t4s-row-cols-lg-4.t4s-row-cols-md-2.t4s-row-cols-2.t4s-gx-md-8.t4s-gy-md-20.t4s-gx-8.t4s-gy-10 > div.t4s-product.t4s-pr-grid.t4s-pr-style1.t4s-pr-7628227444935.t4s-col-item.is-t4s-pr-created > div > div.t4s-product-inner.t4s-pr.t4s-oh > div.t4s-product-btns > a > span.t4s-svg-pr-icon");

        #endregion

        #region 2 piece

        By frameInScreen3 = By.CssSelector("#shopify-section-template--16149187723463__main > div > div.t4s-row > div > div.t4s_box_pr_grid.t4s-products.t4s-text-center.t4s_ratio2_3.t4s_position_8.t4s_cover.t4s-row.t4s-justify-content-center.t4s-row-cols-lg-4.t4s-row-cols-md-2.t4s-row-cols-2.t4s-gx-md-8.t4s-gy-md-20.t4s-gx-8.t4s-gy-10 > div.t4s-product.t4s-pr-grid.t4s-pr-style1.t4s-pr-7616924254407.t4s-col-item.is-t4s-pr-created > div > div.t4s-product-inner.t4s-pr.t4s-oh > div.t4s-product-btns > a > span.t4s-svg-pr-icon");

        #endregion

        #region 2 piece-embroidered suit-PE23-23

        By frameInScreen4 = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/div/div/div/div[1]/div[3]/a/span[1]");
        By notifyButton = By.XPath("/html/body/div[2]/main/section[1]/div/div/div/div/div[2]/div[2]/div[3]/div/form/div[2]/div/div/div");
        By notifySubmitButton = By.XPath("/html/body/div[17]/div/div[4]/div[5]/div");


        #endregion

        public void searchExe()
        {
            #region 3 piece
            driver.Navigate().GoToUrl("https://nishatlinen.com/search");

            WebDriverWait waitForSearch = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            waitForSearch.Until(d => driver.Url.Contains("search"));
            Thread.Sleep(3000);

            FindElement(searchBox);
            Thread.Sleep(2000);
            SendKeys(searchBox,"3 piece");
            Thread.Sleep(1000);
            ClickElement(searchIcon);
            //SendKeys(searchBox, Keys.Enter);
            Thread.Sleep(3000);
            ////Validation
            //Assert.AreEqual("3 piece", $"{driver.Title.Contains("3 piece")}");


            //add to cart item 2
            Actions actionOnFrame2 = new Actions(driver);
            IWebElement goInto2 = driver.FindElement(frameInScreen2);
            actionOnFrame2.MoveToElement(goInto2).Click().Perform();
            Thread.Sleep(4000);


            Actions actionOnAddToCart2 = new Actions(driver);
            IWebElement addToCart2 = driver.FindElement(addToCart);
            actionOnAddToCart2.MoveToElement(addToCart2).Click().Perform();
            Thread.Sleep(4000);

            Actions actionOnContinueShopping2 = new Actions(driver);
            IWebElement continueShopping2 = driver.FindElement(closePopUp);
            actionOnContinueShopping2.MoveToElement(continueShopping2).Click().Perform();
            Thread.Sleep(1000);

            #endregion

            #region 2 piece

            driver.Navigate().GoToUrl("https://nishatlinen.com/search");
            WebDriverWait waitForSearch2 = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            waitForSearch2.Until(d => driver.Url.Contains("search"));
            Thread.Sleep(1000);

            FindElement(searchBox);
            SendKeys(searchBox,"2 piece");
            Thread.Sleep(1000);
            ClickElement(searchIcon);
            //SendKeys(searchBox, Keys.Enter);
            Thread.Sleep(3000);



            Actions actionOnFrame3 = new Actions(driver);
            IWebElement goInto3 = driver.FindElement(frameInScreen3);
            actionOnFrame3.MoveToElement(goInto3).Click().Perform();
            Thread.Sleep(4000);


            Actions actionOnAddToCart3 = new Actions(driver);
            IWebElement addToCart3 = driver.FindElement(addToCart);
            actionOnAddToCart3.MoveToElement(addToCart3).Click().Perform();
            Thread.Sleep(4000);

            Actions actionOnContinueShopping3 = new Actions(driver);
            IWebElement goToCart = driver.FindElement(closePopUp);
            actionOnContinueShopping3.MoveToElement(goToCart).Click().Perform();
            Thread.Sleep(2000);

            #endregion

            #region 2 piece-embroidered suit-PE23-23

            driver.Navigate().GoToUrl("https://nishatlinen.com/search");
            WebDriverWait waitForSearch3 = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            waitForSearch3.Until(d => driver.Url.Contains("search"));
            Thread.Sleep(1000);

            FindElement(searchBox);
            SendKeys(searchBox, "2 piece-embroidered suit-PE23-23");
            Thread.Sleep(1000);
            ClickElement(searchIcon);
            //SendKeys(searchBox, Keys.Enter);
            Thread.Sleep(3000);

            Actions actionOnPic = new Actions(driver);
            IWebElement readMore = driver.FindElement(frameInScreen4);
            actionOnPic.MoveToElement(readMore).Click().Perform();
            Thread.Sleep(4000);

            Actions actionOnNotifyButton = new Actions(driver);
            IWebElement notifyMe = driver.FindElement(notifyButton);
            actionOnNotifyButton.MoveToElement(notifyMe).Click().Perform();
            Thread.Sleep(3000);

            Actions actionOnNotifySubmitButton = new Actions(driver);
            IWebElement notifySubmit = driver.FindElement(notifySubmitButton);
            actionOnNotifySubmitButton.MoveToElement(notifySubmit).Click().Perform();

            #endregion


        }
    }
}
