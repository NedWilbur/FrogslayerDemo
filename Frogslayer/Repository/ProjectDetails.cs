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
        public class ProjectDetailsPage
        {
            private Repo repo;

            public ProjectDetailsPage(Repo _repo)
            {
                repo = _repo;
            }

            #region Elements
            private string basePath = "/html//div[@id='project-details-page']";
            public IWebElement projectHeader => repo.driver.FindElement(By.XPath($"{basePath}//span[text()='{DataSource.projectName}']"));
            #endregion

            #region Methods
            #endregion
        }
    }
}
