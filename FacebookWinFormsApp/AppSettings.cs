using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }

        private ApplicationSettings()
        {
        }

        private static ApplicationSettings s_This;

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = ApplicationSettings.FromFileOrDefault();
                }

                return s_This;
            }
        }

        public bool IsAutoLogin { get; set; }

        public Size LoginFormLastWindowSize { get; set; }

        public Size BrowsingFormsLastWindowSize { get; set; }

        public FormWindowState LoginFormLastWindowState { get; set; }

        public FormWindowState BrowsingFormsLastWindowState { get; set; }

        public Point LoginFormLastWindowLocation { get; set; }

        public Point BrowsingFormsLastWindowLocation { get; set; }

        public string AccessToken { get; set; }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }

        public static ApplicationSettings FromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedThis = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new ApplicationSettings()
                {
                    IsAutoLogin = false,
                    BrowsingFormsLastWindowSize = new Size(1200, 600),
                    BrowsingFormsLastWindowState = FormWindowState.Normal,
                };
            }

            return loadedThis;
        }
    }
}
