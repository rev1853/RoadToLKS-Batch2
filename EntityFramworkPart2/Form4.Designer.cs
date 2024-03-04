namespace EntityFramworkPart2
{
    partial class Form4
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
            System.Windows.Forms.Label element1Label;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label difficultyLevelLabel;
            System.Windows.Forms.Label nameLabel;
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.element1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.difficultyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroSkillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelSkillBS = new System.Windows.Forms.BindingSource(this.components);
            this.formSkillBS = new System.Windows.Forms.BindingSource(this.components);
            this.formElementBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelElementBS = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            element1Label = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            difficultyLevelLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelSkillBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSkillBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formElementBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelElementBS)).BeginInit();
            this.SuspendLayout();
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.AutoGenerateColumns = false;
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.elementDataGridView.DataSource = this.tabelElementBS;
            this.elementDataGridView.Location = new System.Drawing.Point(12, 12);
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.RowHeadersWidth = 51;
            this.elementDataGridView.RowTemplate.Height = 24;
            this.elementDataGridView.Size = new System.Drawing.Size(1200, 220);
            this.elementDataGridView.TabIndex = 1;
            // 
            // element1Label
            // 
            element1Label.AutoSize = true;
            element1Label.Location = new System.Drawing.Point(17, 241);
            element1Label.Name = "element1Label";
            element1Label.Size = new System.Drawing.Size(66, 16);
            element1Label.TabIndex = 1;
            element1Label.Text = "Element1:";
            // 
            // element1TextBox
            // 
            this.element1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formElementBS, "Element1", true));
            this.element1TextBox.Location = new System.Drawing.Point(89, 238);
            this.element1TextBox.Name = "element1TextBox";
            this.element1TextBox.Size = new System.Drawing.Size(213, 22);
            this.element1TextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(difficultyLevelLabel);
            this.groupBox1.Controls.Add(this.difficultyLevelComboBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skills";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(10, 46);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formSkillBS, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(111, 43);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(232, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // difficultyLevelLabel
            // 
            difficultyLevelLabel.AutoSize = true;
            difficultyLevelLabel.Location = new System.Drawing.Point(10, 74);
            difficultyLevelLabel.Name = "difficultyLevelLabel";
            difficultyLevelLabel.Size = new System.Drawing.Size(95, 16);
            difficultyLevelLabel.TabIndex = 2;
            difficultyLevelLabel.Text = "Difficulty Level:";
            // 
            // difficultyLevelComboBox
            // 
            this.difficultyLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formSkillBS, "DifficultyLevel", true));
            this.difficultyLevelComboBox.FormattingEnabled = true;
            this.difficultyLevelComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Supreme"});
            this.difficultyLevelComboBox.Location = new System.Drawing.Point(111, 71);
            this.difficultyLevelComboBox.Name = "difficultyLevelComboBox";
            this.difficultyLevelComboBox.Size = new System.Drawing.Size(232, 24);
            this.difficultyLevelComboBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(10, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formSkillBS, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(111, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.elementIDDataGridViewTextBoxColumn,
            this.difficultyLevelDataGridViewTextBoxColumn,
            this.elementDataGridViewTextBoxColumn,
            this.heroSkillDataGridViewTextBoxColumn,
            this.DeleteButton});
            this.dataGridView1.DataSource = this.tabelSkillBS;
            this.dataGridView1.Location = new System.Drawing.Point(13, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 188);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1122, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1026, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // elementIDDataGridViewTextBoxColumn
            // 
            this.elementIDDataGridViewTextBoxColumn.DataPropertyName = "ElementID";
            this.elementIDDataGridViewTextBoxColumn.HeaderText = "ElementID";
            this.elementIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementIDDataGridViewTextBoxColumn.Name = "elementIDDataGridViewTextBoxColumn";
            this.elementIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // difficultyLevelDataGridViewTextBoxColumn
            // 
            this.difficultyLevelDataGridViewTextBoxColumn.DataPropertyName = "DifficultyLevel";
            this.difficultyLevelDataGridViewTextBoxColumn.HeaderText = "DifficultyLevel";
            this.difficultyLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.difficultyLevelDataGridViewTextBoxColumn.Name = "difficultyLevelDataGridViewTextBoxColumn";
            this.difficultyLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.difficultyLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // elementDataGridViewTextBoxColumn
            // 
            this.elementDataGridViewTextBoxColumn.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn.HeaderText = "Element";
            this.elementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementDataGridViewTextBoxColumn.Name = "elementDataGridViewTextBoxColumn";
            this.elementDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementDataGridViewTextBoxColumn.Width = 125;
            // 
            // heroSkillDataGridViewTextBoxColumn
            // 
            this.heroSkillDataGridViewTextBoxColumn.DataPropertyName = "HeroSkill";
            this.heroSkillDataGridViewTextBoxColumn.HeaderText = "HeroSkill";
            this.heroSkillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heroSkillDataGridViewTextBoxColumn.Name = "heroSkillDataGridViewTextBoxColumn";
            this.heroSkillDataGridViewTextBoxColumn.ReadOnly = true;
            this.heroSkillDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabelSkillBS
            // 
            this.tabelSkillBS.DataSource = typeof(EntityFramworkPart2.Skill);
            // 
            // formSkillBS
            // 
            this.formSkillBS.DataSource = typeof(EntityFramworkPart2.Skill);
            // 
            // formElementBS
            // 
            this.formElementBS.DataSource = typeof(EntityFramworkPart2.Element);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Element1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Element1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Skill";
            this.dataGridViewTextBoxColumn3.HeaderText = "Skill";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // tabelElementBS
            // 
            this.tabelElementBS.DataSource = typeof(EntityFramworkPart2.Element);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1072, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 746);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(element1Label);
            this.Controls.Add(this.element1TextBox);
            this.Controls.Add(this.elementDataGridView);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelSkillBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSkillBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formElementBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelElementBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tabelElementBS;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox element1TextBox;
        private System.Windows.Forms.BindingSource formElementBS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource formSkillBS;
        private System.Windows.Forms.ComboBox difficultyLevelComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tabelSkillBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heroSkillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}