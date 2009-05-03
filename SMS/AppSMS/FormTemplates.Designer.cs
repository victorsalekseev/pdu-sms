namespace AppSMS
{
    partial class FormTemplates
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
            this.tabControl_tmpl = new System.Windows.Forms.TabControl();
            this.tabPage_tobj = new System.Windows.Forms.TabPage();
            this.tabPage_tcmd = new System.Windows.Forms.TabPage();
            this.tabControl_tmpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_tmpl
            // 
            this.tabControl_tmpl.Controls.Add(this.tabPage_tobj);
            this.tabControl_tmpl.Controls.Add(this.tabPage_tcmd);
            this.tabControl_tmpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tmpl.Location = new System.Drawing.Point(0, 0);
            this.tabControl_tmpl.Name = "tabControl_tmpl";
            this.tabControl_tmpl.SelectedIndex = 0;
            this.tabControl_tmpl.Size = new System.Drawing.Size(643, 487);
            this.tabControl_tmpl.TabIndex = 0;
            // 
            // tabPage_tobj
            // 
            this.tabPage_tobj.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tobj.Name = "tabPage_tobj";
            this.tabPage_tobj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tobj.Size = new System.Drawing.Size(635, 461);
            this.tabPage_tobj.TabIndex = 0;
            this.tabPage_tobj.Text = "Шаблоны объектов";
            this.tabPage_tobj.UseVisualStyleBackColor = true;
            // 
            // tabPage_tcmd
            // 
            this.tabPage_tcmd.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tcmd.Name = "tabPage_tcmd";
            this.tabPage_tcmd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tcmd.Size = new System.Drawing.Size(635, 461);
            this.tabPage_tcmd.TabIndex = 1;
            this.tabPage_tcmd.Text = "Шаблоны команд";
            this.tabPage_tcmd.UseVisualStyleBackColor = true;
            // 
            // FormTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 487);
            this.Controls.Add(this.tabControl_tmpl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemplates";
            this.Text = "Шаблоны";
            this.tabControl_tmpl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_tmpl;
        private System.Windows.Forms.TabPage tabPage_tobj;
        private System.Windows.Forms.TabPage tabPage_tcmd;
    }
}