using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppSMS
{
    public partial class FormCmd : Form
    {
        public FormCmd()
        {
            InitializeComponent();
            comboBox_repeat_mul_cmd.SelectedIndex = 0;
            checkBox_repeat.CheckedChanged += new EventHandler(checkBox_repeat_CheckedChanged);
        }

        void checkBox_repeat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_repeat.Checked)
            {
                groupBox_repeat.Enabled = true;
            }
            else
            {
                groupBox_repeat.Enabled = false;
            }
        }


    }
}