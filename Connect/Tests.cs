using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Connect
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile("/Users/junecho/Desktop/Connect.apk")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{

			app.WaitForElement(x => x.Text(("Use my phone number")));
			app.Flash(x => x.Text("Use my phone number"));
			app.Tap(x => x.Text("Use my phone number"));
			app.Screenshot("Phone Number Field");

			app.Tap(x => x.Id("dgts__countryCode"));
			app.Screenshot("Country Code Field");

			app.ScrollDownTo((x => x.Id("text1").Text("United States +1")));
			app.Tap(x => x.Id("text1").Text("United States +1"));
			app.Screenshot("Scrolling down to United States Field");

			app.EnterText("4087188819");
			app.Screenshot("Phone number Field");
			app.Tap((x => x.Text("Continue")));





		}
	}
}
