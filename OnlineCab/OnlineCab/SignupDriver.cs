using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCab
{
    public partial class SignupDriver : Form
    {

        Driver driver;
        public SignupDriver()
        {
            driver = new Driver();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            driver.register(username.Text,password.Text,mobile.Text,licenece.Text);
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
