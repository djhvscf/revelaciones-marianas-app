using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application
	{
		public App ()
		{
			var tabs = new TabbedPage ();

			//tabs.Children.Add (new LocalHtml {Title = "Local" });
			//tabs.Children.Add (new LocalHtmlBaseUrl {Title = "BaseUrl" });
			tabs.Children.Add (new WebPage { Title = "Revelaciones Marianas"});
			//tabs.Children.Add (new WebAppPage {Title ="External"});

			MainPage = tabs;
		}
	}
}

