using System;
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

        public MedicationsForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            InitializeForm();
            LoadMedications();
        }

        private void InitializeForm()
        {
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
        }

        private void ValidateRequiredField(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void ValidateDateRange(object sender, System.ComponentModel.CancelEventArgs e)
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
            var meds = MedicationService.GetAllMedications(_currentUser.Id);

            foreach (var med in meds.OrderBy(m => m.Name))
            {
                medicationsListBox.Items.Add(med);
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
                MedicationService.AddMedication(_currentMedication);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving medication: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}