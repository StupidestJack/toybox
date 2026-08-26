namespace SHLife.UC
{
    partial class Main_Chat
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msgTb = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.mlflp = new System.Windows.Forms.FlowLayoutPanel();
            this.clflp = new System.Windows.Forms.FlowLayoutPanel();
            this.userpnl = new System.Windows.Forms.Panel();
            this.loutbtn = new System.Windows.Forms.Button();
            this.maillbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.userpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0995F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlflp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clflp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userpnl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.78218F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.21782F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(163, 416);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msgTb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sendBtn);
            this.splitContainer1.Size = new System.Drawing.Size(638, 86);
            this.splitContainer1.SplitterDistance = 524;
            this.splitContainer1.TabIndex = 3;
            // 
            // msgTb
            // 
            this.msgTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgTb.Location = new System.Drawing.Point(0, 0);
            this.msgTb.Multiline = true;
            this.msgTb.Name = "msgTb";
            this.msgTb.Size = new System.Drawing.Size(524, 86);
            this.msgTb.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendBtn.Location = new System.Drawing.Point(0, 0);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(110, 86);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "傳送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mlflp
            // 
            this.mlflp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlflp.Location = new System.Drawing.Point(163, 3);
            this.mlflp.Name = "mlflp";
            this.mlflp.Size = new System.Drawing.Size(638, 407);
            this.mlflp.TabIndex = 1;
            // 
            // clflp
            // 
            this.clflp.AutoScroll = true;
            this.clflp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clflp.Location = new System.Drawing.Point(3, 3);
            this.clflp.Name = "clflp";
            this.clflp.Size = new System.Drawing.Size(154, 407);
            this.clflp.TabIndex = 0;
            // 
            // userpnl
            // 
            this.userpnl.Controls.Add(this.loutbtn);
            this.userpnl.Controls.Add(this.maillbl);
            this.userpnl.Controls.Add(this.namelbl);
            this.userpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userpnl.Location = new System.Drawing.Point(3, 416);
            this.userpnl.Name = "userpnl";
            this.userpnl.Size = new System.Drawing.Size(154, 86);
            this.userpnl.TabIndex = 4;
            // 
            // loutbtn
            // 
            this.loutbtn.Location = new System.Drawing.Point(2, 35);
            this.loutbtn.Name = "loutbtn";
            this.loutbtn.Size = new System.Drawing.Size(75, 23);
            this.loutbtn.TabIndex = 2;
            this.loutbtn.Text = "登出";
            this.loutbtn.UseVisualStyleBackColor = true;
            this.loutbtn.Click += new System.EventHandler(this.loutbtn_Click);
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Location = new System.Drawing.Point(5, 17);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(92, 15);
            this.maillbl.TabIndex = 1;
            this.maillbl.Text = "winnie@xjp.gov";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(5, 2);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(81, 15);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "孤獨的維尼64";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Chat";
            this.Size = new System.Drawing.Size(804, 505);
            this.Load += new System.EventHandler(this.Main_Chat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.userpnl.ResumeLayout(false);
            this.userpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel mlflp;
        private System.Windows.Forms.FlowLayoutPanel clflp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel userpnl;
        private System.Windows.Forms.Button loutbtn;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox msgTb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
