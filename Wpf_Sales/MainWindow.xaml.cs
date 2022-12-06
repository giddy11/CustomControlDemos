using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

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
            customersDataGrid.ItemsSource = GetCustomer();


        }

        private static ObservableCollection<Customer> GetCustomer()
        {
            var converter = new BrushConverter();
            var list = new ObservableCollection<Customer>();
            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid
            });

            return list;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tbx = sender as TextBox;
            if (tbx.Text != "")
            {
                var filteredList = Customer.Customers.Where(x => x.Name.Contains(tbx.Text));
                customersDataGrid.ItemsSource = null;
                customersDataGrid.ItemsSource = filteredList;
            }
            else
            {
                customersDataGrid.ItemsSource = Customer.Customers;
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


    public class Customer
    {
        public string Name { get; set; }
        public string InvoiceTag { get; set; }
        public string Email { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public static List<Customer> Customers { get; set; }
        public ImageSource Image { get; set; }

    }

    public enum PaymentStatus
    {
        Paid,
        Cancel,
        Refunded
    }

}
