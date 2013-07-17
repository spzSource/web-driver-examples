using System.Linq;
using ATFramework.Framework.Extensions;
using OpenQA.Selenium;

namespace ATFramework.Framework
{
	public abstract class BaseElement : BaseEntity
	{
		private IWebElement element;
		protected By byLocator;
	
		public IWebElement WebElement
		{
			get
			{
				if (element == null)
					element = Browser.Driver.SafeFindElement(byLocator, WaitTimeInSeconds);
				return element;
			}
			set 
			{ 
				element = value; 
			}
		}
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
