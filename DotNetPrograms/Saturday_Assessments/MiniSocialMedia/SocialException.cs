using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace MiniSocialMedia
{
    public class SocialException : Exception
    {
        public SocialException(string message) : base(message) { }
        public SocialException(string message, Exception inner) : base(message, inner) { }
    }

    public interface IPostable
    {
        void AddPost(string content);
        IReadOnlyList<Post> GetPosts();
    }

    public class Post
    {
        public User Author { get; init; }
        public string Content { get; init; }
        public DateTime CreatedAt { get; set; }

        public Post(User author, string content)
        {
            if (author == null)
                throw new ArgumentNullException(nameof(author), "Author cannot be null");

            Author = author;
            Content = content;
            CreatedAt = DateTime.UtcNow;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Author.GetDisplayName()} - {CreatedAt:MM dd HH:mm}");
            sb.AppendLine(Content);

            var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");
            if (hashtags.Count > 0)
            {
                sb.Append("Tags: ");
                sb.AppendJoin(",", hashtags.Cast<Match>().Select(m => m.Value));
            }

            return sb.ToString();
        }
    }

    public partial class User : IPostable, IComparable<User>
    {
        public string Username { get; init; }
        public string Email { get; init; }

        private readonly List<Post> _posts = new();
        private readonly HashSet<string> _following =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public event Action<Post>? OnNewPost;

        public User(string username, string email)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty", nameof(username));

            if (!IsValidEmail(email))
                throw new SocialException("Invalid email format");

            Username = username.Trim();
            Email = email.Trim().ToLower();
        }

        static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public void Follow(string username)
        {
            if (string.Equals(username, Username, StringComparison.OrdinalIgnoreCase))
                throw new SocialException("You cannot follow yourself");

            _following.Add(username);
        }

        public bool IsFollowing(string username)
        {
            return _following.Contains(username);
        }

        public IReadOnlyCollection<string> GetFollowing()
        {
            return _following;
        }

        public void AddPost(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Post content cannot be empty");

            if (content.Length > 280)
                throw new SocialException("Post too long (max 280 characters)");

            var post = new Post(this, content.Trim());
            _posts.Add(post);
            OnNewPost?.Invoke(post);
        }

        public IReadOnlyList<Post> GetPosts()
        {
            return _posts.AsReadOnly();
        }

        public int CompareTo(User? other)
        {
            if (other == null)
                return 1;

            return string.Compare(Username, other.Username, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"@{Username}";
        }
    }

    public partial class User
    {
        public string GetDisplayName()
        {
            return $"User: {Username} <{Email}>";
        }
    }

    public class Repository<T> where T : class
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IReadOnlyList<T> GetAll()
        {
            return _items.AsReadOnly();
        }

        public T? Find(Predicate<T> match)
        {
            return _items.Find(match);
        }
    }

    public static class SocialUtils
    {
        public static string FormatTimeAgo(this DateTime pastTime)
        {
            TimeSpan difference = DateTime.UtcNow - pastTime;

            if (difference.TotalMinutes < 1)
                return "Just now";

            if (difference.TotalMinutes < 60)
                return $"{(int)difference.TotalMinutes} min ago";

            if (difference.TotalHours < 24)
                return $"{(int)difference.TotalHours} h ago";

            return pastTime.ToString("MMM dd");
        }
    }
}
