using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Wpf_Customer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            var customers = new ObservableCollection<Customer>();

            //Create DataGrid Items Info
            customers.Add(new Customer { Name = "Olivia Rhye", Character = "OR", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#1098ad") });
            customers.Add(new Customer { Name = "Phoenix Baker", Character = "PB", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#1e88e5") });
            customers.Add(new Customer { Name = "Lana Steiner", Character = "LS", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#ff8f00") });
            customers.Add(new Customer { Name = "Demi Willkinson", Character = "DW", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#0ca678") });
            customers.Add(new Customer { Name = "Candice Wu", Character = "CW", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#6741d9") });
            customers.Add(new Customer { Name = "Natali Craig", Character = "NC", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#ff6d00") });
            customers.Add(new Customer { Name = "Drew Cano", Character = "olivia@untitledui.com", Email = "DC", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#ff5252") });
            customers.Add(new Customer { Name = "Orlando Diggs", Character = "OD", Email = "olivia@untitledui.com", InvoiceTag = "INV-3066", BgColor = (Brush)converter.ConvertFromString("#1e88e5") });

            
        }

        public class Customer
        {
            public string Name { get; set; }
            public string InvoiceTag { get; set; }
            public string Email { get; set; }
            public string Character { get; set; }
            public Brush BgColor { get; set; }

        }
    }
}
