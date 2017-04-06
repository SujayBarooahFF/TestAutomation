using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomationFramework;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class CancelCreateTradeAgreementTest : RMxTestsBaseClass
    {
        [TestMethod]
        public void Can_Cancel_Create_A_Simple_TA()
        {
            ListTradeAgreementPage.GoTo();
            
            // check if in the right view 
            Driver.Wait(TimeSpan.FromSeconds(2));
            Assert.IsTrue(ListTradeAgreementPage.IsAt(), "Not in SalesTradeAgreement List Page");
            
            ListTradeAgreementPage.CreateTradeAgreement("AutomatedTestName")
                .WithDescription("Automated Test creation")
                .DiscardChanges();

            // check if in the right view 
            Driver.Wait(TimeSpan.FromSeconds(2));
            Assert.IsTrue(ListTradeAgreementPage.IsAt(), "Not in SalesTradeAgreement List Page");

        }
    }
}
