using CommunityToolkit.Maui.Markup;
using ThreadsApp.Helpers;
using ThreadsApp.Models;

namespace ThreadsApp.Controls;

public class UserView : HorizontalStackLayoutSpaced
{
    public UserView(string prefix = "") : base(5)
    {
        Children.Add(new Label()
                            .Bind(Label.TextProperty, $"{prefix}{nameof(AUser.UserName)}")
                            .Bold()
                            .FontSize(14)
                            .Bottom());
        Children.Add(new FontAwesomeLabel(FontAwesomeStyle.Solid, FontAwesomeIcons.CircleCheck)
                            .TextColor(Colors.Blue)
                            .Bind(Label.IsVisibleProperty, $"{prefix}{nameof(AUser.IsVerified)}")
                            .CenterVertical());
    }
}
