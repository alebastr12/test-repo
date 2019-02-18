using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace testgrid
{
    class XmlSaveLoad
    {
        public static void XmlSave(string filename,List<Element> list)
        {
            StreamWriter sr = new StreamWriter(filename);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            ser.Serialize(sr, list);
            sr.Close();
        } 

        public static List<Element> XmlLoad(string filename)
        {
            List<Element> list = new List<Element>();
            StreamReader sw = new StreamReader(filename);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            list = (List<Element>) ser.Deserialize(sw);
            sw.Close();
            return list;
        }
    }
}
