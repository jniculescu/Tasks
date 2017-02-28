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
    public partial class Validator : Form
    {
        private CoreValidate validate;
        public Validator()
        {
            InitializeComponent();
            validate = new CoreValidate();
        }

        private void Validator_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            Visible = false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (validate.isChecklen(txtRefnum.Text) == true)
            {
                txtResult.Text = "Invalid Length";
            }
            else
            {  
                txtResult.Text = validate.Validating(txtRefnum.Text);
            }
        }
    }
}
