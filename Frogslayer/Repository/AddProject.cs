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
        public class AddProjectPage
        {
            private Repo repo;

            public AddProjectPage(Repo _repo)
            {
                repo = _repo;
            }

            #region Elements
            private string basePath = "/html//div[@id='project-new-page']";
            public IWebElement projectName => repo.FindInputByLabel(basePath, "Project Name");
            public IWebElement surveyCost => repo.FindInputByLabel(basePath, "Survey Cost");
            public IWebElement travelCost => repo.FindInputByLabel(basePath, "Travel Cost");
            public IWebElement btnSave => repo.driver.FindElement(By.XPath($"{basePath}//button[@type='submit']"));
            #endregion

            #region Methods
            #endregion
        }
    }
}
