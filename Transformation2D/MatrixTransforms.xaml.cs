using CustomStructs;
using System.Windows;

namespace Transformation2D
{
    /// <summary>
    /// Interaction logic for MatrixTransforms.xaml
    /// </summary>
    public partial class MatrixTransforms : Window
    {
        public MatrixTransforms()
        {
            InitializeComponent();

            // Original matrix
            var m = new MyMatrix(1, 2, 3, 4, 0, 1);
            tbOriginal.Text = ($" ({m.ToString()}) ");

            // Scale
            m.Scale(1, 0.5);
            tbScale.Text = ($" ({m.ToString()}) ");


        }
    }
}
