namespace SHLife.UC
{
    partial class Admin_Word_Tab
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
            this.searcht = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searcht
            // 
            this.searcht.Location = new System.Drawing.Point(153, 35);
            this.searcht.Margin = new System.Windows.Forms.Padding(4);
            this.searcht.Name = "searcht";
            this.searcht.Size = new System.Drawing.Size(342, 21);
            this.searcht.TabIndex = 0;
            this.searcht.Validated += new System.EventHandler(this.Admin_Word_Tab_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "立即篩選:";
            // 
            // resultb
            // 
            this.resultb.Location = new System.Drawing.Point(34, 71);
            this.resultb.Multiline = true;
            this.resultb.Name = "resultb";
            this.resultb.ReadOnly = true;
            this.resultb.Size = new System.Drawing.Size(485, 340);
            this.resultb.TabIndex = 2;
            // 
            // Admin_Word_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searcht);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Word_Tab";
            this.Size = new System.Drawing.Size(562, 441);
            this.Load += new System.EventHandler(this.Admin_Word_Tab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searcht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultb;
    }
}
