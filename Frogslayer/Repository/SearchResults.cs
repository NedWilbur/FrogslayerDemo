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
        public class SearchResults
        {
            private Repo repo;

            public SearchResults(Repo _repo)
            {
                repo = _repo;
            }

            #region Elements
            private string basePath = "/html//div[@id='body-content']//div[@class='row']/div[2]";
            public IWebElement projectResult => repo.driver.FindElement(By.XPath($"{basePath}//h4[text()='{DataSource.projectName}']"));
            #endregion

            #region Methods
            #endregion
        }
    }
}
