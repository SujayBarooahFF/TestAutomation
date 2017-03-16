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
                    /*
                        var sysMenu = Driver.Instance.FindElement(By.ClassName("hamburger"));
                        sysMenu.Click();
                        Driver.Wait(TimeSpan.FromSeconds(1));
                        var RMxOption = Driver.Instance.FindElement(By.XPath("//*[@id=\"listViewSolutions\"]/div[1]"));
                        RMxOption.Click();
                        var selectTradeAgreement = Driver.Instance.FindElement(By.XPath("//*[@id=\"listViewGroups\"]/div[4]/a"));
                        selectTradeAgreement.Click();
                     */
                    Driver.Wait(TimeSpan.FromSeconds(1));                   
                }
            }
        }        
    }
}
