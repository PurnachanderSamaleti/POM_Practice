using Amazon.Source.Modules;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Test
{
    public class TestCases:Base

    {
        IWebDriver driver;

        [Test]
        public void Horizontalitems()
        {
            HorizontalMenu HM = new HorizontalMenu(driver);
            HM.HomeandKitchen.Click();
            HM.searchbutton.Click();
            HM.Clickonlanguage.Click();
            HM.SelectTelugulanguage.Click();
            HM.Clickoncancel.Click();
        }
    }
}
