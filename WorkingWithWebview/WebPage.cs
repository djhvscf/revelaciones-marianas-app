using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class WebPage : ContentPage
	{
		public WebPage ()
		{
			var browser = new WebView();

			browser.Source = "https://testrevmarianas.000webhostapp.com/";

			Content = browser;
		}
	}
}

