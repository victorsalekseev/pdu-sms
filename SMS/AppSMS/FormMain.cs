using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AppSMS.Components.DB;

namespace AppSMS
{
    public partial class FormMain : Form
    {
        NIcon nc;
        WrXML wXML = new WrXML();

        public FormMain()
        {
            InitializeComponent();
            nc = new NIcon(contextMenuStrip_icon, this);
            dataGridView_obj.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_obj_CellDoubleClick);
            свойстваОбъектаToolStripMenuItem.Click += new EventHandler(свойстваОбъектаToolStripMenuItem_Click);
            выходToolStripMenuItem.Click += new EventHandler(выходToolStripMenuItem_Click);
            закрытьПрограммуToolStripMenuItem.Click += new EventHandler(закрытьПрограммуToolStripMenuItem_Click);
            сохранитьСписокОбъектовToolStripMenuItem.Click += new EventHandler(сохранитьСписокОбъектовToolStripMenuItem_Click);
            обновитьСписокToolStripMenuItem.Click += new EventHandler(обновитьСписокToolStripMenuItem_Click);
            удалитьОбъектToolStripMenuItem.Click += new EventHandler(удалитьОбъектToolStripMenuItem_Click);
            добавитьОбъектToolStripMenuItem.Click += new EventHandler(добавитьОбъектToolStripMenuItem_Click);
            toolStripButton_addnew.Click +=new EventHandler(toolStripButton_addnew_Click);
            toolStripButton_delete.Click += new EventHandler(toolStripButton_delete_Click);

            bindingSource_obj.DataSource = wXML.GetObjectData();
            dataGridView_obj.DataSource = bindingSource_obj;

            //прячем лишние столбцы
            for (int i = 5; i < dataGridView_obj.Columns.Count; i++)
            {
                dataGridView_obj.Columns[i].Visible = false;
            }
        }

        void toolStripButton_addnew_Click(object sender, EventArgs e)
        {
            AddNewObjectItem();
        }

        private void AddNewObjectItem()
        {
            bindingSource_obj.AddNew();
            bindingSource_obj.EndEdit();
            SaveObjectData();
        }

        void toolStripButton_delete_Click(object sender, EventArgs e)
        {
            DeleteCurrentObjectData();
        }

        private void DeleteCurrentObjectData()
        {
            if (MessageBox.Show("Удалить текущий объект?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindingSource_obj.RemoveCurrent();
                bindingSource_obj.EndEdit();
                SaveObjectData();
            }
        }

        void добавитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewObjectItem();
        }

        void удалитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCurrentObjectData();
        }

        void обновитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateObjectList();
        }

        private void UpdateObjectList()
        {
            int pos = bindingSource_obj.Position;
            bindingSource_obj.DataSource = wXML.GetObjectData();
            bindingSource_obj.Position = pos;
        }

        void сохранитьСписокОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveObjectData();
        }

        private void SaveObjectData()
        {
            bindingSource_obj.EndEdit();
            wXML.SaveObjectData();
        }

        void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nc.CloseApp();
        }

        void свойстваОбъектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPropertiesForm();
        }

        void dataGridView_obj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowPropertiesForm();
        }

        private  void ShowPropertiesForm()
        {
            string IdObj = dataGridView_obj.SelectedRows[0].Cells["IdObj"].Value.ToString();
            using (FormPropert frm_pr = new FormPropert(int.Parse(IdObj)))
            {
                frm_pr.ShowDialog();
            }
            UpdateObjectList();
        }

        void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nc.CloseApp();
        }


    }
}