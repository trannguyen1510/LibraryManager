namespace LibraryManager
{
    partial class QL_MUON_TRA
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.muon = new System.Windows.Forms.Button();
            this.tra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(391, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 264);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý mượn - trả\r\n\r\n\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // muon
            // 
            this.muon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.muon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muon.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold);
            this.muon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.muon.Location = new System.Drawing.Point(500, 229);
            this.muon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.muon.Name = "muon";
            this.muon.Size = new System.Drawing.Size(136, 83);
            this.muon.TabIndex = 1;
            this.muon.Text = "Mượn";
            this.muon.UseVisualStyleBackColor = false;
            this.muon.Click += new System.EventHandler(this.button1_Click);
            // 
            // tra
            // 
            this.tra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tra.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.tra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.tra.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold);
            this.tra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tra.Location = new System.Drawing.Point(717, 229);
            this.tra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tra.Name = "tra";
            this.tra.Size = new System.Drawing.Size(133, 83);
            this.tra.TabIndex = 2;
            this.tra.Text = "Trả";
            this.tra.UseVisualStyleBackColor = false;
            this.tra.Click += new System.EventHandler(this.tra_Click);
            // 
            // QL_MUON_TRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::LibraryManager.Properties.Resources.logo_uit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1181, 485);
            this.Controls.Add(this.tra);
            this.Controls.Add(this.muon);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QL_MUON_TRA";
            this.Text = "QL_MUON_TRA";
            this.Load += new System.EventHandler(this.QL_MUON_TRA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button muon;
        private System.Windows.Forms.Button tra;
    }
}

