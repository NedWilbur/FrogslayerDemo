using NUnit.Framework;
using Frogslayer.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Frogslayer.Test
{
    class NewProject : Hooks
    {
        [Test]
        public void CreateNewProject()
        {
            repo.loginPage.Login(); // TODO: Move to [setup] since needed in every unit test?

            Task.Delay(3000).Wait();  // quick patch for StaleElementReferenceException until better solution implemented
            repo.projectList.btnAddProject.Click();

            repo.addProject.projectName.SendKeys(DataSource.projectName);
            repo.addProject.surveyCost.SendKeys(DataSource.surveyCost);
            repo.addProject.travelCost.SendKeys(DataSource.travelCost);
            repo.addProject.btnSave.Click();

            Assert.That(repo.projectDetails.projectHeader.Displayed);
        }


    }
}
