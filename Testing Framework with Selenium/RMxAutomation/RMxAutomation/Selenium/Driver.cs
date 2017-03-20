using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
namespace RMxAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Instance = new ChromeDriver("C:\\Users\\sbarooah\\Documents\\Visual Studio 2013\\Projects\\Testing Framework with Selenium\\BrowserDrivers", options);
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Instance.Close();
        }
        // generalized wait method
        internal static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds*1000));
        }
    }
}
