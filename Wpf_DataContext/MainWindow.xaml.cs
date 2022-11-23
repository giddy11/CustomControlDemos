using System.Windows;

namespace Wpf_DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var obj = new Person()
            {
                FirstName = "John",
                LastName = "Helen",
                Age = 25
            };

            DataContext = obj;
        }
    }
}
