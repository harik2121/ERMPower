using System;
using System.Threading;
using OpenQA.Selenium;


namespace ERMPower.common.Infra
{

    public class RetryClickElement : RetryWithTimeout<bool>
    {
        private readonly IWebElement _webElement;

        public RetryClickElement(IWebElement webElement)
        {
            _webElement = webElement;
        }

        public override bool Execute()
        {
            for (var i = 0; i < NumOfRetries; i++)
            {
                try
                {
                    _webElement.Click();
                    return true;
                }
                catch (ElementNotVisibleException)
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

            throw new StaleElementReferenceException(_webElement.ToString());
        }
    }
}
