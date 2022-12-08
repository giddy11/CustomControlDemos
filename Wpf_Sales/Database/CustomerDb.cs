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
                FirstName = "Olivia",
                LastName = "Rhye",
                Email = "olivia@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 60
            });

            list.Add(new Customer()
            {
                Id = 2,
                FirstName = "Phoenix",
                LastName = "Baker",
                Email = "phoenix@untitledui.com",
                InvoiceTag = "INV-3065",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 70

            });

            list.Add(new Customer()
            {
                Id = 3,
                FirstName = "Lana",
                LastName = "Steiner",
                Email = "lana@untitledui.com",
                InvoiceTag = "INV-3064",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 60

            });

            list.Add(new Customer()
            {
                Id = 4,
                FirstName = "Demi",
                LastName = "Wilkinson",
                Email = "demi@untitledui.com",
                InvoiceTag = "INV-3063",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 30

            });

            list.Add(new Customer()
            {
                Id = 5,
                FirstName = "Candice",
                LastName = "Wu",
                Email = "candice@untitledui.com",
                InvoiceTag = "INV-3062",
                PaymentStatus = PaymentStatus.Refunded,
                Progress = 80

            });

            list.Add(new Customer()
            {
                Id = 6,
                FirstName = "Natali",
                LastName = "Craig",
                Email = "natali@untitledui.com",
                InvoiceTag = "INV-3061",
                PaymentStatus = PaymentStatus.Paid,
                Progress = 20

            });

            list.Add(new Customer()
            {
                Id = 7,
                FirstName = "Drew",
                LastName = "Cano",
                Email = "drew@untitledui.com",
                InvoiceTag = "INV-3060",
                PaymentStatus = PaymentStatus.Cancel,
                Progress = 10

            });

            list.Add(new Customer()
            {
                Id = 8,
                FirstName = "Orlando",
                LastName = "Diggs",
                Email = "orlando@untitledui.com",
                InvoiceTag = "INV-3066",
                PaymentStatus = PaymentStatus.Cancel,
                Progress = 40

            });

            return list;
        }
    }
}
