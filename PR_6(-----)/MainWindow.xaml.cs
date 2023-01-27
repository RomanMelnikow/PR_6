using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace PR_6_______
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int l = 1;
        int pic = 2;
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (l == 1)
            {
                label1.Content = "Посторонним вход воспрещён!";
                l = 2;
            }
            else
            {
                label1.Content = "Добро пожаловать!";
                l = 1;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pic == 1)
            {
                image.Source = new BitmapImage(new Uri(@"/iIC6Cb6nFcM.jpg", UriKind.Relative));
                pic = 2;
            }
            else
            {
                image.Source = new BitmapImage(new Uri(@"/sticker_vk_masyunya_016.png", UriKind.Relative));
                pic = 1;
            }
        }
    }
}
