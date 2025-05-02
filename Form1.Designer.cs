namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnDecrypt = new Button();
            btnEbcrypt = new Button();
            tbN = new TextBox();
            labelN = new Label();
            tbB = new TextBox();
            labelB = new Label();
            tbQ = new TextBox();
            labelQ = new Label();
            tbP = new TextBox();
            labelP = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            plaintextOpenToolStripMenuItem = new ToolStripMenuItem();
            ciphertextOpenToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            plaintextSaveToolStripMenuItem1 = new ToolStripMenuItem();
            ciphertextSaveToolStripMenuItem1 = new ToolStripMenuItem();
            panelRight = new Panel();
            tbCiphertext = new TextBox();
            labelCiphertext = new Label();
            labelPlaintext = new Label();
            tbPlaintext = new TextBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            panelTop.SuspendLayout();
            menuStrip.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LavenderBlush;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(btnDecrypt);
            panelTop.Controls.Add(btnEbcrypt);
            panelTop.Controls.Add(tbN);
            panelTop.Controls.Add(labelN);
            panelTop.Controls.Add(tbB);
            panelTop.Controls.Add(labelB);
            panelTop.Controls.Add(tbQ);
            panelTop.Controls.Add(labelQ);
            panelTop.Controls.Add(tbP);
            panelTop.Controls.Add(labelP);
            panelTop.Controls.Add(menuStrip);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(846, 101);
            panelTop.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(362, 64);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(132, 22);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Расшифровать";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEbcrypt
            // 
            btnEbcrypt.Location = new Point(362, 30);
            btnEbcrypt.Name = "btnEbcrypt";
            btnEbcrypt.Size = new Size(132, 22);
            btnEbcrypt.TabIndex = 8;
            btnEbcrypt.Text = "Зашифровать";
            btnEbcrypt.UseVisualStyleBackColor = true;
            btnEbcrypt.Click += btnEbcrypt_Click;
            // 
            // tbN
            // 
            tbN.Enabled = false;
            tbN.Location = new Point(515, 63);
            tbN.Name = "tbN";
            tbN.Size = new Size(320, 23);
            tbN.TabIndex = 7;
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Location = new Point(500, 66);
            labelN.Name = "labelN";
            labelN.Size = new Size(14, 15);
            labelN.TabIndex = 6;
            labelN.Text = "n";
            // 
            // tbB
            // 
            tbB.Location = new Point(515, 27);
            tbB.Name = "tbB";
            tbB.Size = new Size(320, 23);
            tbB.TabIndex = 5;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(500, 30);
            labelB.Name = "labelB";
            labelB.Size = new Size(14, 15);
            labelB.TabIndex = 4;
            labelB.Text = "b";
            // 
            // tbQ
            // 
            tbQ.Location = new Point(23, 63);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(320, 23);
            tbQ.TabIndex = 3;
            // 
            // labelQ
            // 
            labelQ.AutoSize = true;
            labelQ.Location = new Point(3, 66);
            labelQ.Name = "labelQ";
            labelQ.Size = new Size(14, 15);
            labelQ.TabIndex = 2;
            labelQ.Text = "q";
            // 
            // tbP
            // 
            tbP.Location = new Point(23, 27);
            tbP.Name = "tbP";
            tbP.Size = new Size(320, 23);
            tbP.TabIndex = 1;
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.Location = new Point(3, 30);
            labelP.Name = "labelP";
            labelP.Size = new Size(14, 15);
            labelP.TabIndex = 0;
            labelP.Text = "p";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(844, 24);
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { plaintextOpenToolStripMenuItem, ciphertextOpenToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // plaintextOpenToolStripMenuItem
            // 
            plaintextOpenToolStripMenuItem.Name = "plaintextOpenToolStripMenuItem";
            plaintextOpenToolStripMenuItem.Size = new Size(128, 22);
            plaintextOpenToolStripMenuItem.Text = "Plaintext";
            plaintextOpenToolStripMenuItem.Click += plaintextOpenToolStripMenuItem_Click;
            // 
            // ciphertextOpenToolStripMenuItem
            // 
            ciphertextOpenToolStripMenuItem.Name = "ciphertextOpenToolStripMenuItem";
            ciphertextOpenToolStripMenuItem.Size = new Size(128, 22);
            ciphertextOpenToolStripMenuItem.Text = "Ciphertext";
            ciphertextOpenToolStripMenuItem.Click += ciphertextOpenToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { plaintextSaveToolStripMenuItem1, ciphertextSaveToolStripMenuItem1 });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // plaintextSaveToolStripMenuItem1
            // 
            plaintextSaveToolStripMenuItem1.Name = "plaintextSaveToolStripMenuItem1";
            plaintextSaveToolStripMenuItem1.Size = new Size(128, 22);
            plaintextSaveToolStripMenuItem1.Text = "Plaintext";
            plaintextSaveToolStripMenuItem1.Click += plaintextSaveToolStripMenuItem1_Click;
            // 
            // ciphertextSaveToolStripMenuItem1
            // 
            ciphertextSaveToolStripMenuItem1.Name = "ciphertextSaveToolStripMenuItem1";
            ciphertextSaveToolStripMenuItem1.Size = new Size(128, 22);
            ciphertextSaveToolStripMenuItem1.Text = "Ciphertext";
            ciphertextSaveToolStripMenuItem1.Click += ciphertextSaveToolStripMenuItem1_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.LavenderBlush;
            panelRight.Controls.Add(tbCiphertext);
            panelRight.Controls.Add(labelCiphertext);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(450, 101);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(396, 363);
            panelRight.TabIndex = 1;
            // 
            // tbCiphertext
            // 
            tbCiphertext.Location = new Point(8, 26);
            tbCiphertext.Multiline = true;
            tbCiphertext.Name = "tbCiphertext";
            tbCiphertext.ReadOnly = true;
            tbCiphertext.Size = new Size(380, 323);
            tbCiphertext.TabIndex = 6;
            tbCiphertext.TextChanged += textBox1_TextChanged;
            // 
            // labelCiphertext
            // 
            labelCiphertext.Location = new Point(12, 3);
            labelCiphertext.Name = "labelCiphertext";
            labelCiphertext.Size = new Size(378, 20);
            labelCiphertext.TabIndex = 3;
            labelCiphertext.Text = "Шифротекст";
            labelCiphertext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlaintext
            // 
            labelPlaintext.Location = new Point(4, 104);
            labelPlaintext.Name = "labelPlaintext";
            labelPlaintext.Size = new Size(380, 20);
            labelPlaintext.TabIndex = 2;
            labelPlaintext.Text = "Исходный текст";
            labelPlaintext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPlaintext
            // 
            tbPlaintext.Location = new Point(4, 127);
            tbPlaintext.Multiline = true;
            tbPlaintext.Name = "tbPlaintext";
            tbPlaintext.ReadOnly = true;
            tbPlaintext.Size = new Size(380, 323);
            tbPlaintext.TabIndex = 7;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(846, 464);
            Controls.Add(tbPlaintext);
            Controls.Add(labelPlaintext);
            Controls.Add(panelRight);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа 3";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Panel panelRight;
        private Label labelP;
        private TextBox tbQ;
        private Label labelQ;
        private TextBox tbP;
        private TextBox tbN;
        private Label labelN;
        private TextBox tbB;
        private Label labelB;
        private TextBox tbCiphertext;
        private Label labelCiphertext;
        private Label labelPlaintext;
        private TextBox tbPlaintext;
        private Button btnEbcrypt;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem plaintextOpenToolStripMenuItem;
        private ToolStripMenuItem ciphertextOpenToolStripMenuItem;
        private ToolStripMenuItem plaintextSaveToolStripMenuItem1;
        private ToolStripMenuItem ciphertextSaveToolStripMenuItem1;
        private Button btnDecrypt;
    }
}
