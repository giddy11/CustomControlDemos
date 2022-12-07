namespace Wpf_Sales.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InvoiceTag { get; set; }
        public string Email { get; set; }
        public string Initial => $"{GetInitial(FirstName)}{GetInitial(LastName)}";
        public PaymentStatus PaymentStatus { get; set; }
        //public static Customer Customers { get; set; }
        public double Progress { get; set; }



        private string GetInitial(string str)
        {
            return str.Substring(0, 1);
        }
    }
}
