using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogslayer.Repository
{
    public partial class Repo
    {
        private IWebDriver driver { get; set; }

        public LoginPage loginPage { get; set; }
        public Header header { get; set; }
        public ProjectListPage projectList { get; set; }
        public AddProjectPage addProject { get; set; }
        public ProjectDetailsPage projectDetails { get; set; }
        public SearchResults searchResults { get; set; }

        public Repo(IWebDriver driver)
        {
            // Web driver
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Pages
            loginPage = new LoginPage(this);
            header = new Header(this);
            projectList = new ProjectListPage(this);
            addProject = new AddProjectPage(this);
            projectDetails = new ProjectDetailsPage(this);
            searchResults = new SearchResults(this);
        }

        #region Methods
        /// <summary>
        /// Finds a button with "dataBindText" tcontained within the data-bind attribute
        /// Useful when the element does not have a unique ID or other attribute
        /// </summary>
        /// <param name="dataBindText">Text contained within the element's data-bind attribute</param>
        private IWebElement FindButton(string basePath, string dataBindText) => driver.FindElement(By.XPath($"{basePath}//*[contains(@data-bind, '{dataBindText}')]"));
        
        /// <summary>
        /// Finds input field based on parent label text
        /// Useful when the element does not have a unique ID or other attribute
        /// </summary>
        /// <param name="basePath"></param>
        /// <param name="LabelText"></param>
        /// <param name="timeoutInSeconds"></param>
        /// <returns></returns>
        private IWebElement FindInputByLabel(string basePath, string LabelText) => driver.FindElement(By.XPath($"{basePath}//label[text()='{LabelText}']/../input"));
        #endregion
    }
}
