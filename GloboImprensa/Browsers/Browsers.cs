using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace GloboImprensa.Browsers
{
    class Browsers
    {
        public static IWebDriver GetBrowsers(IWebDriver driver, string browsers)
        {
            switch (browsers)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

                default:
                    throw new NotSupportedException($"{browsers} is not a supported browser");
            }

            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
