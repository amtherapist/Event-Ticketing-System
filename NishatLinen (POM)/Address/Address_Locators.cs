using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NishatLinen__POM_.Address
{
    public class Address_Locators:BaseClass
    {

        By addressElement = By.XPath("/html/body/div[2]/main/section/div/div[1]/nav/ul/li[2]");
        By addNewAddressButton = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/button");

        #region Address Data
        By firstName = By.Id("AddressFirstNameNew");
        By lastName = By.Id("AddressLastNameNew");
        By companyName = By.Id("AddressCompanyNew");
        By newAddress = By.Id("AddressAddress1New");
        By cityName = By.Id("AddressCityNew");


        //driver.FindElement(By.Id("AddressCityNew");
        By zipCode = By.Id("AddressZipNew");
        By phoneNumber = By.Id("AddressPhoneNew");

        By submitButton = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/div/form/div[12]/button[1]");

        By deleteAddressButton = By.XPath("/html/body/div[2]/main/section/div/div[2]/ul/li/button[2]");

        #endregion
        public void addressExe(string fname,string lname, string cname, string newaddress, string cityname, string zipcode, string phonenumber)
        {

            Actions actionOnAddress = new Actions(driver);
            IWebElement address = driver.FindElement(addressElement);
            actionOnAddress.MoveToElement(address).Click().Perform();
            Thread.Sleep(2000);

            Actions actionOnAddNewAddress = new Actions(driver);
            IWebElement addNewAddress = driver.FindElement(addNewAddressButton);
            actionOnAddNewAddress.MoveToElement(addNewAddress).Click().Perform();
            Thread.Sleep(2000);


            #region Data for Address

            FindElement(firstName);
            SendKeys(firstName, fname);

            FindElement(lastName);
            SendKeys(lastName, lname);

            FindElement(companyName);
            SendKeys(companyName, cname);

            FindElement(newAddress);
            SendKeys(newAddress, newaddress);

            FindElement(cityName);
            SendKeys(cityName, cityname);

            FindElement(zipCode);
            SendKeys(cityName, cityname);

            FindElement(phoneNumber);
            SendKeys(phoneNumber, phonenumber);

            #endregion

            ClickElement(submitButton);
            Thread.Sleep(1000);

            Actions actionOnDeleteButton = new Actions(driver);
            IWebElement deleteButton = driver.FindElement(deleteAddressButton);
            actionOnDeleteButton.MoveToElement(deleteButton).Click().Perform();

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

        }

    }
}
