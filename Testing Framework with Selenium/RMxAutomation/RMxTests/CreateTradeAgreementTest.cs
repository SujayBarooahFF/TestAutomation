using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomation;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class CreateTradeAgreementTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Create_A_Simple_TA()
        {
            LoginPage.Goto();
            //LoginPage.LoginAs("sbarooah@flintfox.com").WithPassword("Qwerty90").Login();
            LoginPage loginPAge = new LoginPage(); 
            loginPAge.LoginDefault().Login();
            Thread.Sleep(1000);
            NewTradeAgreementPage.GoTo();
            NewTradeAgreementPage.CreateTradeAgreement("AutomatedTestName")
                .WithDescription("Automated Test creation")
                .SaveChanges();
            Thread.Sleep(1000);
            //NewTradeAgreementPage.GoToNewTradeAgreement();
            Assert.AreEqual(TradeAgreementPage.Name, "AutomatedTestName", "Name did not match with new agreement");
        }

        [TestCleanup]

        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
