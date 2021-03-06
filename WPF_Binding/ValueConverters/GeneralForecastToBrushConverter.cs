﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConverters
{
    class GeneralForecastToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var gf = (GeneralForecast)value;
            switch (gf)
            {
                case GeneralForecast.Sunny:
                    return Brushes.Yellow;
                case GeneralForecast.Rainy:
                    return Brushes.LightGreen;
                case GeneralForecast.Snowy:
                    return Brushes.LightBlue;
                case GeneralForecast.Cloudy:
                    return Brushes.LightGray;
                case GeneralForecast.Dry:
                    return Brushes.LightYellow;
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
