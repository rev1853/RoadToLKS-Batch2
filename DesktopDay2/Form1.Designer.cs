namespace DesktopDay2
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
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label jumlahTerminalLabel;
            System.Windows.Forms.Label kodeIATALabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label negaraLabel;
            this.bandaraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jumlahTerminalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kodeIATATextBox = new System.Windows.Forms.TextBox();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.negaraComboBox = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            alamatLabel = new System.Windows.Forms.Label();
            jumlahTerminalLabel = new System.Windows.Forms.Label();
            kodeIATALabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            negaraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(368, 300);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(52, 16);
            alamatLabel.TabIndex = 1;
            alamatLabel.Text = "Alamat:";
            // 
            // jumlahTerminalLabel
            // 
            jumlahTerminalLabel.AutoSize = true;
            jumlahTerminalLabel.Location = new System.Drawing.Point(368, 325);
            jumlahTerminalLabel.Name = "jumlahTerminalLabel";
            jumlahTerminalLabel.Size = new System.Drawing.Size(109, 16);
            jumlahTerminalLabel.TabIndex = 3;
            jumlahTerminalLabel.Text = "Jumlah Terminal:";
            // 
            // kodeIATALabel
            // 
            kodeIATALabel.AutoSize = true;
            kodeIATALabel.Location = new System.Drawing.Point(368, 356);
            kodeIATALabel.Name = "kodeIATALabel";
            kodeIATALabel.Size = new System.Drawing.Size(75, 16);
            kodeIATALabel.TabIndex = 5;
            kodeIATALabel.Text = "Kode IATA:";
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(368, 384);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(37, 16);
            kotaLabel.TabIndex = 7;
            kotaLabel.Text = "Kota:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(368, 412);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 9;
            namaLabel.Text = "Nama:";
            // 
            // negaraLabel
            // 
            negaraLabel.AutoSize = true;
            negaraLabel.Location = new System.Drawing.Point(368, 445);
            negaraLabel.Name = "negaraLabel";
            negaraLabel.Size = new System.Drawing.Size(56, 16);
            negaraLabel.TabIndex = 11;
            negaraLabel.Text = "Negara:";
            // 
            // bandaraDataGridView
            // 
            this.bandaraDataGridView.AutoGenerateColumns = false;
            this.bandaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandaraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.bandaraDataGridView.DataSource = this.bandaraBindingSource;
            this.bandaraDataGridView.Location = new System.Drawing.Point(12, 12);
            this.bandaraDataGridView.Name = "bandaraDataGridView";
            this.bandaraDataGridView.RowHeadersWidth = 51;
            this.bandaraDataGridView.RowTemplate.Height = 24;
            this.bandaraDataGridView.Size = new System.Drawing.Size(1002, 235);
            this.bandaraDataGridView.TabIndex = 1;
            this.bandaraDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.bandaraDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KodeIATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "KodeIATA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NegaraID";
            this.dataGridViewTextBoxColumn5.HeaderText = "NegaraID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.HeaderText = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "JadwalPenerbangan";
            this.dataGridViewTextBoxColumn8.HeaderText = "JadwalPenerbangan";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "JadwalPenerbangan1";
            this.dataGridViewTextBoxColumn9.HeaderText = "JadwalPenerbangan1";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Negara";
            this.dataGridViewTextBoxColumn10.HeaderText = "Negara";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataSource = typeof(DesktopDay2.Bandara);
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(483, 297);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(120, 22);
            this.alamatTextBox.TabIndex = 2;
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataSource = typeof(DesktopDay2.Bandara);
            // 
            // jumlahTerminalNumericUpDown
            // 
            this.jumlahTerminalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formBindingSource, "JumlahTerminal", true));
            this.jumlahTerminalNumericUpDown.Location = new System.Drawing.Point(483, 325);
            this.jumlahTerminalNumericUpDown.Name = "jumlahTerminalNumericUpDown";
            this.jumlahTerminalNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.jumlahTerminalNumericUpDown.TabIndex = 4;
            // 
            // kodeIATATextBox
            // 
            this.kodeIATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "KodeIATA", true));
            this.kodeIATATextBox.Location = new System.Drawing.Point(483, 353);
            this.kodeIATATextBox.Name = "kodeIATATextBox";
            this.kodeIATATextBox.Size = new System.Drawing.Size(120, 22);
            this.kodeIATATextBox.TabIndex = 6;
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Kota", true));
            this.kotaTextBox.Location = new System.Drawing.Point(483, 381);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(120, 22);
            this.kotaTextBox.TabIndex = 8;
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(483, 409);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(120, 22);
            this.namaTextBox.TabIndex = 10;
            // 
            // negaraComboBox
            // 
            this.negaraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.formBindingSource, "NegaraID", true));
            this.negaraComboBox.DataSource = this.negaraBindingSource;
            this.negaraComboBox.DisplayMember = "Nama";
            this.negaraComboBox.FormattingEnabled = true;
            this.negaraComboBox.Location = new System.Drawing.Point(482, 437);
            this.negaraComboBox.Name = "negaraComboBox";
            this.negaraComboBox.Size = new System.Drawing.Size(121, 24);
            this.negaraComboBox.TabIndex = 12;
            this.negaraComboBox.ValueMember = "ID";
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataSource = typeof(DesktopDay2.Negara);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(negaraLabel);
            this.Controls.Add(this.negaraComboBox);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(jumlahTerminalLabel);
            this.Controls.Add(this.jumlahTerminalNumericUpDown);
            this.Controls.Add(kodeIATALabel);
            this.Controls.Add(this.kodeIATATextBox);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(this.kotaTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.bandaraDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private System.Windows.Forms.DataGridView bandaraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource formBindingSource;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.NumericUpDown jumlahTerminalNumericUpDown;
        private System.Windows.Forms.TextBox kodeIATATextBox;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.ComboBox negaraComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource negaraBindingSource;
    }
}

