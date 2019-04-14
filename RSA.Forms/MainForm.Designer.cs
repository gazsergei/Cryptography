namespace RSA.Forms
{
    partial class MainForm
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
            this.updateValueButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.fnLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.inputNumbersLabel = new System.Windows.Forms.Label();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.outputNumbersLabel = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateValueButton
            // 
            this.updateValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateValueButton.FlatAppearance.BorderSize = 0;
            this.updateValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateValueButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateValueButton.Location = new System.Drawing.Point(735, 115);
            this.updateValueButton.Name = "updateValueButton";
            this.updateValueButton.Size = new System.Drawing.Size(223, 53);
            this.updateValueButton.TabIndex = 108;
            this.updateValueButton.Text = "Обновить P и Q";
            this.updateValueButton.UseVisualStyleBackColor = false;
            this.updateValueButton.Click += new System.EventHandler(this.updateValueButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.encryptButton.FlatAppearance.BorderSize = 0;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.Location = new System.Drawing.Point(735, 328);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(223, 65);
            this.encryptButton.TabIndex = 107;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(735, 190);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(223, 61);
            this.calculateButton.TabIndex = 105;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // eTextBox
            // 
            this.eTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eTextBox.Location = new System.Drawing.Point(438, 39);
            this.eTextBox.Multiline = true;
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(121, 32);
            this.eTextBox.TabIndex = 102;
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eLabel.Location = new System.Drawing.Point(411, 39);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(25, 27);
            this.eLabel.TabIndex = 101;
            this.eLabel.Text = "e";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLabel.ForeColor = System.Drawing.Color.Blue;
            this.xLabel.Location = new System.Drawing.Point(63, 190);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(202, 27);
            this.xLabel.TabIndex = 99;
            this.xLabel.Text = "Секретный ключ:";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rLabel.Location = new System.Drawing.Point(71, 141);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(194, 27);
            this.rLabel.TabIndex = 97;
            this.rLabel.Text = "Открытый ключ:";
            // 
            // fnTextBox
            // 
            this.fnTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnTextBox.Location = new System.Drawing.Point(265, 82);
            this.fnTextBox.Multiline = true;
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(121, 32);
            this.fnTextBox.TabIndex = 96;
            // 
            // dTextBox
            // 
            this.dTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dTextBox.Location = new System.Drawing.Point(618, 36);
            this.dTextBox.Multiline = true;
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(121, 32);
            this.dTextBox.TabIndex = 95;
            // 
            // nTextBox
            // 
            this.nTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTextBox.Location = new System.Drawing.Point(265, 36);
            this.nTextBox.Multiline = true;
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(121, 32);
            this.nTextBox.TabIndex = 93;
            // 
            // qTextBox
            // 
            this.qTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qTextBox.Location = new System.Drawing.Point(88, 82);
            this.qTextBox.Multiline = true;
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(121, 32);
            this.qTextBox.TabIndex = 91;
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnLabel.ForeColor = System.Drawing.Color.Blue;
            this.fnLabel.Location = new System.Drawing.Point(225, 85);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(33, 27);
            this.fnLabel.TabIndex = 90;
            this.fnLabel.Text = "fn";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dLabel.Location = new System.Drawing.Point(591, 39);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(26, 27);
            this.dLabel.TabIndex = 89;
            this.dLabel.Text = "d";
            // 
            // pTextBox
            // 
            this.pTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTextBox.Location = new System.Drawing.Point(88, 36);
            this.pTextBox.Multiline = true;
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(121, 32);
            this.pTextBox.TabIndex = 87;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nLabel.ForeColor = System.Drawing.Color.Blue;
            this.nLabel.Location = new System.Drawing.Point(239, 39);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(26, 27);
            this.nLabel.TabIndex = 86;
            this.nLabel.Text = "n";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qLabel.Location = new System.Drawing.Point(61, 85);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(26, 27);
            this.qLabel.TabIndex = 84;
            this.qLabel.Text = "q";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pLabel.Location = new System.Drawing.Point(61, 39);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(26, 27);
            this.pLabel.TabIndex = 83;
            this.pLabel.Text = "p";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 109;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(93, 265);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(281, 67);
            this.inputTextBox.TabIndex = 110;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(31, 267);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(54, 24);
            this.inputLabel.TabIndex = 111;
            this.inputLabel.Text = "input";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.Location = new System.Drawing.Point(20, 445);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(67, 24);
            this.outputLabel.TabIndex = 113;
            this.outputLabel.Text = "output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(88, 443);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(281, 70);
            this.outputTextBox.TabIndex = 112;
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyLabel.Location = new System.Drawing.Point(268, 141);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(151, 24);
            this.publicKeyLabel.TabIndex = 114;
            this.publicKeyLabel.Text = "publicKeyLabel";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyLabel.Location = new System.Drawing.Point(268, 190);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(162, 24);
            this.privateKeyLabel.TabIndex = 115;
            this.privateKeyLabel.Text = "privateKeyLabel";
            // 
            // inputNumbersLabel
            // 
            this.inputNumbersLabel.AutoSize = true;
            this.inputNumbersLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumbersLabel.Location = new System.Drawing.Point(396, 286);
            this.inputNumbersLabel.Name = "inputNumbersLabel";
            this.inputNumbersLabel.Size = new System.Drawing.Size(187, 24);
            this.inputNumbersLabel.TabIndex = 116;
            this.inputNumbersLabel.Text = "inputNumbersLabel";
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipherLabel.Location = new System.Drawing.Point(91, 369);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(118, 24);
            this.cipherLabel.TabIndex = 117;
            this.cipherLabel.Text = "cipherLabel";
            // 
            // outputNumbersLabel
            // 
            this.outputNumbersLabel.AutoSize = true;
            this.outputNumbersLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputNumbersLabel.Location = new System.Drawing.Point(396, 462);
            this.outputNumbersLabel.Name = "outputNumbersLabel";
            this.outputNumbersLabel.Size = new System.Drawing.Size(200, 24);
            this.outputNumbersLabel.TabIndex = 118;
            this.outputNumbersLabel.Text = "outputNumbersLabel";
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.decryptButton.FlatAppearance.BorderSize = 0;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.Location = new System.Drawing.Point(735, 404);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(223, 65);
            this.decryptButton.TabIndex = 119;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 544);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.outputNumbersLabel);
            this.Controls.Add(this.cipherLabel);
            this.Controls.Add(this.inputNumbersLabel);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateValueButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.fnTextBox);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.pLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateValueButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox fnTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.Label inputNumbersLabel;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.Label outputNumbersLabel;
        private System.Windows.Forms.Button decryptButton;
    }
}

