using OpenQA.Selenium;

namespace RealtAutomation.Framework
{
	public abstract class BaseElement : BaseEntity
	{
		protected By byLocator;
		protected IWebElement WebElement{ get; set; }
		protected readonly int WaitTimeInSeconds = 10;

		public abstract bool IsDisplayed();
		public abstract void Click();
	}
}
