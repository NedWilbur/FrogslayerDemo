using NUnit.Framework;
using Frogslayer.Utils;
using System.Threading.Tasks;

namespace Frogslayer.Test
{
    class SearchProject : Hooks
    {
        [Test]
        public void SearchForProject()
        {
            repo.loginPage.Login();
            repo.header.searchBar.SendKeys(DataSource.projectName);
            repo.header.btnSearch.Click();
            repo.header.btnSearch.Click(); //! clicks twice to workaround issue; results do not always show on first click

            Assert.That(repo.searchResults.projectResult.Displayed);
        }
    }
}
