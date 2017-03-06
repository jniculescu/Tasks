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

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CoreCreate create = new CoreCreate();

        }
    }
}
