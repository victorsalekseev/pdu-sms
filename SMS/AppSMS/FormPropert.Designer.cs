namespace AppSMS
{
    partial class FormPropert
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_timer = new System.Windows.Forms.TabControl();
            this.tabPage_timer = new System.Windows.Forms.TabPage();
            this.dataGridView_cmd = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatetimePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripCmd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.свойстваКомандыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_arch_command = new System.Windows.Forms.TabPage();
            this.dataGridView_arch_evnts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox_send = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_send_try = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_wait_recv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_recv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_wait_send = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_send = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_tele = new System.Windows.Forms.GroupBox();
            this.textBox_pwd_obj = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_sms_format = new System.Windows.Forms.ComboBox();
            this.textBox_SMSC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tel_num_obj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_group_obj = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_name_obj = new System.Windows.Forms.ComboBox();
            this.textBox_name_obj = new System.Windows.Forms.TextBox();
            this.tabControl_timer.SuspendLayout();
            this.tabPage_timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmd)).BeginInit();
            this.contextMenuStripCmd.SuspendLayout();
            this.tabPage_arch_command.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_arch_evnts)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.groupBox_send.SuspendLayout();
            this.groupBox_tele.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(27, 6);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(85, 20);
            this.textBox_id.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(3, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // tabControl_timer
            // 
            this.tabControl_timer.Controls.Add(this.tabPage_timer);
            this.tabControl_timer.Controls.Add(this.tabPage_arch_command);
            this.tabControl_timer.Controls.Add(this.tabPageSettings);
            this.tabControl_timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_timer.Location = new System.Drawing.Point(0, 32);
            this.tabControl_timer.Name = "tabControl_timer";
            this.tabControl_timer.SelectedIndex = 0;
            this.tabControl_timer.Size = new System.Drawing.Size(553, 418);
            this.tabControl_timer.TabIndex = 9;
            // 
            // tabPage_timer
            // 
            this.tabPage_timer.Controls.Add(this.dataGridView_cmd);
            this.tabPage_timer.Location = new System.Drawing.Point(4, 22);
            this.tabPage_timer.Name = "tabPage_timer";
            this.tabPage_timer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_timer.Size = new System.Drawing.Size(545, 392);
            this.tabPage_timer.TabIndex = 0;
            this.tabPage_timer.Text = "Расписание комманд";
            this.tabPage_timer.UseVisualStyleBackColor = true;
            // 
            // dataGridView_cmd
            // 
            this.dataGridView_cmd.AllowUserToAddRows = false;
            this.dataGridView_cmd.AllowUserToDeleteRows = false;
            this.dataGridView_cmd.AllowUserToResizeColumns = false;
            this.dataGridView_cmd.AllowUserToResizeRows = false;
            this.dataGridView_cmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameObj,
            this.state,
            this.DatetimePlan,
            this.RepeatPlan});
            this.dataGridView_cmd.ContextMenuStrip = this.contextMenuStripCmd;
            this.dataGridView_cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_cmd.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_cmd.Name = "dataGridView_cmd";
            this.dataGridView_cmd.ReadOnly = true;
            this.dataGridView_cmd.RowHeadersWidth = 23;
            this.dataGridView_cmd.RowTemplate.Height = 20;
            this.dataGridView_cmd.RowTemplate.ReadOnly = true;
            this.dataGridView_cmd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cmd.Size = new System.Drawing.Size(539, 386);
            this.dataGridView_cmd.TabIndex = 3;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "IdPlan";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 20;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 40;
            // 
            // NameObj
            // 
            this.NameObj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameObj.DataPropertyName = "NamePlan";
            this.NameObj.HeaderText = "Название команды";
            this.NameObj.MinimumWidth = 100;
            this.NameObj.Name = "NameObj";
            this.NameObj.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "CommandPlan";
            this.state.HeaderText = "Команда";
            this.state.MinimumWidth = 40;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // DatetimePlan
            // 
            this.DatetimePlan.DataPropertyName = "DateTimePlan";
            this.DatetimePlan.HeaderText = "Дата исп.";
            this.DatetimePlan.MinimumWidth = 100;
            this.DatetimePlan.Name = "DatetimePlan";
            this.DatetimePlan.ReadOnly = true;
            // 
            // RepeatPlan
            // 
            this.RepeatPlan.DataPropertyName = "RepeatPlan";
            this.RepeatPlan.HeaderText = "Повтор";
            this.RepeatPlan.MinimumWidth = 80;
            this.RepeatPlan.Name = "RepeatPlan";
            this.RepeatPlan.ReadOnly = true;
            this.RepeatPlan.Width = 80;
            // 
            // contextMenuStripCmd
            // 
            this.contextMenuStripCmd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойстваКомандыToolStripMenuItem,
            this.добавитьКомандуToolStripMenuItem,
            this.удалитьКомандуToolStripMenuItem});
            this.contextMenuStripCmd.Name = "contextMenuStripObj";
            this.contextMenuStripCmd.Size = new System.Drawing.Size(172, 70);
            // 
            // свойстваКомандыToolStripMenuItem
            // 
            this.свойстваКомандыToolStripMenuItem.Name = "свойстваКомандыToolStripMenuItem";
            this.свойстваКомандыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.свойстваКомандыToolStripMenuItem.Text = "Свойства команды";
            // 
            // добавитьКомандуToolStripMenuItem
            // 
            this.добавитьКомандуToolStripMenuItem.Name = "добавитьКомандуToolStripMenuItem";
            this.добавитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.добавитьКомандуToolStripMenuItem.Text = "Добавить команду";
            // 
            // удалитьКомандуToolStripMenuItem
            // 
            this.удалитьКомандуToolStripMenuItem.Name = "удалитьКомандуToolStripMenuItem";
            this.удалитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.удалитьКомандуToolStripMenuItem.Text = "Удалить команду";
            // 
            // tabPage_arch_command
            // 
            this.tabPage_arch_command.Controls.Add(this.dataGridView_arch_evnts);
            this.tabPage_arch_command.Location = new System.Drawing.Point(4, 22);
            this.tabPage_arch_command.Name = "tabPage_arch_command";
            this.tabPage_arch_command.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_arch_command.Size = new System.Drawing.Size(545, 392);
            this.tabPage_arch_command.TabIndex = 1;
            this.tabPage_arch_command.Text = "Архив событий";
            this.tabPage_arch_command.UseVisualStyleBackColor = true;
            // 
            // dataGridView_arch_evnts
            // 
            this.dataGridView_arch_evnts.AllowUserToAddRows = false;
            this.dataGridView_arch_evnts.AllowUserToDeleteRows = false;
            this.dataGridView_arch_evnts.AllowUserToResizeColumns = false;
            this.dataGridView_arch_evnts.AllowUserToResizeRows = false;
            this.dataGridView_arch_evnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_arch_evnts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView_arch_evnts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_arch_evnts.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_arch_evnts.Name = "dataGridView_arch_evnts";
            this.dataGridView_arch_evnts.ReadOnly = true;
            this.dataGridView_arch_evnts.RowHeadersWidth = 23;
            this.dataGridView_arch_evnts.RowTemplate.Height = 20;
            this.dataGridView_arch_evnts.RowTemplate.ReadOnly = true;
            this.dataGridView_arch_evnts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_arch_evnts.Size = new System.Drawing.Size(539, 386);
            this.dataGridView_arch_evnts.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCommand";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeCommand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateTimeCommand";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата исп.";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CmdCommand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Команда";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.groupBox_send);
            this.tabPageSettings.Controls.Add(this.groupBox_tele);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(545, 392);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Настройки";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox_send
            // 
            this.groupBox_send.Controls.Add(this.label10);
            this.groupBox_send.Controls.Add(this.textBox_send_try);
            this.groupBox_send.Controls.Add(this.label9);
            this.groupBox_send.Controls.Add(this.textBox_wait_recv);
            this.groupBox_send.Controls.Add(this.label7);
            this.groupBox_send.Controls.Add(this.comboBox_recv);
            this.groupBox_send.Controls.Add(this.label8);
            this.groupBox_send.Controls.Add(this.textBox_wait_send);
            this.groupBox_send.Controls.Add(this.label6);
            this.groupBox_send.Controls.Add(this.comboBox_send);
            this.groupBox_send.Controls.Add(this.label5);
            this.groupBox_send.Location = new System.Drawing.Point(284, 3);
            this.groupBox_send.Name = "groupBox_send";
            this.groupBox_send.Size = new System.Drawing.Size(258, 153);
            this.groupBox_send.TabIndex = 7;
            this.groupBox_send.TabStop = false;
            this.groupBox_send.Text = "Отправка и прием";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "раз";
            // 
            // textBox_send_try
            // 
            this.textBox_send_try.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send_try.Location = new System.Drawing.Point(79, 19);
            this.textBox_send_try.Name = "textBox_send_try";
            this.textBox_send_try.Size = new System.Drawing.Size(142, 20);
            this.textBox_send_try.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Попыт. отпр.";
            // 
            // textBox_wait_recv
            // 
            this.textBox_wait_recv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_wait_recv.Location = new System.Drawing.Point(79, 123);
            this.textBox_wait_recv.Name = "textBox_wait_recv";
            this.textBox_wait_recv.Size = new System.Drawing.Size(173, 20);
            this.textBox_wait_recv.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ожидание, с";
            // 
            // comboBox_recv
            // 
            this.comboBox_recv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_recv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_recv.FormattingEnabled = true;
            this.comboBox_recv.Items.AddRange(new object[] {
            "Немедленно",
            "Отложенно"});
            this.comboBox_recv.Location = new System.Drawing.Point(79, 97);
            this.comboBox_recv.Name = "comboBox_recv";
            this.comboBox_recv.Size = new System.Drawing.Size(173, 21);
            this.comboBox_recv.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Принимать";
            // 
            // textBox_wait_send
            // 
            this.textBox_wait_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_wait_send.Location = new System.Drawing.Point(79, 71);
            this.textBox_wait_send.Name = "textBox_wait_send";
            this.textBox_wait_send.Size = new System.Drawing.Size(173, 20);
            this.textBox_wait_send.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ожидание, с";
            // 
            // comboBox_send
            // 
            this.comboBox_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_send.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_send.FormattingEnabled = true;
            this.comboBox_send.Items.AddRange(new object[] {
            "Немедленно",
            "Отложенно"});
            this.comboBox_send.Location = new System.Drawing.Point(79, 45);
            this.comboBox_send.Name = "comboBox_send";
            this.comboBox_send.Size = new System.Drawing.Size(173, 21);
            this.comboBox_send.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Отправлять";
            // 
            // groupBox_tele
            // 
            this.groupBox_tele.Controls.Add(this.textBox_pwd_obj);
            this.groupBox_tele.Controls.Add(this.label11);
            this.groupBox_tele.Controls.Add(this.label4);
            this.groupBox_tele.Controls.Add(this.comboBox_sms_format);
            this.groupBox_tele.Controls.Add(this.textBox_SMSC);
            this.groupBox_tele.Controls.Add(this.label3);
            this.groupBox_tele.Controls.Add(this.textBox_tel_num_obj);
            this.groupBox_tele.Controls.Add(this.label2);
            this.groupBox_tele.Location = new System.Drawing.Point(3, 3);
            this.groupBox_tele.Name = "groupBox_tele";
            this.groupBox_tele.Size = new System.Drawing.Size(275, 153);
            this.groupBox_tele.TabIndex = 6;
            this.groupBox_tele.TabStop = false;
            this.groupBox_tele.Text = "Связь";
            // 
            // textBox_pwd_obj
            // 
            this.textBox_pwd_obj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pwd_obj.Location = new System.Drawing.Point(130, 92);
            this.textBox_pwd_obj.Name = "textBox_pwd_obj";
            this.textBox_pwd_obj.Size = new System.Drawing.Size(139, 20);
            this.textBox_pwd_obj.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Пароль объекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Формат сообщ.";
            // 
            // comboBox_sms_format
            // 
            this.comboBox_sms_format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_sms_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sms_format.FormattingEnabled = true;
            this.comboBox_sms_format.Items.AddRange(new object[] {
            "Plain text",
            "PDU"});
            this.comboBox_sms_format.Location = new System.Drawing.Point(130, 65);
            this.comboBox_sms_format.Name = "comboBox_sms_format";
            this.comboBox_sms_format.Size = new System.Drawing.Size(139, 21);
            this.comboBox_sms_format.TabIndex = 6;
            // 
            // textBox_SMSC
            // 
            this.textBox_SMSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SMSC.Location = new System.Drawing.Point(130, 13);
            this.textBox_SMSC.Name = "textBox_SMSC";
            this.textBox_SMSC.Size = new System.Drawing.Size(139, 20);
            this.textBox_SMSC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер SMSC объекта";
            // 
            // textBox_tel_num_obj
            // 
            this.textBox_tel_num_obj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tel_num_obj.Location = new System.Drawing.Point(130, 39);
            this.textBox_tel_num_obj.Name = "textBox_tel_num_obj";
            this.textBox_tel_num_obj.Size = new System.Drawing.Size(139, 20);
            this.textBox_tel_num_obj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер тел. объекта";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Группа";
            // 
            // comboBox_group_obj
            // 
            this.comboBox_group_obj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_group_obj.FormattingEnabled = true;
            this.comboBox_group_obj.Location = new System.Drawing.Point(403, 6);
            this.comboBox_group_obj.Name = "comboBox_group_obj";
            this.comboBox_group_obj.Size = new System.Drawing.Size(106, 21);
            this.comboBox_group_obj.TabIndex = 12;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(517, 6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(31, 20);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "S";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // comboBox_name_obj
            // 
            this.comboBox_name_obj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_name_obj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_name_obj.FormattingEnabled = true;
            this.comboBox_name_obj.Location = new System.Drawing.Point(181, 5);
            this.comboBox_name_obj.Name = "comboBox_name_obj";
            this.comboBox_name_obj.Size = new System.Drawing.Size(168, 21);
            this.comboBox_name_obj.TabIndex = 14;
            // 
            // textBox_name_obj
            // 
            this.textBox_name_obj.Location = new System.Drawing.Point(181, 6);
            this.textBox_name_obj.Name = "textBox_name_obj";
            this.textBox_name_obj.Size = new System.Drawing.Size(150, 20);
            this.textBox_name_obj.TabIndex = 15;
            // 
            // FormPropert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.textBox_name_obj);
            this.Controls.Add(this.comboBox_name_obj);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_group_obj);
            this.Controls.Add(this.tabControl_timer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPropert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Свойства объекта";
            this.tabControl_timer.ResumeLayout(false);
            this.tabPage_timer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmd)).EndInit();
            this.contextMenuStripCmd.ResumeLayout(false);
            this.tabPage_arch_command.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_arch_evnts)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBox_send.ResumeLayout(false);
            this.groupBox_send.PerformLayout();
            this.groupBox_tele.ResumeLayout(false);
            this.groupBox_tele.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_timer;
        private System.Windows.Forms.TabPage tabPage_timer;
        private System.Windows.Forms.DataGridView dataGridView_cmd;
        private System.Windows.Forms.TabPage tabPage_arch_command;
        private System.Windows.Forms.DataGridView dataGridView_arch_evnts;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.GroupBox groupBox_send;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_send_try;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_wait_recv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_recv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_wait_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_tele;
        private System.Windows.Forms.TextBox textBox_pwd_obj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_sms_format;
        private System.Windows.Forms.TextBox textBox_SMSC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tel_num_obj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatetimePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCmd;
        private System.Windows.Forms.ToolStripMenuItem свойстваКомандыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомандуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКомандуToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_group_obj;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_name_obj;
        private System.Windows.Forms.TextBox textBox_name_obj;
    }
}