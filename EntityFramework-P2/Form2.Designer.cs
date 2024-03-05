namespace EntityFramework_P2
{
    partial class Form2
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
            System.Windows.Forms.Label negaraIDLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.bandaraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibukotaNegaraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jumlahTerminalTextBox = new System.Windows.Forms.TextBox();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.negaraIDComboBox = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            alamatLabel = new System.Windows.Forms.Label();
            jumlahTerminalLabel = new System.Windows.Forms.Label();
            kodeIATALabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            negaraIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(223, 333);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(52, 16);
            alamatLabel.TabIndex = 2;
            alamatLabel.Text = "Alamat:";
            // 
            // jumlahTerminalLabel
            // 
            jumlahTerminalLabel.AutoSize = true;
            jumlahTerminalLabel.Location = new System.Drawing.Point(223, 361);
            jumlahTerminalLabel.Name = "jumlahTerminalLabel";
            jumlahTerminalLabel.Size = new System.Drawing.Size(109, 16);
            jumlahTerminalLabel.TabIndex = 4;
            jumlahTerminalLabel.Text = "Jumlah Terminal:";
            // 
            // kodeIATALabel
            // 
            kodeIATALabel.AutoSize = true;
            kodeIATALabel.Location = new System.Drawing.Point(223, 389);
            kodeIATALabel.Name = "kodeIATALabel";
            kodeIATALabel.Size = new System.Drawing.Size(75, 16);
            kodeIATALabel.TabIndex = 6;
            kodeIATALabel.Text = "Kode IATA:";
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(223, 417);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(37, 16);
            kotaLabel.TabIndex = 8;
            kotaLabel.Text = "Kota:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(223, 445);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 10;
            namaLabel.Text = "Nama:";
            // 
            // negaraIDLabel
            // 
            negaraIDLabel.AutoSize = true;
            negaraIDLabel.Location = new System.Drawing.Point(223, 473);
            negaraIDLabel.Name = "negaraIDLabel";
            negaraIDLabel.Size = new System.Drawing.Size(56, 16);
            negaraIDLabel.TabIndex = 12;
            negaraIDLabel.Text = "Negara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang, $1";
            // 
            // bandaraDataGridView
            // 
            this.bandaraDataGridView.AllowUserToAddRows = false;
            this.bandaraDataGridView.AllowUserToDeleteRows = false;
            this.bandaraDataGridView.AutoGenerateColumns = false;
            this.bandaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandaraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ibukotaNegaraColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.editButton,
            this.hapusColumn});
            this.bandaraDataGridView.DataSource = this.tabelBindingSource;
            this.bandaraDataGridView.Location = new System.Drawing.Point(23, 55);
            this.bandaraDataGridView.Name = "bandaraDataGridView";
            this.bandaraDataGridView.ReadOnly = true;
            this.bandaraDataGridView.RowHeadersWidth = 51;
            this.bandaraDataGridView.RowTemplate.Height = 24;
            this.bandaraDataGridView.Size = new System.Drawing.Size(972, 266);
            this.bandaraDataGridView.TabIndex = 2;
            this.bandaraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bandaraDataGridView_CellContentClick);
            this.bandaraDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.bandaraDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ibukotaNegaraColumn
            // 
            this.ibukotaNegaraColumn.HeaderText = "Ibukota Negara";
            this.ibukotaNegaraColumn.MinimumWidth = 6;
            this.ibukotaNegaraColumn.Name = "ibukotaNegaraColumn";
            this.ibukotaNegaraColumn.ReadOnly = true;
            this.ibukotaNegaraColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KodeIATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "KodeIATA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NegaraID";
            this.dataGridViewTextBoxColumn5.HeaderText = "NegaraID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.HeaderText = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "JadwalPenerbangan";
            this.dataGridViewTextBoxColumn8.HeaderText = "JadwalPenerbangan";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "JadwalPenerbangan1";
            this.dataGridViewTextBoxColumn9.HeaderText = "JadwalPenerbangan1";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Negara";
            this.dataGridViewTextBoxColumn10.HeaderText = "Negara";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "Ubah";
            this.editButton.MinimumWidth = 6;
            this.editButton.Name = "editButton";
            this.editButton.ReadOnly = true;
            this.editButton.Text = "Ubah";
            this.editButton.UseColumnTextForButtonValue = true;
            this.editButton.Width = 125;
            // 
            // hapusColumn
            // 
            this.hapusColumn.HeaderText = "Hapus";
            this.hapusColumn.MinimumWidth = 6;
            this.hapusColumn.Name = "hapusColumn";
            this.hapusColumn.ReadOnly = true;
            this.hapusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hapusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hapusColumn.Width = 125;
            // 
            // tabelBindingSource
            // 
            this.tabelBindingSource.DataSource = typeof(EntityFramework_P2.Bandara);
            this.tabelBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "Alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(338, 330);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(458, 22);
            this.alamatTextBox.TabIndex = 3;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataSource = typeof(EntityFramework_P2.Bandara);
            // 
            // jumlahTerminalTextBox
            // 
            this.jumlahTerminalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "JumlahTerminal", true));
            this.jumlahTerminalTextBox.Location = new System.Drawing.Point(338, 358);
            this.jumlahTerminalTextBox.Name = "jumlahTerminalTextBox";
            this.jumlahTerminalTextBox.Size = new System.Drawing.Size(458, 22);
            this.jumlahTerminalTextBox.TabIndex = 5;
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "Kota", true));
            this.kotaTextBox.Location = new System.Drawing.Point(338, 414);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(458, 22);
            this.kotaTextBox.TabIndex = 9;
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(338, 442);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(458, 22);
            this.namaTextBox.TabIndex = 11;
            // 
            // negaraIDComboBox
            // 
            this.negaraIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bandaraBindingSource, "NegaraID", true));
            this.negaraIDComboBox.DataSource = this.negaraBindingSource;
            this.negaraIDComboBox.DisplayMember = "Nama";
            this.negaraIDComboBox.FormattingEnabled = true;
            this.negaraIDComboBox.Location = new System.Drawing.Point(338, 470);
            this.negaraIDComboBox.Name = "negaraIDComboBox";
            this.negaraIDComboBox.Size = new System.Drawing.Size(458, 24);
            this.negaraIDComboBox.TabIndex = 13;
            this.negaraIDComboBox.ValueMember = "ID";
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataSource = typeof(EntityFramework_P2.Negara);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "KodeIATA", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(338, 386);
            this.maskedTextBox1.Mask = "???";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(458, 22);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(jumlahTerminalLabel);
            this.Controls.Add(this.jumlahTerminalTextBox);
            this.Controls.Add(kodeIATALabel);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(this.kotaTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(negaraIDLabel);
            this.Controls.Add(this.negaraIDComboBox);
            this.Controls.Add(this.bandaraDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private System.Windows.Forms.DataGridView bandaraDataGridView;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.TextBox jumlahTerminalTextBox;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.ComboBox negaraIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tabelBindingSource;
        private System.Windows.Forms.BindingSource negaraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibukotaNegaraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn hapusColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}