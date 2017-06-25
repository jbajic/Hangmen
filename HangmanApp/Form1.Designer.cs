namespace HangmanApp
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
            this.gbHangmen = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUsedLetters = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btWord = new System.Windows.Forms.Button();
            this.btLetter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbHangmen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHangmen
            // 
            this.gbHangmen.Controls.Add(this.panel1);
            this.gbHangmen.Location = new System.Drawing.Point(572, 28);
            this.gbHangmen.Name = "gbHangmen";
            this.gbHangmen.Size = new System.Drawing.Size(256, 479);
            this.gbHangmen.TabIndex = 2;
            this.gbHangmen.TabStop = false;
            this.gbHangmen.Text = "Hangmen";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 460);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUsedLetters);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelWord);
            this.groupBox1.Controls.Add(this.tbPoints);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbUsedLetters
            // 
            this.lbUsedLetters.AutoSize = true;
            this.lbUsedLetters.Location = new System.Drawing.Point(94, 248);
            this.lbUsedLetters.Name = "lbUsedLetters";
            this.lbUsedLetters.Size = new System.Drawing.Size(35, 13);
            this.lbUsedLetters.TabIndex = 4;
            this.lbUsedLetters.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Used letters:";
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(160, 96);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(126, 46);
            this.labelWord.TabIndex = 2;
            this.labelWord.Text = "label2";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPoints
            // 
            this.tbPoints.Location = new System.Drawing.Point(430, 248);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.ReadOnly = true;
            this.tbPoints.Size = new System.Drawing.Size(56, 20);
            this.tbPoints.TabIndex = 1;
            this.tbPoints.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbWord);
            this.groupBox2.Controls.Add(this.tbLetter);
            this.groupBox2.Controls.Add(this.btWord);
            this.groupBox2.Controls.Add(this.btLetter);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 168);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tbWord
            // 
            this.tbWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbWord.Location = new System.Drawing.Point(56, 115);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(159, 20);
            this.tbWord.TabIndex = 1;
            // 
            // tbLetter
            // 
            this.tbLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLetter.Location = new System.Drawing.Point(56, 47);
            this.tbLetter.MaxLength = 1;
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(36, 20);
            this.tbLetter.TabIndex = 0;
            // 
            // btWord
            // 
            this.btWord.Location = new System.Drawing.Point(264, 104);
            this.btWord.Name = "btWord";
            this.btWord.Size = new System.Drawing.Size(120, 40);
            this.btWord.TabIndex = 3;
            this.btWord.Text = "WORD";
            this.btWord.UseVisualStyleBackColor = true;
            this.btWord.Click += new System.EventHandler(this.btWord_Click);
            // 
            // btLetter
            // 
            this.btLetter.Location = new System.Drawing.Point(264, 38);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(120, 36);
            this.btLetter.TabIndex = 2;
            this.btLetter.Text = "LETTER";
            this.btLetter.UseVisualStyleBackColor = true;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highscoresToolStripMenuItem,
            this.importWordsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            this.highscoresToolStripMenuItem.Click += new System.EventHandler(this.highscoresToolStripMenuItem_Click);
            // 
            // importWordsToolStripMenuItem
            // 
            this.importWordsToolStripMenuItem.Name = "importWordsToolStripMenuItem";
            this.importWordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importWordsToolStripMenuItem.Text = "Import words";
            this.importWordsToolStripMenuItem.Click += new System.EventHandler(this.importWordsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHangmen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbHangmen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbHangmen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btWord;
        private System.Windows.Forms.Button btLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPoints;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label lbUsedLetters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWordsToolStripMenuItem;
    }
}

