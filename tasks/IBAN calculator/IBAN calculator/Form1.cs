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

            var bban = textBox1.Text;
            bban = bban.Replace("-", "");
            var bbanarr = bban.ToCharArray().Select(c => c.ToString()).ToArray();

            //tarkisteen(pankki?) laskeminen/ eka numero = 3 => 2numeroa / 4 tai 7 => 3 numeroa  / muut 1 numero("rahalaitosten" tunnukset)

            if (bbanarr[0] == "4" || bbanarr[0] == "5")
            {
                while (bban.Length <= 13)
                {
                    bban = bban.Insert(6, "0");
                }
            }
            else
            {
                while (bban.Length <= 13)
                {
                    bban = bban.Insert(5, "0");
                }
            }

            //IBAN maakoodin tarkisteen lakeminen ja lisäys

            if (chkBox1.Checked)
            {
                bban = bban.Insert(14, "FI00");
            }
            else
            {
                MessageBox.Show("Country required");
            }
            bban = bban.Replace("FI", "1518");
            decimal numiban = decimal.Parse(bban);

            numiban = numiban % 97;
            var numchk = 98 - numiban;
            string chk;

            if (numchk >= 10)
            {
                chk = numchk.ToString();
            }
            else
            {
                chk = numchk.ToString();
                chk = chk.Insert(0, "0");
            }

            //validity check
            if (numiban % 97 != 1)
            {
                var iban = bban;
                iban = iban.Remove(14);
                iban = iban.Insert(0, "FI" + chk);

                textBox2.Text = iban;
            }
            else
            {
                MessageBox.Show("Error");
            }

            MessageBox.Show("Click OK to exit");
            Application.Exit();
        }

        private void chkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
