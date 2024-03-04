namespace EsemkaPolling
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
            this.pollOptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.jumlahSuaraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSuaraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opsiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pollOptionsDataGridView
            // 
            this.pollOptionsDataGridView.AllowUserToAddRows = false;
            this.pollOptionsDataGridView.AllowUserToDeleteRows = false;
            this.pollOptionsDataGridView.AutoGenerateColumns = false;
            this.pollOptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pollOptionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.pollingColumn,
            this.opsiColumn,
            this.dataGridViewTextBoxColumn5,
            this.jumlahSuaraColumn,
            this.totalSuaraColumn});
            this.pollOptionsDataGridView.DataSource = this.pollOptionsBindingSource;
            this.pollOptionsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.pollOptionsDataGridView.Name = "pollOptionsDataGridView";
            this.pollOptionsDataGridView.ReadOnly = true;
            this.pollOptionsDataGridView.RowHeadersWidth = 51;
            this.pollOptionsDataGridView.RowTemplate.Height = 24;
            this.pollOptionsDataGridView.Size = new System.Drawing.Size(1025, 220);
            this.pollOptionsDataGridView.TabIndex = 1;
            this.pollOptionsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pollOptionsDataGridView_CellFormatting);
            this.pollOptionsDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.pollOptionsDataGridView_CellPainting);
            // 
            // jumlahSuaraColumn
            // 
            this.jumlahSuaraColumn.HeaderText = "Jumlah Suara";
            this.jumlahSuaraColumn.MinimumWidth = 6;
            this.jumlahSuaraColumn.Name = "jumlahSuaraColumn";
            this.jumlahSuaraColumn.ReadOnly = true;
            this.jumlahSuaraColumn.Width = 125;
            // 
            // totalSuaraColumn
            // 
            this.totalSuaraColumn.HeaderText = "Total Suara";
            this.totalSuaraColumn.MinimumWidth = 6;
            this.totalSuaraColumn.Name = "totalSuaraColumn";
            this.totalSuaraColumn.ReadOnly = true;
            this.totalSuaraColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OptionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OptionID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PollID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PollID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // pollingColumn
            // 
            this.pollingColumn.DataPropertyName = "Polls";
            this.pollingColumn.HeaderText = "Polling";
            this.pollingColumn.MinimumWidth = 6;
            this.pollingColumn.Name = "pollingColumn";
            this.pollingColumn.ReadOnly = true;
            this.pollingColumn.Width = 125;
            // 
            // opsiColumn
            // 
            this.opsiColumn.DataPropertyName = "OptionText";
            this.opsiColumn.HeaderText = "Opsi";
            this.opsiColumn.MinimumWidth = 6;
            this.opsiColumn.Name = "opsiColumn";
            this.opsiColumn.ReadOnly = true;
            this.opsiColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PollResponses";
            this.dataGridViewTextBoxColumn5.HeaderText = "PollResponses";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // pollOptionsBindingSource
            // 
            this.pollOptionsBindingSource.DataSource = typeof(EsemkaPolling.PollOptions);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1025, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Masuk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pollOptionsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pollOptionsBindingSource;
        private System.Windows.Forms.DataGridView pollOptionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opsiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahSuaraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSuaraColumn;
        private System.Windows.Forms.Button button1;
    }
}

