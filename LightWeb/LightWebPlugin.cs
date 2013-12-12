using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vixen;                        //Add Reference for Vixen Exe (Also added via reference in Solution Explorer)
using System.Windows.Forms;         //Add Reference for Windows Forms (Also added via reference in Solution Explorer)
using System.Xml;                   //Add Reference for Xml
using System.Net;                   //Add Reference for Network Libraries
using System.Net.Sockets;           //Add Reference for Network Socket Libraries

namespace LightWeb
{
    public class LightWebPlugin:IEventDrivenOutputPlugIn
    {
        //Set message flag constants
        const byte iFlagStart1 = 0x84;
        const byte iFlagStart2 = 0xA4;
        const byte iFlagEnd = 0x96;
        const byte iFlagOffset = 0x01;

        public const string strFile = "LightWebConfig.xml";

        public struct LWNode
        {

        }

        private string strPath;
        private string strConfig;
        private SetupData m_SetupData;
        private XmlNode m_SetupNode;
        private List<Channel> m_Channels;
        private int m_selectedIndex;
        private byte[] BoardData = new byte[7];
        private IPEndPoint IPBoard;
        private Socket server;


        public void Event(byte[] channelValues)
        {
            //Set Start Flags
            BoardData[0] = iFlagStart1;
            BoardData[1] = iFlagStart2;
            //Set Channel Values
            for (int i = 2; i <= 5; i++)
            {
                if (channelValues[i] == iFlagEnd)
                {
                    BoardData[i] = (byte)(channelValues[i] + iFlagOffset);
                }
                else
                {
                    BoardData[i] = channelValues[i];
                }
                //Set End Flag of message
                BoardData[i] = iFlagEnd;
            }
            server.SendTo(BoardData, BoardData.Length, SocketFlags.None, IPBoard);
        }

        public void Initialize(IExecutable executableObject, SetupData setupData, XmlNode setupNode)
        {
            
            //Save initial data given by program for later use
            this.m_SetupData = setupData;
            this.m_Channels = executableObject.Channels;
            this.m_SetupNode = setupData.RootNode;

            //Set configuration file path and fully qualified file path+name
            strPath = Vixen.Paths.SequencePath;
            strConfig = strPath + "\\" + strConfig;


            
        }

        public HardwareMap[] HardwareMap
        {
            get { return new HardwareMap[0]; }
        }

        public void Setup()
        {

            //int StartChannel = 0;
            //int EndChannel = 0;
            
            int StartChannel = Convert.ToInt16(m_SetupNode.Attributes["from"]) - 1;
            int EndChannel = Convert.ToInt16(m_SetupNode.Attributes["to"]) - 1;

            frmSetupDialog SetupDialog = new frmSetupDialog(this.m_Channels, StartChannel, EndChannel);

            if (SetupDialog.ShowDialog() == DialogResult.OK)
            {
                
            
            }

            SetupDialog.Close();
            MessageBox.Show("Yes, this is dog");
        }

        public void Shutdown()
        {
            
        }

        public List<Form> Startup()
        {
            IPBoard = new IPEndPoint(IPAddress.Parse("192.168.1.37"), 10001);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            return new List<Form>();
        }


        public string Author
        {
            get { return "Ike"; }
        }

        public string Description
        {
            get { return "Output Plugin for the LightWeb Control System"; }
        }

        public string Name
        {
            get { return "LightWeb"; }
        }

        public override string ToString()
        {
            return this.Name;
        }


    }
}
