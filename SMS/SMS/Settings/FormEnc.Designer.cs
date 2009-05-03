namespace SMS.Settings
{
    partial class FormEnc
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_set_enc = new System.Windows.Forms.Button();
            this.comboBox_encrs = new System.Windows.Forms.ComboBox();
            this.button_refr = new System.Windows.Forms.Button();
            this.label_usechr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Использ. набор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наборы символов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Установить набор";
            // 
            // button_set_enc
            // 
            this.button_set_enc.Location = new System.Drawing.Point(116, 64);
            this.button_set_enc.Name = "button_set_enc";
            this.button_set_enc.Size = new System.Drawing.Size(169, 23);
            this.button_set_enc.TabIndex = 14;
            this.button_set_enc.Text = "OK";
            this.button_set_enc.UseVisualStyleBackColor = true;
            // 
            // comboBox_encrs
            // 
            this.comboBox_encrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_encrs.FormattingEnabled = true;
            this.comboBox_encrs.Location = new System.Drawing.Point(116, 37);
            this.comboBox_encrs.Name = "comboBox_encrs";
            this.comboBox_encrs.Size = new System.Drawing.Size(169, 21);
            this.comboBox_encrs.TabIndex = 15;
            // 
            // button_refr
            // 
            this.button_refr.Location = new System.Drawing.Point(232, 5);
            this.button_refr.Name = "button_refr";
            this.button_refr.Size = new System.Drawing.Size(53, 23);
            this.button_refr.TabIndex = 16;
            this.button_refr.Text = "Обнов.";
            this.button_refr.UseVisualStyleBackColor = true;
            // 
            // label_usechr
            // 
            this.label_usechr.AutoSize = true;
            this.label_usechr.Location = new System.Drawing.Point(113, 10);
            this.label_usechr.Name = "label_usechr";
            this.label_usechr.Size = new System.Drawing.Size(67, 13);
            this.label_usechr.TabIndex = 10;
            this.label_usechr.Text = "label_usechr";
            // 
            // FormEnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 92);
            this.Controls.Add(this.button_refr);
            this.Controls.Add(this.comboBox_encrs);
            this.Controls.Add(this.button_set_enc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_usechr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Набор символов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_set_enc;
        private System.Windows.Forms.ComboBox comboBox_encrs;
        private System.Windows.Forms.Button button_refr;
        private System.Windows.Forms.Label label_usechr;
    }
}