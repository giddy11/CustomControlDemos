using System;
using System.Windows;

namespace Wpf_Dependency_Properties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        public int MyProperty
        {
            get { return (int)GetValue(MyDependencyProperty); }
            set { SetValue(MyDependencyProperty, value); }
        }

        public static readonly DependencyProperty MyDependencyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        private int _isMouseOverDemo;
        public int IsMouseOverDemo
        {
            get
            {
                return _isMouseOverDemo;
            }
            set
            {
                _isMouseOverDemo = value;
                ChangeNotification();
            }
        }

        private void ChangeNotification()
        {
            throw new NotImplementedException();
        }
    }
}
