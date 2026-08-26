using System.Windows.Forms;

namespace ChildShell
{
    partial class Lock : Form
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.滑 = new System.Windows.Forms.Label();
            this.動 = new System.Windows.Forms.Label();
            this.來 = new System.Windows.Forms.Label();
            this.解 = new System.Windows.Forms.Label();
            this.鎖 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(-2, 229);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(526, 120);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00 : 00 : 00";
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "緊急通話";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(684, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "關機";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(119, 388);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(562, 50);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 滑
            // 
            this.滑.AutoSize = true;
            this.滑.BackColor = System.Drawing.Color.Transparent;
            this.滑.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.滑.ForeColor = System.Drawing.Color.White;
            this.滑.Location = new System.Drawing.Point(12, 349);
            this.滑.Name = "滑";
            this.滑.Size = new System.Drawing.Size(44, 36);
            this.滑.TabIndex = 4;
            this.滑.Text = "滑";
            // 
            // 動
            // 
            this.動.AutoSize = true;
            this.動.BackColor = System.Drawing.Color.Transparent;
            this.動.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.動.ForeColor = System.Drawing.Color.White;
            this.動.Location = new System.Drawing.Point(46, 349);
            this.動.Name = "動";
            this.動.Size = new System.Drawing.Size(44, 36);
            this.動.TabIndex = 5;
            this.動.Text = "動";
            // 
            // 來
            // 
            this.來.AutoSize = true;
            this.來.BackColor = System.Drawing.Color.Transparent;
            this.來.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.來.ForeColor = System.Drawing.Color.White;
            this.來.Location = new System.Drawing.Point(82, 349);
            this.來.Name = "來";
            this.來.Size = new System.Drawing.Size(44, 36);
            this.來.TabIndex = 6;
            this.來.Text = "來";
            // 
            // 解
            // 
            this.解.AutoSize = true;
            this.解.BackColor = System.Drawing.Color.Transparent;
            this.解.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.解.ForeColor = System.Drawing.Color.White;
            this.解.Location = new System.Drawing.Point(118, 349);
            this.解.Name = "解";
            this.解.Size = new System.Drawing.Size(44, 36);
            this.解.TabIndex = 7;
            this.解.Text = "解";
            // 
            // 鎖
            // 
            this.鎖.AutoSize = true;
            this.鎖.BackColor = System.Drawing.Color.Transparent;
            this.鎖.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.鎖.ForeColor = System.Drawing.Color.White;
            this.鎖.Location = new System.Drawing.Point(151, 349);
            this.鎖.Name = "鎖";
            this.鎖.Size = new System.Drawing.Size(44, 36);
            this.鎖.TabIndex = 8;
            this.鎖.Text = "鎖";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(14, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "此電腦似乎沒有安裝 SIM 卡 / 數據機";
            // 
            // Lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.鎖);
            this.Controls.Add(this.解);
            this.Controls.Add(this.來);
            this.Controls.Add(this.動);
            this.Controls.Add(this.滑);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鎖定畫面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lock_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label 滑;
        private System.Windows.Forms.Label 動;
        private System.Windows.Forms.Label 來;
        private System.Windows.Forms.Label 解;
        private System.Windows.Forms.Label 鎖;
        private System.Windows.Forms.Label label2;
    }
}

