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
        public class ProjectListPage
        {
            private Repo repo;

            public ProjectListPage(Repo _repo)
            {
                repo = _repo;
            }

            #region Elements
            private string basePath = "/html//div[@id='projects-page']";
            public IWebElement btnAddProject => repo.FindButton(basePath, "CREATE_PROJECT");
            #endregion

            #region Methods
            #endregion
        }
    }
}
