using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomationFramework;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class LogoutTest : RMxTestsBaseClass
    {
        [TestMethod]
        public void User_Can_Logout()
        {
            DashboardPage.LogOut();
            Driver.Wait(TimeSpan.FromSeconds(1));
            //NewTradeAgreementPage.GoToNewTradeAgreement();
            Assert.IsTrue(LandingPage.IsAt, "Failed to LogOut");
        }
    }
}
