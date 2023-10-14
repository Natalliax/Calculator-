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

namespace LAB1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double x;
        char oper;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = (sender as Button).Content.ToString();
            else
                if (textBox.Text.Length < 15)
                textBox.Text += (sender as Button).Content;
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Contains(",") == false)
            {
                if (textBox.Text.Length < 15)
                    textBox.Text += ",";
            }


        }

        private void ButtonOper_Click(object sender, RoutedEventArgs e)
        {
            x = Convert.ToDouble(textBox.Text);
            oper = (sender as Button).Content.ToString()[0];
            //MessageBox.Show($"{x} {oper}");
            textBox.Text = "0";
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            double y = Convert.ToDouble(textBox.Text);
            double result = 0;
            switch (oper)
            {
                case '+': result = x + y; break;
                case '-': result = x - y; break;
                case '*': result = x * y; break;
                case '/': result = x / y; break;
            }
            textBox.Text = $"{result:0.00}";

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text = "0";
            }

        }

        private void ButtonBackSp_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length - 1 == 0)
                textBox.Text = "0";
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }
    }
}

