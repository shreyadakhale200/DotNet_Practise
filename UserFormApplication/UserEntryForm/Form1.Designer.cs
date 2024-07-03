namespace UserEntryForm
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
            UserEntry_groupBox1 = new GroupBox();
            Update_button1 = new Button();
            Result_label2 = new Label();
            Submit_button1 = new Button();
            Password_textBox2 = new TextBox();
            Username_textBox1 = new TextBox();
            label1 = new Label();
            Username_label1 = new Label();
            Delete_button1 = new Button();
            UserEntry_groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UserEntry_groupBox1
            // 
            UserEntry_groupBox1.Controls.Add(Delete_button1);
            UserEntry_groupBox1.Controls.Add(Update_button1);
            UserEntry_groupBox1.Controls.Add(Result_label2);
            UserEntry_groupBox1.Controls.Add(Submit_button1);
            UserEntry_groupBox1.Controls.Add(Password_textBox2);
            UserEntry_groupBox1.Controls.Add(Username_textBox1);
            UserEntry_groupBox1.Controls.Add(label1);
            UserEntry_groupBox1.Controls.Add(Username_label1);
            UserEntry_groupBox1.Font = new Font("Arial Narrow", 12F);
            UserEntry_groupBox1.Location = new Point(12, 12);
            UserEntry_groupBox1.Name = "UserEntry_groupBox1";
            UserEntry_groupBox1.Size = new Size(460, 214);
            UserEntry_groupBox1.TabIndex = 0;
            UserEntry_groupBox1.TabStop = false;
            UserEntry_groupBox1.Text = "User Entry Form";
            // 
            // Update_button1
            // 
            Update_button1.Location = new Point(186, 147);
            Update_button1.Name = "Update_button1";
            Update_button1.Size = new Size(94, 29);
            Update_button1.TabIndex = 6;
            Update_button1.Text = "Update";
            Update_button1.UseVisualStyleBackColor = true;
            Update_button1.Click += Update_button1_Click;
            // 
            // Result_label2
            // 
            Result_label2.AutoSize = true;
            Result_label2.Location = new Point(115, 178);
            Result_label2.Name = "Result_label2";
            Result_label2.Size = new Size(0, 24);
            Result_label2.TabIndex = 5;
            Result_label2.Click += label2_Click;
            // 
            // Submit_button1
            // 
            Submit_button1.Location = new Point(86, 147);
            Submit_button1.Name = "Submit_button1";
            Submit_button1.Size = new Size(94, 29);
            Submit_button1.TabIndex = 1;
            Submit_button1.Text = "Submit";
            Submit_button1.UseVisualStyleBackColor = true;
            Submit_button1.Click += Submit_button1_Click;
            // 
            // Password_textBox2
            // 
            Password_textBox2.Font = new Font("Arial Narrow", 12F);
            Password_textBox2.Location = new Point(172, 94);
            Password_textBox2.Name = "Password_textBox2";
            Password_textBox2.Size = new Size(174, 30);
            Password_textBox2.TabIndex = 4;
            Password_textBox2.TextChanged += Password_textBox2_TextChanged;
            // 
            // Username_textBox1
            // 
            Username_textBox1.Font = new Font("Arial Narrow", 12F);
            Username_textBox1.Location = new Point(172, 63);
            Username_textBox1.Name = "Username_textBox1";
            Username_textBox1.Size = new Size(174, 30);
            Username_textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(82, 97);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // Username_label1
            // 
            Username_label1.AutoSize = true;
            Username_label1.Font = new Font("Arial Narrow", 12F);
            Username_label1.Location = new Point(77, 66);
            Username_label1.Name = "Username_label1";
            Username_label1.Size = new Size(86, 24);
            Username_label1.TabIndex = 1;
            Username_label1.Text = "Username";
            // 
            // Delete_button1
            // 
            Delete_button1.Location = new Point(286, 147);
            Delete_button1.Name = "Delete_button1";
            Delete_button1.Size = new Size(94, 29);
            Delete_button1.TabIndex = 7;
            Delete_button1.Text = "Delete";
            Delete_button1.UseVisualStyleBackColor = true;
            Delete_button1.Click += Delete_button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 241);
            Controls.Add(UserEntry_groupBox1);
            Name = "Form1";
            Text = "Form1";
            UserEntry_groupBox1.ResumeLayout(false);
            UserEntry_groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox UserEntry_groupBox1;
        private TextBox Password_textBox2;
        private TextBox Username_textBox1;
        private Label label1;
        private Label Username_label1;
        private Button Submit_button1;
        private Label Result_label2;
        private Button Update_button1;
        private Button Delete_button1;
    }
}
