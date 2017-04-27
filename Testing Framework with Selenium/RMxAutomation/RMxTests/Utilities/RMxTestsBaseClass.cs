using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools;
using RMxAutomationFramework;
using System;
using System.Threading;
using System.Drawing;
/*
 * This is the base test class for RMX tests with definitions for Init() and Cleanup() (teardown)
 * 
 * 
 */
namespace RMxTests
{
    public class RMxTestsBaseClass
    {
        private TestContext testContextInstance;
        public static string filename;

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            JsExecutor.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs("sbarooah@flintfox.com").WithPassword("Qwerty91").Login();
            Driver.Wait(TimeSpan.FromSeconds(1));            
        }
        public TestContext TestContext
            {
                get { return testContextInstance; }
                set { testContextInstance = value; }
            }

        [TestCleanup]
        public void Cleanup()
        {               
            
            // if the test has failed, take a screenshot
            UnitTestOutcome outcome = this.testContextInstance.CurrentTestOutcome;
            if (outcome == UnitTestOutcome.Failed)
            {
                //string name = createFilename();
                filename = this.testContextInstance.TestName;
                var timeStamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string ext = ".png";
                filename = filename + "_" + timeStamp + ext;

                Driver.TakeScreenshot(filename);
            }
            Driver.Close();
        } 
     }     
}
