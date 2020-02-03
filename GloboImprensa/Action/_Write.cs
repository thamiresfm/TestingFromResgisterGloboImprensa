using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace GloboImprensa.Action
{
    public class _Write
    {
        private IWebDriver driver; 
        public _Write(IWebDriver Driver )
        {
            driver = Driver;

        }

        public void __Write( By by , string FieldText)
        {
            driver.FindElement(by).SendKeys(FieldText);
        }

    }
}
