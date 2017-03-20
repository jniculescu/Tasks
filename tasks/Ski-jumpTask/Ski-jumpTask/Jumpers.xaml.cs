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
        public Jumpers()
        {
            InitializeComponent();
            Jumper jumper = new Jumper();
            jumper.AddJumper();
            txtResults.Text = jumper.Jumpers.ToString();
        }

    }
}
