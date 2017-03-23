using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class SystemMenu
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
            public class PriceInquiry
            {
                public static void Select()
                {
                    MenuSelector.Select("hamburger", "//*[@id=\"listViewSolutions\"]/div[1]", "//*[@id=\"listViewGroups\"]/div[2]/a");
                    Driver.Wait(TimeSpan.FromSeconds(1));
                }
            }            
        }
        
        public class Settings
        {
            public class ReferenceType
            {
                public static void Select()
                {
                    MenuSelector.Select("hamburger", "//*[@id=\"listViewSolutions\"]/div[2]", "//*[@id=\"listViewGroups\"]/div[2]/a");
                    Driver.Wait(TimeSpan.FromSeconds(1));
                }
            }
            // other menu options here... Rounding Method, Company etc.
                        
        }        
    }
    // sytem admin
}
