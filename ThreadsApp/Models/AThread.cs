using CommunityToolkit.Mvvm.ComponentModel;

namespace ThreadsApp.Models;

public partial class AThread : ObservableObject
{
    [ObservableProperty]
    AUser user;

    [ObservableProperty]
    string message;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HasLikes))]
    int likes;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HasReplies))]
    int replies;
    [ObservableProperty]
    string timeAgo;

    public bool HasReplies => Replies > 0;
    public bool HasLikes => Likes > 0;
}
