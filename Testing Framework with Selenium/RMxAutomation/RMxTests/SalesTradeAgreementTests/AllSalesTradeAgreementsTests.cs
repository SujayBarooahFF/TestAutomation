using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomationFramework;

namespace RMxTests.SalesTradeAgreementTests
{
    [TestClass]
    class AllSalesTradeAgreementsTests: RMxTestsBaseClass
    {
        // Can add new SalesTradeAgreements
        // Toggle between All view and My view
        // *Newly created SalesTradeAgreements should show up in the all SalesTradeAgreements list
        // Single SalesTradeAgreements selection

        // Can copy a SalesTradeAgreements
        // Can delete a SalesTradeAgreements
        // can sort by code
        // can sort by name
        // can sort by date

        //Bulk actions- select multiple and delete
        //Bulk action- select all SalesTradeAgreementss -- not implemented

        //Search a SalesTradeAgreements -- not implemented


        //Newly created SalesTradeAgreements should show up in the all SalesTradeAgreementss list
        //Can delete a SalesTradeAgreements

        [TestMethod]
        public void Added_SalesTradeAgreements_Show_Up()
        {
            // Go to SalesTradeAgreementss, get SalesTradeAgreements count, store
            ListTradeAgreementPage.GoTo();

            // TODO: implement record count after count element is added to the page
            //NewTradeAgreementPage.StoreCount();

            // Add a new SalesTradeAgreements
            ListTradeAgreementPage.GoTo();
            ListTradeAgreementPage.CreateTradeAgreement("Added TA Show up, name")
                .WithDescription("Added TA Show up, Description")
                .SaveChanges();
            
            // Go to SalesTradeAgreementss, get new SalesTradeAgreements count
            ListTradeAgreementPage.GoTo();
            //Assert.AreEqual(NewTradeAgreementPage.PreviousSalesTACount +1, NewTradeAgreementPage.CurrentSalesTACount, "Count of Trade Agreements did not increase by 1");

            // check for added SalesTradeAgreements
            Assert.IsTrue(ListTradeAgreementPage.DoesTradeAgreementExistWithName("Added TA Show up, name"), "Could not find the Sales Trace Agreement");
            
            // Delete SalesTradeAgreements (clean up)
            ListTradeAgreementPage.DeleteSalesTradeAgreement("Added TA Show up, name");
            //Assert.AreEqual(NewTradeAgreementPage.PreviousSalesTACount, NewTradeAgreementPage.CurrentSalesTACount, "Could not delete the Sales Trade Agreement");
            Assert.IsFalse(ListTradeAgreementPage.DoesTradeAgreementExistWithName("Added TA Show up, name"), "Could not delete Sales Trade Agreement");

        }
    }
}