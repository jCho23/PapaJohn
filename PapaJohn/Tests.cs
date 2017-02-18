using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

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

		//[SetUp]
		//public void SetLocation(Double 37.773972, Double -122.431297)
		//{
		//	app = AppInitializer.StartApp(platform);
		//}
	
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
			app.Tap("button2");
			app.Screenshot("Dismissed notification");

			app.Tap("signInButton");
			app.Screenshot("Let's start by Tapping on the 'Sign In' Button");

			app.Tap("emailTextField");
			app.Screenshot("Then we Tapped the Email 'Text Field'");
			app.EnterText("papajohn23@gmail.com");
			app.Screenshot("We entered our Email, 'papajohn23@gmail.com'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("passwordTextField");
			app.Screenshot("Next, we Tapped on the password 'Text Field'");
			app.EnterText("Papajohn23");
			app.Screenshot("Then we entered our password, 'Papajohn23'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("signInButton");
			app.Screenshot("Then we Tapped the 'Sign In' Button");

			app.Tap("orderDeliveryButton");
			app.Screenshot("Next we Tapped on the 'Order for Delivery' Button");

			app.Tap("enter_address_action_button");
			app.Screenshot("We Tapped on the 'Enter Address Button");

			app.Tap("text1");
			app.Screenshot("Then we Tapped on 'Similar Places'");
			app.Tap(x => x.Marked("text1").Index(1));
			app.Screenshot("Next we Tapped on '210-222 Market St'");

			app.Tap(x => x.Marked("text1").Index(1));
			app.Screenshot("We Tapped on 'Street Number'");

			app.Tap("210");
			app.Screenshot("Then we Tapped on '210'"); 
			app.Tap("go_button");
			app.Screenshot("Next we Tapped on the 'Go' Button");

			app.Tap("Pizza");
			app.Screenshot("We Tapped on 'Pizza'");
			app.Tap("Papa's Picks");
			app.Screenshot("Next Tapped on 'Papa's Picks'");
			app.Tap("Pepperoni");
			app.Screenshot("Then Tapped on our favorite pizza, 'Pepperoni'");
			app.Tap("Extra Large Original Crust Pepperoni");
			app.Screenshot("Let's Tap on the 'Extra Large' size");

			app.Tap("add_to_order");
			app.Screenshot("Then we Tapped on 'add to order' ");
			app.Tap("top_cart_button");


			app.Tap("checkout");
		}

	}
}
