using System.Windows;
using System.Windows.Controls;
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
    }


    //<!--<ProgressBar Minimum = "0" Maximum="100" Width="100" Height="10" Foreground="MediumPurple" Value="{Binding Progress}" >-->


















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
