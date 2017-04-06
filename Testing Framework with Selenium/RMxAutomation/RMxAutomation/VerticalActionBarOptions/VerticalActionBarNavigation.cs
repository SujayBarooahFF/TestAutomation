using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomationFramework.VerticalActionBarOptions
{
    public class VerticalActionBarNavigation
    {
        // Access items under RMx workspace/ solution
        public class CreateNew      
        {
            public static void Select()
            {
                VerticalActionBarSelector.Select("glyphicon   glyphicon-plus");
                Driver.Wait(TimeSpan.FromSeconds(1));
            }
        }

        public class Duplicate  
        {
            public static void Select()
            {
                VerticalActionBarSelector.Select("glyphicon   glyphicon-duplicate");
                Driver.Wait(TimeSpan.FromSeconds(3));
            }
        }

        public class Delete
        {
            public static void Select()
            {
                VerticalActionBarSelector.Select("glyphicon   glyphicon-trash");
                Driver.Wait(TimeSpan.FromSeconds(3));
            }
        }
        public class MakeFavourite
        {
            public static void Select()
            {
                VerticalActionBarSelector.Select("glyphicon   glyphicon-star");
                Driver.Wait(TimeSpan.FromSeconds(3));
            }
        }
    }
}
