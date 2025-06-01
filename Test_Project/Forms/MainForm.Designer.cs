namespace Test_Project.Forms
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.medicationsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();

            // mainMenuStrip
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;

            // monthCalendar
            this.monthCalendar.Location = new System.Drawing.Point(18, 30);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;

            // medicationsListView
            this.medicationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.medicationsListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.medicationsListView.FullRowSelect = true;
            this.medicationsListView.Location = new System.Drawing.Point(250, 24);
            this.medicationsListView.Name = "medicationsListView";
            this.medicationsListView.Size = new System.Drawing.Size(550, 426);
            this.medicationsListView.TabIndex = 2;
            this.medicationsListView.UseCompatibleStateImageBehavior = false;
            this.medicationsListView.View = System.Windows.Forms.View.Details;

            // columnHeader1
            this.columnHeader1.Text = "Medication";
            this.columnHeader1.Width = 150;

            // columnHeader2
            this.columnHeader2.Text = "Dosage";
            this.columnHeader2.Width = 100;

            // columnHeader3
            this.columnHeader3.Text = "Times";
            this.columnHeader3.Width = 200;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medicationsListView);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Medication Planner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView medicationsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}