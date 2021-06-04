namespace LibraryManager
{
    partial class Main
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
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.txtbCategory = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbCode = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmlhCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(37, 123);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(144, 26);
            this.txtbSearch.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(200, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtbAmount);
            this.groupBox1.Controls.Add(this.lbAmount);
            this.groupBox1.Controls.Add(this.txtbAuthor);
            this.groupBox1.Controls.Add(this.txtbCategory);
            this.groupBox1.Controls.Add(this.txtbName);
            this.groupBox1.Controls.Add(this.txtbCode);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(286, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // txtbAmount
            // 
            this.txtbAmount.Location = new System.Drawing.Point(121, 183);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(278, 30);
            this.txtbAmount.TabIndex = 9;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(18, 190);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(81, 22);
            this.lbAmount.TabIndex = 8;
            this.lbAmount.Text = "Số lượng";
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(121, 147);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.Size = new System.Drawing.Size(278, 30);
            this.txtbAuthor.TabIndex = 7;
            // 
            // txtbCategory
            // 
            this.txtbCategory.Location = new System.Drawing.Point(121, 111);
            this.txtbCategory.Name = "txtbCategory";
            this.txtbCategory.Size = new System.Drawing.Size(278, 30);
            this.txtbCategory.TabIndex = 6;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(121, 75);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(278, 30);
            this.txtbName.TabIndex = 5;
            // 
            // txtbCode
            // 
            this.txtbCode.Location = new System.Drawing.Point(121, 39);
            this.txtbCode.Name = "txtbCode";
            this.txtbCode.Size = new System.Drawing.Size(278, 30);
            this.txtbCode.TabIndex = 4;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(18, 154);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(75, 22);
            this.lbAuthor.TabIndex = 3;
            this.lbAuthor.Text = "Tác giả:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(18, 118);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(96, 22);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Danh mục:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(18, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 22);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tiêu đề:";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(18, 44);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(85, 22);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Mã Sách:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(732, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 44);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.Location = new System.Drawing.Point(732, 163);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(190, 44);
            this.btnReader.TabIndex = 10;
            this.btnReader.Text = "Quản Lý Độc Giả";
            this.btnReader.UseVisualStyleBackColor = false;
            this.btnReader.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Location = new System.Drawing.Point(732, 228);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(190, 44);
            this.btnReservation.TabIndex = 11;
            this.btnReservation.Text = "Quản Lý Mượn Trả";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(732, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Kết Thúc";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 203);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCode,
            this.clmName,
            this.clmhAuthor,
            this.cmlhCategory,
            this.clmhAmount});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 171);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listView1_ColumnWidthChanged);
            // 
            // clmCode
            // 
            this.clmCode.Text = "Mã sách";
            this.clmCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCode.Width = 104;
            // 
            // clmName
            // 
            this.clmName.Text = "Tiêu đề";
            this.clmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmName.Width = 210;
            // 
            // cmlhCategory
            // 
            this.cmlhCategory.Text = "Danh mục";
            this.cmlhCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmlhCategory.Width = 158;
            // 
            // clmhAmount
            // 
            this.clmhAmount.Text = "Số lượng";
            this.clmhAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmhAmount.Width = 77;
            // 
            // clmhAuthor
            // 
            this.clmhAuthor.Text = "Tác giả";
            this.clmhAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmhAuthor.Width = 126;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Mã Sách",
            "Tiêu Đề",
            "Danh Mục",
            "Tác Giả"});
            this.checkedListBox1.Location = new System.Drawing.Point(79, 180);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(155, 92);
            this.checkedListBox1.TabIndex = 14;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(732, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 44);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Xoá Tất Cả ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(732, 293);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(190, 44);
            this.btnCategory.TabIndex = 16;
            this.btnCategory.Text = "Danh Mục";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Californian FB", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 49);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Thư Viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(944, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.TextBox txtbCategory;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbCode;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clmCode;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader cmlhCategory;
        private System.Windows.Forms.ColumnHeader clmhAmount;
        private System.Windows.Forms.ColumnHeader clmhAuthor;
    }
}

