using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;
using System.Xml.Linq;
using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class MedicationsForm : Form
    {
        private readonly User _currentUser;
        private Medication _currentMedication = new();

        public MedicationsForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            LoadMedications();
        }

        private void LoadMedications()
        {
            listBoxMedications.Items.Clear();
            var meds = MedicationService.GetAllMedications(_currentUser.Id);

            foreach (var med in meds)
            {
                listBoxMedications.Items.Add(med.Name);
            }
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (timePicker.Value != null)
            {
                _currentMedication.IntakeTimes.Add(timePicker.Value.TimeOfDay);
                UpdateTimesList();
            }
        }

        private void UpdateTimesList()
        {
            listBoxTimes.Items.Clear();
            foreach (var time in _currentMedication.IntakeTimes)
            {
                listBoxTimes.Items.Add(time.ToString(@"hh\:mm"));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _currentMedication.UserId = _currentUser.Id;
            _currentMedication.Name = txtName.Text;
            _currentMedication.Dosage = txtDosage.Text;
            _currentMedication.StartDate = dtStart.Value;
            _currentMedication.EndDate = dtEnd.Value;

            MedicationService.AddMedication(_currentMedication);
            LoadMedications();
            MessageBox.Show("Medication saved successfully!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}