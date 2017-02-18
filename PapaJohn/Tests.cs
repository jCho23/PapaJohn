using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PapaJohn
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[SetUp]
		public void SetLocation(Double 37.773972, Double -122.431297)
		{
			app = AppInitializer.StartApp(platform);
		}
	
		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void OrderForDeliveryTest()
		//E-Mail: papajohn23@gmail.com
		//Pass: Papajohn23
		{
			//app.Tap("button2");
			//app.Screenshot("Dismissed notification");

			app.Tap("signInButton");
			app.Tap("emailTextField");
			app.EnterText("papajohn23@gmail.com");
			app.DismissKeyboard();

			app.Tap("passwordTextField");
			app.EnterText("Papajohn23");
			app.DismissKeyboard();

			app.Tap("signInButton");
			app.Screenshot("Then we Tapped the 'Sign In' Button");
		}

		[Test]
		public void OrderForCarryOutTest()
		{
			
		}

	}
}
