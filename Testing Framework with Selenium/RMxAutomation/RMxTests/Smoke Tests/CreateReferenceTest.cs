using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomation;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class CreateReferenceTest : RMxTestsBaseClass
    {
        [TestMethod]
        public void Can_Create_A_ReferenceType()
        {   
            ListReferencesPage.GoTo();
            ListReferencesPage.CreateReference("ReferenceTestName")
                .WithDescription("Reference Automated Test creation")
                .SaveChanges();
            Driver.Wait(TimeSpan.FromSeconds(1));

            Assert.AreEqual(ReferencePage.Name, "ReferenceTestName", "Name did not match with new Reference");
        }
    }
}
