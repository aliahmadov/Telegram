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

namespace Telegram
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

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var canvas = sender as Canvas;
            var grid = canvas.Parent;

            txtBox.Visibility = Visibility.Visible;

            foreach (var item in canvas.Children)
            {
                if (item is Image image)
                {

                    image_Header.ImageSource = image.Source;
                }
                if (item is Label lbl)
                {
                    header_lbl.Content = lbl.Content;
                }
            }
        }



        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var grid = sender as Grid;
            var border = grid.Parent as Border;

            grid.Background = Brushes.AliceBlue;
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = Brushes.Blue;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var grid = sender as Grid;
            var border = grid.Parent as Border;

            grid.Background = Brushes.White;
            border.BorderThickness = new Thickness(0, 0, 0, 3);
            border.BorderBrush = Brushes.WhiteSmoke;
        }


        public bool firstTime { get; set; } = true;
        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                msgLbl.Visibility = Visibility.Hidden;
            }
            else
                msgLbl.Visibility = Visibility.Visible;
        }

        private void txtBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void send_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}

