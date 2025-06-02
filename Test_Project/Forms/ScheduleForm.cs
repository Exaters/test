using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class ScheduleForm : Form
    {
        private readonly User _currentUser;

        public ScheduleForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            InitializeDataGridView();
            LoadSchedule();
        }

        private void InitializeDataGridView()
        {
            dataGridViewSchedule.AutoGenerateColumns = false;
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.AllowUserToDeleteRows = false;
            dataGridViewSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            _ = dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Medication",
                Width = 150
            });

            _ = dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Dosage",
                HeaderText = "Dosage",
                Width = 100
            });

            _ = dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Time",
                HeaderText = "Time",
                Width = 80
            });

            _ = dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Start Date",
                Width = 100
            });

            _ = dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "End Date",
                Width = 100
            });
        }

        private void LoadSchedule()
        {
            var scheduleData = MedicationService.GetAllMedications(_currentUser.Id)
                .SelectMany(med => med.IntakeTimes.Select(time => new
                {
                    med.Name,
                    med.Dosage,
                    Time = time.ToString(@"hh\:mm"),
                    StartDate = med.StartDate.ToShortDateString(),
                    EndDate = med.EndDate.ToShortDateString()
                }))
                .OrderBy(x => x.Time)
                .ToList();

            dataGridViewSchedule.DataSource = scheduleData;
            lblStatus.Text = $"Showing {dataGridViewSchedule.Rows.Count} scheduled doses";
        }

        private void btnFilter_Click(object? sender, EventArgs e)
        {
            DateTime startFilter = dtpStartFilter.Value.Date;
            DateTime endFilter = dtpEndFilter.Value.Date;

            var filteredData = MedicationService.GetAllMedications(_currentUser.Id)
                .Where(med =>
                    med.StartDate.Date <= endFilter && med.EndDate.Date >= startFilter)
                .SelectMany(med => med.IntakeTimes.Select(time => new
                {
                    med.Name,
                    med.Dosage,
                    Time = time.ToString(@"hh\:mm"),
                    StartDate = med.StartDate.ToShortDateString(),
                    EndDate = med.EndDate.ToShortDateString()
                }))
                .OrderBy(x => x.Time)
                .ToList();

            dataGridViewSchedule.DataSource = filteredData;
            lblStatus.Text = $"Showing {dataGridViewSchedule.Rows.Count} scheduled doses " +
                             $"from {startFilter:dd.MM.yyyy} to {endFilter:dd.MM.yyyy}";
        }

        private void btnPrint_Click(object? sender, EventArgs e)
        {
            _ = MessageBox.Show("Print functionality will be implemented here",
                "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}