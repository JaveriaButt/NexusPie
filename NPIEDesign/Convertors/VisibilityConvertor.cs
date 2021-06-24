using NPIE.Controller;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace NPIE.Convertors
{
     
        public class VisibilityConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                bool flag = false;
                if (value is bool)
                {
                    flag = (bool)value;
                }
                else if (value is bool?)
                {
                    bool? nullable = (bool?)value;
                    flag = nullable.HasValue ? nullable.Value : false;
                }
                return (flag ? Visibility.Visible : Visibility.Collapsed);
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                                      CultureInfo culture)
            {
                return Binding.DoNothing;
            }
        }


        public class StringToVisibilityConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                Visibility Response = Visibility.Collapsed;
                try
                {
                    if (!string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        Response = Visibility.Visible;
                    }
                }
                catch (Exception ex)
                {

                }
                return Response;
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                                      CultureInfo culture)
            {
                return Binding.DoNothing;
            }
        }
        public class NullToVisibilityConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                Visibility Response = Visibility.Collapsed;
                try
                {
                    if (value != null)
                    {
                        Response = Visibility.Visible;
                    }
                }
                catch (Exception ex)
                {

                }
                return Response;
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                                      CultureInfo culture)
            {
                return Binding.DoNothing;
            }
        }
        public class NullToVisibilityReverseConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                Visibility Response = Visibility.Visible;
                try
                {
                    if (value != null)
                    {
                        Response = Visibility.Collapsed;
                    }
                }
                catch (Exception ex)
                {

                }
                return Response;
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                                      CultureInfo culture)
            {
                return Binding.DoNothing;
            }
        }
        public class NullToEnableConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                bool Response = false;
                try
                {
                    if (value != null)
                    {
                        Response = true;
                    }
                }
                catch (Exception ex)
                {

                }
                return Response;
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                                      CultureInfo culture)
            {
                return Binding.DoNothing;
            }
        }
        public class NullToDisEnableConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                bool Response = true;
                try
                {
                    if (value != null)
                    {
                        Response = false;
                    }
                }
                catch (Exception ex)
                {

                }
                return Response;
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                                      CultureInfo culture)
            {
                return Binding.DoNothing;
            }
        }
      
     
}
