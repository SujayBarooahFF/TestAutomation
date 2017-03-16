using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomation;

namespace RMxTests
{
    [TestClass]
    public class LoginTests : RMxTestsBaseClass
    {
        [TestMethod]
        public void User_Can_Login()
        {
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }
    }
}
