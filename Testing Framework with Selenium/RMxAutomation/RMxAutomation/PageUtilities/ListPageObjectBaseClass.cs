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

        public static string[] IsAt
        {
            get
            {
                string[] pageId = new string[2];
               /* uncomment after get routeContext is implemented on the page runtime    
                * 
                var routeContext = ((IJavaScriptExecutor)Driver.Instance).ExecuteScript("return routeContext");
                string entityName = routeContext.EntityName.toString();
                string viewType = routeContext.PlatformResourceTypeId.toString();
                
                pageId [0] = entityName;
                pageId [1] = viewType;
                */
                return (pageId);
               
            }
        }

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
