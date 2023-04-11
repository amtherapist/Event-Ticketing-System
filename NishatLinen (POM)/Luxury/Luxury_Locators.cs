using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Luxury
{
    public class Luxury_Locators:BaseClass
    {
        By luxuryDropdown = By.XPath("//*[@href=\"/collections/luxury\"]");
        By luxuryEmbroidered = By.XPath("//*[@href=\"/collections/luxury-pret-embroidered\"]");
        By filterElement = By.XPath("//*[@aria-label=\"Show filters\"]");
        By colorSelect = By.XPath("//*[@href = \"/collections/luxury-pret-embroidered/black\"]");
        By elementOnScreen = By.CssSelector("#b_e9f249a0-0a0f-4baf-9664-73babbd7bbe7");
        By priceRangeSelect = By.XPath("//*[@aria-label=\"Narrow selection to products matching tag 6000 - 9000\"]");

        #region Add to Cart

        By frameInScreen = By.CssSelector("#shopify-section-template--16149187068103__main > div > div.t4s-row > div > div.t4s_box_pr_grid.t4s-products.t4s-text-default.t4s_ratio2_3.t4s_position_8.t4s_cover.t4s-row.t4s-justify-content-center.t4s-row-cols-2.t4s-row-cols-md-2.t4s-row-cols-lg-4.t4s-gx-md-8.t4s-gy-md-20.t4s-gx-8.t4s-gy-10 > div > div > div.t4s-product-inner.t4s-pr.t4s-oh > div.t4s-product-btns > a > span.t4s-svg-pr-icon > svg");
        By addToCartButton = By.XPath("/html/body/div[2]/main/section[1]/div/div/div/div/div[2]/div[2]/div[3]/div/form/div[2]/div/button");
        By closePopUp = By.ClassName("add-to-cart-form-modal-close");

        #endregion

        #region Assertion

        By colorTag = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/div[1]/a[1]");
        By priceTag = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/div[1]/a[2]");

        #endregion

        public void luxuryExe()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(luxuryDropdown);
            action.MoveToElement(element).Perform();
            Thread.Sleep(2000);

            ClickElement(luxuryEmbroidered);
            Thread.Sleep(2000);

            ClickElement(filterElement);
            Thread.Sleep(2000);

            ClickElement(colorSelect);
            Thread.Sleep(3000);

            Scroll(elementOnScreen);
            //SendKeys(elementOnScreen, Keys.PageUp);
            //FindElement(filterElement);
            //SendKeys(filterElement, Keys.PageUp);
            Thread.Sleep(3000);

            //FindElement(filterElement);
            //SendKeys(filterElement, Keys.Null);
            //Thread.Sleep(1000);

            ClickElement(filterElement);
            Thread.Sleep(2000);

            ClickElement(priceRangeSelect);
            
            Thread.Sleep(3000);

            #region Assertion for filter verification 
            //validation

            IWebElement colorTagElement = driver.FindElement(colorTag);
            Assert.IsTrue(colorTagElement.Displayed);

            Thread.Sleep(2000);

            IWebElement priceTagElement = driver.FindElement(priceTag);
            Assert.IsTrue(priceTagElement.Displayed);

            #endregion



            #region Add to Cart

            ////add to cart steps
            Actions actionOnFrame = new Actions(driver);
            IWebElement goInto = driver.FindElement(frameInScreen);
            actionOnFrame.MoveToElement(goInto).Perform();
            actionOnFrame.Click().Perform();
            Thread.Sleep(3000);


            Actions actionOnAddToCart = new Actions(driver);
            IWebElement addToCart = driver.FindElement(addToCartButton);
            actionOnAddToCart.MoveToElement(addToCart).Click().Perform();
            Thread.Sleep(4000);

            Actions actionOnContinueShopping = new Actions(driver);
            IWebElement continueShopping = driver.FindElement(closePopUp);
            actionOnContinueShopping.MoveToElement(continueShopping).Click().Perform();
            Thread.Sleep(2000);

            #endregion


        }
    }
}
