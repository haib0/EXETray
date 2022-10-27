namespace EXETray
{
    public partial class EXETrayForm : Form
    {
        public EXETrayForm()
        {
            InitializeComponent();
           
        }

        private void EXETrayForm_Load(object sender, EventArgs e)
        {

        }

        private void EXETray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visible)
                {
                    this.Hide();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}