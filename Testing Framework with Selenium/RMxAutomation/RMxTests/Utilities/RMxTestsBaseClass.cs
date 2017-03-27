using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomationFramework;
using System.Threading;
/*
 * This is the base test class for RMX tests with definitions for init() and tear down.
 * 
 * 
 */
namespace RMxTests
{
    public class RMxTestsBaseClass
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs("sbarooah@flintfox.com").WithPassword("Qwerty90").Login();
            Thread.Sleep(1000);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
     
}
