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


namespace ISRPO_SREZ
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

        

        private void Button_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void CB1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CB1.SelectedIndex == 0)
            {
                Firmi firmi = new Firmi();
                firmi.Show();
            }

            if (CB1.SelectedIndex == 1)
            {
                Prodan prodan = new Prodan();
                prodan.Show();
                
            }
        }

        private void BT1_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                //printDialog.PrintDocument();
            }
        }
    }
}
