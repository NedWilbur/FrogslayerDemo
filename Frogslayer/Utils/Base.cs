using Frogslayer.Repository;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogslayer.Utils
{
    public class Base
    {
        public IWebDriver webDriver { get; set; }
        public Repo repo { get; set; }
    }
}
