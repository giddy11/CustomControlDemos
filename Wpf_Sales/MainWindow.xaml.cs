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

        //private void txtSearch_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    txtBSearch.Visibility=Visibility.Collapsed; txtSearch.Focus();
        //}

        //private void txtSearch_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    if (txtSearch.Text.Trim() ==string.Empty)
        //    {
        //        txtBSearch.Visibility = Visibility.Visible;
        //    }
        //}

        //  private void txtBlockSearch_MouseDown(object sender, MouseButtonEventArgs e)
        //  {
        //      txtBlockSearch.Focus();
        //  }

        //  private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //      if (!string.IsNullOrEmpty(txtBlockSearch.Text) && txtBlockSearch.Text.Length > 0)
        //      {
        //          txtBlockSearch.Visibility = Visibility.Collapsed;
        //      }
        //      else
        //      {
        //          txtBlockSearch.Visibility = Visibility.Visible;
        //      }
        //  }


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
