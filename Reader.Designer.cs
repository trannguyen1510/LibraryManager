
namespace LibraryManager
{
    partial class Reader
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
            this.grBxReader = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDateBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grBxReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBxReader
            // 
            this.grBxReader.Controls.Add(this.listView1);
            this.grBxReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBxReader.Location = new System.Drawing.Point(12, 228);
            this.grBxReader.Name = "grBxReader";
            this.grBxReader.Size = new System.Drawing.Size(776, 210);
            this.grBxReader.TabIndex = 0;
            this.grBxReader.TabStop = false;
            this.grBxReader.Text = "Danh sách độc giả";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmName,
            this.clmDateBirth,
            this.clmAddress,
            this.clmEmail,
            this.clmDateCreated,
            this.clmCode});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 179);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 38;
            // 
            // clmName
            // 
            this.clmName.Text = "Full Name";
            this.clmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmName.Width = 189;
            // 
            // clmDateBirth
            // 
            this.clmDateBirth.Text = "Date Of Birth";
            this.clmDateBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDateBirth.Width = 113;
            // 
            // clmAddress
            // 
            this.clmAddress.Text = "Address";
            this.clmAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAddress.Width = 142;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmEmail.Width = 78;
            // 
            // clmDateCreated
            // 
            this.clmDateCreated.Text = "Date Created";
            this.clmDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDateCreated.Width = 126;
            // 
            // clmCode
            // 
            this.clmCode.Text = "Code";
            this.clmCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCode.Width = 70;
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grBxReader);
            this.Name = "Reader";
            this.Text = "Reader";
            this.grBxReader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxReader;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmDateBirth;
        private System.Windows.Forms.ColumnHeader clmAddress;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmDateCreated;
        private System.Windows.Forms.ColumnHeader clmCode;
    }
}