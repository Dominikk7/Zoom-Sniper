using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Mime;
using System.Reflection;
using ComponentFactory.Krypton.Toolkit;

namespace ZoomSniper
{
    public class SaveManager
    {
        public static string path1 = @"%APPDATA%\ZoomSniper\";
        public string path2 = @"%APPDATA%\ZoomSniper\bigData.xml";
        public string pathTest;
        public string pathDirectory;

        public void appStarup(ref List<links> linkList, ref KryptonButton updateBtn)
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
            
            
            try
            {
                statistics();
                checkUpdate(ref updateBtn);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot check for update");
            }
        }
        
        public void checkUpdate(ref KryptonButton updateBtn)
        {
            //Get local version
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            string fileVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            string[] versionArr = version.Split('.');
            int majorVersion = Int16.Parse(versionArr[0]);
            int minorVersion = Int16.Parse(versionArr[1]);
            int buildVersion = Int16.Parse(versionArr[2]);


            //Get online version 
            string latestVersion = "0.0.0"; //temp in case of no connection
            latestVersion = new System.Net.WebClient().DownloadString("https://download.sourcehex.com/Versions/ZoomSniper.txt");
            versionArr = latestVersion.Split('.');
            int majorVersionL = Int16.Parse(versionArr[0]);
            int minorVersionL = Int16.Parse(versionArr[1]);
            int buildVersionL = Int16.Parse(versionArr[2]);

            //Compare versions
            bool update = false;
            if(majorVersionL > majorVersion)
            {
                //update
                update = true;
            }
            else if(minorVersionL > minorVersion && majorVersionL == majorVersion)
            {
                //update
                update = true;
            }
            else if(buildVersionL > buildVersion && majorVersionL == majorVersion && minorVersionL== minorVersion)
            {
                //update
                update = true;
            }

            if (update)
            {
                //Set update button
                string updateUrl = "https://download.sourcehex.com/Downloads/ZoomSetup" + latestVersion + ".msi";
                updateBtn.AccessibleDescription = updateUrl;
                updateBtn.Visible = true;
            }


            //MessageBox.Show("Version:  );

        }
        public async void statistics()
        {
            string systemName = "";
            string ip = "offline";
            try
            {
                ip = new System.Net.WebClient().DownloadString("https://api.ipify.org");
            }
            catch (Exception ex)
            {
                Console.WriteLine("offline");
                return;
            }

            //from https://stackoverflow.com/questions/26253423/get-system-information-using-c-sharp
            System.Management.SelectQuery query = new System.Management.SelectQuery(@"Select * from Win32_ComputerSystem");

            //initialize the searcher with the query it is supposed to execute
            using (System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query))
            {
                //execute the query
                foreach (System.Management.ManagementObject process in searcher.Get())
                {
                    //print system info
                    process.Get();

                    //Set systemName
                    systemName += process["Model"].ToString();
                    systemName += "|";
                    systemName += process["Name"].ToString();
                }
            }
            //MessageBox.Show(systemName);
            //MessageBox.Show(ip);

            try
            {
                //Send HTTP request
                sendRequest(systemName, ip);
            }
            catch(Exception ex)
            {
                Console.WriteLine("cannot send request");
            }
            


        }
        public void sendRequest(string systemName, string ip)
        {
            //send to database
            HttpClient client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            var values = new Dictionary<string, string>
            {
            { "appID", "zoomSniperApp" },
            { "systemName", systemName },
            { "ip", ip }
            };

            var jsonData = JsonConvert.SerializeObject(values);
            var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");
            client.PostAsync("http://api.sourcehex.com/api", contentData);
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
