using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference_app
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

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Validator validate = new Validator();
            validate.Show();
            Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Creator create = new Creator();
            create.Show();
            Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
