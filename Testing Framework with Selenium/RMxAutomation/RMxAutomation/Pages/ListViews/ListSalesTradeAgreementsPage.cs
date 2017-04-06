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
    public class ListTradeAgreementPage : ListPageObjectBaseClass
    {
        public static int lastCount;
        
        public static void GoTo()
        {
            SystemMenu.RMx.SalesTradeAgreement.Select();           
        }

        public static bool IsAt()
        {
                Driver.Wait(TimeSpan.FromSeconds(10));
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                string entityName = js.ExecuteScript("return getRouteContext().prop[0].EntityName").ToString();
                int platformResourceTypeId = Convert.ToInt32(js.ExecuteScript("return getRouteContext().prop[3].PlatformResourceTypeId"));

                if (entityName.Equals("TradeAgreementVersion") && platformResourceTypeId == 5)
                    return true;
                else
                    return false;
        }

        public static CreateTradeAgreementCommand CreateTradeAgreement(string name)
        {
            //select Grid Add button
            Add();
            return new CreateTradeAgreementCommand(name);
        }

        /*public static void GoToNewTradeAgreement()
        {

        }
         */

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

        public static bool DoesTradeAgreementExistWithName(string name)
        {
            return Driver.Instance.FindElements(By.LinkText(name)).Any();
        }

        public static void DeleteSalesTradeAgreement(string name)
        {
            var selectedRecord = Driver.Instance.FindElements(By.LinkText(name)).Any();
        }

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

            ActionBar.SaveChanges.Select();       
        }
        public void DiscardChanges()
        {
            Driver.Wait(TimeSpan.FromSeconds(1));
            ActionBar.Cancel.Select();
        }

  }
}
