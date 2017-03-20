using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class SystemMenuNavigation
    {
        public class RMx
        {
            public class SalesTradeAgreement
            {
                public static void Select()
                {
                    MenuSelector.Select("hamburger", "//*[@id=\"listViewSolutions\"]/div[1]", "//*[@id=\"listViewGroups\"]/div[4]/a");
                    Driver.Wait(TimeSpan.FromSeconds(1));                   
                }
            }
        }        
    }
    // other menu options here
}
