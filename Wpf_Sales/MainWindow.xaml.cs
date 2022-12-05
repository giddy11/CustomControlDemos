using System;
using System.Collections.ObjectModel;
using System.Windows;
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
            customersDataGrid.ItemsSource = MainWindow.GetCustomer();


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

    }

    public enum PaymentStatus
    {
        Paid,
        Cancel,
        Refunded
    }

}
