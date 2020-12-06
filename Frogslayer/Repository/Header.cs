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
        public class Header
        {
            private Repo repo;

            public Header(Repo _repo)
            {
                repo = _repo;
            }

            #region Elements
            private string basePath = "/html";
            public IWebElement searchBar => repo.driver.FindElement(By.XPath($"{basePath}//input[@id='search']"));
            public IWebElement btnSearch => repo.FindButton(basePath, "Search");
            public IWebElement btnLogout => repo.FindButton(basePath, "logout");
            #endregion

            #region Methods
            #endregion
        }
    }
}
