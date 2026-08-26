namespace SHLife
{
    partial class LoginForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acclb = new System.Windows.Forms.Label();
            this.accTb = new System.Windows.Forms.TextBox();
            this.pwtb = new System.Windows.Forms.TextBox();
            this.pwlb = new System.Windows.Forms.Label();
            this.stderr = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SHLife.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // acclb
            // 
            this.acclb.AutoSize = true;
            this.acclb.Location = new System.Drawing.Point(12, 194);
            this.acclb.Name = "acclb";
            this.acclb.Size = new System.Drawing.Size(34, 14);
            this.acclb.TabIndex = 1;
            this.acclb.Text = "帳號:";
            // 
            // accTb
            // 
            this.accTb.Location = new System.Drawing.Point(12, 211);
            this.accTb.Name = "accTb";
            this.accTb.Size = new System.Drawing.Size(250, 20);
            this.accTb.TabIndex = 2;
            // 
            // pwtb
            // 
            this.pwtb.Location = new System.Drawing.Point(12, 271);
            this.pwtb.Name = "pwtb";
            this.pwtb.PasswordChar = '*';
            this.pwtb.Size = new System.Drawing.Size(250, 20);
            this.pwtb.TabIndex = 4;
            // 
            // pwlb
            // 
            this.pwlb.AutoSize = true;
            this.pwlb.Location = new System.Drawing.Point(12, 254);
            this.pwlb.Name = "pwlb";
            this.pwlb.Size = new System.Drawing.Size(34, 14);
            this.pwlb.TabIndex = 3;
            this.pwlb.Text = "密碼:";
            // 
            // stderr
            // 
            this.stderr.AutoSize = true;
            this.stderr.ForeColor = System.Drawing.Color.Red;
            this.stderr.Location = new System.Drawing.Point(9, 309);
            this.stderr.Name = "stderr";
            this.stderr.Size = new System.Drawing.Size(0, 14);
            this.stderr.TabIndex = 5;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(15, 355);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(247, 23);
            this.login.TabIndex = 6;
            this.login.Text = "登入";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(15, 384);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(247, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timelbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 22);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "站台狀態：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(66, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "正常";
            // 
            // timelbl
            // 
            this.timelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(103, 4);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(168, 14);
            this.timelbl.TabIndex = 2;
            this.timelbl.Text = "系統時間：1145-01-04 19:19:08";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.stderr);
            this.Controls.Add(this.pwtb);
            this.Controls.Add(this.pwlb);
            this.Controls.Add(this.accTb);
            this.Controls.Add(this.acclb);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "滬享生活";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label acclb;
        private System.Windows.Forms.TextBox accTb;
        private System.Windows.Forms.TextBox pwtb;
        private System.Windows.Forms.Label pwlb;
        private System.Windows.Forms.Label stderr;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Timer timer1;
    }
}

