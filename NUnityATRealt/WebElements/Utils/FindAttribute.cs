using System;
using OpenQA.Selenium;

namespace RealtAutomation.WebElements.Utils
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
	public sealed class FindAttribute : Attribute
	{
		public How How { get; set; }
		public string Using { get; set; }
		
		private By finder = null;

		internal By Finder
		{
			get
			{
				if (this.finder == null)
				{
					this.finder = ByFactory.From(this);
				}

				return this.finder;
			}

			set
			{
				this.finder = (By)value;
			}
		}
	}
}
