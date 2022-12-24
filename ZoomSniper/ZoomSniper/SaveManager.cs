using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ZoomSniper
{
    public class SaveManager
    {
        public static string path1 = @"%APPDATA%\ZoomSniper\";
        public string path2 = @"%APPDATA%\ZoomSniper\bigData.xml";
        public string pathTest;
        public string pathDirectory;

        public void appStarup(ref List<links> linkList)
        {
            //Create files if needed
            pathDirectory = Environment.ExpandEnvironmentVariables(path1);
            pathTest = Environment.ExpandEnvironmentVariables(path2);
            //Make sure directory exists
            try
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(pathDirectory);
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to create save file");
            }


            if (!(File.Exists(pathTest)))
            {
                SerializeListData(ref linkList);
            }
            DeserializeListData(ref linkList);
        }

        public void SerializeListData(ref List<links> linkList)
        {
            pathTest = Environment.ExpandEnvironmentVariables(path2);

            XmlSerializer ser = new XmlSerializer(typeof(List<links>));
            TextWriter writer = new StreamWriter(pathTest);
            ser.Serialize(writer, linkList);
            writer.Close();
        }

        public void DeserializeListData(ref List<links> linkList)
        {
            pathTest = Environment.ExpandEnvironmentVariables(path2);

            XmlSerializer serializer = new XmlSerializer(typeof(List<links>));

            StreamReader reader = new StreamReader(pathTest);
            linkList = (List<links>)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
