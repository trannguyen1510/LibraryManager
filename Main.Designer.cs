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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabpageHome = new System.Windows.Forms.TabPage();
            this.tabPageBorrow = new System.Windows.Forms.TabPage();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.tabPageExit = new System.Windows.Forms.TabPage();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.clmNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mbtnSearch = new MaterialSkin.Controls.MaterialButton();
            this.mtbSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabpageHome.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabpageHome);
            this.materialTabControl1.Controls.Add(this.tabPageBorrow);
            this.materialTabControl1.Controls.Add(this.tabPageReader);
            this.materialTabControl1.Controls.Add(this.tabPageExit);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1153, 569);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabpageHome
            // 
            this.tabpageHome.Controls.Add(this.materialCard2);
            this.tabpageHome.Controls.Add(this.materialCard1);
            this.tabpageHome.ImageKey = "home_32x.png";
            this.tabpageHome.Location = new System.Drawing.Point(4, 39);
            this.tabpageHome.Name = "tabpageHome";
            this.tabpageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageHome.Size = new System.Drawing.Size(1145, 526);
            this.tabpageHome.TabIndex = 0;
            this.tabpageHome.Text = "Home";
            this.tabpageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageBorrow
            // 
            this.tabPageBorrow.BackColor = System.Drawing.Color.White;
            this.tabPageBorrow.ImageKey = "book_32x.png";
            this.tabPageBorrow.Location = new System.Drawing.Point(4, 39);
            this.tabPageBorrow.Name = "tabPageBorrow";
            this.tabPageBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBorrow.Size = new System.Drawing.Size(1145, 526);
            this.tabPageBorrow.TabIndex = 1;
            this.tabPageBorrow.Text = "Mượn sách";
            // 
            // tabPageReader
            // 
            this.tabPageReader.BackColor = System.Drawing.Color.White;
            this.tabPageReader.ImageKey = "reader_32x.png";
            this.tabPageReader.Location = new System.Drawing.Point(4, 39);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReader.Size = new System.Drawing.Size(1145, 526);
            this.tabPageReader.TabIndex = 2;
            this.tabPageReader.Text = "Độc giả";
            // 
            // tabPageExit
            // 
            this.tabPageExit.BackColor = System.Drawing.Color.White;
            this.tabPageExit.ImageKey = "exit_32x.png";
            this.tabPageExit.Location = new System.Drawing.Point(4, 39);
            this.tabPageExit.Name = "tabPageExit";
            this.tabPageExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExit.Size = new System.Drawing.Size(1145, 526);
            this.tabPageExit.TabIndex = 4;
            this.tabPageExit.Text = "Thoát";
            this.tabPageExit.Click += new System.EventHandler(this.tabPageExit_Click);
            this.tabPageExit.Enter += new System.EventHandler(this.tabPageExit_Enter);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(475, 26);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 9;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mtbSearch);
            this.materialCard1.Controls.Add(this.mbtnSearch);
            this.materialCard1.Controls.Add(this.materialComboBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(173, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(743, 99);
            this.materialCard1.TabIndex = 18;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialListView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(51, 144);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(996, 372);
            this.materialCard2.TabIndex = 19;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNum,
            this.clmID,
            this.clmTitle,
            this.clmAuthor,
            this.clmCategory});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(17, 17);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(962, 338);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // clmNum
            // 
            this.clmNum.Text = "STT";
            // 
            // clmTitle
            // 
            this.clmTitle.Text = "Tiêu đề";
            this.clmTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTitle.Width = 330;
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "Danh mục";
            this.clmCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCategory.Width = 100;
            // 
            // clmAuthor
            // 
            this.clmAuthor.Text = "Tác giả";
            this.clmAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAuthor.Width = 200;
            // 
            // clmID
            // 
            this.clmID.Text = "Mã sách";
            this.clmID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmID.Width = 200;
            // 
            // mbtnSearch
            // 
            this.mbtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSearch.Depth = 0;
            this.mbtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnSearch.HighEmphasis = true;
            this.mbtnSearch.Icon = null;
            this.mbtnSearch.Location = new System.Drawing.Point(630, 39);
            this.mbtnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(86, 36);
            this.mbtnSearch.TabIndex = 10;
            this.mbtnSearch.Text = "Tìm kiếm";
            this.mbtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSearch.UseAccentColor = false;
            this.mbtnSearch.UseVisualStyleBackColor = true;
            this.mbtnSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // mtbSearch
            // 
            this.mtbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbSearch.Depth = 0;
            this.mtbSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSearch.LeadingIcon = null;
            this.mtbSearch.Location = new System.Drawing.Point(37, 27);
            this.mtbSearch.MaxLength = 50;
            this.mtbSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbSearch.Multiline = false;
            this.mtbSearch.Name = "mtbSearch";
            this.mtbSearch.Size = new System.Drawing.Size(406, 50);
            this.mtbSearch.TabIndex = 11;
            this.mtbSearch.Text = "";
            this.mtbSearch.TrailingIcon = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home_32x.png");
            this.imageList1.Images.SetKeyName(1, "book_32x.png");
            this.imageList1.Images.SetKeyName(2, "exit_32x.png");
            this.imageList1.Images.SetKeyName(3, "reader_32x.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1159, 636);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.materialTabControl1.ResumeLayout(false);
            this.tabpageHome.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabpageHome;
        private System.Windows.Forms.TabPage tabPageBorrow;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.TabPage tabPageExit;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.ColumnHeader clmNum;
        private System.Windows.Forms.ColumnHeader clmTitle;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.ColumnHeader clmAuthor;
        private System.Windows.Forms.ColumnHeader clmID;
        private MaterialSkin.Controls.MaterialTextBox mtbSearch;
        private MaterialSkin.Controls.MaterialButton mbtnSearch;
        private System.Windows.Forms.ImageList imageList1;
    }
}

