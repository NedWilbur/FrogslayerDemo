using Frogslayer.Repository;
using Frogslayer.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogslayer.Test
{
    class Login : Hooks
    {
        [Test]
        public void User_Login()
        {
            repo.loginPage.Login();

            Assert.That(repo.header.btnLogout.Displayed);
        }
    }
}
