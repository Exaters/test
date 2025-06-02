using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Test_Project.Models;
using Test_Project.Services;

namespace MedicationApp
{
    public partial class MedicationsForm : Form
    {
        private Medication? _currentMedication;
        private readonly int _userId;

        // Объявляем все контролы здесь
        private ListBox medicationsListBox;
        private TextBox medicationNameTextBox;
        private TextBox dosageTextBox;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private PictureBox pictureBox;
        private Button uploadImageButton;
        private Button removeImageButton;
        private ListBox timesListBox;
        private DateTimePicker timePicker;
        private Button addTimeButton;
        private Button removeTimeButton;
        private Button saveButton;
        private Button deleteButton;
        private Button newMedicationButton;

        public MedicationsForm(User user)
        {
            InitializeComponent();
            _userId = user.Id;

            // Подписываемся на события
            medicationsListBox.SelectedIndexChanged += MedicationsListBox_SelectedIndexChanged;
            addTimeButton.Click += addTimeButton_Click;
            removeTimeButton.Click += removeTimeButton_Click;
            deleteButton.Click += deleteButton_Click;
            uploadImageButton.Click += uploadImageButton_Click;
            removeImageButton.Click += removeImageButton_Click;
            saveButton.Click += saveButton_Click;
            newMedicationButton.Click += NewMedicationButton_Click;

            LoadMedications();
        }

        private void InitializeComponent()
        {
            medicationsListBox = new ListBox();
            medicationNameTextBox = new TextBox();
            dosageTextBox = new TextBox();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            pictureBox = new PictureBox();
            uploadImageButton = new Button();
            removeImageButton = new Button();
            timesListBox = new ListBox();
            timePicker = new DateTimePicker();
            addTimeButton = new Button();
            removeTimeButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            newMedicationButton = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();

            // medicationsListBox
            medicationsListBox.Location = new Point(12, 12);
            medicationsListBox.Name = "medicationsListBox";
            medicationsListBox.Size = new Size(200, 364);
            medicationsListBox.TabIndex = 0;

            // medicationNameTextBox
            medicationNameTextBox.Location = new Point(230, 10);
            medicationNameTextBox.Name = "medicationNameTextBox";
            medicationNameTextBox.Size = new Size(200, 27);
            medicationNameTextBox.TabIndex = 1;

            // dosageTextBox
            dosageTextBox.Location = new Point(230, 40);
            dosageTextBox.Name = "dosageTextBox";
            dosageTextBox.Size = new Size(200, 27);
            dosageTextBox.TabIndex = 2;

            // startDatePicker
            startDatePicker.Location = new Point(230, 70);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 27);
            startDatePicker.TabIndex = 3;

            // endDatePicker
            endDatePicker.Location = new Point(230, 100);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 27);
            endDatePicker.TabIndex = 4;

