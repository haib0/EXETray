namespace EXETray
{
    public partial class EXETrayForm : Form
    {
        public EXETrayForm()
        {
            InitializeComponent();
            InitializeEexTray();
        }

        private void EXETrayForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeEexTray()
        {
            this.EXETray.ContextMenuStrip = new ContextMenuStrip();
            this.EXETray.ContextMenuStrip.Items.Add("Exit", null, (sender, args) => this.Close());
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