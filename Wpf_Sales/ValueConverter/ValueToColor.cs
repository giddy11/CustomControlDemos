using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Wpf_Sales.ValueConverter
{
    public class ValueToColour : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (PaymentStatus)value;
            switch (value)
            {
                case PaymentStatus.Paid: return new SolidColorBrush(Colors.Green);
                case PaymentStatus.Refunded: return new SolidColorBrush(Colors.Black); ;
                default:
                    return new SolidColorBrush(Colors.Red);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
