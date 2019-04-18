namespace Stenography.Forms
{
    partial class StenographyForm
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(572, 139);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(105, 23);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(108, 104);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(112, 20);
            this.cipherTextBox.TabIndex = 7;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(161, 78);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(59, 20);
            this.filePathTextBox.TabIndex = 8;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(66, 81);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(89, 13);
            this.filePathLabel.TabIndex = 4;
            this.filePathLabel.Text = "Исходный текст";
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Location = new System.Drawing.Point(66, 107);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(36, 13);
            this.cipherLabel.TabIndex = 5;
            this.cipherLabel.Text = "Шифр";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(572, 113);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(105, 23);
            this.openButton.TabIndex = 6;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // StenographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.cipherLabel);
            this.Controls.Add(this.openButton);
            this.Name = "StenographyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StenographyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

