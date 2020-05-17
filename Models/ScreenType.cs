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
        ADD_STUDENT = 1,
        [XmlEnum("2")]
        SEARCH_STUDENT = 2,
        [XmlEnum("3")]
        DEPARTMENT = 3,
        [XmlEnum("4")]
        ADD_SUBJECT = 4
    }
}
