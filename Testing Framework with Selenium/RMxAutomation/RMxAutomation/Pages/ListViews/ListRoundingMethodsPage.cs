using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.UI;
using RMxAutomationFramework.PageUtilities;
using RMxAutomationFramework.ActionBarOptions;

namespace RMxAutomationFramework.Pages.ListViews
{
    public class ListRoundingMethodsPage : ListPageObjectBaseClass
    {
        public static void GoTo()
        {
            SystemMenu.Settings.RoundingMethod.Select();           
        }

        public static bool IsAt()
        {
                Driver.Wait(TimeSpan.FromSeconds(10));
                
                string entityName = JsExecutor.JsExecutor.ExecuteScript("return getRouteContext().prop[0].EntityName").ToString();
                int platformResourceTypeId = Convert.ToInt32(JsExecutor.JsExecutor.ExecuteScript("return getRouteContext().prop[3].PlatformResourceTypeId"));

                if (entityName.Equals("RoundingMethod") && platformResourceTypeId == 5)
                    return true;
                else
                    return false;
        }

        public static CreateRoundingMethodCommand CreateRoundingMethod(string name)
        {
            //select Grid Add button
            Add();
            return new CreateRoundingMethodCommand(name);
        }
    }

    public class CreateRoundingMethodCommand
    {
        private readonly string name;
        private string description;

        public CreateRoundingMethodCommand(string name)
        {
            this.name = name;
        }
        public CreateRoundingMethodCommand WithDescription(string description)
        {
            this.description = description;
            return this;
        }

        public void SaveChanges()
        {
            Driver.Instance.FindElement(By.Id("nameTextbox")).SendKeys(name);
            //Driver.Instance.FindElement(By.XPath("//*[@id=\"az_form_rmx_tradeagreementversion_az_tab1_az_section2_az_composite6_az_textbox4\"]")).SendKeys(description);
            
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