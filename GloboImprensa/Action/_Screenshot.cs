using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace GloboImprensa.Action
{
    class _Screenshot
    {
        private IWebDriver driver;
        private Boolean PastExist;
        private string PathPast;
        private string NameProject;

        public _Screenshot(IWebDriver Driver)
        {
            driver = Driver;
            PastExist = false;

        }

        public void PrintScreenshot()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            NameProject = assembly.GetName().Name;

            if (!PastExist)
            {
                PathPast = Environment.CurrentDirectory + "/" + NameProject + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + "/";
                Directory.CreateDirectory(PathPast);
                GetScreenshot();
                PastExist = true;

            }
            else
            {
                GetScreenshot();
            }

        }

        public void GetScreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            String fp = PathPast + "Screenshot" + NameProject + " " + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".png";
            screenshot.SaveAsFile(fp, ScreenshotImageFormat.Png);
        }

    }
}
