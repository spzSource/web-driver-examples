using OpenQA.Selenium;
using ATFramework.Framework;
using ATFramework.Framework.Extensions;

namespace ATFramework.WebElements
{
	public class ComboBox : BaseElement
	{
		public ComboBox(By by)
		{
			this.byLocator = by;
		}

		public ComboBox(IWebElement element)
		{
			WebElement = element;
		}

		public void SendKeys(string key)
		{
			WebElement = Browser.Driver.SafeFindElement(byLocator, WaitTimeInSeconds);
			WebElement.SendKeys(key);
		}

		public override void Click()
		{
			WebElement = Browser.Driver.SafeFindElement(byLocator, WaitTimeInSeconds);
			WebElement.Click();
		}

		public override bool IsDisplayed()
		{
			WebElement = Browser.Driver.SafeFindElement(byLocator, WaitTimeInSeconds);
			return WebElement.Displayed;
		}
	}
}
