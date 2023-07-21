using System.Collections;
using ThreadsApp.Models;

namespace ThreadsApp.Helpers;

public static class ThreadsGenerator
{
    public static AUser CreateUser(bool isVerified = false, bool isFollowing = false)
    {
        return new AUser
        {
            UserName = "jamesmontemagno",
            DisplayName = "James Montemagno",
            IsVerified = isVerified,
            IsFollowing = isFollowing,
            Image = "profilecircle.png",
            FollowerCount = 1500
        };
    }
    public static IEnumerable CreateUsers()
    {
        return new[]
        {
            CreateUser(false, true),
            new AUser
            {
                UserName = "shanselman",
                DisplayName = "Scott Hanselman",
                IsVerified = true,
                IsFollowing = false,
                HasSimilarFollowers = true,
                Image = "profilecircle.png",
                FollowerCount = 1500000
            },
            CreateUser(true, false),
            CreateUser(true, true),
            CreateUser(),
            CreateUser()
        };
    }
    public static IEnumerable CreateThreads()
    {
        return new[]
            {
                new AThread
                {
                    User = CreateUser(true, false),
                    Message = "This is a thread message that you should read",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(false, true),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(true, true),
                    Message = "This is a thread message that you should read",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                     Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
                new AThread
                {
                    User = CreateUser(),
                    Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                },
             };
    }
}
