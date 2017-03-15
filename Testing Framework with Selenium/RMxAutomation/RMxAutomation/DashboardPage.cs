using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
