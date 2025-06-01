using System;
using System.Linq;
using System.Windows.Forms;
using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private DateTime _selectedDate = DateTime.Today;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            InitializeMenu();
            InitializeCalendar();
            InitializeMedicationsList();
            LoadMedications();
        }

        private void InitializeMenu()
        {
            var menuItems = new[]
            {
                "Dashboard",
                "My Medications",
                "Schedule",
                "Reports",
                "Profile",
                "Exit"
            };

            mainMenuStrip.Items.Clear();

            foreach (var item in menuItems)
            {
                var menuItem = new ToolStripMenuItem(item);
                menuItem.Click += MenuItem_Click;
                mainMenuStrip.Items.Add(menuItem);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                switch (menuItem.Text)
                {
                    case "My Medications":
                        OpenForm(new MedicationsForm(_currentUser), true);
                        break;
                    case "Schedule":
                        OpenForm(new ScheduleForm(_currentUser));
                        break;
                    case "Reports":
                        OpenForm(new ReportsForm(_currentUser));
                        break;
                    case "Profile":
                        OpenForm(new ProfileForm(_currentUser));
                        break;
                    case "Exit":
                        Application.Exit();
                        break;
                }
            }
        }

        private void OpenForm(Form form, bool refreshMedications = false)
        {
            try
            {
                var result = form.ShowDialog();
                if (refreshMedications && result == DialogResult.OK)
                {
                    LoadMedications();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeCalendar()
        {
            monthCalendar.SelectionStart = _selectedDate;
            monthCalendar.DateSelected += (s, e) =>
            {
                _selectedDate = monthCalendar.SelectionStart;
                LoadMedications();
            };
        }

        private void InitializeMedicationsList()
        {
            medicationsListView.View = View.Details;
            medicationsListView.FullRowSelect = true;
            medicationsListView.UseCompatibleStateImageBehavior = false;
        }

        private void LoadMedications()
        {
            medicationsListView.Items.Clear();
            var meds = MedicationService.GetMedicationsForDate(
                _currentUser.Id,
                _selectedDate
            );

            foreach (var med in meds)
            {
                var times = string.Join(", ", med.IntakeTimes.Select(t => t.ToString(@"hh\:mm")));
                medicationsListView.Items.Add(new ListViewItem(new[]
                {
                    med.Name,
                    med.Dosage,
                    times
                }));
            }
        }
    }
}