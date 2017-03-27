using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomationFramework
{
    public class ListReferencesPage
    {   
        public static void GoTo()
        {
            SystemMenu.Settings.ReferenceType.Select();        
                    
            var addnew = Driver.Instance.FindElement(By.CssSelector("#az_view_az_section1_az_grid1 > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-addnew"));
            addnew.Click();
            Driver.Wait(TimeSpan.FromSeconds(1));
        }

        public static CreateReferenceCommand CreateReference(string code)
        {
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

            Driver.Instance.FindElement(By.ClassName("actionname")).Click();
            Driver.Wait(TimeSpan.FromSeconds(2));

        }

    }
}
