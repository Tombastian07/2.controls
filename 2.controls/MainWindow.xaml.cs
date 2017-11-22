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

namespace _2.controls
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

        public bool Imige = false;

        private void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton1.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton1.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton1.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton2_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton2.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton2.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton2.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton3_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton3.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton3.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton3.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton4_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton4.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton4.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton4.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton5_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton5.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton5.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton5.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton6_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton6.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton6.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton6.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton7_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton7.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton7.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton7.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton8_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton8.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton8.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton8.Content = "0";
                    Imige = false;
                }
            }
        }

        private void btnButton9_Click(object sender, RoutedEventArgs e)
        {
            if (btnButton9.Content.ToString() == "")
            {
                if (Imige == false)
                {
                    btnButton9.Content = "X";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton9.Content = "0";
                    Imige = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnButton1.Content = "";
            btnButton2.Content = "";
            btnButton3.Content = "";
            btnButton4.Content = "";
            btnButton5.Content = "";
            btnButton6.Content = "";
            btnButton7.Content = "";
            btnButton8.Content = "";
            btnButton9.Content = "";
        }
    }
}
