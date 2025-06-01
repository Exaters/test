namespace Test_Project.Forms
{
    partial class MedicationsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.medicationNameTextBox = new System.Windows.Forms.TextBox();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.medicationsListBox = new System.Windows.Forms.ListBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.timesListBox = new System.Windows.Forms.ListBox();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.removeTimeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblDosage = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblIntakeTimes = new System.Windows.Forms.Label();
            this.lblMedicationsList = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // medicationNameTextBox
            this.medicationNameTextBox.Location = new System.Drawing.Point(20, 30);
            this.medicationNameTextBox.Name = "medicationNameTextBox";
            this.medicationNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.medicationNameTextBox.TabIndex = 1;

            // dosageTextBox
            this.dosageTextBox.Location = new System.Drawing.Point(20, 80);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(200, 23);
            this.dosageTextBox.TabIndex = 3;

            // startDatePicker
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(20, 130);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 5;

            // endDatePicker
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(20, 180);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 23);
            this.endDatePicker.TabIndex = 7;

            // medicationsListBox
            this.medicationsListBox.FormattingEnabled = true;
            this.medicationsListBox.ItemHeight = 15;
            this.medicationsListBox.Location = new System.Drawing.Point(250, 30);
            this.medicationsListBox.Name = "medicationsListBox";
            this.medicationsListBox.Size = new System.Drawing.Size(250, 154);
            this.medicationsListBox.TabIndex = 0;

            // timePicker
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(20, 230);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(120, 23);
            this.timePicker.TabIndex = 9;

            // timesListBox
            this.timesListBox.FormattingEnabled = true;
            this.timesListBox.ItemHeight = 15;
            this.timesListBox.Location = new System.Drawing.Point(20, 260);
            this.timesListBox.Name = "timesListBox";
            this.timesListBox.Size = new System.Drawing.Size(200, 94);
            this.timesListBox.TabIndex = 10;

            // addTimeButton
            this.addTimeButton.Location = new System.Drawing.Point(150, 230);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(70, 23);
            this.addTimeButton.TabIndex = 11;
            this.addTimeButton.Text = "Add";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);

            // removeTimeButton
            this.removeTimeButton.Location = new System.Drawing.Point(150, 330);
            this.removeTimeButton.Name = "removeTimeButton";
            this.removeTimeButton.Size = new System.Drawing.Size(70, 23);
            this.removeTimeButton.TabIndex = 12;
            this.removeTimeButton.Text = "Remove";
            this.removeTimeButton.UseVisualStyleBackColor = true;
            this.removeTimeButton.Click += new System.EventHandler(this.removeTimeButton_Click);

            // saveButton
            this.saveButton.Location = new System.Drawing.Point(250, 360);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 30);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // cancelButton
            this.cancelButton.Location = new System.Drawing.Point(360, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            // errorProvider
            this.errorProvider.ContainerControl = this;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Medication Name:";

            // lblDosage
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(20, 60);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(48, 15);
            this.lblDosage.TabIndex = 2;
            this.lblDosage.Text = "Dosage:";

            // lblStartDate
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(20, 110);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 15);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";

            // lblEndDate
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(20, 160);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 15);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date:";

            // lblIntakeTimes
            this.lblIntakeTimes.AutoSize = true;
            this.lblIntakeTimes.Location = new System.Drawing.Point(20, 210);
            this.lblIntakeTimes.Name = "lblIntakeTimes";
            this.lblIntakeTimes.Size = new System.Drawing.Size(76, 15);
            this.lblIntakeTimes.TabIndex = 8;
            this.lblIntakeTimes.Text = "Intake Times:";

            // lblMedicationsList
            this.lblMedicationsList.AutoSize = true;
            this.lblMedicationsList.Location = new System.Drawing.Point(250, 10);
            this.lblMedicationsList.Name = "lblMedicationsList";
            this.lblMedicationsList.Size = new System.Drawing.Size(97, 15);
            this.lblMedicationsList.TabIndex = 15;
            this.lblMedicationsList.Text = "Your Medications:";

            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(470, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);

            // MedicationsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.lblMedicationsList);
            this.Controls.Add(this.lblIntakeTimes);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDosage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeTimeButton);
            this.Controls.Add(this.addTimeButton);
            this.Controls.Add(this.timesListBox);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.medicationsListBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(this.medicationNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Medications";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox medicationNameTextBox;
        private TextBox dosageTextBox;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private ListBox medicationsListBox;
        private DateTimePicker timePicker;
        private ListBox timesListBox;
        private Button addTimeButton;
        private Button removeTimeButton;
        private Button saveButton;
        private Button cancelButton;
        private ErrorProvider errorProvider;
        private Label lblName;
        private Label lblDosage;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblIntakeTimes;
        private Label lblMedicationsList;
        private Button deleteButton;
    }
}