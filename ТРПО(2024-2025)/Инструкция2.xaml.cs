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

namespace ТРПО_2024_2025_
{
    /// <summary>
    /// Логика взаимодействия для Инструкция2.xaml
    /// </summary>
    public partial class Инструкция2 : Window
    {
        public Инструкция2()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
            this.Close();

        }
    }
}
