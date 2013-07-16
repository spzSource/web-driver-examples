using ATFramework.Framework;
using ATFramework.Framework.Extensions;
using OpenQA.Selenium;

namespace ATFramework.WebElements
{
	public class Button : BaseElement
	{
		public Button(By by)
		{
			this.byLocator = by;
		}

		public Button(IWebElement element)
		{
			WebElement = element;
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
