

using CommunityToolkit.Maui.Markup;
using ThreadsApp.Helpers;
using ThreadsApp.Models;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace ThreadsApp.Controls;

public class ThreadCell : ViewCell
{
    public ThreadCell()
    {
        View = new ThreadView();
    }
}

public class ThreadView : Grid
{
    const int iconSize = 20;

    public ThreadView()
    {
        Padding = 10;
        ColumnDefinitions = Columns.Define(Auto, Star, Auto, Auto);
        ColumnSpacing = 10;
        RowSpacing = 5;
        RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto);
        Children.Add(new Image()
                        .Bind(Image.SourceProperty, $"{nameof(AThread.User)}.{nameof(AThread.User.Image)}")
                        .Width(35).Height(35)
                        .Row(0).Column(0)
                        .RowSpan(2)
                        .CenterHorizontal()
                        .Top()
                        .Margin(new Thickness(0, 5, 0, 0))
                        .Aspect(Aspect.AspectFill));
        Children.Add(new UserView($"{nameof(AThread.User)}.")
                        .Row(0).Column(1));
        Children.Add(new Label()
                        .Bind(Label.TextProperty, nameof(AThread.TimeAgo))
                        .Row(0).Column(2)
                        .Bottom());
        Children.Add(new FontAwesomeLabel(FontAwesomeStyle.Solid, FontAwesomeIcons.Ellipsis)
                        .Row(0).Column(3)
                        .Bottom());
        Children.Add(new Label()
                        .Bind(Label.TextProperty, nameof(AThread.Message))
                        .Row(1).Column(1)
                        .ColumnSpan(3));
        Children.Add(new HorizontalStackLayoutSpaced()
                {
                    new FontAwesomeLabel(FontAwesomeStyle.Regular, FontAwesomeIcons.Heart)
                    .FontSize(iconSize),
                    new FontAwesomeLabel(FontAwesomeStyle.Regular, FontAwesomeIcons.Comment)
                    .FontSize(iconSize),
                    new FontAwesomeLabel(FontAwesomeStyle.Solid, FontAwesomeIcons.Retweet)
                    .FontSize(iconSize),
                    new FontAwesomeLabel(FontAwesomeStyle.Regular, FontAwesomeIcons.PaperPlane)
                    .FontSize(iconSize)
                }.Row(2).Column(1).Margin(0,4));
        Children.Add(new HorizontalStackLayoutSpaced
                {
                    new Label()
                        .Bind(Label.TextProperty, nameof(AThread.Replies), stringFormat: "{0} replies")
                        .Bind(Label.IsVisibleProperty, nameof(AThread.HasReplies))
                        .CenterVertical(),
                    new Label()
                        .Bind(Label.TextProperty, nameof(AThread.Likes), stringFormat: "{0} likes")
                        .Bind(Label.IsVisibleProperty, nameof(AThread.HasLikes))
                        .CenterVertical(),
                }.Row(3).Column(1).ColumnSpan(3));
    }
    
}
