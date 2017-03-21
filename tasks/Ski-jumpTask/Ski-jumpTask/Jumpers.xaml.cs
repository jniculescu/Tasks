using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ski_jumpTask
{
    /// <summary>
    /// Interaction logic for Jumpers.xaml
    /// </summary>
    public partial class Jumpers : Window
    {
        public float distMultip;
        public int criticalPoint;
        public int pointsCpoint;
        public float windageMultp;

        public List<string> platform = new List<string>();
        public List<string> names = new List<string>();
        public List<string> wind = new List<string>();
        public int num;
        private bool full;

        public Jumpers()
        {
            InitializeComponent();
        }


        public void Setvars(MainWindow main)
        {
            distMultip = main.distMultip;
            criticalPoint = main.criticalPoint;
            pointsCpoint = main.pointsCpoint;
            windageMultp = main.windageMultp;
            this.Show();
        }

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            Jumper jumper = new Jumper();
            jumper.AddJumper(this);
        }

        private void sldrWind_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtWind.Text = sldrWind.Value.ToString();

        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            if (!full)
            {
                num = 1;
                string name = txtName.Text;
                string plat = txtPlatform.Text;
                string windAverage = txtWind.Text;

                wind.Add(windAverage);
                names.Add(name);
                platform.Add(plat);
                num++;
                if (num > int.Parse(txtAmount.Text))
                {
                    full = true;
                    MessageBox.Show("All Jumpers has the needed info now");
                }
                else
                {
                    full = false;
                }
                
            }
            else
            {
                MessageBox.Show("Can't do that");
            }
        }

        private void sldrPlatform_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtPlatform.Text = sldrPlatform.Value.ToString();
        }

    }
}
