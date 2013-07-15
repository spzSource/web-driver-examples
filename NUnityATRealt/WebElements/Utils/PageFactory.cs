//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace NUnitATRealt.WebElements.Utils
//{
//	class PageFactory
//	{
//		public PageFactory()
//		{ }

//		public static void InitElements(ISearchContext driver, object page)
//		{
//			Type type = page.GetType();
//			List<MemberInfo> members = new List<MemberInfo>();

//			const BindingFlags PublicBindingOptions = BindingFlags.Instance | BindingFlags.Public;
//			members.AddRange(type.GetFields(PublicBindingOptions));
//			members.AddRange(type.GetProperties(PublicBindingOptions));

//			while (type != null)
//			{
//				const BindingFlags NonPublicBindingOptions = BindingFlags.Instance | BindingFlags.NonPublic;
//				members.AddRange(type.GetFields(NonPublicBindingOptions));
//				members.AddRange(type.GetProperties(NonPublicBindingOptions));
//				type = type.BaseType;
//			}

//			foreach (var member in members)
//			{
//				By by = CreateLocatorList(member);
//				if (by != null)
//				{
//					object proxyObject = null;
//					var field = member as FieldInfo;
//					var property = member as PropertyInfo;
//					if (field != null)
//					{
//						proxyObject = CreateProxyObject(field.FieldType, driver, by);
//						if (proxyObject == null)
//						{
//							throw new ArgumentException("Type of field '" + field.Name + "' is not IWebElement or IList<IWebElement>");
//						}

//						field.SetValue(page, proxyObject);
//					}
//					else if (property != null)
//					{
//						proxyObject = CreateProxyObject(property.PropertyType, driver, by);
//						if (proxyObject == null)
//						{
//							throw new ArgumentException("Type of property '" + property.Name + "' is not IWebElement or IList<IWebElement>");
//						}

//						property.SetValue(page, proxyObject, null);
//					}
//				}
//			}
//		}

//		private static By CreateLocatorList(MemberInfo member)
//		{
//			By by = null;
//			Attribute[] attributes = Attribute.GetCustomAttributes(member, typeof(FindAttribute), true);
//			if (attributes.Length > 0)
//			{
//				var castedAttribute = (FindAttribute)attributes.First();
//				if (castedAttribute.Using == null)
//				{
//					castedAttribute.Using = member.Name;
//				}

//				by = castedAttribute.Finder;
//			}
//			return by;
//		}

//		private static object CreateProxyObject(Type memberType, ISearchContext driver, By by)
//		{
//			object proxyObject = new WebElementProxy(driver, by);
//			return proxyObject;
//		}
//	}
//}
