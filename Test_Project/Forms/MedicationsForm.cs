using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class MedicationsForm : Form
    {
        private readonly User _currentUser;
        private Medication _currentMedication = new Medication();
        private List<Medication> _allMedications = new List<Medication>();

        public MedicationsForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            InitializeForm();
            LoadMedications();
        }

        private void InitializeForm()
        {
            // Настройка подписей
            lblName.Text = "Medication Name:";
            lblDosage.Text = "Dosage:";
            lblStartDate.Text = "Start Date:";
            lblEndDate.Text = "End Date:";
            lblIntakeTimes.Text = "Intake Times:";
            lblMedicationsList.Text = "Your Medications:";

            // Настройка элементов управления
            medicationNameTextBox.Tag = "Name";
            dosageTextBox.Tag = "Dosage";

            // Привязка событий валидации
            medicationNameTextBox.Validating += ValidateRequiredField;
            dosageTextBox.Validating += ValidateRequiredField;
            startDatePicker.Validating += ValidateDateRange;
            endDatePicker.Validating += ValidateDateRange;

            // Настройка timePicker
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Value = DateTime.Today.Date.AddHours(8);

            // Обработчик выбора препарата
            medicationsListBox.SelectedIndexChanged += MedicationsListBox_SelectedIndexChanged;

            // Установка начальных дат
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today.AddDays(7);
        }

        private void MedicationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medicationsListBox.SelectedIndex >= 0)
            {
                _currentMedication = _allMedications[medicationsListBox.SelectedIndex];

                medicationNameTextBox.Text = _currentMedication.Name;
                dosageTextBox.Text = _currentMedication.Dosage;
                startDatePicker.Value = _currentMedication.StartDate;
                endDatePicker.Value = _currentMedication.EndDate;

                _currentMedication.IntakeTimes = new List<TimeSpan>(_currentMedication.IntakeTimes);
                UpdateTimesList();
            }
        }

        private void ValidateRequiredField(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, $"{textBox.Tag} is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void ValidateDateRange(object sender, CancelEventArgs e)
        {
            if (endDatePicker.Value < startDatePicker.Value)
            {
                errorProvider.SetError(endDatePicker, "End date cannot be before start date");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(endDatePicker, "");
            }
        }

        private void LoadMedications()
        {
            medicationsListBox.Items.Clear();
            _allMedications = MedicationService.GetAllMedications(_currentUser.Id);

            foreach (var med in _allMedications.OrderBy(m => m.Name))
            {
                medicationsListBox.Items.Add($"{med.Name} ({med.Dosage})");
            }
        }

        private void addTimeButton_Click(object sender, EventArgs e)
        {
            _currentMedication.IntakeTimes.Add(timePicker.Value.TimeOfDay);
            UpdateTimesList();
        }

        private void UpdateTimesList()
        {
            timesListBox.Items.Clear();
            foreach (var time in _currentMedication.IntakeTimes.OrderBy(t => t))
            {
                timesListBox.Items.Add(time.ToString(@"hh\:mm"));
            }
        }

        private void removeTimeButton_Click(object sender, EventArgs e)
        {
            if (timesListBox.SelectedIndex != -1)
            {
                _currentMedication.IntakeTimes.RemoveAt(timesListBox.SelectedIndex);
                UpdateTimesList();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            _currentMedication.UserId = _currentUser.Id;
            _currentMedication.Name = medicationNameTextBox.Text;
            _currentMedication.Dosage = dosageTextBox.Text;
            _currentMedication.StartDate = startDatePicker.Value;
            _currentMedication.EndDate = endDatePicker.Value;

            try
            {
                if (_currentMedication.Id == 0)
                {
                    MedicationService.AddMedication(_currentMedication);
                }
                else
                {
                    MedicationService.UpdateMedication(_currentMedication);
                }

                LoadMedications();
                ClearForm();

                MessageBox.Show("Medication saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving medication: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_currentMedication.Id > 0 &&
                MessageBox.Show("Are you sure you want to delete this medication?",
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MedicationService.DeleteMedication(_currentMedication.Id);
                    LoadMedications();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting medication: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            _currentMedication = new Medication();
            medicationNameTextBox.Clear();
            dosageTextBox.Clear();
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today.AddDays(7);
            timesListBox.Items.Clear();
            _currentMedication.IntakeTimes.Clear();
            medicationsListBox.SelectedIndex = -1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}