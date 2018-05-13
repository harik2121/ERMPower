using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ERMPower.common.Infra

{
    public class RetryFindElement : RetryWithTimeout<IWebElement>
    {
        private readonly RemoteWebDriver _driver;
        private readonly By _by;

        public RetryFindElement(RemoteWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public override IWebElement Execute()
        {
            for (var i = 0; i < NumOfRetries; i++)
            {
                try
                {
                    var element = _driver.FindElement(_by);

                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException)
                {
                    if (i == NumOfRetries - 1)
                    {
                        throw;
                    }
                }
                catch (StaleElementReferenceException)
                {
                    if (i == NumOfRetries - 1)
                    {
                        throw;
                    }
                }

                Thread.Sleep(TimeoutMilliseconds);
            }

            throw new NoSuchElementException(_by.ToString());
        }
    }
}
