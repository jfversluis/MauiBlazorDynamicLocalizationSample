using System.Globalization;

namespace MauiBlazorLocalizationSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var language = Preferences.Get("language", "en-US");
		var culture = new CultureInfo(language);

		Thread.CurrentThread.CurrentCulture = culture;
		Thread.CurrentThread.CurrentUICulture = culture;
		CultureInfo.DefaultThreadCurrentCulture = culture;
		CultureInfo.DefaultThreadCurrentUICulture = culture;

		MainPage = new MainPage();
	}
}
