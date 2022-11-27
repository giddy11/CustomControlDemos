  using System.Windows;

namespace Wpf_Rectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RectangleModel model = new();
        public MainWindow()
        {
            InitializeComponent();

            model.Width = 200;
            model.Height = 100;
            model.StrokeThickness = 2;

            DataContext = model;


            CustomRectangle.BindTo(nameof(model.Width), model, view, CustomRectangle.WidthProperty);
            CustomRectangle.BindTo(nameof(model.Height), model, view, CustomRectangle.HeightProperty);
            CustomRectangle.BindTo(nameof(model.StrokeThickness), model, view, CustomRectangle.StrokeThicknessProperty);
        }




    }
}
