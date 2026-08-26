namespace SHLife
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stp = new System.Windows.Forms.Panel();
            this.timelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Panel();
            this.ml = new System.Windows.Forms.Label();
            this.nl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clf = new System.Windows.Forms.FlowLayoutPanel();
            this.sp = new System.Windows.Forms.Panel();
            this.mt = new System.Windows.Forms.TextBox();
            this.snd = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.mf = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.stp.SuspendLayout();
            this.up.SuspendLayout();
            this.sp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.88425F));
            this.tableLayoutPanel1.Controls.Add(this.mf, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.up, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clf, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sp, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.7671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2329F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stp
            // 
            this.stp.Controls.Add(this.timelbl);
            this.stp.Controls.Add(this.label2);
            this.stp.Controls.Add(this.label1);
            this.stp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stp.Location = new System.Drawing.Point(0, 540);
            this.stp.Name = "stp";
            this.stp.Size = new System.Drawing.Size(933, 22);
            this.stp.TabIndex = 9;
            // 
            // timelbl
            // 
            this.timelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(748, 4);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(182, 15);
            this.timelbl.TabIndex = 2;
            this.timelbl.Text = "系統時間：1145-01-04 19:19:08";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(66, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "正常";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "站台狀態：";
            // 
            // up
            // 
            this.up.Controls.Add(this.button1);
            this.up.Controls.Add(this.nl);
            this.up.Controls.Add(this.ml);
            this.up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.up.Location = new System.Drawing.Point(3, 467);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(219, 71);
            this.up.TabIndex = 1;
            // 
            // ml
            // 
            this.ml.AutoSize = true;
            this.ml.Location = new System.Drawing.Point(9, 20);
            this.ml.Name = "ml";
            this.ml.Size = new System.Drawing.Size(42, 15);
            this.ml.TabIndex = 0;
            this.ml.Text = "a@a.c";
            // 
            // nl
            // 
            this.nl.AutoSize = true;
            this.nl.Location = new System.Drawing.Point(9, 5);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(54, 15);
            this.nl.TabIndex = 1;
            this.nl.Text = "Niugnep";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "登出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clf
            // 
            this.clf.AutoScroll = true;
            this.clf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clf.Location = new System.Drawing.Point(0, 0);
            this.clf.Margin = new System.Windows.Forms.Padding(0);
            this.clf.Name = "clf";
            this.clf.Size = new System.Drawing.Size(225, 464);
            this.clf.TabIndex = 2;
            // 
            // sp
            // 
            this.sp.Controls.Add(this.snd);
            this.sp.Controls.Add(this.mt);
            this.sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp.Location = new System.Drawing.Point(228, 467);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(702, 71);
            this.sp.TabIndex = 4;
            // 
            // mt
            // 
            this.mt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mt.Location = new System.Drawing.Point(0, 0);
            this.mt.Multiline = true;
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(606, 74);
            this.mt.TabIndex = 0;
            // 
            // snd
            // 
            this.snd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snd.Location = new System.Drawing.Point(603, 0);
            this.snd.Name = "snd";
            this.snd.Size = new System.Drawing.Size(99, 71);
            this.snd.TabIndex = 1;
            this.snd.Text = "傳送";
            this.snd.UseVisualStyleBackColor = true;
            this.snd.Click += new System.EventHandler(this.snd_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // mf
            // 
            this.mf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf.Location = new System.Drawing.Point(228, 3);
            this.mf.Name = "mf";
            this.mf.Size = new System.Drawing.Size(702, 458);
            this.mf.TabIndex = 3;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.stp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chat";
            this.Text = "滬享生活-聊天室";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.stp.ResumeLayout(false);
            this.stp.PerformLayout();
            this.up.ResumeLayout(false);
            this.up.PerformLayout();
            this.sp.ResumeLayout(false);
            this.sp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel stp;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel up;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nl;
        private System.Windows.Forms.Label ml;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel clf;
        private System.Windows.Forms.Panel sp;
        private System.Windows.Forms.Button snd;
        private System.Windows.Forms.TextBox mt;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.FlowLayoutPanel mf;
    }
}