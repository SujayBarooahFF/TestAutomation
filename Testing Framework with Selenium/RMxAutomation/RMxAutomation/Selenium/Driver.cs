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
            TurnOnWait();
        }

        public static void Close()
        {
            Instance.Close();
        }
        // generalized wait method
        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds*1000));
        }
        public static void NoWait(Action action)
        {
            //Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
            TurnOffWait();
            action();
            TurnOnWait();
         }
        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

        }
        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));

        }

    }
}
