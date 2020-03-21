using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsProgramsTesting
{
    public abstract class ProgramHandler
    {
        public Uri driverURL = new Uri("http://127.0.0.1:4723");       // IP where WinAppDriver.exe is listening 
        public WindowsDriver<WindowsElement> driver;
        public AppiumOptions appiumOptions = new AppiumOptions();

        public ProgramHandler(string appID)
        {
            appiumOptions.AddAdditionalCapability("app", appID);
            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            driver = new WindowsDriver<WindowsElement>(driverURL, appiumOptions);    // Open program
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);       // Driver has 5 seconds to find element      

        }
        
    }

}
