namespace Test_Project.Forms
{
    partial class Medications : Form
    {
        private System.Windows.Forms.ListBox medicationsListBox;
        private System.Windows.Forms.Button addTimeButton;
        private System.Windows.Forms.Button removeTimeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button uploadImageButton;
        private System.Windows.Forms.Button removeImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newMedicationButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ListBox intakeTimesListBox;
        private System.Windows.Forms.PictureBox medicationPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dosageLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label intakeTimesLabel;

        private void InitializeComponent()
        {
            medicationsListBox = new System.Windows.Forms.ListBox();
            addTimeButton = new System.Windows.Forms.Button();
            removeTimeButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            uploadImageButton = new System.Windows.Forms.Button();
            removeImageButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            newMedicationButton = new System.Windows.Forms.Button();
            nameTextBox = new System.Windows.Forms.TextBox();
            dosageTextBox = new System.Windows.Forms.TextBox();
            startDatePicker = new System.Windows.Forms.DateTimePicker();
            endDatePicker = new System.Windows.Forms.DateTimePicker();
            intakeTimesListBox = new System.Windows.Forms.ListBox();
            medicationPictureBox = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            dosageLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            intakeTimesLabel = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(medicationPictureBox)).BeginInit();

            this.ClientSize = new System.Drawing.Size(720, 470);
            this.Text = "Медикаменты";

            medicationsListBox.Location = new System.Drawing.Point(12, 12);
            medicationsListBox.Size = new System.Drawing.Size(200, 400);

            nameLabel.Text = "Название:";
            nameLabel.Location = new System.Drawing.Point(230, 12);
            nameLabel.Size = new System.Drawing.Size(100, 20);

            nameTextBox.Location = new System.Drawing.Point(330, 12);
            nameTextBox.Size = new System.Drawing.Size(200, 23);

            dosageLabel.Text = "Дозировка:";
            dosageLabel.Location = new System.Drawing.Point(230, 42);
            dosageLabel.Size = new System.Drawing.Size(100, 20);

            dosageTextBox.Location = new System.Drawing.Point(330, 42);
            dosageTextBox.Size = new System.Drawing.Size(200, 23);

            startDateLabel.Text = "Дата начала:";
            startDateLabel.Location = new System.Drawing.Point(230, 72);
            startDateLabel.Size = new System.Drawing.Size(100, 20);

            startDatePicker.Location = new System.Drawing.Point(330, 72);
            startDatePicker.Size = new System.Drawing.Size(200, 23);

            endDateLabel.Text = "Дата окончания:";
            endDateLabel.Location = new System.Drawing.Point(230, 102);
            endDateLabel.Size = new System.Drawing.Size(100, 20);

            endDatePicker.Location = new System.Drawing.Point(330, 102);
            endDatePicker.Size = new System.Drawing.Size(200, 23);

            intakeTimesLabel.Text = "Время приёма:";
            intakeTimesLabel.Location = new System.Drawing.Point(230, 132);
            intakeTimesLabel.Size = new System.Drawing.Size(100, 20);

            intakeTimesListBox.Location = new System.Drawing.Point(330, 132);
            intakeTimesListBox.Size = new System.Drawing.Size(200, 80);

            addTimeButton.Text = "Добавить время";
            addTimeButton.Location = new System.Drawing.Point(330, 220);
            addTimeButton.Size = new System.Drawing.Size(95, 30);

            removeTimeButton.Text = "Удалить время";
            removeTimeButton.Location = new System.Drawing.Point(435, 220);
            removeTimeButton.Size = new System.Drawing.Size(95, 30);

            medicationPictureBox.Location = new System.Drawing.Point(550, 12);
            medicationPictureBox.Size = new System.Drawing.Size(150, 150);
            medicationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            medicationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            uploadImageButton.Text = "Загрузить фото";
            uploadImageButton.Location = new System.Drawing.Point(550, 170);
            uploadImageButton.Size = new System.Drawing.Size(150, 30);

            removeImageButton.Text = "Удалить фото";
            removeImageButton.Location = new System.Drawing.Point(550, 210);
            removeImageButton.Size = new System.Drawing.Size(150, 30);

            saveButton.Text = "Сохранить";
            saveButton.Location = new System.Drawing.Point(550, 260);
            saveButton.Size = new System.Drawing.Size(150, 30);

            deleteButton.Text = "Удалить";
            deleteButton.Location = new System.Drawing.Point(550, 300);
            deleteButton.Size = new System.Drawing.Size(150, 30);

            newMedicationButton.Text = "Новое лекарство";
            newMedicationButton.Location = new System.Drawing.Point(12, 420);
            newMedicationButton.Size = new System.Drawing.Size(200, 30);

            this.Controls.Add(medicationsListBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(nameTextBox);
            this.Controls.Add(dosageLabel);
            this.Controls.Add(dosageTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(startDatePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(endDatePicker);
            this.Controls.Add(intakeTimesLabel);
            this.Controls.Add(intakeTimesListBox);
            this.Controls.Add(addTimeButton);
            this.Controls.Add(removeTimeButton);
            this.Controls.Add(medicationPictureBox);
            this.Controls.Add(uploadImageButton);
            this.Controls.Add(removeImageButton);
            this.Controls.Add(saveButton);
            this.Controls.Add(deleteButton);
            this.Controls.Add(newMedicationButton);

            ((System.ComponentModel.ISupportInitialize)(medicationPictureBox)).EndInit();
        }
    }
}
