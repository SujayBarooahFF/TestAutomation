using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class ListReferencesPage
    {   
        public static void GoTo()
        {
            //SystemMenuNavigation.Settings.References.Select();            
            SystemMenuNavigation.RMx.SalesTradeAgreement.Select();

            // change xPath to References
            var addnew = Driver.Instance.FindElement(By.CssSelector("#az_view_az_section1_az_grid1 > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-addnew"));
            addnew.Click();
            Driver.Wait(TimeSpan.FromSeconds(1));
        }

        public static CreateReferenceCommand CreateReference(string name)
        {
            return new CreateReferenceCommand(name);
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

        public static bool DoesReferenceExistWithName(string name)
        {
            return Driver.Instance.FindElements(By.LinkText(name)).Any();
        }

        public static void DeleteReference(string p)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateReferenceCommand
    {
        private readonly string name;
        private string description;

        public CreateReferenceCommand(string name)
        {
            this.name = name;
        }
        public CreateReferenceCommand WithDescription(string description)
        {
            this.description = description;
            return this;
        }

        public void SaveChanges()
        {
            Driver.Instance.FindElement(By.Id("nameTextbox")).SendKeys(name);
            Driver.Instance.FindElement(By.XPath("//*[@id=\"az_form_rmx_tradeagreementversion_az_tab1_az_section2_az_composite6_az_textbox4\"]")).SendKeys(description);

            Driver.Wait(TimeSpan.FromSeconds(1));

            Driver.Instance.FindElement(By.CssSelector("#az_form_rmx_tradeagreementversion_az_actionbar1 > div.actionbarcontent > div > ul > li:nth-child(1)")).Click();
            Driver.Wait(TimeSpan.FromSeconds(2));

        }

    }
}
