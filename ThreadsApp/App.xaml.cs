namespace ThreadsApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	public static object GetColorResource(string key)
    {
		var colors = App.Current.Resources.MergedDictionaries.First(x => x.Source.OriginalString.Contains("Colors.xaml")); 
		return colors[key];
    }
}
