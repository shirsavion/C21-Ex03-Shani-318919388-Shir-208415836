using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookApp
{
    namespace Logic
    {
        public sealed class AppSettings
        {
            public Point LastWindowsLocation { set; get; }
            public Size LastWindowsSize { get; set; }
            public bool RememberUser { get; set; }
            public string LastAccessToken { get; set; }
            public List<string> BDCards { get; set; }

            private AppSettings()
            {
                LastWindowsLocation = new Point(50, 50);
                LastWindowsSize = new Size(800, 900);
                RememberUser = false;
                LastAccessToken = null;
                BDCards = new List<string>();
            }

            internal void SaveToFile()
            {
                using (Stream stream = new FileStream(@"C:\Temp\FileAppSetting.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    serializer.Serialize(stream, this);
                }
            }

            internal static AppSettings LoadFromFile()
            {
                AppSettings obj = new AppSettings();

                if (File.Exists(@"C:\Temp\FileAppSetting.xml"))
                {
                    using (Stream stream = new FileStream(@"C:\Temp\FileAppSetting.xml", FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        obj = serializer.Deserialize(stream) as AppSettings;
                    }
                }

                return obj;
            }
        }
    }
}