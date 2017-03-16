using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class MenuSelector
    {
        // refactored method to navigate to any option on the system menu
        public static void Select(string sysMenuClassName, string solutionXPath, string optionXpath)
        {
            Driver.Instance.FindElement(By.ClassName(sysMenuClassName)).Click();
            Driver.Instance.FindElement(By.XPath(solutionXPath)).Click();
            Driver.Instance.FindElement(By.XPath(optionXpath)).Click();
        }
    }
}
