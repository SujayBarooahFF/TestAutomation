using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMxAutomationFramework
{
    public class DashboardPage
    {

        public static bool IsAt
        { 
            get
            {
                // Refactor: can we create a generalized IsAt for all pages?- Check with shishir for page ID
                var WorkspaceName = Driver.Instance.FindElement(By.Id("btnProfile"));
                if (WorkspaceName.Text == "Sujay Barooah")
                    return true;
                return false;
            }
        }


        public static void LogOut()
        {
            var profileButton = Driver.Instance.FindElement(By.Id("btnProfile"));
            profileButton.Click();

            Driver.Wait(TimeSpan.FromSeconds(1));
            
            var logoutButton = Driver.Instance.FindElement(By.ClassName("btn-logoff"));
            logoutButton.Click();

            Driver.Wait(TimeSpan.FromSeconds(1));

            //This is a temporary page- should be re-directed to landing page automatically
            var logoutRedirect = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/a"));
            logoutRedirect.Click();
            
        }
    }
}
