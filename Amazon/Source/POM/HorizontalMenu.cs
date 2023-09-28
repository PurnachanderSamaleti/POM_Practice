using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Amazon.Source.Modules
{
    public class HorizontalMenu
    {
        IWebDriver _driver;
        public HorizontalMenu(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
                }
            [FindsBy(How = How.PartialLinkText, Using = "Home & Kitchen")]
            public IWebElement HomeandKitchen;

            [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
            public IWebElement searchbutton;

            [FindsBy(How = How.ClassName, Using = "icp-nav-flag")]
            public IWebElement Clickonlanguage;

            [FindsBy(How = How.XPath, Using = "(//span[@dir='ltr'])[7]")]
            public IWebElement SelectTelugulanguage;

            [FindsBy(How = How.ClassName, Using = "a-button-text")]
            public IWebElement Clickoncancel;
            
        }
    }

