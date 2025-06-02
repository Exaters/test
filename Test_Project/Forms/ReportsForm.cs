using System.Windows.Forms.DataVisualization.Charting;
using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly User _currentUser;

        public ReportsForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            InitializeChart();
            LoadReportData();
        }

        private void InitializeChart()
        {
            chartMedications.Series.Clear();
            chartMedications.ChartAreas.Clear();
            chartMedications.Titles.Clear();

            var chartArea = new ChartArea();
            chartMedications.ChartAreas.Add(chartArea);

            _ = chartMedications.Titles.Add("Medication Duration Analysis");
            chartMedications.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
        }

        private void LoadReportData()
        {
            var medications = MedicationService.GetAllMedications(_currentUser.Id);

            lblTotal.Text = $"Total: {medications.Count}";
            lblActive.Text = $"Active: {medications.Count(m => m.EndDate >= DateTime.Today)}";
            lblCompleted.Text = $"Completed: {medications.Count(m => m.EndDate < DateTime.Today)}";

            var series = new Series("Duration (days)");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            foreach (var med in medications.OrderBy(m => m.Name))
            {
                int duration = (med.EndDate - med.StartDate).Days;
                _ = series.Points.AddXY(med.Name, duration);
            }

            chartMedications.Series.Add(series);
        }

        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Export to PDF functionality will be implemented here");
        }

        private void exportExcelButton_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Export to Excel functionality will be implemented here");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}