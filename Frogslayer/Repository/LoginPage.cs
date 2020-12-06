using Frogslayer.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogslayer.Repository
{
    public partial class Repo
    {
        /// <summary>
        /// Login page 
        /// http://paramount-demo.frogslayerdev.com/app/#!/login/
        /// </summary>
        public class LoginPage
        {
            private Repo repo;

            public LoginPage(Repo _repo)
            {
                repo = _repo;
            }

            #region Elements
            private string basePath = $"//div[@id='login-page']//form[@role='form']";
            public IWebElement inpUserName => repo.FindInputByLabel(basePath, "Email");
            public IWebElement inpPassword => repo.FindInputByLabel(basePath, "Password");
            public IWebElement btnLogin => repo.FindButton(basePath, "login");
            #endregion

            #region Methods
            /// <summary>
            /// Logs into AUT
            /// </summary>
            /// <param name="userName"></param>
            /// <param name="password"></param>
            public void Login(string userName = null, string password = null)
            {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    userName = DataSource.userName;
                    password = DataSource.password;
                }

                Debug.WriteLine($"Logging in ({userName}/{password})");
                inpUserName.SendKeys(userName);
                inpPassword.SendKeys(password);
                btnLogin.Click();
            }
            #endregion
        }
    }
}
