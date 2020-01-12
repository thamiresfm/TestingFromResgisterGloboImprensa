using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboImprensa.Hooks
{
    class _Wait
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private IWebElement element;

        public _Wait(IWebDriver Driver)
        {
            driver = Driver;
        }

        public void __Wait(double TimeWaiting, By elemento)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeWaiting));
            element = wait.Until(driver => driver.FindElement(elemento));
        }
    }
}
