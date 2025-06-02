using System.Text.Json;
using Test_Project.Models;

namespace Test_Project.Services
{
    public static class AuthService
    {
        private static List<User> _users = new();
        private static string _filePath = "Data/users.json";

        static AuthService()
        {
            LoadUsers();
        }

        public static bool Register(User newUser)
        {
            if (_users.Any(u => u.Username == newUser.Username))
            {
                return false;
            }

            newUser.Id = _users.Count + 1;
            _users.Add(newUser);
            SaveUsers();
            return true;
        }

        public static User? Login(string username, string passwordHash)
        {
            return _users.FirstOrDefault(u =>
                u.Username == username &&
                u.Password == passwordHash);
        }

        public static void UpdateUser(User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Password = updatedUser.Password;
                SaveUsers();
            }
        }

        private static void LoadUsers()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    _users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }

        private static void SaveUsers()
        {
            try
            {
                string json = JsonSerializer.Serialize(_users);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Error saving users: {ex.Message}");
            }
        }
    }
}