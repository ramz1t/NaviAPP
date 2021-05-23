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

namespace navi
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

        private void simg_MouseLeftButtonDown (object sender, RoutedEventArgs e)
        {

        }

        private void homeBT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void teamBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
