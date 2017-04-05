using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.UI;
using RMxAutomationFramework.PageUtilities;
using RMxAutomationFramework.ActionBarOptions;

namespace RMxAutomationFramework
{
    public class ListReferencesPage : ListPageObjectBaseClass
    {   
        public static void GoTo()
        {
            SystemMenu.Settings.ReferenceType.Select();                  
        }

        public static CreateReferenceCommand CreateReference(string code)
        {
            Add();
            return new CreateReferenceCommand(code);
        }

        /* public static void StoreCount()
        {
            lastCount = GetSalesTradeAgreementCount();
        }*/

        /*private static int GetSalesTradeAgreementCount()
        {
            // find count of 
            return 0;
        }*/

        //public static int PreviousSalesTACount { get; set; }

        //public static string CurrentSalesTACount { get; set; }

        public static bool DoesReferenceExistWithCode(string code)
        {
            return Driver.Instance.FindElements(By.LinkText(code)).Any();
        }

        public static void DeleteReference(string p)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateReferenceCommand
    {
        private readonly string code;
        private string description;

        public CreateReferenceCommand(string code)
        {
            this.code = code;
        }
        public CreateReferenceCommand WithDescription(string description)
        {
            this.description = description;
            return this;
        }

        public void SaveChanges()
        {
            Driver.Instance.FindElement(By.Id("az_form_az_referencetype_az_tab1_az_section2_az_composite4_az_textbox2")).SendKeys(code);
            Driver.Instance.FindElement(By.Id("az_form_az_referencetype_az_tab1_az_section2_az_composite6_az_textbox4")).SendKeys(description);

            Driver.Wait(TimeSpan.FromSeconds(1));

            ActionBar.SaveChanges.Select();       

        }

    }
}
