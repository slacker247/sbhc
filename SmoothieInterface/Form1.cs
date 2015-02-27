using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothieInterface
{
    public partial class Form1 : Form
    {
        protected SerialComms.SerialComms m_ComPort = null;
        protected List<char> m_Received = new List<char>();

        public void msgHandler(String msg)
        {
            setStatus("Error: " + msg);
        }

        public void readHandler(object data)
        {
            if(data is String)
            {
                m_Received.AddRange(((String)data).ToCharArray());
            }
            else if(data is byte[])
            {
                m_Received.AddRange(System.Text.Encoding.Default.GetString((byte[])data).ToCharArray());
            }
        }

        public String received()
        {
            StringBuilder msg = new StringBuilder("");
            bool endString = false;
            DateTime dt = DateTime.Now;
            TimeSpan ts = dt - DateTime.Now;
            TimeSpan timeout = new TimeSpan(0, 0, 15);
            while (!endString && ts < timeout)
            {
                Application.DoEvents();
                Thread.Sleep(120);
                ts = DateTime.Now - dt;
                for (int i = 0; i < m_Received.Count; i++)
                {
                    msg.Append(m_Received[i]);
                    if (m_Received[i] == '\0')
                        endString = true;
                    if (m_Received[i] == '\n')
                        endString = true;
                    m_Received.RemoveAt(i);
                    i--;
                }
            }
            m_Received.Clear();
            return msg.ToString();
        }

        public String waitForReceived()
        {
            String msg = "";
            DateTime dt = DateTime.Now;
            TimeSpan ts = dt - DateTime.Now;
            TimeSpan timeout = new TimeSpan(0, 0, 15);
            do
            {
                msg += received();
                Application.DoEvents();
                Thread.Sleep(120);
                ts = DateTime.Now - dt;
            } while (ts < timeout);
            return msg;
        }

        delegate void setStatusCallback(String msg);
        public void setStatus(String msg)
        {
            if (lsb_History.InvokeRequired)
            {
                setStatusCallback d = new setStatusCallback(setStatus);
                this.Invoke(d, new object[] { msg });
            }
            else
            {
                String[] lines = msg.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!String.IsNullOrEmpty(lines[i]))
                    {
                        lsb_History.Items.Insert(0, lines[i]);
                    }
                    Application.DoEvents();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void mi_EditSettings_Click(object sender, EventArgs e)
        {
            SettingsFrm frm = new SettingsFrm();

            frm.cmd += new SettingsFrm.SendCmd(sendCmd);

            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // TODO : save settings
                //sendCmd("get");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load availible com ports
            cmb_ComPorts.Items.AddRange(SerialComms.SerialComms.getComPorts());
            
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(btn_HomeX, "Home X");
            toolTip1.SetToolTip(btn_HomeY, "Home Y");
            toolTip1.SetToolTip(btn_HomeZ, "Home Z");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close open com port
            closeComPort();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                // minus Y
            }
            if (e.KeyCode == Keys.Down)
            {
                // plus Y
            }
            if (e.KeyCode == Keys.Left)
            {
                // plus x
            }
            if (e.KeyCode == Keys.Right)
            {
                // minus x
            }
            if (e.KeyCode == Keys.PageUp)
            {
                // plus z
            }
            if (e.KeyCode == Keys.PageDown)
            {
                // minus z
            }
            if(e.KeyCode == Keys.Escape)
            {
                // abort any movement
            }
        }

        protected void openComPort()
        {
            closeComPort();
            m_ComPort = new SerialComms.SerialComms();
            m_ComPort.received += new SerialComms.SerialComms.recv(readHandler);
            m_ComPort.msg += new SerialComms.SerialComms.Message(msgHandler);
            m_ComPort.setBaudRate(115200);
            m_ComPort.setStopBits(System.IO.Ports.StopBits.One);
            m_ComPort.setParity(System.IO.Ports.Parity.None);
            m_ComPort.setDataBits(8);
            m_ComPort.setPortName(cmb_ComPorts.SelectedItem.ToString());
            if(m_ComPort.open() == 0)
            {
                btn_Connect.Text = "Close";
                setStatus("Connected to " + cmb_ComPorts.SelectedItem.ToString());
            }
            else
            {
                setStatus("Error opening ComPort.");
            }
        }

        protected void closeComPort()
        {
            if (m_ComPort != null && m_ComPort.isOpen())
            {
                m_ComPort.close();
                if (!btn_Connect.IsDisposed)
                {
                    btn_Connect.Text = "Connect";
                    setStatus("Closed connection to " + cmb_ComPorts.SelectedItem.ToString());
                }
            }
        }

        protected String sendCmd(String cmd, bool singleLine = false)
        {
            String response = "";
            if (m_ComPort != null && m_ComPort.isOpen())
            {
                setStatus("Sending cmd: " + cmd);
                if (m_ComPort.sendData(cmd) == 0)
                {
                    if (singleLine)
                        response = received();
                    else
                        response = waitForReceived();
                }
                else
                {
                    setStatus("Failed to send command.");
                }
            }
            else
            {
                setStatus("Com Port is not open.");
            }
            return response;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            btn_Connect.Enabled = false;
            if(m_ComPort != null &&
               m_ComPort.isOpen())
            {
                closeComPort();
            }
            else if(cmb_ComPorts.SelectedIndex > -1)
            {
                openComPort();
                String response = sendCmd("version\r\n", true);
                setStatus(response);
            }
            btn_Connect.Enabled = true;
        }

        private void btn_SendCmd_Click(object sender, EventArgs e)
        {
            btn_SendCmd.Enabled = false;
            String response = sendCmd(txb_SendCmd.Text + "\r\n");
            setStatus(response);
            setStatus("--end received");
            btn_SendCmd.Enabled = true;
        }
    }
}
