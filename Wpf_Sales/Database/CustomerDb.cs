using System.Collections.ObjectModel;
using Wpf_Sales.Models;

namespace Wpf_Sales.Database
{
    public class CustomerDb
    {
        public static ObservableCollection<Customer> GetCustomer()
        {
            var list = new ObservableCollection<Customer>();
            list.Add(new Customer()
            {
                Id = 1,
                Name = "Olivia Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 60
            }) ;

            list.Add(new Customer()
            {
                Id = 2,
                Name = "Phoenix Baker",
                Email = "phoenix@untitledui.com",
                InvoiceTag = "INV-3065",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 70

            });

            list.Add(new Customer()
            {
                Id = 3,
                Name = "Lana Steiner",
                Email = "lana@untitledui.com",
                InvoiceTag = "INV-3064",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 60

            });

            list.Add(new Customer()
            {
                Id = 4,
                Name = "Demi Wilkinson",
                Email = "demi@untitledui.com",
                InvoiceTag = "INV-3063",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 30

            });

            list.Add(new Customer()
            {
                Id = 5,
                Name = "Candice Wu",
                Email = "candice@untitledui.com",
                InvoiceTag = "INV-3062",
                PaymentStatus = PaymentStatus.Refunded,
                Progress = 80

            });

            list.Add(new Customer()
            {
                Id = 6,
                Name = "Natali Craig",
                Email = "natali@untitledui.com",
                InvoiceTag = "INV-3061",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 20

            });

            list.Add(new Customer()
            {
                Id = 7,
                Name = "Drew Cano",
                Email = "drew@untitledui.com",
                InvoiceTag = "INV-3060",
                PaymentStatus = PaymentStatus.Cancel,
                Progress = 10

            });

            list.Add(new Customer()
            {
                Id = 8,
                Name = "Orlando Diggs",
                Email = "orlando@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Cancel,
                Progress = 40

            });

            return list;
        }
    }
}
