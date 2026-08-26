namespace SHLife
{
    partial class MainForm
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
            this.topPbl = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.btmPnl = new System.Windows.Forms.Panel();
            this.timeLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.staticLbl = new System.Windows.Forms.Label();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPbl.SuspendLayout();
            this.btmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPbl
            // 
            this.topPbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.topPbl.Controls.Add(this.minBtn);
            this.topPbl.Controls.Add(this.maxBtn);
            this.topPbl.Controls.Add(this.closeBtn);
            this.topPbl.Controls.Add(this.titleLbl);
            this.topPbl.ForeColor = System.Drawing.Color.White;
            this.topPbl.Location = new System.Drawing.Point(0, 0);
            this.topPbl.Margin = new System.Windows.Forms.Padding(4);
            this.topPbl.Name = "topPbl";
            this.topPbl.Size = new System.Drawing.Size(804, 30);
            this.topPbl.TabIndex = 0;
            this.topPbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseDown);
            this.topPbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseMove);
            this.topPbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(710, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(32, 30);
            this.minBtn.TabIndex = 3;
            this.minBtn.Text = "_";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Location = new System.Drawing.Point(741, 0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(32, 30);
            this.maxBtn.TabIndex = 2;
            this.maxBtn.Text = "口";
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(772, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 30);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "❌";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(218, 8);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(55, 15);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "滬享生活";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseDown);
            this.titleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseMove);
            this.titleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseUp);
            // 
            // btmPnl
            // 
            this.btmPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.btmPnl.Controls.Add(this.timeLbl);
            this.btmPnl.Controls.Add(this.statusLbl);
            this.btmPnl.Controls.Add(this.staticLbl);
            this.btmPnl.ForeColor = System.Drawing.Color.White;
            this.btmPnl.Location = new System.Drawing.Point(0, 535);
            this.btmPnl.Margin = new System.Windows.Forms.Padding(4);
            this.btmPnl.Name = "btmPnl";
            this.btmPnl.Size = new System.Drawing.Size(804, 30);
            this.btmPnl.TabIndex = 1;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(539, 7);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(58, 15);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "系統時間:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(76, 6);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(31, 15);
            this.statusLbl.TabIndex = 1;
            this.statusLbl.Text = "正常";
            // 
            // staticLbl
            // 
            this.staticLbl.AutoSize = true;
            this.staticLbl.Location = new System.Drawing.Point(12, 6);
            this.staticLbl.Name = "staticLbl";
            this.staticLbl.Size = new System.Drawing.Size(58, 15);
            this.staticLbl.TabIndex = 1;
            this.staticLbl.Text = "站台狀態:";
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPnl.Location = new System.Drawing.Point(0, 30);
            this.mainPnl.Margin = new System.Windows.Forms.Padding(4);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(804, 505);
            this.mainPnl.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 565);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.btmPnl);
            this.Controls.Add(this.topPbl);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPbl.ResumeLayout(false);
            this.topPbl.PerformLayout();
            this.btmPnl.ResumeLayout(false);
            this.btmPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPbl;
        private System.Windows.Forms.Panel btmPnl;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label staticLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

