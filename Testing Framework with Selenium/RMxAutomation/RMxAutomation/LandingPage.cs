using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class LandingPage
    {
        public static bool IsAt
        {
            get
            {

                var Landing = Driver.Instance.FindElement(By.ClassName("logo-rm"));

                if (Landing != null)
                    return true;
                return false;
            }
        }
    }
}
