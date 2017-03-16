﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class TradeAgreementPage
    {
        public static string text;
        public static string Name
        {
            get
            {
                // need explicit waits here... TODO wait till element is loaded on page
                Thread.Sleep(5000);
                var element = Driver.Instance.FindElement(By.Id("nameTextbox"));
                text = element.GetAttribute("value");
                if (text != "")
                {
                    //text = name.Text;
                    return text;
                }                   
                return String.Empty;
            }
        }
    }
}