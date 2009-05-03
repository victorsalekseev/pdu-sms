using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                         string ddd = "AT+CSQ\r\r\n+CSQ: 23,99\r\n\r\nOK\r\n";
            string pat1 = @"CSQ:\s?<tel>\r\n";
             */


            //AT+CSCS=?\r\r\n+CSCS: (\"IRA\",\"GSM\",\"UCS2\")\r\n\r\nOK\r\n
            string ddd = "AT+CSQ\r\r\n+CSQ: 24,99\r\n\r\nOK\r\n";

            string pat1 = @"CSQ:\s(?<addr>[0-9\,\.]+)[\r\n]";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match match1 = reg1.Match(ddd);
            string ss = match1.Groups["addr"].Value;
             ss=ss+"f";
        }
    }
}