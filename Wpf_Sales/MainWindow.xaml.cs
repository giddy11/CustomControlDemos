using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wpf_Sales.Database;

namespace Wpf_Sales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            customersDataGrid.ItemsSource = CustomerDb.GetCustomer();


            
        }

        private void txtBlockSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (txtBlockSearch != null)
            {
                txtBlockSearch.Focus();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBlockSearch != null && !string.IsNullOrEmpty(((TextBox)sender).Text) && ((TextBox)sender).Text.Length > 0)
            {
                txtBlockSearch.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtBlockSearch.Visibility = Visibility.Visible;
            }
        }
    }




















    //var cust = new Customer();
    //cust.Add(new Customer()
    //{
    //    Name = "Olivia Rhye",
    //        Character = "OR",
    //        Email = "olivia@untitledui.com",
    //        InvoiceTag = "INV-3066",
    //    });

    //    customersDataGrid.Items.Add(cust);

    //private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    var tbx = sender as TextBox;
    //    if (tbx.Text != "")
    //    {
    //        var filteredList = Customer.Customers.Where(x => x.Name.Contains(tbx.Text));
    //        customersDataGrid.ItemsSource = null;
    //        customersDataGrid.ItemsSource = filteredList;
    //    }
    //    else
    //    {
    //        customersDataGrid.ItemsSource = Customer.Customers;
    //    }
    //}
}
