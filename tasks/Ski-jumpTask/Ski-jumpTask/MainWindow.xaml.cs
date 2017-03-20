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
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * 
    Create jumpers (amount, for loop and naming each of them)

    counting the points for each jumper:
    suurmäki critical info: 1.8 points per M over or under K-point, K-point = 116M, points for reaching K-point = 60 points.
    stylepoints = max 20 per judge, highest and lowest gets removed. so max is 60.
    windage= wind strength average(5 wind measuring points) x (k-point - 36)/20. rounded to 0,5 increments. points amount is 1.8x rounded sum.

*/
namespace Ski_jumpTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public float distMultip;
        public int criticalPoint;
        public int pointsCpoint;
        public float windageMultp;

        private void btnLahti_Click(object sender, RoutedEventArgs e)
        {
            distMultip = 1.8f;
            criticalPoint = 116;
            pointsCpoint = 60;
            windageMultp = 1.8f;

            Jumpers jumpers = new Jumpers();
            jumpers.Show();
            this.Close();
        }
    }
}
