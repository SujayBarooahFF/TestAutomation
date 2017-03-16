using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RMxAutomation
{
    public class NewTradeAgreementPage
    {

        public static void GoTo()
        {
            // Refactor: Should we make a general menu navigation? -- done
            SystemMenuNavigation.RMx.SalesTradeAgreement.Select();

            //Refactor: should we make generic CRUD operations?
            var addnew = Driver.Instance.FindElement(By.CssSelector("#az_view_az_section1_az_grid1 > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-addnew"));
            addnew.Click();
            Driver.Wait(TimeSpan.FromSeconds(1));
        }

        public static CreateTradeAgreementCommand CreateTradeAgreement(string name)
        {
            return new CreateTradeAgreementCommand(name);
        }

        /*
        public static void GoToNewTradeAgreement()
        {

        }
         */

    }

    public class CreateTradeAgreementCommand
    {
        private readonly string name;
        private string description;

        public CreateTradeAgreementCommand(string name)
        {
            this.name = name;
        }
        public CreateTradeAgreementCommand WithDescription(string description)
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
