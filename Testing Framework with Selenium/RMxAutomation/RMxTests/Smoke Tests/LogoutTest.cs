using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomation;
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
            Thread.Sleep(1000);
            //NewTradeAgreementPage.GoToNewTradeAgreement();
            Assert.IsTrue(LandingPage.IsAt, "Failed to LogOut");
        }
    }
}
