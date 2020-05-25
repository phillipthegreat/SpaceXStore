using SpaceXStore.Data.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SpaceXStore.Data.Helper
{
    public static class Serializer
    {

        public static T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public static void Serialize(string filename)
        {
            // First write something so that there is something to read ...  
            var s = new Store();
            var writer = new XmlSerializer(typeof(Store));
            using (var wfile = new StreamWriter(filename))
            {
                writer.Serialize(wfile, s);
                wfile.Close();
            }

        }

        public static Store Deserialize(string xmlPath)
        {
            Store store = null;
            XmlSerializer reader = new XmlSerializer(typeof(Store));
            using (StreamReader file = new StreamReader(xmlPath))
            {
                store = (Store)reader.Deserialize(file);
                file.Close();
            }

            return store;
        }
    }
}
