using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AppSMS
{
    /// <summary>
    /// ������ � ����. �������� ����� �����
    /// � �������� � ���� ��������� ����� � ������������ ����.
    /// ��������� ����� ������ �������� CloseApp()
    /// </summary>
    class NIcon
    {
        NotifyIcon ni = new NotifyIcon();
        bool is_allw_closing = false;
        Form _mForm = null;

        public Form mForm
        {
            get { return _mForm; }
            set { _mForm = value; }
        }

        public NIcon()
        {
        }

        public NIcon(ContextMenuStrip cms, Form frm)
        {
            mForm = frm;
            ni.Icon = global::AppSMS.Properties.Resources.indx;
            ni.Visible = true;
            ni.Text = Application.ProductName;
            ni.ContextMenuStrip = cms;
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            _mForm.FormClosing += new FormClosingEventHandler(_mForm_FormClosing);
        }

        public void CloseApp()
        {
            if (MessageBox.Show("������� ���������?", "��������", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                is_allw_closing = true;
                ni.Visible = false;
                _mForm.Close();
            }
        }

        void _mForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_allw_closing)
            {
                e.Cancel = true;
                _mForm.Visible = false;
            }
        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ChangeVisiblePosition();
            }
        }

        public void ChangeVisiblePosition()
        {
            if (!_mForm.Visible)
            {
                _mForm.Visible = true;
                _mForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                _mForm.Visible = false;
            }
        }
    }
}
