using Test_Project.Forms;

namespace Test_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Создаем папку Data если ее нет
            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            // Создаем пустые файлы если их нет
            string usersFile = Path.Combine(dataPath, "users.json");
            if (!File.Exists(usersFile))
            {
                File.WriteAllText(usersFile, "[]");
            }

            string medsFile = Path.Combine(dataPath, "medications.json");
            if (!File.Exists(medsFile))
            {
                File.WriteAllText(medsFile, "[]");
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreenForm());
        }
    }
}