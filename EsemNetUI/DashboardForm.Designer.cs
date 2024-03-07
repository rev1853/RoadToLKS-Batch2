namespace EsemNetUI
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPaketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePotonganHargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transaksiCardUserControl6 = new EsemNetUI.TransaksiCardUserControl();
            this.transaksiCardUserControl5 = new EsemNetUI.TransaksiCardUserControl();
            this.transaksiCardUserControl4 = new EsemNetUI.TransaksiCardUserControl();
            this.transaksiCardUserControl3 = new EsemNetUI.TransaksiCardUserControl();
            this.transaksiCardUserControl2 = new EsemNetUI.TransaksiCardUserControl();
            this.transaksiCardUserControl1 = new EsemNetUI.TransaksiCardUserControl();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.menuStrip1.Size = new System.Drawing.Size(300, 734);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(5, 15, 10, 15);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(269, 62);
            this.toolStripMenuItem3.Text = "Dashboard";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterPaketToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.masterMemberToolStripMenuItem,
            this.masterKodePotonganHargaToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(5, 15, 10, 15);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(269, 62);
            this.toolStripMenuItem1.Text = "Master Data";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // masterPaketToolStripMenuItem
            // 
            this.masterPaketToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.masterPaketToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPaketToolStripMenuItem.Name = "masterPaketToolStripMenuItem";
            this.masterPaketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.masterPaketToolStripMenuItem.Size = new System.Drawing.Size(432, 28);
            this.masterPaketToolStripMenuItem.Text = "Master Komputer";
            this.masterPaketToolStripMenuItem.Click += new System.EventHandler(this.masterPaketToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(432, 28);
            this.masterToolStripMenuItem.Text = "Master Paket";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // masterMemberToolStripMenuItem
            // 
            this.masterMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterMemberToolStripMenuItem.Name = "masterMemberToolStripMenuItem";
            this.masterMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.masterMemberToolStripMenuItem.Size = new System.Drawing.Size(432, 28);
            this.masterMemberToolStripMenuItem.Text = "Master Member";
            this.masterMemberToolStripMenuItem.Click += new System.EventHandler(this.masterMemberToolStripMenuItem_Click);
            // 
            // masterKodePotonganHargaToolStripMenuItem
            // 
            this.masterKodePotonganHargaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterKodePotonganHargaToolStripMenuItem.Name = "masterKodePotonganHargaToolStripMenuItem";
            this.masterKodePotonganHargaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.masterKodePotonganHargaToolStripMenuItem.Size = new System.Drawing.Size(432, 28);
            this.masterKodePotonganHargaToolStripMenuItem.Text = "Master Kode Potongan Harga";
            this.masterKodePotonganHargaToolStripMenuItem.Click += new System.EventHandler(this.masterKodePotonganHargaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Padding = new System.Windows.Forms.Padding(5, 15, 10, 15);
            this.toolStripMenuItem4.Size = new System.Drawing.Size(269, 62);
            this.toolStripMenuItem4.Text = "Transaksi";
            this.toolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(5, 15, 10, 15);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 62);
            this.toolStripMenuItem2.Text = "Logout";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selamat Datang John";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1133, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "12 Januari 1993 12:46";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transaksiCardUserControl6);
            this.groupBox1.Controls.Add(this.transaksiCardUserControl5);
            this.groupBox1.Controls.Add(this.transaksiCardUserControl4);
            this.groupBox1.Controls.Add(this.transaksiCardUserControl3);
            this.groupBox1.Controls.Add(this.transaksiCardUserControl2);
            this.groupBox1.Controls.Add(this.transaksiCardUserControl1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(337, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 609);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaksi Hari Ini";
            // 
            // transaksiCardUserControl6
            // 
            this.transaksiCardUserControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.transaksiCardUserControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaksiCardUserControl6.Location = new System.Drawing.Point(520, 546);
            this.transaksiCardUserControl6.Name = "transaksiCardUserControl6";
            this.transaksiCardUserControl6.Size = new System.Drawing.Size(360, 160);
            this.transaksiCardUserControl6.TabIndex = 11;
            // 
            // transaksiCardUserControl5
            // 
            this.transaksiCardUserControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.transaksiCardUserControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaksiCardUserControl5.Location = new System.Drawing.Point(98, 546);
            this.transaksiCardUserControl5.Name = "transaksiCardUserControl5";
            this.transaksiCardUserControl5.Size = new System.Drawing.Size(360, 160);
            this.transaksiCardUserControl5.TabIndex = 10;
            // 
            // transaksiCardUserControl4
            // 
            this.transaksiCardUserControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.transaksiCardUserControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaksiCardUserControl4.Location = new System.Drawing.Point(520, 350);
            this.transaksiCardUserControl4.Name = "transaksiCardUserControl4";
            this.transaksiCardUserControl4.Size = new System.Drawing.Size(360, 160);
            this.transaksiCardUserControl4.TabIndex = 9;
            // 
            // transaksiCardUserControl3
            // 
            this.transaksiCardUserControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.transaksiCardUserControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaksiCardUserControl3.Location = new System.Drawing.Point(98, 350);
            this.transaksiCardUserControl3.Name = "transaksiCardUserControl3";
            this.transaksiCardUserControl3.Size = new System.Drawing.Size(360, 160);
            this.transaksiCardUserControl3.TabIndex = 8;
            // 
            // transaksiCardUserControl2
            // 
            this.transaksiCardUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.transaksiCardUserControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaksiCardUserControl2.Location = new System.Drawing.Point(520, 138);
            this.transaksiCardUserControl2.Name = "transaksiCardUserControl2";
            this.transaksiCardUserControl2.Size = new System.Drawing.Size(360, 160);
            this.transaksiCardUserControl2.TabIndex = 7;
            // 
            // transaksiCardUserControl1
            // 
            this.transaksiCardUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transaksiCardUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.transaksiCardUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaksiCardUserControl1.Location = new System.Drawing.Point(98, 138);
            this.transaksiCardUserControl1.Name = "transaksiCardUserControl1";
            this.transaksiCardUserControl1.Size = new System.Drawing.Size(360, 160);
            this.transaksiCardUserControl1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(715, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tambah Transaksi";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "12 Komputer Terpakai";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1376, 734);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem masterPaketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePotonganHargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private TransaksiCardUserControl transaksiCardUserControl6;
        private TransaksiCardUserControl transaksiCardUserControl5;
        private TransaksiCardUserControl transaksiCardUserControl4;
        private TransaksiCardUserControl transaksiCardUserControl3;
        private TransaksiCardUserControl transaksiCardUserControl2;
        private TransaksiCardUserControl transaksiCardUserControl1;
    }
}