namespace Test_Project.Forms
{
    partial class SplashScreenForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTitle = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(28, 162);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(396, 68);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Drugs Scedule";
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 400);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SplashScreenForm";
            Text = "SplashScreen";
            Load += SplashScreenForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblTitle;
    }
}