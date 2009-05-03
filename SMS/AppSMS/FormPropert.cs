using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppSMS.Components.DB;
using System.Collections;

namespace AppSMS
{
    public partial class FormPropert : Form
    {
        private int IdObj = 0;
        WrXML wXML = new WrXML();

        public FormPropert()
        {
            InitializeComponent();
            Init();
        }

        public FormPropert(int _IdObj)
        {
            InitializeComponent();
            IdObj = _IdObj;
            Init();

            DataTable dt_obj = wXML.GetObjectData();

            BindingSource bs = new BindingSource();
            bs.DataSource = dt_obj;

            //Список групп
            BindingSource bs_group = new BindingSource();
            bs_group.DataSource = dt_obj;


            Hashtable ht = new Hashtable(20);
            for (int i = 0; i < bs_group.Count; i++)
            {
                DataRowView dr = (DataRowView)bs_group[i];
                if (!ht.ContainsKey(dr["GroupObj"].ToString().ToUpper()))
                {
                    ht.Add(dr["GroupObj"].ToString().ToUpper(), dr["GroupObj"].ToString());
                }
                bs_group.MoveNext();
            }
            comboBox_group_obj.Items.Clear();
            foreach (object _GroupObj in ht.Values)
            {
	             comboBox_group_obj.Items.Add(_GroupObj);
            }

                
            //comboBox_group_obj.DataSource = bs_group;
            //comboBox_group_obj.DisplayMember = "GroupObj";
            //comboBox_group_obj.ValueMember = "GroupObj";

            comboBox_name_obj.DataSource = bs;
            comboBox_name_obj.DisplayMember = "NameObj";
            comboBox_name_obj.ValueMember = "NameObj";

            textBox_id.DataBindings.Add("Text", bs, "IdObj");
            textBox_name_obj.DataBindings.Add("Text", bs, "NameObj");
            comboBox_group_obj.DataBindings.Add("Text", bs, "GroupObj");

            textBox_SMSC.DataBindings.Add("Text", bs, "SMSCObj");
            textBox_tel_num_obj.DataBindings.Add("Text", bs, "NumTelObj");
            comboBox_sms_format.DataBindings.Add("SelectedIndex", bs, "MsgFormatObj");
            textBox_pwd_obj.DataBindings.Add("Text", bs, "LinkPwdObj");

            textBox_send_try.DataBindings.Add("Text", bs, "TrySendObj");
            comboBox_send.DataBindings.Add("SelectedIndex", bs, "IsWaitSendObj");
            textBox_wait_send.DataBindings.Add("Text", bs, "WaitSendObj");
            comboBox_recv.DataBindings.Add("SelectedIndex", bs, "IsWaitRecvObj");
            textBox_wait_recv.DataBindings.Add("Text", bs, "WaitRecvObj");
            
            bs.Position= bs.Find("IdObj", IdObj);

        }

        private void Init()
        {
            comboBox_sms_format.SelectedIndex = 0;
            comboBox_send.SelectedIndex = 0;
            comboBox_recv.SelectedIndex = 0;

            свойстваКомандыToolStripMenuItem.Click += new EventHandler(свойстваКомандыToolStripMenuItem_Click);
            dataGridView_cmd.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_cmd_CellDoubleClick);
            button_save.Click += new EventHandler(button_save_Click);
            comboBox_send.SelectedIndexChanged += new EventHandler(comboBox_send_SelectedIndexChanged);
            comboBox_recv.SelectedIndexChanged+=new EventHandler(comboBox_recv_SelectedIndexChanged);
            SetEnabledSendRecv();
        }

        void comboBox_send_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabledSendRecv();
        }

        void comboBox_recv_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabledSendRecv();
        }

        private void SetEnabledSendRecv()
        {
            switch (comboBox_send.SelectedIndex)
            {
                case 0:
                    {
                        textBox_wait_send.Enabled = false;
                    }
                    break;
                case 1:
                    {
                        textBox_wait_send.Enabled = true;
                    }
                    break;

                default:
                    break;
            }

            switch (comboBox_recv.SelectedIndex)
            {
                case 0:
                    {
                        textBox_wait_recv.Enabled = false;
                    }
                    break;
                case 1:
                    {
                        textBox_wait_recv.Enabled = true;
                    }
                    break;

                default:
                    break;
            }
        }

        void button_save_Click(object sender, EventArgs e)
        {
            wXML.SaveObjectData();
        }

        void dataGridView_cmd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormCommands();
        }

        void свойстваКомандыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormCommands();
        }

        private static void ShowFormCommands()
        {
            using (FormCmd frm_cmd = new FormCmd())
            {
                frm_cmd.ShowDialog();
            }
        }
    }
}