using System.Windows.Forms;

namespace myproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(String.Compare(txt_user.Text,"Maha")==0 && String.Compare(txt_pass.Text,"22011556-023")==0)
            {
                MessageBox.Show("Correct login password");
            }
            else
            {
                MessageBox.Show("login failed");
            }
        }
    }
}
