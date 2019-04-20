namespace GilluKiskatra.Forms
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
            this.checkButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.rLabel = new System.Windows.Forms.Label();
            this.spTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.sTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.vTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.spLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.vLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateValueButton
            // 
            this.updateValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateValueButton.FlatAppearance.BorderSize = 0;
            this.updateValueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateValueButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateValueButton.Location = new System.Drawing.Point(542, 219);
            this.updateValueButton.Name = "updateValueButton";
            this.updateValueButton.Size = new System.Drawing.Size(197, 35);
            this.updateValueButton.TabIndex = 82;
            this.updateValueButton.Text = "Обновить P и Q";
            this.updateValueButton.UseVisualStyleBackColor = false;
            this.updateValueButton.Click += new System.EventHandler(this.updateValueButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButton.Location = new System.Drawing.Point(542, 350);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(197, 65);
            this.checkButton.TabIndex = 81;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(111, 327);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(141, 55);
            this.resultLabel.TabIndex = 80;
            this.resultLabel.Text = "result";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(542, 283);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(197, 61);
            this.calculateButton.TabIndex = 79;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yTextBox.Location = new System.Drawing.Point(265, 216);
            this.yTextBox.Multiline = true;
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(121, 32);
            this.yTextBox.TabIndex = 78;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yLabel.ForeColor = System.Drawing.Color.Blue;
            this.yLabel.Location = new System.Drawing.Point(237, 219);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(28, 27);
            this.yLabel.TabIndex = 77;
            this.yLabel.Text = "Y";
            // 
            // eTextBox
            // 
            this.eTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eTextBox.Location = new System.Drawing.Point(88, 216);
            this.eTextBox.Multiline = true;
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(121, 32);
            this.eTextBox.TabIndex = 76;
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eLabel.Location = new System.Drawing.Point(61, 216);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(25, 27);
            this.eLabel.TabIndex = 75;
            this.eLabel.Text = "e";
            // 
            // xTextBox
            // 
            this.xTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xTextBox.Location = new System.Drawing.Point(618, 148);
            this.xTextBox.Multiline = true;
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(121, 32);
            this.xTextBox.TabIndex = 74;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLabel.ForeColor = System.Drawing.Color.Blue;
            this.xLabel.Location = new System.Drawing.Point(592, 151);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(27, 27);
            this.xLabel.TabIndex = 73;
            this.xLabel.Text = "X";
            // 
            // rTextBox
            // 
            this.rTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTextBox.Location = new System.Drawing.Point(438, 148);
            this.rTextBox.Multiline = true;
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(121, 32);
            this.rTextBox.TabIndex = 72;
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rLabel.Location = new System.Drawing.Point(413, 151);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(20, 27);
            this.rLabel.TabIndex = 71;
            this.rLabel.Text = "r";
            // 
            // spTextBox
            // 
            this.spTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spTextBox.Location = new System.Drawing.Point(265, 148);
            this.spTextBox.Multiline = true;
            this.spTextBox.Name = "spTextBox";
            this.spTextBox.Size = new System.Drawing.Size(121, 32);
            this.spTextBox.TabIndex = 70;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(88, 148);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 32);
            this.idTextBox.TabIndex = 69;
            // 
            // sTextBox
            // 
            this.sTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sTextBox.Location = new System.Drawing.Point(618, 36);
            this.sTextBox.Multiline = true;
            this.sTextBox.Name = "sTextBox";
            this.sTextBox.Size = new System.Drawing.Size(121, 32);
            this.sTextBox.TabIndex = 68;
            // 
            // nTextBox
            // 
            this.nTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTextBox.Location = new System.Drawing.Point(265, 36);
            this.nTextBox.Multiline = true;
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(121, 32);
            this.nTextBox.TabIndex = 67;
            // 
            // vTextBox
            // 
            this.vTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vTextBox.Location = new System.Drawing.Point(438, 36);
            this.vTextBox.Multiline = true;
            this.vTextBox.Name = "vTextBox";
            this.vTextBox.Size = new System.Drawing.Size(121, 32);
            this.vTextBox.TabIndex = 66;
            // 
            // qTextBox
            // 
            this.qTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qTextBox.Location = new System.Drawing.Point(88, 82);
            this.qTextBox.Multiline = true;
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(121, 32);
            this.qTextBox.TabIndex = 65;
            // 
            // spLabel
            // 
            this.spLabel.AutoSize = true;
            this.spLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spLabel.ForeColor = System.Drawing.Color.Blue;
            this.spLabel.Location = new System.Drawing.Point(225, 151);
            this.spLabel.Name = "spLabel";
            this.spLabel.Size = new System.Drawing.Size(42, 27);
            this.spLabel.TabIndex = 64;
            this.spLabel.Text = "Sp";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(61, 151);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 27);
            this.idLabel.TabIndex = 63;
            this.idLabel.Text = "Id";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sLabel.ForeColor = System.Drawing.Color.Blue;
            this.sLabel.Location = new System.Drawing.Point(592, 39);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(24, 27);
            this.sLabel.TabIndex = 62;
            this.sLabel.Text = "s";
            // 
            // pTextBox
            // 
            this.pTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTextBox.Location = new System.Drawing.Point(88, 36);
            this.pTextBox.Multiline = true;
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(121, 32);
            this.pTextBox.TabIndex = 61;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nLabel.ForeColor = System.Drawing.Color.Blue;
            this.nLabel.Location = new System.Drawing.Point(239, 39);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(26, 27);
            this.nLabel.TabIndex = 60;
            this.nLabel.Text = "n";
            // 
            // vLabel
            // 
            this.vLabel.AutoSize = true;
            this.vLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLabel.ForeColor = System.Drawing.Color.Blue;
            this.vLabel.Location = new System.Drawing.Point(413, 39);
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(23, 27);
            this.vLabel.TabIndex = 59;
            this.vLabel.Text = "v";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qLabel.Location = new System.Drawing.Point(61, 85);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(26, 27);
            this.qLabel.TabIndex = 58;
            this.qLabel.Text = "q";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pLabel.Location = new System.Drawing.Point(61, 39);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(26, 27);
            this.pLabel.TabIndex = 57;
            this.pLabel.Text = "p";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateValueButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.spTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.sTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.vTextBox);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.spLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.vLabel);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.pLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateValueButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox spTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox sTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox vTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label spLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label vLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label pLabel;
    }
}

