using System.Linq;
using ATFramework.Framework.Extensions;
using OpenQA.Selenium;

namespace ATFramework.Framework
{
	public abstract class BaseElement : BaseEntity
	{
		protected By byLocator;
		protected IWebElement WebElement{ get; set; }
		protected readonly int WaitTimeInSeconds = 10;

		public abstract bool IsDisplayed();
		public abstract void Click();

		public virtual bool isPresent()
		{
			bool result = false;
			if (Browser.Driver.SafeFindElements(byLocator, WaitTimeInSeconds).Count() > 0)
			{
				result = true;
			}
			return result;
		}
	}
}
