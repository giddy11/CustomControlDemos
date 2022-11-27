using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Rectangle
{
    public class RectangleModel : INotifyPropertyChanged
    {
        private double _width;

        public double Width
        {
            get => _width;
            set 
            { 
                _width = value;
                OnPropertyChanged(nameof(Width));
            }
        }



        private double _height;

        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }


        private double _strokeThickness;

        public double StrokeThickness
        {
            get => _strokeThickness;
            set
            {
                _strokeThickness = value;
                OnPropertyChanged(nameof(StrokeThickness));
            }
        }



        protected virtual void OnPropertyChanged(string propertyName)
            =>PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
