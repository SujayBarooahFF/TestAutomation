using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace RMxAutomationFramework
{
    public class Driver
    {
       public static string saveLocation;
        
        public static IWebDriver Instance { get; set; }
        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArguments("disable-infobars");
            Instance = new ChromeDriver(options);
            TurnOnWait();
        }
        public static void Close()
        {
            Instance.Close();
            ProcessEnd();
        }
        public static void ProcessEnd()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
        // generalized wait method
        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds*1000));
        }
        public static void NoWait(Action action)
        {
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
        public static void TakeScreenshot(string filename)
        {
           try
            {
                createTempDirectory();
                //createFilename();
                var screenshot = ((ITakesScreenshot)Driver.Instance).GetScreenshot();
                screenshot.SaveAsFile(filename, ScreenshotImageFormat.Png);
            }
            catch(Exception){}
        }
        public static void createTempDirectory()
        {
            try
            {
                string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Screenshots");
                //string filePath = Path.Combine(myFolder, ord + ".pdf");
                bool dirExists = System.IO.Directory.Exists(saveLocation);
                if (!dirExists)
                    System.IO.Directory.CreateDirectory(saveLocation);
            }
            catch (Exception) { }
        }            
    }
    
    public class JsExecutor  
    {
        public static IJavaScriptExecutor JscriptExecutor { get; set; }
        public static void Initialize()
        {
            JscriptExecutor = (IJavaScriptExecutor)Driver.Instance;
        }
    }
}
