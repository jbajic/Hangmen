namespace HangmanApp
{
    partial class Highscores
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
            this.label1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(154, 70);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(19, 25);
            this.name1.TabIndex = 1;
            this.name1.Text = "-";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(318, 70);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(19, 25);
            this.score1.TabIndex = 2;
            this.score1.Text = "-";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(318, 135);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(19, 25);
            this.score2.TabIndex = 5;
            this.score2.Text = "-";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.Location = new System.Drawing.Point(154, 135);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(19, 25);
            this.name2.TabIndex = 4;
            this.name2.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "2.";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score3.Location = new System.Drawing.Point(318, 220);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(19, 25);
            this.score3.TabIndex = 8;
            this.score3.Text = "-";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name3.Location = new System.Drawing.Point(154, 220);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(19, 25);
            this.name3.TabIndex = 7;
            this.name3.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "3.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score3);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label1);
            this.Name = "Highscores";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}