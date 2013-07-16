using OpenQA.Selenium;

namespace ATFramework.Framework
{
    public abstract class BasePage : BaseEntity
    {
		protected IWebDriver Driver
		{
			get { return Browser.Driver; }
		}

		public T LoadPage<T>(string menuItem)  where T : class
		{
			T page = null;



			return page;
		}
    }
}
