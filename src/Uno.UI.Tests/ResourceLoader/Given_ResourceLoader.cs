﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uno.UI.Tests.ResourceLoaderTests
{
	[TestClass]
	public class Given_ResourceLoader
	{
		[TestCleanup]
		public void TestCleanup()
		{
			Windows.ApplicationModel.Resources.ResourceLoader.ClearResources();
		}

		[TestMethod]
		public void When_ResourceFile_Neutral()
		{
			var file = GetType().Assembly.GetManifestResourceNames().First(r => r.EndsWith("ResourceLoader.When_ResourceFile-en.upri", StringComparison.OrdinalIgnoreCase));

			using (var s = GetType().Assembly.GetManifestResourceStream(file))
			{
				Windows.ApplicationModel.Resources.ResourceLoader.DefaultLanguage = "en";
				Windows.ApplicationModel.Resources.ResourceLoader.ProcessResourceFile(file, s);

				Assert.AreEqual("App70", Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString("ApplicationName"));
			}
		}

		[TestMethod]
		public void When_ResourceFile_Neutral_Both()
		{
			void setResources(string language)
			{
				CultureInfo.CurrentUICulture = new CultureInfo(language);
				Windows.ApplicationModel.Resources.ResourceLoader.ClearResources();
				Windows.ApplicationModel.Resources.ResourceLoader.DefaultLanguage = language;
				RegisterResourceFile("When_ResourceFile_Neutral_Both-en.upri");
				RegisterResourceFile("When_ResourceFile_Neutral_Both-fr.upri");
			}

			setResources("fr");
			Assert.AreEqual("App70-fr", Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString("ApplicationName"));

			setResources("fr-FR");
			Assert.AreEqual("App70-fr", Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString("ApplicationName"));

			setResources("en");
			Assert.AreEqual("App70-en", Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString("ApplicationName"));
		}

		private void RegisterResourceFile(string Value)
		{
			var file = GetType().Assembly.GetManifestResourceNames().First(r => r.EndsWith(Value, StringComparison.OrdinalIgnoreCase));

			using (var s = GetType().Assembly.GetManifestResourceStream(file))
			{
				Windows.ApplicationModel.Resources.ResourceLoader.ProcessResourceFile(file, s);
			}
		}
	}
}
