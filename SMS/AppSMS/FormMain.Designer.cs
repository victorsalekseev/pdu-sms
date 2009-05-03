namespace AppSMS
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСписокОбъектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panel_top = new System.Windows.Forms.Panel();
            this.tabControl_log = new System.Windows.Forms.TabControl();
            this.tabPage_logmodem = new System.Windows.Forms.TabPage();
            this.tabPage_logcommand = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.dataGridView_obj = new System.Windows.Forms.DataGridView();
            this.IdObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTelObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripObj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.свойстваОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator_obj = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource_obj = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip_icon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_addnew = new System.Windows.Forms.ToolStripButton();
            this.textBoxLog_modem = new AppSMS.Components.Controls.TextBoxLog();
            this.textBoxLog_cmd = new AppSMS.Components.Controls.TextBoxLog();
            this.menuStrip.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.tabControl_log.SuspendLayout();
            this.tabPage_logmodem.SuspendLayout();
            this.tabPage_logcommand.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_obj)).BeginInit();
            this.contextMenuStripObj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_obj)).BeginInit();
            this.bindingNavigator_obj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_obj)).BeginInit();
            this.contextMenuStrip_icon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.объектToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(659, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьПрограммуToolStripMenuItem,
            this.сохранитьСписокОбъектовToolStripMenuItem,
            this.обновитьСписокToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // закрытьПрограммуToolStripMenuItem
            // 
            this.закрытьПрограммуToolStripMenuItem.Name = "закрытьПрограммуToolStripMenuItem";
            this.закрытьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.закрытьПрограммуToolStripMenuItem.Text = "Закрыть программу";
            // 
            // сохранитьСписокОбъектовToolStripMenuItem
            // 
            this.сохранитьСписокОбъектовToolStripMenuItem.Name = "сохранитьСписокОбъектовToolStripMenuItem";
            this.сохранитьСписокОбъектовToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.сохранитьСписокОбъектовToolStripMenuItem.Text = "Сохранить список объектов";
            // 
            // обновитьСписокToolStripMenuItem
            // 
            this.обновитьСписокToolStripMenuItem.Name = "обновитьСписокToolStripMenuItem";
            this.обновитьСписокToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.обновитьСписокToolStripMenuItem.Text = "Обновить список";
            // 
            // объектToolStripMenuItem
            // 
            this.объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            this.объектToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.объектToolStripMenuItem.Text = "Объект";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 527);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(659, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.tabControl_log);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_top.Location = new System.Drawing.Point(0, 371);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(659, 156);
            this.panel_top.TabIndex = 3;
            // 
            // tabControl_log
            // 
            this.tabControl_log.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl_log.Controls.Add(this.tabPage_logmodem);
            this.tabControl_log.Controls.Add(this.tabPage_logcommand);
            this.tabControl_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_log.Location = new System.Drawing.Point(0, 0);
            this.tabControl_log.Multiline = true;
            this.tabControl_log.Name = "tabControl_log";
            this.tabControl_log.SelectedIndex = 0;
            this.tabControl_log.Size = new System.Drawing.Size(659, 156);
            this.tabControl_log.TabIndex = 0;
            // 
            // tabPage_logmodem
            // 
            this.tabPage_logmodem.Controls.Add(this.textBoxLog_modem);
            this.tabPage_logmodem.Location = new System.Drawing.Point(23, 4);
            this.tabPage_logmodem.Name = "tabPage_logmodem";
            this.tabPage_logmodem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logmodem.Size = new System.Drawing.Size(632, 148);
            this.tabPage_logmodem.TabIndex = 0;
            this.tabPage_logmodem.Text = "Лог модема";
            this.tabPage_logmodem.UseVisualStyleBackColor = true;
            // 
            // tabPage_logcommand
            // 
            this.tabPage_logcommand.Controls.Add(this.textBoxLog_cmd);
            this.tabPage_logcommand.Location = new System.Drawing.Point(23, 4);
            this.tabPage_logcommand.Name = "tabPage_logcommand";
            this.tabPage_logcommand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logcommand.Size = new System.Drawing.Size(632, 148);
            this.tabPage_logcommand.TabIndex = 1;
            this.tabPage_logcommand.Text = "Лог команд";
            this.tabPage_logcommand.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 368);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(659, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.dataGridView_obj);
            this.panel_bottom.Controls.Add(this.bindingNavigator_obj);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(0, 24);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(659, 344);
            this.panel_bottom.TabIndex = 7;
            // 
            // dataGridView_obj
            // 
            this.dataGridView_obj.AllowUserToAddRows = false;
            this.dataGridView_obj.AllowUserToDeleteRows = false;
            this.dataGridView_obj.AllowUserToResizeColumns = false;
            this.dataGridView_obj.AllowUserToResizeRows = false;
            this.dataGridView_obj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_obj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdObj,
            this.NameObj,
            this.StateObj,
            this.GroupObj,
            this.NumTelObj});
            this.dataGridView_obj.ContextMenuStrip = this.contextMenuStripObj;
            this.dataGridView_obj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_obj.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_obj.Name = "dataGridView_obj";
            this.dataGridView_obj.RowHeadersWidth = 23;
            this.dataGridView_obj.RowTemplate.Height = 20;
            this.dataGridView_obj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_obj.Size = new System.Drawing.Size(659, 319);
            this.dataGridView_obj.TabIndex = 2;
            // 
            // IdObj
            // 
            this.IdObj.DataPropertyName = "IdObj";
            this.IdObj.HeaderText = "ID";
            this.IdObj.MinimumWidth = 20;
            this.IdObj.Name = "IdObj";
            this.IdObj.ReadOnly = true;
            this.IdObj.Width = 40;
            // 
            // NameObj
            // 
            this.NameObj.DataPropertyName = "NameObj";
            this.NameObj.HeaderText = "Название объекта";
            this.NameObj.MinimumWidth = 100;
            this.NameObj.Name = "NameObj";
            this.NameObj.Width = 150;
            // 
            // StateObj
            // 
            this.StateObj.DataPropertyName = "StateObj";
            this.StateObj.HeaderText = "Состояние";
            this.StateObj.MinimumWidth = 40;
            this.StateObj.Name = "StateObj";
            this.StateObj.ReadOnly = true;
            this.StateObj.Width = 120;
            // 
            // GroupObj
            // 
            this.GroupObj.DataPropertyName = "GroupObj";
            this.GroupObj.HeaderText = "Группа";
            this.GroupObj.MinimumWidth = 80;
            this.GroupObj.Name = "GroupObj";
            this.GroupObj.ReadOnly = true;
            this.GroupObj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupObj.Width = 120;
            // 
            // NumTelObj
            // 
            this.NumTelObj.DataPropertyName = "NumTelObj";
            this.NumTelObj.HeaderText = "Номер телефона";
            this.NumTelObj.MinimumWidth = 80;
            this.NumTelObj.Name = "NumTelObj";
            this.NumTelObj.Width = 120;
            // 
            // contextMenuStripObj
            // 
            this.contextMenuStripObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойстваОбъектаToolStripMenuItem,
            this.добавитьОбъектToolStripMenuItem,
            this.удалитьОбъектToolStripMenuItem});
            this.contextMenuStripObj.Name = "contextMenuStripObj";
            this.contextMenuStripObj.Size = new System.Drawing.Size(168, 70);
            // 
            // свойстваОбъектаToolStripMenuItem
            // 
            this.свойстваОбъектаToolStripMenuItem.Name = "свойстваОбъектаToolStripMenuItem";
            this.свойстваОбъектаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.свойстваОбъектаToolStripMenuItem.Text = "Свойства объекта";
            // 
            // добавитьОбъектToolStripMenuItem
            // 
            this.добавитьОбъектToolStripMenuItem.Name = "добавитьОбъектToolStripMenuItem";
            this.добавитьОбъектToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.добавитьОбъектToolStripMenuItem.Text = "Добавить объект";
            // 
            // удалитьОбъектToolStripMenuItem
            // 
            this.удалитьОбъектToolStripMenuItem.Name = "удалитьОбъектToolStripMenuItem";
            this.удалитьОбъектToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.удалитьОбъектToolStripMenuItem.Text = "Удалить объект";
            // 
            // bindingNavigator_obj
            // 
            this.bindingNavigator_obj.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator_obj.BindingSource = this.bindingSource_obj;
            this.bindingNavigator_obj.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_obj.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator_obj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton_addnew,
            this.toolStripButton_delete});
            this.bindingNavigator_obj.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator_obj.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_obj.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_obj.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_obj.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_obj.Name = "bindingNavigator_obj";
            this.bindingNavigator_obj.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_obj.Size = new System.Drawing.Size(659, 25);
            this.bindingNavigator_obj.TabIndex = 1;
            this.bindingNavigator_obj.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // contextMenuStrip_icon
            // 
            this.contextMenuStrip_icon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.contextMenuStrip_icon.Name = "contextMenuStrip_icon";
            this.contextMenuStrip_icon.Size = new System.Drawing.Size(107, 26);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // toolStripButton_delete
            // 
            this.toolStripButton_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_delete.Image")));
            this.toolStripButton_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_delete.Name = "toolStripButton_delete";
            this.toolStripButton_delete.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripButton_addnew
            // 
            this.toolStripButton_addnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_addnew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_addnew.Image")));
            this.toolStripButton_addnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_addnew.Name = "toolStripButton_addnew";
            this.toolStripButton_addnew.Size = new System.Drawing.Size(23, 22);
            // 
            // textBoxLog_modem
            // 
            this.textBoxLog_modem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog_modem.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog_modem.Name = "textBoxLog_modem";
            this.textBoxLog_modem.Size = new System.Drawing.Size(626, 142);
            this.textBoxLog_modem.TabIndex = 1;
            this.textBoxLog_modem.TextLog = "Свойства";
            // 
            // textBoxLog_cmd
            // 
            this.textBoxLog_cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog_cmd.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog_cmd.Name = "textBoxLog_cmd";
            this.textBoxLog_cmd.Size = new System.Drawing.Size(626, 142);
            this.textBoxLog_cmd.TabIndex = 2;
            this.textBoxLog_cmd.TextLog = "Свойства";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 549);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.tabControl_log.ResumeLayout(false);
            this.tabPage_logmodem.ResumeLayout(false);
            this.tabPage_logcommand.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_obj)).EndInit();
            this.contextMenuStripObj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_obj)).EndInit();
            this.bindingNavigator_obj.ResumeLayout(false);
            this.bindingNavigator_obj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_obj)).EndInit();
            this.contextMenuStrip_icon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_icon;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_obj;
        private System.Windows.Forms.BindingSource bindingSource_obj;
        private System.Windows.Forms.BindingNavigator bindingNavigator_obj;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripObj;
        private System.Windows.Forms.ToolStripMenuItem свойстваОбъектаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьОбъектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьОбъектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПрограммуToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_log;
        private System.Windows.Forms.TabPage tabPage_logmodem;
        private AppSMS.Components.Controls.TextBoxLog textBoxLog_modem;
        private System.Windows.Forms.TabPage tabPage_logcommand;
        private AppSMS.Components.Controls.TextBoxLog textBoxLog_cmd;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСписокОбъектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьСписокToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTelObj;
        private System.Windows.Forms.ToolStripButton toolStripButton_delete;
        private System.Windows.Forms.ToolStripButton toolStripButton_addnew;
    }
}

