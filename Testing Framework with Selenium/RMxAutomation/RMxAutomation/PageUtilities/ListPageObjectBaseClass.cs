using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RMxAutomationFramework.PageUtilities
{
    public class ListPageObjectBaseClass
    {
        //public static int lastCount;

        // this probably is not a good contender for generics. Need to be inside each class.
        public static bool IsAt
        {
            get
            {
                //string[] pageId = new string[2];
                // uncomment after get routeContext is implemented on the page runtime    
                Driver.Wait(TimeSpan.FromSeconds(10));
                //List<object> routeContext = ((IJavaScriptExecutor)Driver.Instance).ExecuteScript("return window.getRouteContext") as List<object>;
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                var routeContext = js.ExecuteScript("return eName()");
                //var platformContext = ((IJavaScriptExecutor)Driver.Instance).ExecuteScript("return platformcontext");
                //string entityName = routeContext.EntityName.toString();
                // string viewType = routeContext.PlatformResourceTypeId.toString();
                
                // pageId [0] = entityName;
                // pageId [1] = viewType;                               
                if (routeContext != null)
                    return true;
                else
                    return false;
            }
        }

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

        /*public static void GoTo()
        {
           
        }*/
       
        /*public static void GoToNewRecord()
        {

        }*/

        /* public static void StoreRecordCount()
        {
            lastCount = GetSalesTradeAgreementCount();
        }*/

        /*private static int GetRecordCount()
        {
            // find count of 
            return 0;
        }*/

        //public static int PreviousSalesTACount { get; set; }

        //public static string CurrentSalesTACount { get; set; }

        /*public static bool DoesRecordExistWithName(string name)
        {
            return Driver.Instance.FindElements(By.LinkText(name)).Any();
        }*/

        /*public static void DeleteRecord(string recordName)
        {   
            throw new NotImplementedException();
        }*/
    }

 }
