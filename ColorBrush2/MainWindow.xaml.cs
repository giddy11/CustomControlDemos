using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorBrush2
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

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            //ColorPickerDialog cPicker = new ColorPickerDialog();
            //cPicker.StartingColor = fillBrush.Color;
            //cPicker.Owner = this;
            //rectFill.Fill = fillBrush;
            //bool? dialogResult = cPicker.ShowDialog();
            //if (dialogResult != null && (bool)dialogResult == true)
            //{
            //    if (selectedShape != null)
            //    {
            //        if (selectedShape.StrokeThickness == selectedStrokeThickness) 
            //        {
            //            selectedShape.Fill =
            //            new SolidColorBrush(cPicker.SelectedColor);
            //            selectedShape.StrokeThickness = originalStrokeThickness;
            //        }
            //    }
            //    fillBrush = new SolidColorBrush(cPicker.SelectedColor);
            //    rectFill.Fill = fillBrush;
            //}
        }

        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!canvas1.IsMouseCaptured)
            {
                startPoint = e.GetPosition(canvas1);
                canvas1.CaptureMouse();

                if (rbSelect.IsChecked == true)
                {
                    if (canvas1 == e.Source)
                        return;

                    foreach (Path path in canvas1.Children)
                        path.StrokeThickness = originalStrokeThickness;

                    selectedShape = (Path)e.Source;
                    selectedShape.StrokeThickness = originalStrokeThickness;
                    fillBrush = (SolidColorBrush)selectedShape.Fill;
                    e.Handled = true;
                }
                else if (rbDelete.IsChecked == true)
                {
                    if (canvas1 == e.Source)
                        return;
                    selectedShape = (Path)e.Source;
                    DeleteShape(selectedShape);
                }
            }
        }

        private void DeleteShape(Path path)
        {
            path.StrokeThickness = selectedStrokeThickness;
            string msg = "Do you really want to delete this shape?";
            string title = "Delete Shape?";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(msg, title, buttons, icon);
            if (result == MessageBoxResult.Yes)
                canvas1.Children.Remove(path);
            else
            {
                path.StrokeThickness = originalStrokeThickness;
                return;
            }
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canvas1.IsMouseCaptured)
            {
                currentPoint = e.GetPosition(canvas1);
                if (rubberBand == null)
                {
                    rubberBand = new Rectangle();
                    rubberBand.Stroke = Brushes.LightCoral;
                    rubberBand.StrokeDashArray = new DoubleCollection(new double[] { 4, 2 });
                    if (rbRectangle.IsChecked == true || rbEllipse.IsChecked == true)
                    {
                        canvas1.Children.Add(rubberBand);
                    }
                }

                double width = Math.Abs(startPoint.X - currentPoint.X);
                double height = Math.Abs(startPoint.Y - currentPoint.Y);
                double left = Math.Min(startPoint.X, currentPoint.X);
                double top = Math.Min(startPoint.Y, currentPoint.Y);
                rubberBand.Width = width;
                rubberBand.Height = height;
                Canvas.SetLeft(rubberBand, left);
                Canvas.SetTop(rubberBand, top);
            }
        }

        private void canvas1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (rbRectangle.IsChecked == true)
                AddShape(startPoint, currentPoint, "rectangle");
            else if (rbEllipse.IsChecked == true)
                AddShape(startPoint, currentPoint, "ellipse");
            if (rubberBand != null)
            {
                canvas1.Children.Remove(rubberBand);
                rubberBand = null;
                canvas1.ReleaseMouseCapture();
            }
        }

        private void AddShape(Point point1, Point point2, string s)
        {
            Path path = new Path();
            path.Fill = fillBrush;
            path.Stroke = strokeBrush;
            path.StrokeThickness = originalStrokeThickness;
            if (s == "rectangle")
            {
                RectangleGeometry geometry = new RectangleGeometry();
                double width = Math.Abs(point1.X - point2.X);
                double height = Math.Abs(point1.Y - point2.Y);
                double left = Math.Min(point1.X, point2.X);
                double top = Math.Min(point1.Y, point2.Y);
                geometry.Rect = new Rect(top, left, width, height);
                path.Data = geometry;
            }
            else if (s == "ellipse")
            {
                EllipseGeometry geometry = new EllipseGeometry();
                double width = Math.Abs(point1.X - point2.X);
                double height = Math.Abs(point1.Y - point2.Y);
                double left = Math.Min(point1.X, point2.X);
                double top = Math.Min(point1.Y, point2.Y);
                geometry.Center = new Point(left + width / 2, top + height / 2);
                geometry.RadiusX = width / 2;
                geometry.RadiusY = height / 2;
                path.Data = geometry;
            }
            canvas1.Children.Add(path);
        }

        private Rectangle rubberBand;
        private Point startPoint;
        private Point currentPoint;
        private Path selectedShape;
        private double selectedStrokeThickness = 2;
        private double originalStrokeThickness = 1;
        private SolidColorBrush strokeBrush = new SolidColorBrush(Colors.Blue);
        private SolidColorBrush fillBrush = new SolidColorBrush(Colors.LightBlue);
    }
}
