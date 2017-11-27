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

        public void btnButton1_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton2_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton3_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton4_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton5_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton6_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton7_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton8_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void btnButton9_Click(object sender, RoutedEventArgs e)
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
            Winner();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
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
        public void Winner()
        {
            string test = "X";
            Winner1(test);
            test = "0";
            Winner1(test);
        }
        public void Winner1(string test)
        {
            if (btnButton1.Content.ToString() == test && btnButton2.Content.ToString() == test && btnButton3.Content.ToString() == test || btnButton4.Content.ToString() == test && btnButton5.Content.ToString() == test && btnButton6.Content.ToString() == test || btnButton7.Content.ToString() == test && btnButton8.Content.ToString() == test && btnButton9.Content.ToString() == test
            || btnButton1.Content.ToString() == test && btnButton4.Content.ToString() == test && btnButton7.Content.ToString() == test || btnButton2.Content.ToString() == test && btnButton5.Content.ToString() == test && btnButton8.Content.ToString() == test || btnButton3.Content.ToString() == test && btnButton6.Content.ToString() == test && btnButton9.Content.ToString() == test
            || btnButton1.Content.ToString() == test && btnButton5.Content.ToString() == test && btnButton9.Content.ToString() == test || btnButton3.Content.ToString() == test && btnButton5.Content.ToString() == test && btnButton7.Content.ToString() == test)
            {
                if (test == "X")
                {
                    MessageBox.Show(" X je hebt gewonnen", "Gefeliciteerd");
                }
                else
                {
                    MessageBox.Show(" 0 je hebt gewonnen", "Gefeliciteerd");
                }
                Button_Click(null, null);
            }
            else if ((string)btnButton1.Content != "" && (string)btnButton2.Content != "" && (string)btnButton3.Content != "" && (string)btnButton4.Content != "" && (string)btnButton5.Content != "" && (string)btnButton6.Content != "" && (string)btnButton7.Content != "" && (string)btnButton8.Content != "" && (string)btnButton9.Content != "") 
            {
                MessageBox.Show("Het is gelijkspel", "Probeer opnieuw");
            }
        }
    }
}
