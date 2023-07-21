using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration;
using ListView = Microsoft.Maui.Controls.ListView;
using CommunityToolkit.Mvvm.ComponentModel;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using ThreadsApp.Controls;
using ThreadsApp.Helpers;
using ThreadsApp.Models;

namespace ThreadsApp.Pages;

public partial class SearchPage : BasePage
{
	public SearchPage()
	{
        Shell.SetSearchHandler(this, new SearchHandler
        {
            Placeholder = "Search",
            ShowsResults = false,
            CancelButtonColor = Colors.Black,
            Keyboard = Keyboard.Text
        });
        On<iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Always);
    }



    public class UserViewCell : ViewCell
    {
        Button followButton;
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (BindingContext is not AUser user)
                return;

            followButton
            .Text(user.IsFollowing ? "Unfollow" : "Follow");
        }
        public UserViewCell()
        {

            followButton = new Button
            {
                BorderColor = Colors.LightGray,
                BorderWidth = 1,
                CornerRadius = 12
            }
            .Bold()
            .Padding(20, 0)
            .RowSpan(2)
            .Column(2)
            .Height(33)
            .BackgroundColor(Colors.Transparent)
            .TextColor(Colors.Black)
            .CenterVertical();

            View = new Grid
            {
                ColumnDefinitions = Columns.Define(Auto, Star, Auto),
                RowDefinitions = Rows.Define(Auto, Auto, Auto),
                ColumnSpacing = 10,
                RowSpacing = 4,
                Children =
                {
                    new Image()
                        .Bind(Image.SourceProperty, nameof(AUser.Image))
                        .Width(35).Height(35)
                        .Row(0).Column(0)
                        .RowSpan(3)
                        .CenterHorizontal()
                        .Top()
                        .Margin(new Thickness(0, 5, 0, 0))
                        .Aspect(Aspect.AspectFill),
                    new UserView()
                        .Row(0).Column(1),
                    new Label()
                        .Bind(Label.TextProperty, nameof(AUser.DisplayName))
                        .TextColor(Colors.LightGray)
                        .Column(1)
                        .Row(1),
                    new HorizontalStackLayoutSpaced()
                    {
                        new Image()
                        .Source("profilecircle.png")
                        .Width(12).Height(12)
                        .CenterHorizontal()
                        .Bind(Image.IsVisibleProperty, nameof(AUser.HasSimilarFollowers)),
                        new Label()
                            .Bind(Label.TextProperty, nameof(AUser.FollowersDisplay))

                    }.Column(1)
                    .Row(2),
                    followButton
                }
            }.Padding(10, 10);
        }
    }

    public override void Build()
    {
        Title = "Search";

        var listView = new ListView(ListViewCachingStrategy.RecycleElement);
        listView.HasUnevenRows = true;
        listView.SelectionMode = ListViewSelectionMode.None;
        listView.ItemsSource = ThreadsGenerator.CreateUsers();
        listView.ItemTemplate = new DataTemplate(typeof(UserViewCell));

        Content = listView;
    }
}