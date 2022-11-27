using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Wpf_Rectangle
{
    public class CustomRectangle : UIElement
    {


        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", 
                typeof(double), 
                typeof(CustomRectangle), 
                new FrameworkPropertyMetadata(0.0, new PropertyChangedCallback(OnValueChanged)));

        public double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", 
                typeof(double), 
                typeof(CustomRectangle), 
                new FrameworkPropertyMetadata(0.0, new PropertyChangedCallback(OnValueChanged)));

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); } 
        }

       
        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness", 
                typeof(double), 
                typeof(CustomRectangle), 
                new FrameworkPropertyMetadata(0.0, new PropertyChangedCallback(OnValueChanged)));


        protected override void OnRender(DrawingContext drawingContext)
        {
            var stroke = new SolidColorBrush(Colors.Black);
            var drawingPen = new Pen(stroke, StrokeThickness);
            drawingContext.DrawRectangle(null, drawingPen, new Rect(0, 0, Width, Height));
        }


        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.Property == WidthProperty ||
                e.Property == HeightProperty ||
                e.Property == StrokeThicknessProperty)
            {
                var ui = (UIElement)d;
                ui.InvalidateVisual();
            }
        }


        public static void BindTo(string name, object source, DependencyObject d, DependencyProperty property)
        {
            var binding = new Binding(name)
            {
                Source = source,
                Mode = BindingMode.OneWay
            };
            BindingOperations.SetBinding(d, property, binding);
        }


    }
}
