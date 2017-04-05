using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomationFramework;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class CreateTradeAgreementTest : RMxTestsBaseClass
    {
        [TestMethod]
        public void Can_Create_A_Simple_TA()
        {
            ListTradeAgreementPage.GoTo();
            
            // check if in the right view 
            Assert.IsTrue(ListTradeAgreementPage.IsAt(), "Not in SalesTradeAgreement List Page");


            ListTradeAgreementPage.CreateTradeAgreement("AutomatedTestName")
                .WithDescription("Automated Test creation")
                .SaveChanges();
            
            Driver.Wait(TimeSpan.FromSeconds(10));
                       
            Assert.AreEqual(TradeAgreementPage.Name, "AutomatedTestName", "Name did not match with the new agreement");

        }
    }
}
