namespace Test_Project.Forms
{
    partial class ReportsForm
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
            this.chartMedications = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.exportPdfButton = new System.Windows.Forms.Button();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedications)).BeginInit();
            this.SuspendLayout();

            // chartMedications
            this.chartMedications.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartMedications.Location = new System.Drawing.Point(0, 0);
            this.chartMedications.Name = "chartMedications";
            this.chartMedications.Size = new System.Drawing.Size(800, 300);
            this.chartMedications.TabIndex = 0;
            this.chartMedications.Text = "chart1";

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: 0";

            // lblActive
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(20, 350);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(60, 15);
            this.lblActive.TabIndex = 2;
            this.lblActive.Text = "Active: 0";

            // lblCompleted
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(20, 380);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(80, 15);
            this.lblCompleted.TabIndex = 3;
            this.lblCompleted.Text = "Completed: 0";

            // exportPdfButton
            this.exportPdfButton.Location = new System.Drawing.Point(200, 320);
            this.exportPdfButton.Name = "exportPdfButton";
            this.exportPdfButton.Size = new System.Drawing.Size(120, 30);
            this.exportPdfButton.TabIndex = 4;
            this.exportPdfButton.Text = "Export to PDF";
            this.exportPdfButton.Click += new System.EventHandler(this.exportPdfButton_Click);

            // exportExcelButton
            this.exportExcelButton.Location = new System.Drawing.Point(350, 320);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(120, 30);
            this.exportExcelButton.TabIndex = 5;
            this.exportExcelButton.Text = "Export to Excel";
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);

            // closeButton
            this.closeButton.Location = new System.Drawing.Point(500, 320);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 30);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);

            // ReportsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exportExcelButton);
            this.Controls.Add(this.exportPdfButton);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chartMedications);
            this.Name = "ReportsForm";
            this.Text = "Medication Reports";
            ((System.ComponentModel.ISupportInitialize)(this.chartMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedications;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Button exportPdfButton;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Windows.Forms.Button closeButton;
    }
}