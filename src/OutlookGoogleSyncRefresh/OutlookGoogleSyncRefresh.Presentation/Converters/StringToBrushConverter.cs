﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace OutlookGoogleSyncRefresh.Presentation.Converters
{
    public class StringToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (value != null)
                {
                    Color color = (Color)value;
                    return new SolidColorBrush(color);
                }
            }
            catch (Exception)
            {

            }
            return new SolidColorBrush(Color.FromArgb(1, 1, 1, 1));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (value != null)
                {
                    var colorBrush = value as SolidColorBrush;
                    if (colorBrush != null)
                    {
                        return colorBrush.Color;
                    }
                }
            }
            catch (Exception)
            {

            }
            return Color.FromArgb(1, 1, 1, 1);
        }
    }
}
