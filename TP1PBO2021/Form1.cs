using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.username = Convert.ToString(tbusername.Text);
            login.password = Convert.ToString(tbpassword.Text);

            if (login.password != "pbo123")
            {
                MessageBox.Show("Maaf Password Salah, Mohon Ulangi Kembali ");
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Visible = false;
            }
        }
    }
}
