namespace 图书管理系统
{
    partial class frmLibraryRecord
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
            this.dgvLibraryRecord = new System.Windows.Forms.DataGridView();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.stuRecord = new System.Windows.Forms.StatusStrip();
            this.作者 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.联系方式 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryRecord)).BeginInit();
            this.stuRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibraryRecord
            // 
            this.dgvLibraryRecord.AllowUserToAddRows = false;
            this.dgvLibraryRecord.AllowUserToDeleteRows = false;
            this.dgvLibraryRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryRecord.Location = new System.Drawing.Point(18, 12);
            this.dgvLibraryRecord.Name = "dgvLibraryRecord";
            this.dgvLibraryRecord.ReadOnly = true;
            this.dgvLibraryRecord.RowTemplate.Height = 23;
            this.dgvLibraryRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibraryRecord.Size = new System.Drawing.Size(441, 294);
            this.dgvLibraryRecord.TabIndex = 18;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(18, 312);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(115, 43);
            this.btnReturnBook.TabIndex = 19;
            this.btnReturnBook.Text = "还书";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(344, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 43);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 312);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 43);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // stuRecord
            // 
            this.stuRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者,
            this.联系方式,
            this.系统时间});
            this.stuRecord.Location = new System.Drawing.Point(0, 376);
            this.stuRecord.Name = "stuRecord";
            this.stuRecord.Size = new System.Drawing.Size(477, 22);
            this.stuRecord.TabIndex = 29;
            // 
            // 作者
            // 
            this.作者.Name = "作者";
            this.作者.Size = new System.Drawing.Size(104, 17);
            this.作者.Text = "作者：网1_蔡剑发";
            // 
            // 系统时间
            // 
            this.系统时间.Name = "系统时间";
            this.系统时间.Size = new System.Drawing.Size(44, 17);
            this.系统时间.Text = "时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 联系方式
            // 
            this.联系方式.Name = "联系方式";
            this.联系方式.Size = new System.Drawing.Size(121, 17);
            this.联系方式.Text = "手机：18850543552";
            // 
            // frmLibraryRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 398);
            this.Controls.Add(this.stuRecord);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.dgvLibraryRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLibraryRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借书记录界面";
            this.Load += new System.EventHandler(this.frmLibraryRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryRecord)).EndInit();
            this.stuRecord.ResumeLayout(false);
            this.stuRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibraryRecord;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip stuRecord;
        private System.Windows.Forms.ToolStripStatusLabel 作者;
        private System.Windows.Forms.ToolStripStatusLabel 系统时间;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel 联系方式;
    }
}