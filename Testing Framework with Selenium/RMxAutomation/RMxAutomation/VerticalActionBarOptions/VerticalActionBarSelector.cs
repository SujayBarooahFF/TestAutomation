using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomationFramework.VerticalActionBarOptions
{
    public class VerticalActionBarSelector
    {
        // refactored method to select an option from the ActionBar (Popup or FullScreen)
        public static void Select(string ActionName)
        {
            var element = Driver.Instance.FindElement(By.ClassName(ActionName));
            element.Click();
        }
    }
}
