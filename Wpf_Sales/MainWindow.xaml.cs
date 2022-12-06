using System.Windows;
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


    //var cust = new Customer();
    //cust.Add(new Customer()
    //{
    //    Name = "Olivia Rhye",
    //        Character = "OR",
    //        Email = "olivia@untitledui.com",
    //        InvoiceTag = "INV-3066",
    //    });

    //    customersDataGrid.Items.Add(cust);
}
