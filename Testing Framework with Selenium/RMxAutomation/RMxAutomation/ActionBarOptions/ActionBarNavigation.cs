using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomationFramework.ActionBarOptions
{
    public class ActionBar
    {
        // Access items under RMx workspace/ solution
        public class SaveChanges
        {
                public static void Select()
                {
                    ActionBarSelector.Select("actionname");
                    Driver.Wait(TimeSpan.FromSeconds(1));                   
                }
        }

        public class Cancel
        {
            public static void Select()
            {
                ActionBarSelector.Select("actionname-cancel");
                Driver.Wait(TimeSpan.FromSeconds(3));
            }
        }

    }
}
