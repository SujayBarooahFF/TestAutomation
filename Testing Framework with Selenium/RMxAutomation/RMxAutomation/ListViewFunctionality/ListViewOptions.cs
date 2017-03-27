using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomationFramework
{
    public class ListViewOptions
    {
        // refactored methods to select an option available on the List View
        public static void Add()
        {
            var addnew = Driver.Instance.FindElement(By.CssSelector("#az_view_az_section1_az_grid1 > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-addnew"));
            addnew.Click();
            Driver.Wait(TimeSpan.FromSeconds(2));
        }
        public static void Delete()
        {
            var delete = Driver.Instance.FindElement(By.CssSelector("#az_view_az_section1_az_grid1 > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-remove"));
            delete.Click();
            Driver.Wait(TimeSpan.FromSeconds(2));
        }
        public static void Refresh()
        {
            var refresh = Driver.Instance.FindElement(By.CssSelector("#az_view_az_section1_az_grid1 > div.k-header.k-grid-toolbar > a.k-button.k-button-icontext.k-grid-refresh"));
            refresh.Click();
            Driver.Wait(TimeSpan.FromSeconds(2));
        }

        /*public static void SaveAsDefaultView()
        {
            
        }*/

    }
}
