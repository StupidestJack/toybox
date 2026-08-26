namespace SHLife.UC
{
    partial class CVR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.會員編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.違規分類 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.關鍵字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.完整訊息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.發送時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.狀態 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.審查 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.會員編號,
            this.違規分類,
            this.關鍵字,
            this.完整訊息,
            this.發送時間,
            this.狀態,
            this.審查,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(31, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 477);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(369, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "審核狀態：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "分類：";
            // 
            // 會員編號
            // 
            this.會員編號.HeaderText = "會員編號";
            this.會員編號.Name = "會員編號";
            // 
            // 違規分類
            // 
            this.違規分類.HeaderText = "違規分類";
            this.違規分類.Name = "違規分類";
            // 
            // 關鍵字
            // 
            this.關鍵字.HeaderText = "關鍵字";
            this.關鍵字.Name = "關鍵字";
            // 
            // 完整訊息
            // 
            this.完整訊息.HeaderText = "完整訊息";
            this.完整訊息.Name = "完整訊息";
            // 
            // 發送時間
            // 
            this.發送時間.HeaderText = "發送時間";
            this.發送時間.Name = "發送時間";
            // 
            // 狀態
            // 
            this.狀態.HeaderText = "狀態";
            this.狀態.Name = "狀態";
            // 
            // 審查
            // 
            this.審查.HeaderText = "審查";
            this.審查.Name = "審查";
            this.審查.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.審查.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CVR";
            this.Size = new System.Drawing.Size(665, 605);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 會員編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 違規分類;
        private System.Windows.Forms.DataGridViewTextBoxColumn 關鍵字;
        private System.Windows.Forms.DataGridViewTextBoxColumn 完整訊息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 發送時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 狀態;
        private System.Windows.Forms.DataGridViewButtonColumn 審查;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
