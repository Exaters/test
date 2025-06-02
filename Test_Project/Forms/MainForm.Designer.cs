namespace Test_Project.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
        }

        private void InitializeComponent()
        {
            mainMenuStrip = new MenuStrip();
            monthCalendar = new MonthCalendar();
            medicationsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnExport = new Button();
            SuspendLayout();

            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(7, 3, 0, 3);
            mainMenuStrip.Size = new Size(681, 24);
            mainMenuStrip.TabIndex = 0;

            monthCalendar.Location = new Point(19, 36);
            monthCalendar.Margin = new Padding(10, 12, 10, 12);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 1;

            medicationsListView.AutoArrange = false;
            medicationsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            medicationsListView.Dock = DockStyle.Right;
            medicationsListView.FullRowSelect = true;
            medicationsListView.Location = new Point(241, 24);
            medicationsListView.Margin = new Padding(3, 4, 3, 4);
            medicationsListView.Name = "medicationsListView";
            medicationsListView.Size = new Size(440, 576);
            medicationsListView.TabIndex = 2;
            medicationsListView.UseCompatibleStateImageBehavior = false;
            medicationsListView.View = View.Details;

            columnHeader1.Text = "Medication";
            columnHeader1.Width = 150;

            columnHeader2.Text = "Dosage";
            columnHeader2.Width = 100;

            columnHeader3.Text = "Times";
            columnHeader3.Width = 200;

            btnExport.Location = new Point(19, 258);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(192, 30);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export to Text File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 600);
            Controls.Add(btnExport);
            Controls.Add(medicationsListView);
            Controls.Add(monthCalendar);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Medication Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip mainMenuStrip;
        private MonthCalendar monthCalendar;
        private ListView medicationsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnExport;
    }
}