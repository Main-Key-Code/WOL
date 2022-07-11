using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Globalization;

using System.Threading;

namespace WOL
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            btnWakeUp.Text = "Wake On Lan";
        }

        private void CheckLog(string text, int Line)
        {
            tBoxLog.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] >> {text}");

            if (Line == 1) { tBoxLog.AppendText(Environment.NewLine); }

            tBoxLog.ScrollToCaret();
        }

        byte[] macAdd = new byte[] { 0x6C, 0x4B, 0x90, 0x70, 0x1C, 0xB5 };

        private void btnWakeUp_Click(object sende0r, EventArgs e)
        {
            //34-E1-2D-6C-D2-1B
            if (CheckMacText())
            {
                WakeOn(tBoxMacAddress.Text);
            }
        }

        private void tBoxMacAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckMacText())
                {
                    WakeOn(tBoxMacAddress.Text);
                }
            }
        }

        private bool CheckMacText()
        {
            if (tBoxMacAddress.Text == "")
            {
                MessageBox.Show("MAC Address 를 입력 하시기 바랍니다.", "필수값 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void WakeOn(string sMACAddress)
        {
            using (UdpClient client = new UdpClient())
            {
                sMACAddress = sMACAddress.Replace("-", "");

                byte[] buffer = new byte[sMACAddress.Length / 2];

                for (int i = 0; i < sMACAddress.Length; i += 2)
                {
                    string digit = sMACAddress.Substring(i, 2);
                    buffer[i / 2] = byte.Parse(digit, NumberStyles.HexNumber);
                }

                client.Connect(IPAddress.Broadcast, 7);

                byte[] packet = new byte[17 * 6];

                for (int i = 0; i < 6; i++)
                {
                    packet[i] = 0xFF;
                }

                for (int y = 1; y <= 16; y++)
                {
                    for (int x = 0; x < 6; x++)
                    {
                        packet[y * 6 + x] = buffer[x];
                    }
                }

                client.Send(packet, packet.Length);

                Task.Run(() =>
                {
                    string tttt = null;

                    foreach (var t in packet) { tttt += $"{t}"; }

                    tBoxLog.Invoke(new Action(() =>
                    {
                        CheckLog($"Client.Send [{tttt}]", 1);
                    }));

                });


            }
        }
    }
}

