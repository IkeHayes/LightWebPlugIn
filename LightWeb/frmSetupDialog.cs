using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Vixen;
using System.Xml;

namespace LightWeb
{
    public partial class frmSetupDialog : Form
    {
        
        private string strConfig;
        private List<Channel> vChannels;
        private int vStartChannel = 0;
        private int vEndChannel = 0;
        
        public frmSetupDialog(List<Channel> channels, int startChannel, int endChannel)
        {
            InitializeComponent();

            vChannels = channels;
            vStartChannel = startChannel;
            vEndChannel = endChannel;
            strConfig = Vixen.Paths.SequencePath + "\\" + LightWebPlugin.strFile;

            bool bExists = System.IO.File.Exists(strConfig);
            if (bExists == false)
            {
                DialogResult drCreate = MessageBox.Show("LightWeb Configuration File not found. Click OK to create.", "Create Config File", MessageBoxButtons.OKCancel);
                if (drCreate == DialogResult.OK)
                {
                    CreateDefaultConfig();
                }
            }
            else
            {

            }

            //foreach (channel ch in channels)
            //{
            //    if (ch.outputchannel >= startchannel)
            //    {
            //        cmbnodeselect.items.add(ch.name);
            //    }
            //}
            //cmbNodeSelect.SelectedIndex = 0;



        }

        public int SelectedChannel
        {
            get { return cmbNodeSelect.SelectedIndex; }
        }

        private void cmdSaveNode_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateDefaultConfig()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create("LightWebSettings.xml", settings);
            writer.WriteStartDocument();
            writer.WriteComment("This is a Configuration File for the Vixen LightWeb PlugIn.");
            writer.WriteStartElement("PlugInSettings");
                writer.WriteElementString("ConfigName", "Default");
                writer.WriteElementString("NumNodes", "1");
                writer.WriteElementString("StartChannel", "0");
                writer.WriteElementString("EndChannel", "1");
                writer.WriteStartElement("NodeSettings");
                    writer.WriteStartElement("Node");
                    writer.WriteAttributeString("NodeNum", "1");
                        writer.WriteElementString("Description", "Default Base Node");
                        writer.WriteElementString("IPAddress", "192.168.25.100");
                        writer.WriteElementString("NumChannels", "2");
                        writer.WriteStartElement("Channels");
                            writer.WriteElementString("Ch1", "0");
                            writer.WriteElementString("Ch2", "1");
                        writer.WriteEndElement();
                    writer.WriteEndElement();
                writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }
    }
}
