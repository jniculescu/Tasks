using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string bban = textBox1.Text;
            bban = bban.Replace("-", "");

            string ibanchk = "123";

            int numiban = int.Parse(ibanchk);


            bool correct;

            if(numiban % 97 == 1)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }

            if(correct == true)
            {
                //this is right
            }
            //tarkisteen(pankki?) laskeminen/ eka numero = 3 => 2numeroa / 4 tai 7 => 3 numeroa  / muut 1 numero("rahalaitosten" tunnukset

            if(bban[0] = 3)
            {

            }

            //syöttö oikean mallinen

            //IBAN maakoodin tarkisteen lakeminen
        }
    }
}
