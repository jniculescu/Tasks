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
    public partial class Creator : Form
    {
        private CoreCreate create;
        public Creator()
        {
            InitializeComponent();
            create = new CoreCreate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (create.Check(txtInput.Text) == false)
            {
                txtInput.Text = "Error";
            }
            else
            {
                if (int.Parse(txtAmount.Text) > 1)
                {
                    create.MultipleRefs(txtInput.Text, txtAmount.Text);
                }
                else
                {
                    create.Create(txtInput.Text);
                    txtOutput.Text = create.Results();
                }

            }

        }
    }
}