            // pictureBox
            pictureBox.Location = new Point(230, 130);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(119, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;

            // uploadImageButton
            uploadImageButton.Location = new Point(355, 130);
            uploadImageButton.Name = "uploadImageButton";
            uploadImageButton.Size = new Size(75, 30);
            uploadImageButton.TabIndex = 6;
            uploadImageButton.Text = "Upload Image";

            // removeImageButton
            removeImageButton.Location = new Point(355, 166);
            removeImageButton.Name = "removeImageButton";
            removeImageButton.Size = new Size(75, 30);
            removeImageButton.TabIndex = 7;
            removeImageButton.Text = "Remove Image";

            // timesListBox
            timesListBox.Location = new Point(230, 240);
            timesListBox.Name = "timesListBox";
            timesListBox.Size = new Size(104, 104);
            timesListBox.TabIndex = 8;

            // timePicker
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(340, 240);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(90, 27);
            timePicker.TabIndex = 9;

            // addTimeButton
            addTimeButton.Location = new Point(355, 273);
            addTimeButton.Name = "addTimeButton";
            addTimeButton.Size = new Size(75, 30);
            addTimeButton.TabIndex = 10;
            addTimeButton.Text = "Add Time";

            // removeTimeButton
            removeTimeButton.Location = new Point(355, 309);
            removeTimeButton.Name = "removeTimeButton";
            removeTimeButton.Size = new Size(75, 30);
            removeTimeButton.TabIndex = 11;
            removeTimeButton.Text = "Remove Time";

            // saveButton
            saveButton.Location = new Point(230, 353);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(84, 30);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";

            // deleteButton
            deleteButton.Location = new Point(346, 353);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(84, 30);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";

            // newMedicationButton
            newMedicationButton.Location = new Point(12, 380);
            newMedicationButton.Size = new Size(200, 30);
            newMedicationButton.Text = "Новое лекарство";
            newMedicationButton.Name = "newMedicationButton";
            newMedicationButton.TabIndex = 14;

            // MedicationsForm
            ClientSize = new Size(447, 422);
            Controls.Add(medicationsListBox);
            Controls.Add(medicationNameTextBox);
            Controls.Add(dosageTextBox);
            Controls.Add(startDatePicker);
            Controls.Add(endDatePicker);
            Controls.Add(pictureBox);
            Controls.Add(uploadImageButton);
            Controls.Add(removeImageButton);
            Controls.Add(timesListBox);
            Controls.Add(timePicker);
            Controls.Add(addTimeButton);
            Controls.Add(removeTimeButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(newMedicationButton);

            Name = "MedicationsForm";
            Text = "Medications";

            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadMedications()
        {
            var medications = MedicationService.GetAllMedications(_userId);
            medicationsListBox.DataSource = medications;
            medicationsListBox.DisplayMember = "Name";
        }

        private void MedicationsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (medicationsListBox.SelectedItem is Medication selectedMedication)
            {
                _currentMedication = selectedMedication;

                medicationNameTextBox.Text = selectedMedication.Name;
                dosageTextBox.Text = selectedMedication.Dosage;
                startDatePicker.Value = selectedMedication.StartDate;
                endDatePicker.Value = selectedMedication.EndDate;

                timesListBox.Items.Clear();
                foreach (var time in selectedMedication.IntakeTimes)
                {
                    timesListBox.Items.Add(time.ToString(@"hh\:mm"));
                }

                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }

                if (!string.IsNullOrEmpty(selectedMedication.ImagePath) && File.Exists(selectedMedication.ImagePath))
                {
                    using var fs = new FileStream(selectedMedication.ImagePath, FileMode.Open, FileAccess.Read);
                    pictureBox.Image = Image.FromStream(fs);
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            else
            {
                ClearForm();
            }
        }

        private void addTimeButton_Click(object? sender, EventArgs e)
        {
            var timeStr = timePicker.Value.TimeOfDay.ToString(@"hh\:mm");
            if (!timesListBox.Items.Contains(timeStr))
            {
                timesListBox.Items.Add(timeStr);
            }
        }

        private void removeTimeButton_Click(object? sender, EventArgs e)
        {
            if (timesListBox.SelectedIndex >= 0)
            {
                timesListBox.Items.RemoveAt(timesListBox.SelectedIndex);
            }
        }

        private void uploadImageButton_Click(object? sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var imagesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MedicationImages");
                    Directory.CreateDirectory(imagesDir);

                    var fileName = Guid.NewGuid() + Path.GetExtension(openFileDialog.FileName);
                    var destPath = Path.Combine(imagesDir, fileName);

                    File.Copy(openFileDialog.FileName, destPath, true);

                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                        pictureBox.Image = null;
                    }

                    using var fs = new FileStream(destPath, FileMode.Open, FileAccess.Read);
                    pictureBox.Image = Image.FromStream(fs);

                    if (_currentMedication != null)
                    {
                        _currentMedication.ImagePath = destPath;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }

        private void removeImageButton_Click(object? sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }

            if (_currentMedication != null)
            {
                _currentMedication.ImagePath = null;
            }
        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(medicationNameTextBox.Text))
            {
                MessageBox.Show("Введите название лекарства");
                return;
            }

            if (_currentMedication == null)
            {
                _currentMedication = new Medication();
            }

            _currentMedication.Name = medicationNameTextBox.Text;
            _currentMedication.Dosage = dosageTextBox.Text;
            _currentMedication.StartDate = startDatePicker.Value;
            _currentMedication.EndDate = endDatePicker.Value;

            _currentMedication.IntakeTimes.Clear();
            foreach (string time in timesListBox.Items)
            {
                if (TimeSpan.TryParse(time, out var ts))
                {
                    _currentMedication.IntakeTimes.Add(ts);
                }
            }

            _currentMedication.UserId = _userId;

            MedicationService.SaveMedication(_currentMedication);
            LoadMedications();
        }

        private void deleteButton_Click(object? sender, EventArgs e)
        {
            if (_currentMedication == null)
            {
                MessageBox.Show("Выберите лекарство для удаления");
                return;
            }

            MedicationService.DeleteMedication(_currentMedication.Id);
            _currentMedication = null;
            LoadMedications();
            ClearForm();
        }

        private void ClearForm()
        {
            medicationNameTextBox.Text = "";
            dosageTextBox.Text = "";
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today;
            timesListBox.Items.Clear();

            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        private void NewMedicationButton_Click(object? sender, EventArgs e)
        {
            _currentMedication = null;
            ClearForm();
            medicationsListBox.ClearSelected();
        }
    }
}
