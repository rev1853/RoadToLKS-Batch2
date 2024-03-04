namespace CRUDEF
{
    partial class Form3
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
            System.Windows.Forms.Label hargaLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label stokLabel;
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.stokTextBox = new System.Windows.Forms.TextBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            hargaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            stokLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(236, 71);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(48, 16);
            hargaLabel.TabIndex = 1;
            hargaLabel.Text = "Harga:";
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Harga", true));
            this.hargaTextBox.Location = new System.Drawing.Point(290, 68);
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(100, 22);
            this.hargaTextBox.TabIndex = 2;
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(236, 99);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 3;
            namaLabel.Text = "Nama:";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(290, 96);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(100, 22);
            this.namaTextBox.TabIndex = 4;
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new System.Drawing.Point(236, 127);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new System.Drawing.Size(37, 16);
            stokLabel.TabIndex = 5;
            stokLabel.Text = "Stok:";
            // 
            // stokTextBox
            // 
            this.stokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Stok", true));
            this.stokTextBox.Location = new System.Drawing.Point(290, 124);
            this.stokTextBox.Name = "stokTextBox";
            this.stokTextBox.Size = new System.Drawing.Size(100, 22);
            this.stokTextBox.TabIndex = 6;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataSource = typeof(CRUDEF.Barang);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(hargaLabel);
            this.Controls.Add(this.hargaTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(stokLabel);
            this.Controls.Add(this.stokTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource barangBindingSource;
        private System.Windows.Forms.TextBox hargaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox stokTextBox;
    }
}