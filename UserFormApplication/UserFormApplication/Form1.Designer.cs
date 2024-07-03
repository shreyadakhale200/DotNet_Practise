namespace UserFormApplication
{
    partial class MoviesFilling_Form1
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
            Movies_groupBox1 = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            Save_button1 = new Button();
            genre_textBox2 = new TextBox();
            Genre_label1 = new Label();
            Name_textBox1 = new TextBox();
            Name_label1 = new Label();
            label1 = new Label();
            Ratings_numericUpDown1 = new NumericUpDown();
            duration_numericUpDown1 = new NumericUpDown();
            Duration_label2 = new Label();
            Movies_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ratings_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duration_numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Movies_groupBox1
            // 
            Movies_groupBox1.Controls.Add(label2);
            Movies_groupBox1.Controls.Add(button1);
            Movies_groupBox1.Controls.Add(Save_button1);
            Movies_groupBox1.Controls.Add(genre_textBox2);
            Movies_groupBox1.Controls.Add(Genre_label1);
            Movies_groupBox1.Controls.Add(Name_textBox1);
            Movies_groupBox1.Controls.Add(Name_label1);
            Movies_groupBox1.Font = new Font("Rockwell", 13.8F);
            Movies_groupBox1.Location = new Point(353, 34);
            Movies_groupBox1.Name = "Movies_groupBox1";
            Movies_groupBox1.Size = new Size(419, 357);
            Movies_groupBox1.TabIndex = 0;
            Movies_groupBox1.TabStop = false;
            Movies_groupBox1.Text = "Movies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 299);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(156, 197);
            button1.Name = "button1";
            button1.Size = new Size(257, 47);
            button1.TabIndex = 9;
            button1.Text = "Check Connection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Save_button1
            // 
            Save_button1.Location = new Point(23, 197);
            Save_button1.Name = "Save_button1";
            Save_button1.Size = new Size(113, 47);
            Save_button1.TabIndex = 8;
            Save_button1.Text = "SAVE";
            Save_button1.UseVisualStyleBackColor = true;
            // 
            // genre_textBox2
            // 
            genre_textBox2.Font = new Font("Rockwell", 13.8F);
            genre_textBox2.Location = new Point(196, 81);
            genre_textBox2.Name = "genre_textBox2";
            genre_textBox2.Size = new Size(186, 35);
            genre_textBox2.TabIndex = 4;
            // 
            // Genre_label1
            // 
            Genre_label1.AutoSize = true;
            Genre_label1.Font = new Font("Rockwell", 13.8F);
            Genre_label1.Location = new Point(94, 84);
            Genre_label1.Name = "Genre_label1";
            Genre_label1.Size = new Size(79, 26);
            Genre_label1.TabIndex = 3;
            Genre_label1.Text = "Genre";
            // 
            // Name_textBox1
            // 
            Name_textBox1.Font = new Font("Rockwell", 13.8F);
            Name_textBox1.Location = new Point(196, 45);
            Name_textBox1.Name = "Name_textBox1";
            Name_textBox1.Size = new Size(186, 35);
            Name_textBox1.TabIndex = 2;
            // 
            // Name_label1
            // 
            Name_label1.AutoSize = true;
            Name_label1.Font = new Font("Rockwell", 13.8F);
            Name_label1.Location = new Point(28, 48);
            Name_label1.Name = "Name_label1";
            Name_label1.Size = new Size(145, 26);
            Name_label1.TabIndex = 1;
            Name_label1.Text = "Movie Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 13.8F);
            label1.Location = new Point(436, 154);
            label1.Name = "label1";
            label1.Size = new Size(90, 26);
            label1.TabIndex = 3;
            label1.Text = "Ratings";
            label1.Click += label1_Click;
            // 
            // Ratings_numericUpDown1
            // 
            Ratings_numericUpDown1.Location = new Point(549, 153);
            Ratings_numericUpDown1.Name = "Ratings_numericUpDown1";
            Ratings_numericUpDown1.Size = new Size(186, 27);
            Ratings_numericUpDown1.TabIndex = 5;
            // 
            // duration_numericUpDown1
            // 
            duration_numericUpDown1.Location = new Point(549, 183);
            duration_numericUpDown1.Name = "duration_numericUpDown1";
            duration_numericUpDown1.Size = new Size(186, 27);
            duration_numericUpDown1.TabIndex = 7;
            // 
            // Duration_label2
            // 
            Duration_label2.AutoSize = true;
            Duration_label2.Font = new Font("Rockwell", 13.8F);
            Duration_label2.Location = new Point(422, 184);
            Duration_label2.Name = "Duration_label2";
            Duration_label2.Size = new Size(104, 26);
            Duration_label2.TabIndex = 6;
            Duration_label2.Text = "Duration";
            // 
            // MoviesFilling_Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 419);
            Controls.Add(duration_numericUpDown1);
            Controls.Add(Duration_label2);
            Controls.Add(Ratings_numericUpDown1);
            Controls.Add(label1);
            Controls.Add(Movies_groupBox1);
            Name = "MoviesFilling_Form1";
            Text = "Movies Form";
            Movies_groupBox1.ResumeLayout(false);
            Movies_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Ratings_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)duration_numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Movies_groupBox1;
        private TextBox Name_textBox1;
        private Label Name_label1;
        private TextBox genre_textBox2;
        private Label Genre_label1;
        private Label label1;
        private NumericUpDown Ratings_numericUpDown1;
        private NumericUpDown duration_numericUpDown1;
        private Label Duration_label2;
        private Button Save_button1;
        private Button button1;
        private Label label2;
    }
}
