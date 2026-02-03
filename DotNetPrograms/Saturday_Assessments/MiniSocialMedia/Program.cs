using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MiniSocialMedia
{
    class Program
    {
        private static Repository<User> _users = new Repository<User>();
        private static User? _currentUser = null;
        private static readonly string _dataFile = "social-data.json";
        static bool IsRunning = true;

        static void Main()
        {
            Console.Title = "MiniSocial - Console Edition";
            Console.WriteLine("==== MiniSocial ====");
            Console.WriteLine();

            LoadData();

            while (IsRunning)
            {
                try
                {
                    if (_currentUser == null)
                        ShowLoginMenu();
                    else
                        ShowMainMenu();
                }
                catch (SocialException ex)
                {
                    ConsoleColorWrite(ConsoleColor.Red, $"Error: {ex.Message}");
                    if (ex.InnerException != null)
                        Console.WriteLine($"Details: {ex.InnerException.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error!!");
                    Console.WriteLine(ex);
                    LogError(ex);
                }
                finally
                {
                    if (IsRunning)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();
                        Console.WriteLine("==== MiniSocial ====");
                        Console.WriteLine();
                    }
                }
            }
        }

        static void ShowLoginMenu()
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterUser();
                    break;
                case "2":
                    LoginUser();
                    break;
                case "0":
                    SaveData();
                    IsRunning = false;
                    break;
                default:
                    throw new SocialException("Invalid menu choice. Please select a valid option.");
            }
        }

        static void ShowMainMenu()
        {
            if (_currentUser == null)
                throw new SocialException("No user is logged in.");

            Console.WriteLine($"Logged in as: {_currentUser.GetDisplayName()}");
            Console.WriteLine();
            Console.WriteLine("1. Post message");
            Console.WriteLine("2. View my posts");
            Console.WriteLine("3. View timeline (feed)");
            Console.WriteLine("4. Follow user");
            Console.WriteLine("5. List users");
            Console.WriteLine("6. Logout");
            Console.WriteLine("0. Exit and save");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PostMessage();
                    break;
                case "2":
                    ViewMyPosts();
                    break;
                case "3":
                    ShowTimeline();
                    break;
                case "4":
                    FollowUser();
                    break;
                case "5":
                    ListUsers();
                    break;
                case "6":
                    Logout();
                    break;
                case "0":
                    SaveData();
                    IsRunning = false;
                    break;
                default:
                    throw new SocialException("Invalid menu choice. Please select a valid option.");
            }
        }

        static void RegisterUser()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
                throw new SocialException("Username and email are required.");

            var existingUser = _users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (existingUser != null)
                throw new SocialException("Username already exists.");

            User newUser = new User(username, email);
            _users.Add(newUser);

            Console.WriteLine($"Welcome, {username}! Your account has been created.");
        }

        static void LoginUser()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            var user = _users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
                throw new SocialException("User not found.");

            _currentUser = user;
            Console.WriteLine($"Logged in as {user.Username}!");

            foreach (var u in _users.GetAll())
                u.OnNewPost += OnPostNotification;
        }

        static void OnPostNotification(Post post)
        {
            if (_currentUser == null || post.Author == _currentUser)
                return;

            string preview = post.Content.Length > 40
                ? post.Content.Substring(0, 40) + "..."
                : post.Content;

            ConsoleColorWrite(ConsoleColor.Cyan,
                $"New post by {post.Author.Username}\n{preview}\n");
        }

        static void PostMessage()
        {
            if (_currentUser == null)
                throw new SocialException("You must be logged in to post a message.");

            Console.WriteLine("Write your post below:");
            Console.WriteLine("Maximum length: 280 characters");
            Console.WriteLine("Empty input will cancel the post");
            Console.WriteLine();

            string content = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Post cancelled.");
                return;
            }

            _currentUser.AddPost(content.Trim());
            Console.WriteLine("Post published successfully!");
        }

        static void ShowTimeline()
        {
            if (_currentUser == null)
                throw new SocialException("You must be logged in to view the timeline.");

            List<Post> timeline = new List<Post>();
            timeline.AddRange(_currentUser.GetPosts());

            foreach (string followed in _currentUser.GetFollowing())
            {
                var user = _users.Find(u =>
                    u.Username.Equals(followed, StringComparison.OrdinalIgnoreCase));

                if (user != null)
                    timeline.AddRange(user.GetPosts());
            }

            timeline = timeline
                .OrderByDescending(p => p.CreatedAt)
                .ToList();

            Console.WriteLine("=== Your Timeline ===");
            Console.WriteLine();

            ShowPosts(timeline);
        }

        static void ShowPosts(IEnumerable<Post> posts)
        {
            if (!posts.Any())
            {
                Console.WriteLine("No posts to display.");
                return;
            }

            foreach (var post in posts)
            {
                Console.WriteLine(post);
                Console.WriteLine();
            }
        }

        static void FollowUser()
        {
            if (_currentUser == null)
                throw new SocialException("You must be logged in to follow users.");

            Console.Write("Enter username to follow: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cancelled.");
                return;
            }

            string target = input.Trim();

            if (target.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You cannot follow yourself.");
                return;
            }

            var user = _users.Find(u =>
                u.Username.Equals(target, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            _currentUser.Follow(target);
            Console.WriteLine($"Now following @{target}");
        }

        static void ListUsers()
        {
            Console.WriteLine("Registered users:");
            Console.WriteLine();

            var users = _users.GetAll().OrderBy(u => u);

            foreach (var user in users)
                Console.WriteLine($"@{user.Username,-20} {user.Email}");
        }

        static void Logout()
        {
            _currentUser = null;
            Console.WriteLine("Logged out successfully.");
        }

        static void SaveData()
        {
            try
            {
                var data = _users.GetAll().Select(u => new
                {
                    u.Username,
                    u.Email,
                    Following = u.GetFollowing(),
                    Posts = u.GetPosts().Select(p => new
                    {
                        p.Content,
                        p.CreatedAt
                    })
                });

                var json = System.Text.Json.JsonSerializer.Serialize(
                    data,
                    new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(_dataFile, json);
                Console.WriteLine("Data saved.");
            }
            catch (Exception ex)
            {
                LogError(ex);
                Console.WriteLine("Failed to save data.");
            }
        }

        static void LoadData()
        {
            try
            {
                if (!File.Exists(_dataFile))
                    return;

                File.ReadAllText(_dataFile);
                Console.WriteLine("Data loaded (simulation - add proper logic).");
            }
            catch (Exception ex)
            {
                LogError(ex);
                Console.WriteLine("Failed to load data.");
            }
        }

        static void LogError(Exception ex)
        {
            try
            {
                string entry =
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]\n" +
                    $"Message: {ex.Message}\n" +
                    $"StackTrace:\n{ex.StackTrace}\n" +
                    $"-----------------------------\n";

                File.AppendAllText("error.log", entry);
            }
            catch { }
        }

        private static void ConsoleColorWrite(ConsoleColor color, string text)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = original;
        }
        static void ViewMyPosts()
        {
            if (_currentUser == null)
                throw new SocialException("You must be logged in to view your posts.");

            var posts = _currentUser.GetPosts();

            Console.WriteLine("=== My Posts ===");
            Console.WriteLine();

            ShowPosts(posts);
        }

    }
}
