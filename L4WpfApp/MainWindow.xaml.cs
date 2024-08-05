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

namespace L4WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDollar.Text);
            double sum = Convert.ToDouble(sumDollar.Text);
            resultDollar.Text = (rate * sum).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEUR.Text);
            double sum = Convert.ToDouble(sumEUR.Text);
            resultEUR.Text = (rate * sum).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateUAH.Text);
            double sum = Convert.ToDouble(sumUAH.Text);
            resultUAH.Text = (rate * sum).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateAMD.Text);
            double sum = Convert.ToDouble(sumAMD.Text);
            resultAMD.Text = (rate * sum).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(lengthInches.Text);
            double k = 1 / 39.37;
            resultInches.Text = (k * length).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(lengthFeet.Text);
            double k = 3.281;
            resultFeet.Text = (k * length).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(lengthMiles.Text);
            double k = 1609;
            resultMiles.Text = (k * length).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(lengthVerst.Text);
            double k = 1067;
            resultVerst.Text = (k * length).ToString();
        }
    }
}
