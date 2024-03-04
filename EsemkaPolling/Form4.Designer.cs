namespace EsemkaPolling
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
            System.Windows.Forms.Label identityCodeLabel;
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identityCodeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            identityCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(EsemkaPolling.Users);
            // 
            // identityCodeLabel
            // 
            identityCodeLabel.AutoSize = true;
            identityCodeLabel.Location = new System.Drawing.Point(10, 15);
            identityCodeLabel.Name = "identityCodeLabel";
            identityCodeLabel.Size = new System.Drawing.Size(88, 16);
            identityCodeLabel.TabIndex = 1;
            identityCodeLabel.Text = "Identity Code:";
            // 
            // identityCodeTextBox
            // 
            this.identityCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "IdentityCode", true));
            this.identityCodeTextBox.Location = new System.Drawing.Point(104, 12);
            this.identityCodeTextBox.Name = "identityCodeTextBox";
            this.identityCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.identityCodeTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Masuk";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(identityCodeLabel);
            this.Controls.Add(this.identityCodeTextBox);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TextBox identityCodeTextBox;
        private System.Windows.Forms.Button button1;
    }
}