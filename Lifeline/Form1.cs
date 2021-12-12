using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifeline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname, pwd;
            uname = textBox1.Text;
            pwd = textBox2.Text;
            if(uname.Equals("root") && pwd.Equals("toor"))
            {
                label5.Hide();
                MessageBox.Show("Login successful");
            }
            else
            {
                label5.Text = "Invalid User Name or Password!";
                label5.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
