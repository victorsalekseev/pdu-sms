using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS.Settings
{
    public partial class FormEnc : Form
    {
        ATGSM at;
        public FormEnc()
        {
            InitializeComponent();
            button_set_enc.Click += new EventHandler(button_set_enc_Click);
            button_refr.Click += new EventHandler(button_refr_Click);

            FormMain fr = (FormMain)Application.OpenForms[0];
            at= fr.GetATGSM();
            GetEnc();
        }

        void button_refr_Click(object sender, EventArgs e)
        {
            GetEnc();
        }

        void button_set_enc_Click(object sender, EventArgs e)
        {
            button_set_enc.Enabled = false;
            button_set_enc.Text = "Установка...";
            Application.DoEvents();
            at.SetEnc(comboBox_encrs.Text);
            button_set_enc.Text = "OK";
            button_set_enc.Enabled = true;
            Application.DoEvents();
            GetEnc();
            GetEnc();
        }

        private void GetEnc()
        {
            comboBox_encrs.Items.Clear();
            comboBox_encrs.Items.AddRange(at.GetArraySupEnc());            
            label_usechr.Text = at.GetCurrentEnc();
            comboBox_encrs.SelectedItem = label_usechr.Text;
        }
    }
}