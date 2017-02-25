﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBAN_calculator
{
    public partial class Form1 : Form
    {

        Core core;
        public Form1()
        {
            InitializeComponent();
            core = new Core();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            core.bban = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            core.BBAN();
            if(core.isBBAN2(chkBox1.Checked) == true)
            {
                MessageBox.Show("Error");
            }
            core.IBAN();

            var retiban = core.RetriveIBAN();
            textBox2.Text = retiban;

            MessageBox.Show("Click OK to exit");
            Application.Exit();
        }

        public void chkBox1_CheckedChanged(object sender, EventArgs e)
        {

            

        }
    }
}
