using System.Windows;
using System.Windows.Controls;

namespace Wpf_Dependency_Properties
{
    /// <summary>
    /// Interaction logic for MyUC.xaml
    /// </summary>
    public partial class MyUC : UserControl
    {
        public MyUC()
        {
            InitializeComponent();
            
        }
        
        public int Awesomeness
        {
            get { return (int)GetValue(AwesomenessProperty); }
            set { SetValue(AwesomenessProperty, value); }
        }

        public static readonly DependencyProperty AwesomenessProperty =
            DependencyProperty.Register("Awesomeness", typeof(int), typeof(MyUC), new PropertyMetadata(0));
    }
}
