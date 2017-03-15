using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMxAutomation
{
    public class LoginPage
    {

        public static void Goto()
        {
            Driver.Instance.Navigate().GoToUrl("http://azara-qa.foxdev.flintfox.com");
            //var wait = new WebDriverWait(Driver.)
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;
        public LoginCommand (string userName)
        {
            this.userName = userName;
        }
        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("Email"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("Password"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.ClassName("btn-login"));
            loginButton.Click();
        }
    }
}
