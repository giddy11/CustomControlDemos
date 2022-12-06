using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Sales.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string InvoiceTag { get; set; }
        public string Email { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public static Customer Customers { get; set; }
        public double Progress { get; set; }
    }
}
