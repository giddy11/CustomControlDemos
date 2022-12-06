using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Sales.Database
{
    public class CustomerDb
    {
        public static ObservableCollection<Customer> GetCustomer()
        {
            var list = new ObservableCollection<Customer>();
            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73
            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            list.Add(new Customer()
            {
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 73

            });

            return list;
        }
    }
}
