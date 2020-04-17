using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Resources
{
  public  class General
    {
        public static DataSet XMLToDataSet(string XMLString)
        {
            DataSet DataSet = null;
            try
            {
                StringReader stream = null;
                XmlTextReader reader = null;
                try
                {
                    DataSet xmlDS = new DataSet();
                    stream = new StringReader(XMLString);
                    // Load the XmlTextReader from the stream
                    reader = new XmlTextReader(stream);
                    xmlDS.ReadXml(reader);
                    return xmlDS;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    if (reader != null) reader.Close();
                }

            }
            catch (Exception ex)
            {

            }
            return DataSet;
        }
        public static string DataSetToXML(DataSet XMLString)
        {
            string DataSet = string.Empty;
            try
            {

            }
            catch (Exception ex)
            {

            }
            return DataSet;
        }


        //Clas Object
        public static object XMLToOBJECT(string XMLString, Type _Type)
        {
            object DataSet = null;
            try
            {
                //Convert XML String to XML Document
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(XMLString);

                //Serializer for the Obejct Type
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(_Type);

                //Read XML froom string 

                using (XmlReader reader = XmlReader.Create(new StringReader(doc.InnerXml)))
                {
                    //Deserialize xml and convert it in to class object

                    DataSet = serializer.Deserialize(reader);
                    //Close Reader
                    reader.Close();

                }
            }
            catch (Exception ex)
            {

            }

            return DataSet;
        }
        public static string OBJECTTOXML(object DataSet, bool StringFormate = false)
        {
            string XMLString = string.Empty;
            try
            {
                var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                var serializer = new XmlSerializer(DataSet.GetType());
                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;




                using (var stream = new StringWriter())
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, DataSet, emptyNamepsaces);
                    XMLString = stream.ToString();
                }



                if (StringFormate == true)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(XMLString);
                    XmlNodeList emptyElements = xmlDocument.SelectNodes(@"//*[not(node())]");
                    for (int i = emptyElements.Count - 1; i >= 0; i--)
                    {
                        emptyElements[i].ParentNode.RemoveChild(emptyElements[i]);
                    }
                    XMLString = xmlDocument.InnerXml;
                }
            }
            catch (Exception ex)
            {

            }
            return XMLString;
        }

        //GetTags
        public static string GETTAG(string FromXMLString, string TagName)
        {
            string ElementValue = string.Empty;
            try
            {
                //Convert XML String to XML Document
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(FromXMLString);

                XmlNodeList xnList = doc.SelectNodes(TagName);
                foreach (XmlNode xn in xnList)
                {
                    ElementValue = xn.InnerXml;
                }
            }
            catch (Exception ex)
            {

            }

            return ElementValue;
        }

        // IS DIGIT
        public static bool IsDigit(string digitString)
        {
            bool Response = true;
            try
            {
                foreach (char c in digitString)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
        }
    }
}
