using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomation;

namespace RMxTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void User_Can_Login()
        {
            LoginPage.Goto();
            LoginPage.LoginAs("sbarooah@flintfox.com").WithPassword("Qwerty90").Login();
            
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }

        [TestCleanup]

        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
