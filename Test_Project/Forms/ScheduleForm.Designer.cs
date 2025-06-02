namespace Test_Project.Forms
{
    partial class ScheduleForm
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
            dataGridViewSchedule = new DataGridView();
            lblStatus = new Label();
            btnFilter = new Button();
            btnClose = new Button();
            dtpStartFilter = new DateTimePicker();
            dtpEndFilter = new DateTimePicker();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(14, 55);
            dataGridViewSchedule.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewSchedule.RowTemplate.Height = 25;
            dataGridViewSchedule.Size = new Size(791, 467);
            dataGridViewSchedule.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(14, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(714, 13);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(91, 33);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(714, 530);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 33);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtpStartFilter
            // 
            dtpStartFilter.Format = DateTimePickerFormat.Short;
            dtpStartFilter.Location = new Point(442, 15);
            dtpStartFilter.Margin = new Padding(3, 4, 3, 4);
            dtpStartFilter.Name = "dtpStartFilter";
            dtpStartFilter.Size = new Size(125, 27);
            dtpStartFilter.TabIndex = 5;
            // 
            // dtpEndFilter
            // 
            dtpEndFilter.Format = DateTimePickerFormat.Short;
            dtpEndFilter.Location = new Point(583, 15);
            dtpEndFilter.Margin = new Padding(3, 4, 3, 4);
            dtpEndFilter.Name = "dtpEndFilter";
            dtpEndFilter.Size = new Size(125, 27);
            dtpEndFilter.TabIndex = 6;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(14, 530);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(91, 33);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 571);
            Controls.Add(dtpStartFilter);
            Controls.Add(dtpEndFilter);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnFilter);
            Controls.Add(lblStatus);
            Controls.Add(dataGridViewSchedule);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Medication Schedule";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpStartFilter;
        private System.Windows.Forms.DateTimePicker dtpEndFilter;
    }
}
