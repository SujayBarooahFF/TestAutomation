using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomation;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class LogoutTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void User_Can_Logout()
        {
            LoginPage.Goto();
            LoginPage.LoginAs("sbarooah@flintfox.com").WithPassword("Qwerty90").Login();
            Thread.Sleep(1000);

            DashboardPage.LogOut();
            Thread.Sleep(1000);
            //NewTradeAgreementPage.GoToNewTradeAgreement();
            Assert.IsTrue(LandingPage.IsAt, "Failed to LogOut");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
