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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // medicationNameTextBox
            // 
            this.medicationNameTextBox.Location = new System.Drawing.Point(20, 20);
            this.medicationNameTextBox.Name = "medicationNameTextBox";
            this.medicationNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.medicationNameTextBox.TabIndex = 0;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.Location = new System.Drawing.Point(20, 60);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(200, 23);
            this.dosageTextBox.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(20, 100);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(20, 140);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 23);
            this.endDatePicker.TabIndex = 3;
            // 
            // medicationsListBox
            // 
            this.medicationsListBox.FormattingEnabled = true;
            this.medicationsListBox.ItemHeight = 15;
            this.medicationsListBox.Location = new System.Drawing.Point(250, 20);
            this.medicationsListBox.Name = "medicationsListBox";
            this.medicationsListBox.Size = new System.Drawing.Size(200, 154);
            this.medicationsListBox.TabIndex = 4;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(20, 180);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(120, 23);
            this.timePicker.TabIndex = 5;
            // 
            // timesListBox
            // 
            this.timesListBox.FormattingEnabled = true;
            this.timesListBox.ItemHeight = 15;
            this.timesListBox.Location = new System.Drawing.Point(20, 220);
            this.timesListBox.Name = "timesListBox";
            this.timesListBox.Size = new System.Drawing.Size(200, 154);
            this.timesListBox.TabIndex = 6;
            // 
            // addTimeButton
            // 
            this.addTimeButton.Location = new System.Drawing.Point(150, 180);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(70, 23);
            this.addTimeButton.TabIndex = 7;
            this.addTimeButton.Text = "Add";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // removeTimeButton
            // 
            this.removeTimeButton.Location = new System.Drawing.Point(150, 350);
            this.removeTimeButton.Name = "removeTimeButton";
            this.removeTimeButton.Size = new System.Drawing.Size(70, 23);
            this.removeTimeButton.TabIndex = 8;
            this.removeTimeButton.Text = "Remove";
            this.removeTimeButton.UseVisualStyleBackColor = true;
            this.removeTimeButton.Click += new System.EventHandler(this.removeTimeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(300, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(380, 350);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MedicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 390);
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
    }
}