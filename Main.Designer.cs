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
            this.materialCardHome2 = new MaterialSkin.Controls.MaterialCard();
            this.materialHomeListView = new MaterialSkin.Controls.MaterialListView();
            this.clmHomeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCardHome1 = new MaterialSkin.Controls.MaterialCard();
            this.mtbHomeSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.mbtnHomeSearch = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPageBorrow = new System.Windows.Forms.TabPage();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.tabPageExit = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCardReader = new MaterialSkin.Controls.MaterialCard();
            this.materialReaderListView = new MaterialSkin.Controls.MaterialListView();
            this.clmReaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmReaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmReaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmReaderDateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmReaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmReaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tabpageHome.SuspendLayout();
            this.materialCardHome2.SuspendLayout();
            this.materialCardHome1.SuspendLayout();
            this.tabPageReader.SuspendLayout();
            this.materialCardReader.SuspendLayout();
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
            this.tabpageHome.Controls.Add(this.materialCardHome2);
            this.tabpageHome.Controls.Add(this.materialCardHome1);
            this.tabpageHome.ImageKey = "home_32x.png";
            this.tabpageHome.Location = new System.Drawing.Point(4, 39);
            this.tabpageHome.Name = "tabpageHome";
            this.tabpageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageHome.Size = new System.Drawing.Size(1145, 526);
            this.tabpageHome.TabIndex = 0;
            this.tabpageHome.Text = "Home";
            this.tabpageHome.UseVisualStyleBackColor = true;
            // 
            // materialCardHome2
            // 
            this.materialCardHome2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHome2.Controls.Add(this.materialHomeListView);
            this.materialCardHome2.Depth = 0;
            this.materialCardHome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHome2.Location = new System.Drawing.Point(51, 144);
            this.materialCardHome2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHome2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHome2.Name = "materialCardHome2";
            this.materialCardHome2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHome2.Size = new System.Drawing.Size(996, 372);
            this.materialCardHome2.TabIndex = 19;
            // 
            // materialHomeListView
            // 
            this.materialHomeListView.AutoSizeTable = false;
            this.materialHomeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialHomeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialHomeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHomeIndex,
            this.clmHomeID,
            this.clmHomeTitle,
            this.clmHomeAuthor,
            this.clmHomeCategory});
            this.materialHomeListView.Depth = 0;
            this.materialHomeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialHomeListView.FullRowSelect = true;
            this.materialHomeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialHomeListView.HideSelection = false;
            this.materialHomeListView.Location = new System.Drawing.Point(17, 17);
            this.materialHomeListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialHomeListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialHomeListView.MouseState = MaterialSkin.MouseState.OUT;
            this.materialHomeListView.Name = "materialHomeListView";
            this.materialHomeListView.OwnerDraw = true;
            this.materialHomeListView.Size = new System.Drawing.Size(962, 338);
            this.materialHomeListView.TabIndex = 0;
            this.materialHomeListView.UseCompatibleStateImageBehavior = false;
            this.materialHomeListView.View = System.Windows.Forms.View.Details;
            // 
            // clmHomeIndex
            // 
            this.clmHomeIndex.Text = "STT";
            // 
            // clmHomeID
            // 
            this.clmHomeID.Text = "Mã sách";
            this.clmHomeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeID.Width = 200;
            // 
            // clmHomeTitle
            // 
            this.clmHomeTitle.Text = "Tiêu đề";
            this.clmHomeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeTitle.Width = 330;
            // 
            // clmHomeAuthor
            // 
            this.clmHomeAuthor.Text = "Tác giả";
            this.clmHomeAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeAuthor.Width = 200;
            // 
            // clmHomeCategory
            // 
            this.clmHomeCategory.Text = "Danh mục";
            this.clmHomeCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeCategory.Width = 100;
            // 
            // materialCardHome1
            // 
            this.materialCardHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHome1.Controls.Add(this.mtbHomeSearch);
            this.materialCardHome1.Controls.Add(this.mbtnHomeSearch);
            this.materialCardHome1.Controls.Add(this.materialComboBoxCategory);
            this.materialCardHome1.Depth = 0;
            this.materialCardHome1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHome1.Location = new System.Drawing.Point(173, 17);
            this.materialCardHome1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHome1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHome1.Name = "materialCardHome1";
            this.materialCardHome1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHome1.Size = new System.Drawing.Size(743, 99);
            this.materialCardHome1.TabIndex = 18;
            // 
            // mtbHomeSearch
            // 
            this.mtbHomeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbHomeSearch.Depth = 0;
            this.mtbHomeSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbHomeSearch.LeadingIcon = null;
            this.mtbHomeSearch.Location = new System.Drawing.Point(37, 27);
            this.mtbHomeSearch.MaxLength = 50;
            this.mtbHomeSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbHomeSearch.Multiline = false;
            this.mtbHomeSearch.Name = "mtbHomeSearch";
            this.mtbHomeSearch.Size = new System.Drawing.Size(406, 50);
            this.mtbHomeSearch.TabIndex = 11;
            this.mtbHomeSearch.Text = "";
            this.mtbHomeSearch.TrailingIcon = null;
            // 
            // mbtnHomeSearch
            // 
            this.mbtnHomeSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnHomeSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnHomeSearch.Depth = 0;
            this.mbtnHomeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnHomeSearch.HighEmphasis = true;
            this.mbtnHomeSearch.Icon = null;
            this.mbtnHomeSearch.Location = new System.Drawing.Point(630, 39);
            this.mbtnHomeSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnHomeSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnHomeSearch.Name = "mbtnHomeSearch";
            this.mbtnHomeSearch.Size = new System.Drawing.Size(86, 36);
            this.mbtnHomeSearch.TabIndex = 10;
            this.mbtnHomeSearch.Text = "Tìm kiếm";
            this.mbtnHomeSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnHomeSearch.UseAccentColor = false;
            this.mbtnHomeSearch.UseVisualStyleBackColor = true;
            this.mbtnHomeSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // materialComboBoxCategory
            // 
            this.materialComboBoxCategory.AutoResize = false;
            this.materialComboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxCategory.Depth = 0;
            this.materialComboBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxCategory.DropDownHeight = 174;
            this.materialComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxCategory.DropDownWidth = 121;
            this.materialComboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxCategory.FormattingEnabled = true;
            this.materialComboBoxCategory.IntegralHeight = false;
            this.materialComboBoxCategory.ItemHeight = 43;
            this.materialComboBoxCategory.Location = new System.Drawing.Point(475, 26);
            this.materialComboBoxCategory.MaxDropDownItems = 4;
            this.materialComboBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCategory.Name = "materialComboBoxCategory";
            this.materialComboBoxCategory.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxCategory.StartIndex = 0;
            this.materialComboBoxCategory.TabIndex = 9;
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
            this.tabPageReader.Controls.Add(this.materialCardReader);
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
            this.tabPageExit.Enter += new System.EventHandler(this.tabPageExit_Enter);
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
            // materialCardReader
            // 
            this.materialCardReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardReader.Controls.Add(this.materialReaderListView);
            this.materialCardReader.Depth = 0;
            this.materialCardReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardReader.Location = new System.Drawing.Point(51, 144);
            this.materialCardReader.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardReader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardReader.Name = "materialCardReader";
            this.materialCardReader.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardReader.Size = new System.Drawing.Size(996, 372);
            this.materialCardReader.TabIndex = 0;
            // 
            // materialReaderListView
            // 
            this.materialReaderListView.AutoSizeTable = false;
            this.materialReaderListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialReaderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialReaderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmReaderIndex,
            this.clmReaderID,
            this.clmReaderName,
            this.clmReaderDateOfBirth,
            this.clmReaderAddress,
            this.clmReaderEmail,
            this.clmDateCreated});
            this.materialReaderListView.Depth = 0;
            this.materialReaderListView.FullRowSelect = true;
            this.materialReaderListView.HideSelection = false;
            this.materialReaderListView.Location = new System.Drawing.Point(17, 17);
            this.materialReaderListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialReaderListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialReaderListView.MouseState = MaterialSkin.MouseState.OUT;
            this.materialReaderListView.Name = "materialReaderListView";
            this.materialReaderListView.OwnerDraw = true;
            this.materialReaderListView.Size = new System.Drawing.Size(962, 338);
            this.materialReaderListView.TabIndex = 0;
            this.materialReaderListView.UseCompatibleStateImageBehavior = false;
            this.materialReaderListView.View = System.Windows.Forms.View.Details;
            // 
            // clmReaderIndex
            // 
            this.clmReaderIndex.Text = "STT";
            // 
            // clmReaderID
            // 
            this.clmReaderID.Text = "Mã sinh viên";
            this.clmReaderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmReaderID.Width = 150;
            // 
            // clmReaderName
            // 
            this.clmReaderName.Text = "Họ và tên";
            this.clmReaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmReaderName.Width = 250;
            // 
            // clmReaderDateOfBirth
            // 
            this.clmReaderDateOfBirth.Text = "Ngày sinh";
            this.clmReaderDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmReaderDateOfBirth.Width = 100;
            // 
            // clmReaderAddress
            // 
            this.clmReaderAddress.Text = "Địa chỉ";
            this.clmReaderAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmReaderAddress.Width = 170;
            // 
            // clmReaderEmail
            // 
            this.clmReaderEmail.Text = "Email";
            this.clmReaderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmReaderEmail.Width = 120;
            // 
            // clmDateCreated
            // 
            this.clmDateCreated.Text = "Ngày tạo";
            this.clmDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDateCreated.Width = 100;
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
            this.materialCardHome2.ResumeLayout(false);
            this.materialCardHome1.ResumeLayout(false);
            this.materialCardHome1.PerformLayout();
            this.tabPageReader.ResumeLayout(false);
            this.materialCardReader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabpageHome;
        private System.Windows.Forms.TabPage tabPageBorrow;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.TabPage tabPageExit;
        private MaterialSkin.Controls.MaterialCard materialCardHome2;
        private MaterialSkin.Controls.MaterialListView materialHomeListView;
        private MaterialSkin.Controls.MaterialCard materialCardHome1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCategory;
        private System.Windows.Forms.ColumnHeader clmHomeIndex;
        private System.Windows.Forms.ColumnHeader clmHomeTitle;
        private System.Windows.Forms.ColumnHeader clmHomeCategory;
        private System.Windows.Forms.ColumnHeader clmHomeAuthor;
        private System.Windows.Forms.ColumnHeader clmHomeID;
        private MaterialSkin.Controls.MaterialTextBox mtbHomeSearch;
        private MaterialSkin.Controls.MaterialButton mbtnHomeSearch;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCardReader;
        private MaterialSkin.Controls.MaterialListView materialReaderListView;
        private System.Windows.Forms.ColumnHeader clmReaderIndex;
        private System.Windows.Forms.ColumnHeader clmReaderID;
        private System.Windows.Forms.ColumnHeader clmReaderName;
        private System.Windows.Forms.ColumnHeader clmReaderDateOfBirth;
        private System.Windows.Forms.ColumnHeader clmReaderAddress;
        private System.Windows.Forms.ColumnHeader clmReaderEmail;
        private System.Windows.Forms.ColumnHeader clmDateCreated;
    }
}

