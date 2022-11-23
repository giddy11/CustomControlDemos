using System.Windows;

namespace CustomControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new DataObject() { Name = "Brian Legends" };
        }
        //Vector v = new Vector();
        //public class DataObject : INotifyPropertyChanged
        //{
        //    private void NotifyPropertyChanged(string propertyName)
        //    {
        //        var handler = PropertyChanged;
        //        if (handler != null)
        //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }

        //    private String _name;
        //    public String Name
        //    {
        //        get { return _name; }
        //        set
        //        {
        //            _name = value;
        //            NotifyPropertyChanged("Name");
        //        }
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;
        //}



    }
}
