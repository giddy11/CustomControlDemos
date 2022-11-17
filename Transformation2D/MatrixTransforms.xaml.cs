using CustomClasses;
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
using System.Windows.Shapes;

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
            m.Scale( 1,0.5);
            tbScale.Text = ($" ({m.ToString()}) ");

            
        }
    }
}
