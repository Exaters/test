namespace Test_Project.Forms
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            new AuthForm().Show();
        }
    }
}
