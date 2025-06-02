using System.Security.Cryptography;
using System.Text;

namespace Test_Project.Services
{
    public static class HashService
    {
        private const string Salt = "fixed_salt_value_12345";

        public static string ComputeSaltedHash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                string saltedInput = input + Salt;
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedInput));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}