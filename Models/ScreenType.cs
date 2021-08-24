using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public enum ScreenType
    {
        [XmlEnum("0")]
        None = 0,

        [XmlEnum("1")]
        VIEWPRODUCTS = 1,

       [XmlEnum("2")]
       ADD_PRODUCTS = 2,

       [XmlEnum("3")]
       SALE_SCREEN = 3,




    }
}
