using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class DashboardPage
    {

        public static bool IsAt
        { 
            get
            {
                //var header = Driver.Instance.FindElements(By.TagName("h2"));
                var WorkspaceName = Driver.Instance.FindElement(By.Id("btnProfile"));
                                //WorkspaceName.GetType();
                      
                if (WorkspaceName.Text == "Sujay Barooah")
                    return true;
                return false;
            }
        }


        public static void LogOut()
        {
            var profileButton = Driver.Instance.FindElement(By.Id("btnProfile"));
            profileButton.Click();
            
            Thread.Sleep(500);
            
            var logoutButton = Driver.Instance.FindElement(By.ClassName("btn-logoff"));
            logoutButton.Click();
            
            Thread.Sleep(500);
            //This is a temporary page- should be re-directed to landing page automatically
            var logoutRedirect = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/a"));
            logoutRedirect.Click();
            
        }
    }
}
