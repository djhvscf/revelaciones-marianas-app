using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class WebPage : ContentPage
	{
	    private readonly WebView _browser;

		public WebPage ()
		{
            _browser = new WebView
            {
                Source = "https://testrevmarianas.000webhostapp.com/"
            };
            
            Content = _browser;
		}

	    protected override bool OnBackButtonPressed()
	    {
	        if (_browser.CanGoBack)
	        {
	            _browser.GoBack();
	            return true;
	        }

	        return base.OnBackButtonPressed();
	    }
    }
}

