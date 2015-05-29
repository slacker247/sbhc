using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothieInterface
{
    public partial class SettingsFrm : Form
    {
        protected Settings m_Settings = new Settings();


        public delegate String SendCmd(String message, bool singleLine);
        public event SendCmd cmd;

        public SettingsFrm()
        {
            InitializeComponent();
            pg_Properties.SelectedObject = m_Settings;
        }

        protected void loadSettings()
        {
            if(cmd != null)
            {
                Settings lSettings = new Settings();
                Dictionary<PropertyInfo, String> props = Settings.getReferences();

                foreach (PropertyInfo prop in props.Keys)
                {
                    String propValue = "";
                    propValue = cmd(String.Format("config-get {0}\r\n", props[prop]), true);
                    if (!String.IsNullOrEmpty(propValue))
                    {
                        bool propExists = !propValue.Contains("not in config");
                        if (propExists)
                        {
                            String[] tmp = propValue.Split(' ');
                            propValue = tmp[tmp.Length - 1].Trim();
                        }
                        if (propExists && !String.IsNullOrEmpty(propValue))
                        {
                            if (prop.PropertyType == typeof(String))
                            {
                                lSettings.set(props[prop], propValue);
                            }
                            else
                            {
                                float fValue = 0f;
                                bool bValue = false;
                                if (float.TryParse(propValue, out fValue))
                                {
                                    lSettings.set(props[prop], fValue);
                                }
                                else if (bool.TryParse(propValue, out bValue))
                                {
                                    lSettings.set(props[prop], bValue);
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        protected void saveSettings()
        {
            if (cmd != null)
            {

            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            //  http://smoothieware.org/configuring-smoothie
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            loadSettings();
        }
    }
}
