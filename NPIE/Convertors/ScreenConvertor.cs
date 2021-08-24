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
                if (Object != null)
                {
                    ScreenType Screen = (ScreenType)Enum.Parse(typeof(ScreenType), Object.ToString(), true);
                    switch (Screen)
                    {
                        case ScreenType.None:
                            {
                                return null;
                            }
                        case ScreenType.VIEWPRODUCTS:
                            {
                                return new Screen.Items.ViewProducts();
                            }
                        case ScreenType.ADD_PRODUCTS:
                            {
                                return new Screen.Items.AddProduct();
                            }
                        case ScreenType.SALE_SCREEN:
                            {
                                return new Screen.SaleScreen();
                            }
                        case ScreenType.CATAGORY_SCREEN:
                            {
                                return new Screen.Catagories.Catagoriess();
                            }
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
