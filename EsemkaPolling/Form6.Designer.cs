namespace EsemkaPolling
{
    partial class Form6
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
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label optionTextLabel;
            this.pollsDataGridView = new System.Windows.Forms.DataGridView();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.optionTextTextBox = new System.Windows.Forms.TextBox();
            this.pollOptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pollOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            questionLabel = new System.Windows.Forms.Label();
            optionTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pollsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pollsDataGridView
            // 
            this.pollsDataGridView.AutoGenerateColumns = false;
            this.pollsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pollsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pollsDataGridView.DataSource = this.bindingSource1;
            this.pollsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.pollsDataGridView.Name = "pollsDataGridView";
            this.pollsDataGridView.RowHeadersWidth = 51;
            this.pollsDataGridView.RowTemplate.Height = 24;
            this.pollsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pollsDataGridView.Size = new System.Drawing.Size(1142, 252);
            this.pollsDataGridView.TabIndex = 1;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(12, 273);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(63, 16);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "Question:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pollsBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(81, 270);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(195, 22);
            this.questionTextBox.TabIndex = 2;
            // 
            // optionTextLabel
            // 
            optionTextLabel.AutoSize = true;
            optionTextLabel.Location = new System.Drawing.Point(24, 301);
            optionTextLabel.Name = "optionTextLabel";
            optionTextLabel.Size = new System.Drawing.Size(78, 16);
            optionTextLabel.TabIndex = 3;
            optionTextLabel.Text = "Option Text:";
            // 
            // optionTextTextBox
            // 
            this.optionTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pollOptionsBindingSource, "OptionText", true));
            this.optionTextTextBox.Location = new System.Drawing.Point(108, 298);
            this.optionTextTextBox.Name = "optionTextTextBox";
            this.optionTextTextBox.Size = new System.Drawing.Size(168, 22);
            this.optionTextTextBox.TabIndex = 4;
            // 
            // pollOptionsDataGridView
            // 
            this.pollOptionsDataGridView.AutoGenerateColumns = false;
            this.pollOptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pollOptionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.pollOptionsDataGridView.DataSource = this.bindingSource2;
            this.pollOptionsDataGridView.Location = new System.Drawing.Point(282, 270);
            this.pollOptionsDataGridView.Name = "pollOptionsDataGridView";
            this.pollOptionsDataGridView.RowHeadersWidth = 51;
            this.pollOptionsDataGridView.RowTemplate.Height = 24;
            this.pollOptionsDataGridView.Size = new System.Drawing.Size(872, 220);
            this.pollOptionsDataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(890, 496);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(264, 52);
            this.button5.TabIndex = 10;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OptionID";
            this.dataGridViewTextBoxColumn9.HeaderText = "OptionID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PollID";
            this.dataGridViewTextBoxColumn10.HeaderText = "PollID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OptionText";
            this.dataGridViewTextBoxColumn11.HeaderText = "OptionText";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Polls";
            this.dataGridViewTextBoxColumn12.HeaderText = "Polls";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PollResponses";
            this.dataGridViewTextBoxColumn13.HeaderText = "PollResponses";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(EsemkaPolling.PollOptions);
            // 
            // pollOptionsBindingSource
            // 
            this.pollOptionsBindingSource.DataSource = typeof(EsemkaPolling.PollOptions);
            // 
            // pollsBindingSource
            // 
            this.pollsBindingSource.DataSource = typeof(EsemkaPolling.Polls);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PollID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PollID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AdminID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AdminID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn3.HeaderText = "Question";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsClosed";
            this.dataGridViewTextBoxColumn4.HeaderText = "IsClosed";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn5.HeaderText = "CreatedAt";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Admins";
            this.dataGridViewTextBoxColumn6.HeaderText = "Admins";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PollOptions";
            this.dataGridViewTextBoxColumn7.HeaderText = "PollOptions";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PollResponses";
            this.dataGridViewTextBoxColumn8.HeaderText = "PollResponses";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EsemkaPolling.Polls);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 687);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pollOptionsDataGridView);
            this.Controls.Add(optionTextLabel);
            this.Controls.Add(this.optionTextTextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.pollsDataGridView);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pollsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pollsBindingSource;
        private System.Windows.Forms.DataGridView pollsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource pollOptionsBindingSource;
        private System.Windows.Forms.TextBox optionTextTextBox;
        private System.Windows.Forms.DataGridView pollOptionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}