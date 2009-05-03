namespace AppSMS
{
    partial class FormCmd
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
            this.label_name_cmd = new System.Windows.Forms.Label();
            this.textBox_name_cmd = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox_cmd = new System.Windows.Forms.GroupBox();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.dateTimePicker_date_cmd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_time_cmd = new System.Windows.Forms.DateTimePicker();
            this.label_datetime_run = new System.Windows.Forms.Label();
            this.groupBox_repeat = new System.Windows.Forms.GroupBox();
            this.comboBox_repeat_mul_cmd = new System.Windows.Forms.ComboBox();
            this.textBox_repeat_val_cmd = new System.Windows.Forms.TextBox();
            this.checkBox_repeat_odd_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_even_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_vs_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_sb_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_pt_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_ct_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_sr_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_vt_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat_pn_cmd = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat = new System.Windows.Forms.CheckBox();
            this.button_set_datetime = new System.Windows.Forms.Button();
            this.groupBox_cmd.SuspendLayout();
            this.groupBox_repeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name_cmd
            // 
            this.label_name_cmd.AutoSize = true;
            this.label_name_cmd.Location = new System.Drawing.Point(120, 8);
            this.label_name_cmd.Name = "label_name_cmd";
            this.label_name_cmd.Size = new System.Drawing.Size(106, 13);
            this.label_name_cmd.TabIndex = 7;
            this.label_name_cmd.Text = "Название команды";
            // 
            // textBox_name_cmd
            // 
            this.textBox_name_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name_cmd.Location = new System.Drawing.Point(228, 5);
            this.textBox_name_cmd.Name = "textBox_name_cmd";
            this.textBox_name_cmd.Size = new System.Drawing.Size(202, 20);
            this.textBox_name_cmd.TabIndex = 6;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(5, 8);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(29, 5);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(85, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // groupBox_cmd
            // 
            this.groupBox_cmd.Controls.Add(this.textBox_cmd);
            this.groupBox_cmd.Location = new System.Drawing.Point(8, 31);
            this.groupBox_cmd.Name = "groupBox_cmd";
            this.groupBox_cmd.Size = new System.Drawing.Size(426, 100);
            this.groupBox_cmd.TabIndex = 9;
            this.groupBox_cmd.TabStop = false;
            this.groupBox_cmd.Text = "Команда";
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_cmd.Location = new System.Drawing.Point(3, 16);
            this.textBox_cmd.MaxLength = 160;
            this.textBox_cmd.Multiline = true;
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_cmd.Size = new System.Drawing.Size(420, 81);
            this.textBox_cmd.TabIndex = 9;
            // 
            // dateTimePicker_date_cmd
            // 
            this.dateTimePicker_date_cmd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date_cmd.Location = new System.Drawing.Point(110, 137);
            this.dateTimePicker_date_cmd.Name = "dateTimePicker_date_cmd";
            this.dateTimePicker_date_cmd.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker_date_cmd.TabIndex = 10;
            this.dateTimePicker_date_cmd.Value = new System.DateTime(2009, 10, 20, 0, 0, 0, 0);
            // 
            // dateTimePicker_time_cmd
            // 
            this.dateTimePicker_time_cmd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_time_cmd.Location = new System.Drawing.Point(206, 137);
            this.dateTimePicker_time_cmd.Name = "dateTimePicker_time_cmd";
            this.dateTimePicker_time_cmd.ShowUpDown = true;
            this.dateTimePicker_time_cmd.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker_time_cmd.TabIndex = 11;
            this.dateTimePicker_time_cmd.Value = new System.DateTime(2009, 10, 20, 0, 0, 0, 0);
            // 
            // label_datetime_run
            // 
            this.label_datetime_run.AutoSize = true;
            this.label_datetime_run.Location = new System.Drawing.Point(5, 141);
            this.label_datetime_run.Name = "label_datetime_run";
            this.label_datetime_run.Size = new System.Drawing.Size(103, 13);
            this.label_datetime_run.TabIndex = 12;
            this.label_datetime_run.Text = "Время исполнения";
            // 
            // groupBox_repeat
            // 
            this.groupBox_repeat.Controls.Add(this.comboBox_repeat_mul_cmd);
            this.groupBox_repeat.Controls.Add(this.textBox_repeat_val_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_odd_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_even_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_vs_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_sb_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_pt_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_ct_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_sr_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_vt_cmd);
            this.groupBox_repeat.Controls.Add(this.checkBox_repeat_pn_cmd);
            this.groupBox_repeat.Enabled = false;
            this.groupBox_repeat.Location = new System.Drawing.Point(8, 175);
            this.groupBox_repeat.Name = "groupBox_repeat";
            this.groupBox_repeat.Size = new System.Drawing.Size(426, 68);
            this.groupBox_repeat.TabIndex = 13;
            this.groupBox_repeat.TabStop = false;
            // 
            // comboBox_repeat_mul_cmd
            // 
            this.comboBox_repeat_mul_cmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_repeat_mul_cmd.FormattingEnabled = true;
            this.comboBox_repeat_mul_cmd.Items.AddRange(new object[] {
            "Секунды",
            "Часы",
            "Сутки"});
            this.comboBox_repeat_mul_cmd.Location = new System.Drawing.Point(102, 19);
            this.comboBox_repeat_mul_cmd.Name = "comboBox_repeat_mul_cmd";
            this.comboBox_repeat_mul_cmd.Size = new System.Drawing.Size(90, 21);
            this.comboBox_repeat_mul_cmd.TabIndex = 10;
            // 
            // textBox_repeat_val_cmd
            // 
            this.textBox_repeat_val_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_repeat_val_cmd.Location = new System.Drawing.Point(6, 20);
            this.textBox_repeat_val_cmd.Name = "textBox_repeat_val_cmd";
            this.textBox_repeat_val_cmd.Size = new System.Drawing.Size(90, 20);
            this.textBox_repeat_val_cmd.TabIndex = 9;
            // 
            // checkBox_repeat_odd_cmd
            // 
            this.checkBox_repeat_odd_cmd.AutoSize = true;
            this.checkBox_repeat_odd_cmd.Checked = true;
            this.checkBox_repeat_odd_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_odd_cmd.Location = new System.Drawing.Point(294, 22);
            this.checkBox_repeat_odd_cmd.Name = "checkBox_repeat_odd_cmd";
            this.checkBox_repeat_odd_cmd.Size = new System.Drawing.Size(97, 17);
            this.checkBox_repeat_odd_cmd.TabIndex = 8;
            this.checkBox_repeat_odd_cmd.Text = "Нечетные дни";
            this.checkBox_repeat_odd_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_even_cmd
            // 
            this.checkBox_repeat_even_cmd.AutoSize = true;
            this.checkBox_repeat_even_cmd.Checked = true;
            this.checkBox_repeat_even_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_even_cmd.Location = new System.Drawing.Point(198, 22);
            this.checkBox_repeat_even_cmd.Name = "checkBox_repeat_even_cmd";
            this.checkBox_repeat_even_cmd.Size = new System.Drawing.Size(86, 17);
            this.checkBox_repeat_even_cmd.TabIndex = 7;
            this.checkBox_repeat_even_cmd.Text = "Четные дни";
            this.checkBox_repeat_even_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_vs_cmd
            // 
            this.checkBox_repeat_vs_cmd.AutoSize = true;
            this.checkBox_repeat_vs_cmd.Checked = true;
            this.checkBox_repeat_vs_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_vs_cmd.Location = new System.Drawing.Point(294, 45);
            this.checkBox_repeat_vs_cmd.Name = "checkBox_repeat_vs_cmd";
            this.checkBox_repeat_vs_cmd.Size = new System.Drawing.Size(42, 17);
            this.checkBox_repeat_vs_cmd.TabIndex = 6;
            this.checkBox_repeat_vs_cmd.Text = "Вс.";
            this.checkBox_repeat_vs_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_sb_cmd
            // 
            this.checkBox_repeat_sb_cmd.AutoSize = true;
            this.checkBox_repeat_sb_cmd.Checked = true;
            this.checkBox_repeat_sb_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_sb_cmd.Location = new System.Drawing.Point(246, 45);
            this.checkBox_repeat_sb_cmd.Name = "checkBox_repeat_sb_cmd";
            this.checkBox_repeat_sb_cmd.Size = new System.Drawing.Size(42, 17);
            this.checkBox_repeat_sb_cmd.TabIndex = 5;
            this.checkBox_repeat_sb_cmd.Text = "Сб.";
            this.checkBox_repeat_sb_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_pt_cmd
            // 
            this.checkBox_repeat_pt_cmd.AutoSize = true;
            this.checkBox_repeat_pt_cmd.Checked = true;
            this.checkBox_repeat_pt_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_pt_cmd.Location = new System.Drawing.Point(198, 45);
            this.checkBox_repeat_pt_cmd.Name = "checkBox_repeat_pt_cmd";
            this.checkBox_repeat_pt_cmd.Size = new System.Drawing.Size(42, 17);
            this.checkBox_repeat_pt_cmd.TabIndex = 4;
            this.checkBox_repeat_pt_cmd.Text = "Пт.";
            this.checkBox_repeat_pt_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_ct_cmd
            // 
            this.checkBox_repeat_ct_cmd.AutoSize = true;
            this.checkBox_repeat_ct_cmd.Checked = true;
            this.checkBox_repeat_ct_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_ct_cmd.Location = new System.Drawing.Point(150, 45);
            this.checkBox_repeat_ct_cmd.Name = "checkBox_repeat_ct_cmd";
            this.checkBox_repeat_ct_cmd.Size = new System.Drawing.Size(42, 17);
            this.checkBox_repeat_ct_cmd.TabIndex = 3;
            this.checkBox_repeat_ct_cmd.Text = "Чт.";
            this.checkBox_repeat_ct_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_sr_cmd
            // 
            this.checkBox_repeat_sr_cmd.AutoSize = true;
            this.checkBox_repeat_sr_cmd.Checked = true;
            this.checkBox_repeat_sr_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_sr_cmd.Location = new System.Drawing.Point(102, 45);
            this.checkBox_repeat_sr_cmd.Name = "checkBox_repeat_sr_cmd";
            this.checkBox_repeat_sr_cmd.Size = new System.Drawing.Size(42, 17);
            this.checkBox_repeat_sr_cmd.TabIndex = 2;
            this.checkBox_repeat_sr_cmd.Text = "Ср.";
            this.checkBox_repeat_sr_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_vt_cmd
            // 
            this.checkBox_repeat_vt_cmd.AutoSize = true;
            this.checkBox_repeat_vt_cmd.Checked = true;
            this.checkBox_repeat_vt_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_vt_cmd.Location = new System.Drawing.Point(55, 45);
            this.checkBox_repeat_vt_cmd.Name = "checkBox_repeat_vt_cmd";
            this.checkBox_repeat_vt_cmd.Size = new System.Drawing.Size(41, 17);
            this.checkBox_repeat_vt_cmd.TabIndex = 1;
            this.checkBox_repeat_vt_cmd.Text = "Вт.";
            this.checkBox_repeat_vt_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat_pn_cmd
            // 
            this.checkBox_repeat_pn_cmd.AutoSize = true;
            this.checkBox_repeat_pn_cmd.Checked = true;
            this.checkBox_repeat_pn_cmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repeat_pn_cmd.Location = new System.Drawing.Point(6, 45);
            this.checkBox_repeat_pn_cmd.Name = "checkBox_repeat_pn_cmd";
            this.checkBox_repeat_pn_cmd.Size = new System.Drawing.Size(43, 17);
            this.checkBox_repeat_pn_cmd.TabIndex = 0;
            this.checkBox_repeat_pn_cmd.Text = "Пн.";
            this.checkBox_repeat_pn_cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat
            // 
            this.checkBox_repeat.AutoSize = true;
            this.checkBox_repeat.Location = new System.Drawing.Point(9, 163);
            this.checkBox_repeat.Name = "checkBox_repeat";
            this.checkBox_repeat.Size = new System.Drawing.Size(124, 17);
            this.checkBox_repeat.TabIndex = 15;
            this.checkBox_repeat.Text = "Исполнять каждые";
            this.checkBox_repeat.UseVisualStyleBackColor = true;
            // 
            // button_set_datetime
            // 
            this.button_set_datetime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_set_datetime.Location = new System.Drawing.Point(302, 137);
            this.button_set_datetime.Name = "button_set_datetime";
            this.button_set_datetime.Size = new System.Drawing.Size(132, 20);
            this.button_set_datetime.TabIndex = 14;
            this.button_set_datetime.Text = "Установить текущее";
            this.button_set_datetime.UseVisualStyleBackColor = true;
            // 
            // FormCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 251);
            this.Controls.Add(this.checkBox_repeat);
            this.Controls.Add(this.button_set_datetime);
            this.Controls.Add(this.groupBox_repeat);
            this.Controls.Add(this.label_datetime_run);
            this.Controls.Add(this.dateTimePicker_time_cmd);
            this.Controls.Add(this.dateTimePicker_date_cmd);
            this.Controls.Add(this.groupBox_cmd);
            this.Controls.Add(this.label_name_cmd);
            this.Controls.Add(this.textBox_name_cmd);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Свойства команды";
            this.groupBox_cmd.ResumeLayout(false);
            this.groupBox_cmd.PerformLayout();
            this.groupBox_repeat.ResumeLayout(false);
            this.groupBox_repeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_cmd;
        private System.Windows.Forms.TextBox textBox_name_cmd;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.GroupBox groupBox_cmd;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_cmd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time_cmd;
        private System.Windows.Forms.Label label_datetime_run;
        private System.Windows.Forms.GroupBox groupBox_repeat;
        private System.Windows.Forms.CheckBox checkBox_repeat_odd_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_even_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_vs_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_sb_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_pt_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_ct_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_sr_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_vt_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat_pn_cmd;
        private System.Windows.Forms.ComboBox comboBox_repeat_mul_cmd;
        private System.Windows.Forms.TextBox textBox_repeat_val_cmd;
        private System.Windows.Forms.CheckBox checkBox_repeat;
        private System.Windows.Forms.Button button_set_datetime;
    }
}