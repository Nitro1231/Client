namespace Client.FormControls
{
    partial class Server
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IP_A = new System.Windows.Forms.Panel();
            this.IP_B = new System.Windows.Forms.Panel();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Port_B = new System.Windows.Forms.Panel();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.Port_A = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IP_B.SuspendLayout();
            this.Port_B.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            this.SizeChanged += new System.EventHandler(Server_SizeChanged);
            // 
            // IP_A
            // 
            this.IP_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.IP_A.Location = new System.Drawing.Point(0, 25);
            this.IP_A.Name = "IP_A";
            this.IP_A.Size = new System.Drawing.Size(280, 40);
            this.IP_A.TabIndex = 0;
            // 
            // IP_B
            // 
            this.IP_B.Controls.Add(this.IP_textBox);
            this.IP_B.Location = new System.Drawing.Point(3, 25);
            this.IP_B.Name = "IP_B";
            this.IP_B.Size = new System.Drawing.Size(274, 36);
            this.IP_B.TabIndex = 1;
            // 
            // IP_textBox
            // 
            this.IP_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.IP_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP_textBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_textBox.ForeColor = System.Drawing.Color.White;
            this.IP_textBox.Location = new System.Drawing.Point(4, 6);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(266, 26);
            this.IP_textBox.TabIndex = 2;
            this.IP_textBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP:";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.White;
            this.Connect.Location = new System.Drawing.Point(0, 194);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(280, 41);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server Port:";
            // 
            // Port_B
            // 
            this.Port_B.Controls.Add(this.Port_textBox);
            this.Port_B.Location = new System.Drawing.Point(3, 108);
            this.Port_B.Name = "Port_B";
            this.Port_B.Size = new System.Drawing.Size(274, 36);
            this.Port_B.TabIndex = 8;
            // 
            // Port_textBox
            // 
            this.Port_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Port_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Port_textBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_textBox.ForeColor = System.Drawing.Color.White;
            this.Port_textBox.Location = new System.Drawing.Point(4, 6);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(266, 26);
            this.Port_textBox.TabIndex = 2;
            this.Port_textBox.Text = "5555";
            // 
            // Port_A
            // 
            this.Port_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Port_A.Location = new System.Drawing.Point(0, 108);
            this.Port_A.Name = "Port_A";
            this.Port_A.Size = new System.Drawing.Size(280, 40);
            this.Port_A.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IP_B);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IP_A);
            this.panel1.Controls.Add(this.Port_B);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Port_A);
            this.panel1.Location = new System.Drawing.Point(35, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 238);
            this.panel1.TabIndex = 10;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Server";
            this.Size = new System.Drawing.Size(350, 525);
            this.Load += new System.EventHandler(this.Server_Load);
            this.IP_B.ResumeLayout(false);
            this.IP_B.PerformLayout();
            this.Port_B.ResumeLayout(false);
            this.Port_B.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel IP_A;
        private System.Windows.Forms.Panel IP_B;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Port_B;
        private System.Windows.Forms.TextBox Port_textBox;
        private System.Windows.Forms.Panel Port_A;
        private System.Windows.Forms.Panel panel1;
    }
}
