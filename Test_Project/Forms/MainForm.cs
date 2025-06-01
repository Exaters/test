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
            _currentUser = user;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Menu setup
            var dashboardItem = new ToolStripMenuItem("Dashboard");
            var medicationsItem = new ToolStripMenuItem("My Medications");
            var scheduleItem = new ToolStripMenuItem("Schedule");
            var reportsItem = new ToolStripMenuItem("Reports");
            var profileItem = new ToolStripMenuItem("Profile");
            var exitItem = new ToolStripMenuItem("Exit");

            menuStrip.Items.AddRange(new ToolStripItem[] {
                dashboardItem,
                medicationsItem,
                scheduleItem,
                reportsItem,
                profileItem,
                exitItem
            });

            // Calendar setup
            monthCalendar.SelectionStart = _selectedDate;
            monthCalendar.DateSelected += (s, e) =>
            {
                _selectedDate = monthCalendar.SelectionStart;
                LoadMedications();
            };

            // ListView setup
            listViewMedications.View = View.Details;
            listViewMedications.Columns.Add("Medication", 150);
            listViewMedications.Columns.Add("Dosage", 100);
            listViewMedications.Columns.Add("Times", 200);

            LoadMedications();
        }

        private void LoadMedications()
        {
            listViewMedications.Items.Clear();
            var meds = MedicationService.GetMedicationsForDate(
                _currentUser.Id,
                _selectedDate
            );

            foreach (var med in meds)
            {
                var times = string.Join(", ", med.IntakeTimes.Select(t => t.ToString(@"hh\:mm")));
                listViewMedications.Items.Add(new ListViewItem(new[] { med.Name, med.Dosage, times }));
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem?.Text == null) return;

            switch (e.ClickedItem.Text)
            {
                case "Exit":
                    Application.Exit();
                    break;
                case "My Medications":
                    new MedicationsForm(_currentUser).ShowDialog();
                    LoadMedications();
                    break;
                    // Other menu cases
            }
        }
    }
}