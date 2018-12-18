using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Data;

namespace KarliCards_GUI
{
    [ValueConversion(typeof(Ch13CardLib.Rank), typeof(string))]
    class RankNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            int source = (int)value;
            if (source == 1 || source > 10)
            {
                switch (source)
                {
                    case 1:
                        return "Ace";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return DependencyProperty.UnsetValue;
                }
            }
            else
            {
                return source.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            return DependencyProperty.UnsetValue;
        }
    }
}
