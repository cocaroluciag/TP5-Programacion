﻿using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace AppFakeStore2.Utils
{
    public class CapitalizeFirstLetterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str && !string.IsNullOrEmpty(str))
            {
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
