namespace testScore
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
            this.Score1 = new System.Windows.Forms.Label();
            this.scoreBox1 = new System.Windows.Forms.TextBox();
            this.scoreBox2 = new System.Windows.Forms.TextBox();
            this.scoreBox3 = new System.Windows.Forms.TextBox();
            this.scoreBox4 = new System.Windows.Forms.TextBox();
            this.scoreBox5 = new System.Windows.Forms.TextBox();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score4 = new System.Windows.Forms.Label();
            this.Score5 = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.Label();
            this.grade1 = new System.Windows.Forms.Label();
            this.exitbutton1 = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1.Location = new System.Drawing.Point(24, 53);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(62, 18);
            this.Score1.TabIndex = 0;
            this.Score1.Text = "Score1\r\n";
            // 
            // scoreBox1
            // 
            this.scoreBox1.Location = new System.Drawing.Point(103, 50);
            this.scoreBox1.Name = "scoreBox1";
            this.scoreBox1.Size = new System.Drawing.Size(100, 22);
            this.scoreBox1.TabIndex = 1;
            this.scoreBox1.TextChanged += new System.EventHandler(this.scoreBox1_TextChanged);
            // 
            // scoreBox2
            // 
            this.scoreBox2.Location = new System.Drawing.Point(103, 105);
            this.scoreBox2.Name = "scoreBox2";
            this.scoreBox2.Size = new System.Drawing.Size(100, 22);
            this.scoreBox2.TabIndex = 2;
            // 
            // scoreBox3
            // 
            this.scoreBox3.Location = new System.Drawing.Point(103, 164);
            this.scoreBox3.Name = "scoreBox3";
            this.scoreBox3.Size = new System.Drawing.Size(100, 22);
            this.scoreBox3.TabIndex = 3;
            // 
            // scoreBox4
            // 
            this.scoreBox4.Location = new System.Drawing.Point(103, 231);
            this.scoreBox4.Name = "scoreBox4";
            this.scoreBox4.Size = new System.Drawing.Size(100, 22);
            this.scoreBox4.TabIndex = 4;
            // 
            // scoreBox5
            // 
            this.scoreBox5.Location = new System.Drawing.Point(103, 293);
            this.scoreBox5.Name = "scoreBox5";
            this.scoreBox5.Size = new System.Drawing.Size(100, 22);
            this.scoreBox5.TabIndex = 5;
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.Location = new System.Drawing.Point(24, 110);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(62, 18);
            this.Score2.TabIndex = 6;
            this.Score2.Text = "Score2";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score3.Location = new System.Drawing.Point(24, 169);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(62, 18);
            this.Score3.TabIndex = 7;
            this.Score3.Text = "Score3";
            // 
            // Score4
            // 
            this.Score4.AutoSize = true;
            this.Score4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score4.Location = new System.Drawing.Point(24, 236);
            this.Score4.Name = "Score4";
            this.Score4.Size = new System.Drawing.Size(62, 18);
            this.Score4.TabIndex = 8;
            this.Score4.Text = "Score4";
            // 
            // Score5
            // 
            this.Score5.AutoSize = true;
            this.Score5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score5.Location = new System.Drawing.Point(24, 293);
            this.Score5.Name = "Score5";
            this.Score5.Size = new System.Drawing.Size(62, 18);
            this.Score5.TabIndex = 9;
            this.Score5.Text = "Score5";
            // 
            // Average
            // 
            this.Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.Location = new System.Drawing.Point(92, 415);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(96, 55);
            this.Average.TabIndex = 10;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.Location = new System.Drawing.Point(24, 359);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(59, 18);
            this.Grade.TabIndex = 11;
            this.Grade.Text = "Grade:";
            // 
            // grade1
            // 
            this.grade1.Location = new System.Drawing.Point(100, 350);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(449, 39);
            this.grade1.TabIndex = 12;
            this.grade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitbutton1
            // 
            this.exitbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton1.Location = new System.Drawing.Point(440, 415);
            this.exitbutton1.Name = "exitbutton1";
            this.exitbutton1.Size = new System.Drawing.Size(75, 55);
            this.exitbutton1.TabIndex = 13;
            this.exitbutton1.Text = "Exit";
            this.exitbutton1.UseVisualStyleBackColor = true;
            this.exitbutton1.Click += new System.EventHandler(this.exitbutton1_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(262, 415);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 55);
            this.clearbutton.TabIndex = 14;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 499);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.exitbutton1);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Score5);
            this.Controls.Add(this.Score4);
            this.Controls.Add(this.Score3);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.scoreBox5);
            this.Controls.Add(this.scoreBox4);
            this.Controls.Add(this.scoreBox3);
            this.Controls.Add(this.scoreBox2);
            this.Controls.Add(this.scoreBox1);
            this.Controls.Add(this.Score1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.TextBox scoreBox1;
        private System.Windows.Forms.TextBox scoreBox2;
        private System.Windows.Forms.TextBox scoreBox3;
        private System.Windows.Forms.TextBox scoreBox4;
        private System.Windows.Forms.TextBox scoreBox5;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score4;
        private System.Windows.Forms.Label Score5;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label grade1;
        private System.Windows.Forms.Button exitbutton1;
        private System.Windows.Forms.Button clearbutton;
    }
}

