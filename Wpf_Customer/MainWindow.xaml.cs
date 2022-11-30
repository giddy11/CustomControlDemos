using System.Windows;
using System.Windows.Input;

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
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool Ismaximised = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (Ismaximised)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 800;
                    this.Height = 450;

                    Ismaximised = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    Ismaximised = true;
                }
            }
        }
    }
}
