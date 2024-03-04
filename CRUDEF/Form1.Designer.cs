namespace CRUDEF
{
    partial class Form1
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
            this.barangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.stokTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            hargaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            stokLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(274, 271);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(48, 16);
            hargaLabel.TabIndex = 1;
            hargaLabel.Text = "Harga:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(274, 299);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 3;
            namaLabel.Text = "Nama:";
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new System.Drawing.Point(274, 327);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new System.Drawing.Size(37, 16);
            stokLabel.TabIndex = 5;
            stokLabel.Text = "Stok:";
            // 
            // barangDataGridView
            // 
            this.barangDataGridView.AutoGenerateColumns = false;
            this.barangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.barangDataGridView.DataSource = this.barangBindingSource;
            this.barangDataGridView.Location = new System.Drawing.Point(100, 26);
            this.barangDataGridView.Name = "barangDataGridView";
            this.barangDataGridView.RowHeadersWidth = 51;
            this.barangDataGridView.RowTemplate.Height = 24;
            this.barangDataGridView.Size = new System.Drawing.Size(622, 220);
            this.barangDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Harga";
            this.dataGridViewTextBoxColumn3.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stok";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stok";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataSource = typeof(CRUDEF.Barang);
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Harga", true));
            this.hargaTextBox.Location = new System.Drawing.Point(328, 268);
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(205, 22);
            this.hargaTextBox.TabIndex = 2;
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataSource = typeof(CRUDEF.Barang);
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(328, 296);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(205, 22);
            this.namaTextBox.TabIndex = 4;
            // 
            // stokTextBox
            // 
            this.stokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Stok", true));
            this.stokTextBox.Location = new System.Drawing.Point(328, 324);
            this.stokTextBox.Name = "stokTextBox";
            this.stokTextBox.Size = new System.Drawing.Size(205, 22);
            this.stokTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(437, 435);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(285, 22);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 517);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(hargaLabel);
            this.Controls.Add(this.hargaTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(stokLabel);
            this.Controls.Add(this.stokTextBox);
            this.Controls.Add(this.barangDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource barangBindingSource;
        private System.Windows.Forms.DataGridView barangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox hargaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox stokTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource formBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

