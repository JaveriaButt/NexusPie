using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace NPIE.Convertors
{
   public class ScreenConvertor :IValueConverter
    {
        public object Convert(object Object, Type type, object value1, CultureInfo cultureInfo)
        {
            UserControl Response = null;
            try
            {
                if(Object != null)
                {
                    ScreenType Screen = ((dynamic)Object).ChildControl;
                    switch (Screen)
                    {
                          
                        
                    }


                }

            }catch(Exception ex)
            { }
            return Response;

        }

        public object ConvertBack(object Object,Type type, object value1,CultureInfo cultureInfoS)
        {
            return Binding.DoNothing;
        }
    }
}
