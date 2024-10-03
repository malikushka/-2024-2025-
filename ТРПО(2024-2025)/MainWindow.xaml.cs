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

namespace ТРПО_2024_2025_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        private DateTime lastClickTime = DateTime.MinValue;

        private void go_Click(object sender, RoutedEventArgs e)
        {
            Автомат newWindow = new Автомат();
            newWindow.Show();
            this.Close();

        }

        private void myStackPanel1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TimeSpan interval = DateTime.Now - lastClickTime;
            if (interval.TotalMilliseconds < 300)
            {
               
                go.Visibility = Visibility.Visible;
                
                lastClickTime = DateTime.MinValue;
            }
            else
            {
               
                lastClickTime = DateTime.Now;
            }

        }

        private void myStackPanel2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TimeSpan interval = DateTime.Now - lastClickTime;
            if (interval.TotalMilliseconds < 300)
            {

                go.Visibility = Visibility.Visible;

                lastClickTime = DateTime.MinValue;
            }
            else
            {

                lastClickTime = DateTime.Now;
            }

        }

        private void myStackPanel3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TimeSpan interval = DateTime.Now - lastClickTime;
            if (interval.TotalMilliseconds < 300)
            {

                go.Visibility = Visibility.Visible;

                lastClickTime = DateTime.MinValue;
            }
            else
            {

                lastClickTime = DateTime.Now;
            }

        }
    }
}
