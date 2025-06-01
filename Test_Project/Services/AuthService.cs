using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
                return false;

            newUser.Id = _users.Count + 1;
            _users.Add(newUser);
            SaveUsers();
            return true;
        }

        public static User? Login(string username, string password)
        {
            return _users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);
        }

        private static void LoadUsers()
        {
            if (File.Exists(_filePath))
                _users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(_filePath));
        }

        //private static void SaveUsers()
        //{
        //    File.WriteAllText(_filePath, JsonSerializer.Serialize(_users));
        //}
        // old method
        //private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");
        // method not working because of wtf
        private static void SaveUsers()
        {
            try
            {
                string json = JsonSerializer.Serialize(_users);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving users: {ex.Message}");
            }
        }
    }
}
