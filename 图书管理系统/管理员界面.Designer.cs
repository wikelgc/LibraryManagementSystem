namespace 图书管理系统
{
    partial class frmAdmin
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
            this.lblKind = new System.Windows.Forms.Label();
            this.cmbKind = new System.Windows.Forms.ComboBox();
            this.btnSearchByKind = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.txtBookKind = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.stuAdmin = new System.Windows.Forms.StatusStrip();
            this.作者 = new System.Windows.Forms.ToolStripStatusLabel();
            this.班级 = new System.Windows.Forms.ToolStripStatusLabel();
            this.学号 = new System.Windows.Forms.ToolStripStatusLabel();
            this.联系方式 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.stuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(427, 26);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(65, 12);
            this.lblKind.TabIndex = 0;
            this.lblKind.Text = "书籍类别：";
            // 
            // cmbKind
            // 
            this.cmbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKind.FormattingEnabled = true;
            this.cmbKind.Location = new System.Drawing.Point(498, 23);
            this.cmbKind.Name = "cmbKind";
            this.cmbKind.Size = new System.Drawing.Size(93, 20);
            this.cmbKind.TabIndex = 3;
            // 
            // btnSearchByKind
            // 
            this.btnSearchByKind.Location = new System.Drawing.Point(599, 23);
            this.btnSearchByKind.Name = "btnSearchByKind";
            this.btnSearchByKind.Size = new System.Drawing.Size(63, 20);
            this.btnSearchByKind.TabIndex = 4;
            this.btnSearchByKind.Text = "按类查找";
            this.btnSearchByKind.UseVisualStyleBackColor = true;
            this.btnSearchByKind.Click += new System.EventHandler(this.btnSearchByKind_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(20, 56);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowTemplate.Height = 23;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(642, 167);
            this.dgvBooks.TabIndex = 5;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(20, 449);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 32);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "新增书目";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(562, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 21);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除书目";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 21);
            this.txtName.TabIndex = 8;
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(18, 25);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(65, 12);
            this.lblBookNameForSearch.TabIndex = 9;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(356, 22);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(65, 21);
            this.btnSearchBook.TabIndex = 10;
            this.btnSearchBook.Text = "查找";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(20, 245);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(642, 129);
            this.txtContent.TabIndex = 11;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(562, 379);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(100, 21);
            this.btnAlter.TabIndex = 12;
            this.btnAlter.Text = "修改书目";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(17, 226);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(88, 16);
            this.lblContent.TabIndex = 13;
            this.lblContent.Text = "内容摘要：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(18, 383);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(41, 12);
            this.lblBookName.TabIndex = 14;
            this.lblBookName.Text = "书名：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(18, 410);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 12);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.Text = "作者：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(171, 383);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(65, 12);
            this.lblBookKind.TabIndex = 16;
            this.lblBookKind.Text = "图书类别：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(171, 410);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 12);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "出版时间：";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(348, 383);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(53, 12);
            this.lblPress.TabIndex = 18;
            this.lblPress.Text = "出版社：";
            // 
            // txtBookKind
            // 
            this.txtBookKind.Location = new System.Drawing.Point(242, 380);
            this.txtBookKind.Name = "txtBookKind";
            this.txtBookKind.Size = new System.Drawing.Size(100, 21);
            this.txtBookKind.TabIndex = 19;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(407, 380);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(100, 21);
            this.txtPress.TabIndex = 20;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(242, 407);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 21;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(65, 407);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtAuthor.TabIndex = 22;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(65, 381);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 21);
            this.txtBookName.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(407, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 21);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(562, 449);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 32);
            this.btnQuery.TabIndex = 25;
            this.btnQuery.Text = "查看借书记录";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(291, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 32);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // stuAdmin
            // 
            this.stuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者,
            this.班级,
            this.学号,
            this.联系方式,
            this.系统时间});
            this.stuAdmin.Location = new System.Drawing.Point(0, 502);
            this.stuAdmin.Name = "stuAdmin";
            this.stuAdmin.Size = new System.Drawing.Size(683, 22);
            this.stuAdmin.TabIndex = 27;
            // 
            // 作者
            // 
            this.作者.Name = "作者";
            this.作者.Size = new System.Drawing.Size(80, 17);
            this.作者.Text = "作者：蔡剑发";
            // 
            // 班级
            // 
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(142, 17);
            this.班级.Text = "班级：11级_网络工程1班";
            // 
            // 学号
            // 
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(114, 17);
            this.学号.Text = "学号：1125114001";
            // 
            // 联系方式
            // 
            this.联系方式.Name = "联系方式";
            this.联系方式.Size = new System.Drawing.Size(145, 17);
            this.联系方式.Text = "手机号码：18850543552";
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
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 524);
            this.Controls.Add(this.stuAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.txtBookKind);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBookKind);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblBookNameForSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearchByKind);
            this.Controls.Add(this.cmbKind);
            this.Controls.Add(this.lblKind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.stuAdmin.ResumeLayout(false);
            this.stuAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox cmbKind;
        private System.Windows.Forms.Button btnSearchByKind;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.TextBox txtBookKind;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip stuAdmin;
        private System.Windows.Forms.ToolStripStatusLabel 作者;
        private System.Windows.Forms.ToolStripStatusLabel 班级;
        private System.Windows.Forms.ToolStripStatusLabel 学号;
        private System.Windows.Forms.ToolStripStatusLabel 联系方式;
        private System.Windows.Forms.ToolStripStatusLabel 系统时间;
        private System.Windows.Forms.Timer timer1;
    }
}