using System;
using System.Globalization;
using OpenQA.Selenium;

namespace RealtAutomation.WebElements.Utils
{
	internal static class ByFactory
	{
		public static By From(FindAttribute attribute)
		{
			var how = attribute.How;
			var usingValue = attribute.Using;
			switch (how)
			{
				case How.Id:
					return By.Id(usingValue);
				case How.Name:
					return By.Name(usingValue);
				case How.TagName:
					return By.TagName(usingValue);
				case How.ClassName:
					return By.ClassName(usingValue);
				case How.CssSelector:
					return By.CssSelector(usingValue);
				case How.LinkText:
					return By.LinkText(usingValue);
				case How.PartialLinkText:
					return By.PartialLinkText(usingValue);
				case How.XPath:
					return By.XPath(usingValue);
			}

			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Did not know how to construct How from how {0}, using {1}", how, usingValue));
		}
	}
}
