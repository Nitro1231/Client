namespace Client
{
    partial class main
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
            this.TopBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.max = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.server1 = new Client.FormControls.Server();
            this.TopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            this.SizeChanged += new System.EventHandler(main_SizeChanged);

            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.TopBar.Controls.Add(this.panel1);
            this.TopBar.Controls.Add(this.Title);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(350, 25);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveLocation);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.max);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(271, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 25);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveLocation);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(26, 2);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(23, 20);
            this.max.TabIndex = 3;
            this.max.Text = "▣";
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(47, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 20);
            this.exit.TabIndex = 2;
            this.exit.Text = "✖";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(4, 2);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(22, 20);
            this.min.TabIndex = 1;
            this.min.Text = "∇";
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveLocation);
            // 
            // server1
            // 
            this.server1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.server1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.server1.ForeColor = System.Drawing.Color.White;
            this.server1.Location = new System.Drawing.Point(0, 26);
            this.server1.Name = "server1";
            this.server1.Size = new System.Drawing.Size(350, 525);
            this.server1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.server1);
            this.Controls.Add(this.TopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.main_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Panel panel1;
        private FormControls.Server server1;
    }
}

