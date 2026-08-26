namespace SHLife.UC
{
    partial class Main_Login
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
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.accLbl = new System.Windows.Forms.Label();
            this.accTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.stderr = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.exitbtm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPb
            // 
            this.logoPb.Image = global::SHLife.Properties.Resources.Logo;
            this.logoPb.Location = new System.Drawing.Point(352, 73);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(115, 117);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPb.TabIndex = 0;
            this.logoPb.TabStop = false;
            // 
            // accLbl
            // 
            this.accLbl.AutoSize = true;
            this.accLbl.Location = new System.Drawing.Point(313, 201);
            this.accLbl.Name = "accLbl";
            this.accLbl.Size = new System.Drawing.Size(34, 15);
            this.accLbl.TabIndex = 1;
            this.accLbl.Text = "帳號:";
            // 
            // accTb
            // 
            this.accTb.Location = new System.Drawing.Point(316, 219);
            this.accTb.Name = "accTb";
            this.accTb.Size = new System.Drawing.Size(173, 21);
            this.accTb.TabIndex = 2;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(316, 270);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '●';
            this.passTb.Size = new System.Drawing.Size(173, 21);
            this.passTb.TabIndex = 4;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(313, 252);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(34, 15);
            this.passLbl.TabIndex = 3;
            this.passLbl.Text = "密碼:";
            // 
            // stderr
            // 
            this.stderr.AutoSize = true;
            this.stderr.ForeColor = System.Drawing.Color.Red;
            this.stderr.Location = new System.Drawing.Point(313, 313);
            this.stderr.Name = "stderr";
            this.stderr.Size = new System.Drawing.Size(183, 15);
            this.stderr.TabIndex = 5;
            this.stderr.Text = "(任何登入失敗的訊息皆顯示於此)";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(316, 340);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(173, 23);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "登入";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // exitbtm
            // 
            this.exitbtm.Location = new System.Drawing.Point(316, 369);
            this.exitbtm.Name = "exitbtm";
            this.exitbtm.Size = new System.Drawing.Size(173, 23);
            this.exitbtm.TabIndex = 7;
            this.exitbtm.Text = "退出";
            this.exitbtm.UseVisualStyleBackColor = true;
            this.exitbtm.Click += new System.EventHandler(this.exitbtm_Click);
            // 
            // Main_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitbtm);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.stderr);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.accTb);
            this.Controls.Add(this.accLbl);
            this.Controls.Add(this.logoPb);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Login";
            this.Size = new System.Drawing.Size(804, 505);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Label accLbl;
        private System.Windows.Forms.TextBox accTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label stderr;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button exitbtm;
    }
}
