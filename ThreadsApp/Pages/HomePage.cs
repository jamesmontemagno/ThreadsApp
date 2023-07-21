using ThreadsApp.Helpers;
using ThreadsApp.Controls;

namespace ThreadsApp.Pages;
public partial class HomePage : BasePage
{
	public HomePage()
	{
	}

    public override void Build()
    {
        var listView = new ListView(ListViewCachingStrategy.RetainElement)
        {
            HasUnevenRows = true,
            ItemTemplate = new DataTemplate(typeof(ThreadCell)),
            IsPullToRefreshEnabled = true,
            SelectionMode = ListViewSelectionMode.None,
            SeparatorVisibility = SeparatorVisibility.None,
            ItemsSource = ThreadsGenerator.CreateThreads()
        };

        Content = listView;
    }

}