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
    /// Логика взаимодействия для Инструкция.xaml
    /// </summary>
    public partial class Инструкция : Window
    {
        public Инструкция()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            Инструкция2 newWindow = new Инструкция2();
            newWindow.Show();
            this.Close();

        }
    }
}
