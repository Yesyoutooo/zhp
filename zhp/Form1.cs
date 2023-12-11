using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace zhp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_uc1_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();

            Panel1.Controls.Add(userControl1);

            userControl1.Dock = DockStyle.Fill;
        }

        private void btn_uc2_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();

            Panel1.Controls.Add(userControl2);

            userControl2.Dock = DockStyle.Fill;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "lol";
            string caption = "no";
            var result = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
