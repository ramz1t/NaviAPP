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
    /// Логика взаимодействия для controls.xaml
    /// </summary>
    public partial class controls : UserControl
    {
        public controls()
        {
            InitializeComponent();
        }

        private void homeBT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main mw = new Main();
            mw.Show();
            (sender as Window).Hide();
        }

        private void teamBT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Window w = Window.GetWindow(sender as DependencyObject);
            w.Hide();
        }
    }
}
