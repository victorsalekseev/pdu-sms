using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using SMS.Settings;

namespace SMS
{
    public partial class FormMain : Form
    {
        ATGSM at;
        public FormMain()
        {
            InitializeComponent();
            at = new ATGSM("COM3");
            at.ReadBuffer += new ATGSM.OnReadBuffer(at_ReadBuffer);//!!! выше и первее всех команд здесь!!!
            button_runat.Click += new EventHandler(button_runat_Click);
            this.Text = "Signal " + at.GetSignalLevel().ToString() + " dB";
            string ff=at.GetNumberFromBEU("002B00370039003000330033003200390032003300330031");
            at.GetTimeFromText("09/04/28,09:42:34+16");
            кодировкаToolStripMenuItem.Click += new EventHandler(кодировкаToolStripMenuItem_Click);
        }

        void button_runat_Click(object sender, EventArgs e)
        {
            at.RunAT(textBox_attxt.Text, "\r\n");
        }

        void at_ReadBuffer(string buffer)
        {
            DateTime dts = DateTime.Now;
            textBox_log.AppendText(Environment.NewLine+"Start -- " + dts.ToLongTimeString() + " / " + dts.ToShortDateString() + " -------" + Environment.NewLine);
            textBox_log.AppendText(buffer);
            DateTime dte = DateTime.Now;
            textBox_log.AppendText("End ---- " + dte.ToLongTimeString() + " / " + dte.ToShortDateString() + " -------" + Environment.NewLine);

            //textBox_log.
        }

        void кодировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormEnc fe = new FormEnc())
            {
                fe.ShowDialog();
            }
        }

        public ATGSM GetATGSM()
        {
            return at;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //at.SendSMS("+79033292331", 145, "Test");
            at.SendPDUSMS();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_data.Text= at.ReadSMSText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}