using System.Windows;

namespace Wpf_DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            obj = new Person();

            obj.Name = "Gideon";

            DataContext = this;
        }







        public Person obj { get; set; }
    }





    public class Person
    {



        //public override string ToString()
        //{
        //    return $"{Name}";
        //}

        public string Name { get; set; }
    }
}
