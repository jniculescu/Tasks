using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int.Refnumber_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            CoreValidate validate = new CoreValidate();
            Lengthchk lengthcheck = new Lengthchk();

            if (lengthcheck.isChecklenvalid(txtInputValidate.Text) == false)
            {
                if (validate.Validating(txtInputValidate.Text) == true)
                {
                    txtOutputValidate.Text = validate.Fullvalidate(txtInputValidate.Text);
                }
                else
                {
                    txtOutputValidate.Text = "Error";
                }
            }
            else
            {
                txtOutputValidate.Text = "Error";
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CoreCreate create = new CoreCreate();
            Lengthchk lengthcheck = new Lengthchk();

            if (lengthcheck.isChecklencreate(txtInputCreate.Text) == false)
            {
                create.Create(txtInputCreate.Text);
                txtOutputCreate.Text = create.Results();
            }




        }
    }
}
