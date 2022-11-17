using CustomClasses;
using System.Windows;
using System.Windows.Media;

namespace Transformation2D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MatrixOperations : Window
    {
        public MatrixOperations()
        {
            InitializeComponent();

            // Invert matrix
            var m = new MyMatrix(1, 2, 3, 4, 0, 0);
            tbOriginal.Text = ($" ({m.ToString()}) ");
            m.MatrixInvert();
            tbInvert.Text = ($" ({m.ToString()}) ");

            // Matrix multiplication
            var m1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var m2 = new MyMatrix(0, 1, 2, 1, 0, 1);
            var m12 = m1 * m2;
            var m21 = m2 * m1;

            tbM1M2.Text = ($"M1 = ({m1.ToString()}), M2 = ({m2.ToString()}) ");
            tbM12.Text = ($" ({m12.ToString()}) ");
            tbM21.Text = ($" ({m21.ToString()}) ");

        }
    }
}
