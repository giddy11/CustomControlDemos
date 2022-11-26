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

namespace Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Company = new Company { Name = "CypherCrescent Limited", Address = "Trans Amadi, PH" };
            DataContext = this;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is my customised button");
        }



        public Company Company { get; set; }
    }










    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
