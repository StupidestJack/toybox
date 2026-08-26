namespace SHLife
{
    partial class AdminForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.accbtn = new System.Windows.Forms.Button();
            this.checkbtn = new System.Windows.Forms.Button();
            this.wordbtn = new System.Windows.Forms.Button();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.topPbl.SuspendLayout();
            this.btmPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.topPbl.Size = new System.Drawing.Size(777, 30);
            this.topPbl.TabIndex = 0;
            this.topPbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseDown);
            this.topPbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseMove);
            this.topPbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPbl_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(683, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(32, 30);
            this.minBtn.TabIndex = 3;
            this.minBtn.Text = "_";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Location = new System.Drawing.Point(714, 0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(32, 30);
            this.maxBtn.TabIndex = 2;
            this.maxBtn.Text = "口";
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(745, 0);
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
            this.btmPnl.Location = new System.Drawing.Point(0, 499);
            this.btmPnl.Margin = new System.Windows.Forms.Padding(4);
            this.btmPnl.Name = "btmPnl";
            this.btmPnl.Size = new System.Drawing.Size(777, 30);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.accbtn);
            this.splitContainer1.Panel1.Controls.Add(this.checkbtn);
            this.splitContainer1.Panel1.Controls.Add(this.wordbtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainPnl);
            this.splitContainer1.Size = new System.Drawing.Size(777, 477);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 2;
            // 
            // accbtn
            // 
            this.accbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accbtn.Location = new System.Drawing.Point(3, 95);
            this.accbtn.Name = "accbtn";
            this.accbtn.Size = new System.Drawing.Size(193, 36);
            this.accbtn.TabIndex = 2;
            this.accbtn.Text = "違規帳號管理";
            this.accbtn.UseVisualStyleBackColor = true;
            // 
            // checkbtn
            // 
            this.checkbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbtn.Location = new System.Drawing.Point(3, 53);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(193, 36);
            this.checkbtn.TabIndex = 1;
            this.checkbtn.Text = "聊天內容審查";
            this.checkbtn.UseVisualStyleBackColor = true;
            // 
            // wordbtn
            // 
            this.wordbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordbtn.Location = new System.Drawing.Point(3, 11);
            this.wordbtn.Name = "wordbtn";
            this.wordbtn.Size = new System.Drawing.Size(193, 36);
            this.wordbtn.TabIndex = 0;
            this.wordbtn.Text = "敏感字詞瀏覽";
            this.wordbtn.UseVisualStyleBackColor = true;
            this.wordbtn.Click += new System.EventHandler(this.wordbtn_Click);
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPnl.Location = new System.Drawing.Point(4, 4);
            this.mainPnl.Margin = new System.Windows.Forms.Padding(4);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(570, 469);
            this.mainPnl.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 529);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btmPnl);
            this.Controls.Add(this.topPbl);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPbl.ResumeLayout(false);
            this.topPbl.PerformLayout();
            this.btmPnl.ResumeLayout(false);
            this.btmPnl.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPbl;
        private System.Windows.Forms.Panel btmPnl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label staticLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Button accbtn;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Button wordbtn;
    }
}

