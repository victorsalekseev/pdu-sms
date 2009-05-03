namespace SMS
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настроукиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_attxt = new System.Windows.Forms.TextBox();
            this.button_runat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(0, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(217, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ч";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_data
            // 
            this.textBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_data.Location = new System.Drawing.Point(0, 27);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_data.Size = new System.Drawing.Size(292, 288);
            this.textBox_data.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настроукиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настроукиToolStripMenuItem
            // 
            this.настроукиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кодировкаToolStripMenuItem});
            this.настроукиToolStripMenuItem.Name = "настроукиToolStripMenuItem";
            this.настроукиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.настроукиToolStripMenuItem.Text = "Настройки";
            // 
            // кодировкаToolStripMenuItem
            // 
            this.кодировкаToolStripMenuItem.Name = "кодировкаToolStripMenuItem";
            this.кодировкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.кодировкаToolStripMenuItem.Text = "Кодировка";
            // 
            // textBox_log
            // 
            this.textBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_log.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_log.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_log.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_log.Location = new System.Drawing.Point(0, 350);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(292, 91);
            this.textBox_log.TabIndex = 8;
            // 
            // textBox_attxt
            // 
            this.textBox_attxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_attxt.Location = new System.Drawing.Point(0, 447);
            this.textBox_attxt.Name = "textBox_attxt";
            this.textBox_attxt.Size = new System.Drawing.Size(243, 20);
            this.textBox_attxt.TabIndex = 9;
            // 
            // button_runat
            // 
            this.button_runat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_runat.Location = new System.Drawing.Point(249, 446);
            this.button_runat.Name = "button_runat";
            this.button_runat.Size = new System.Drawing.Size(43, 20);
            this.button_runat.TabIndex = 10;
            this.button_runat.Text = "RUN";
            this.button_runat.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 465);
            this.Controls.Add(this.button_runat);
            this.Controls.Add(this.textBox_attxt);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настроукиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодировкаToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_attxt;
        private System.Windows.Forms.Button button_runat;
    }
}

