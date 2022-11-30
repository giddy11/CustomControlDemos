using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Wpf_HitTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            foreach (Rectangle rect in canvas1.Children)
            {
                //rect.Fill = Brushes.LightBlue;
            }
        }

        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private List<Rectangle> hitList = new List<Rectangle>();
        private EllipseGeometry hitArea = new EllipseGeometry();

    }
}
/*private List<Rectangle> hitList = new List<Rectangle>(); 
 private EllipseGeometry hitArea = new EllipseGeometry(); 
 public HitTestExample() 
 { 
 InitializeComponent(); 
 Initialize(); 
 } 
 private void Initialize() 
 { 
 foreach (Rectangle rect in canvas1.Children) 
 { 
 rect.Fill = Brushes.LightBlue; 
 } 
 } 
 private void OnMouseLeftButtonDown( 
 object sender, MouseButtonEventArgs e) 
 { 
 // Initialization: 
 Initialize(); 
 // Get mouse click point: 
 Point pt = e.GetPosition(canvas1); 
 // Define hit-testing area: 
 hitArea = new EllipseGeometry(pt, 1.0, 1.0); 
 hitList.Clear(); 
 // Call HitTest method: 
 VisualTreeHelper.HitTest(canvas1, null, 
 new HitTestResultCallback(HitTestCallback), 
 new GeometryHitTestParameters(hitArea)); 
 if (hitList.Count > 0) 
 { 
 foreach (Rectangle rect in hitList) 
 { 
 // Change rectangle fill color if it is hit: 
 rect.Fill = Brushes.LightCoral; 
 } 
 MessageBox.Show("You hit " + hitList.Count.ToString() + 
 "rectangles."); 
 } 
 } 
 public HitTestResultBehavior HitTestCallback( 
 HitTestResult result) 
 { 
 // Retrieve the results of the hit test. 
 IntersectionDetail intersectionDetail = 
 ((GeometryHitTestResult)result).IntersectionDetail; 
CHAPTER 3 ■ WPF GRAPHICS BASICS IN 2D 
107 
 switch (intersectionDetail) 
 { 
 case IntersectionDetail.FullyContains: 
 // Add the hit test result to the list: 
 hitList.Add((Rectangle)result.VisualHit); 
 return HitTestResultBehavior.Continue; 
 case IntersectionDetail.Intersects: 
 // Set the behavior to return visuals at all z-order levels: 
 return HitTestResultBehavior.Continue; 
 case IntersectionDetail.FullyInside: 
 // Set the behavior to return visuals at all z-order levels: 
 return HitTestResultBehavior.Continue; 
 default: 
 return HitTestResultBehavior.Stop; 
 } 
 } 
*/