namespace ProjectMLA
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Coral;
            checkBox1.Location = new Point(143, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "דוריטוס";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.Coral;
            checkBox2.Location = new Point(143, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "ביסלי";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.Coral;
            checkBox3.Location = new Point(143, 85);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(56, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "במבה";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.Coral;
            checkBox4.Location = new Point(143, 110);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(55, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "צ'יפס";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(635, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "לתשלום";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = Color.Coral;
            checkBox5.Location = new Point(143, 136);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(96, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "שוקולד אגוזים";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = Color.DarkCyan;
            checkBox6.Location = new Point(143, 229);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(52, 19);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "קולה";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = Color.DarkCyan;
            checkBox7.Location = new Point(143, 254);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(57, 19);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "אקסל";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = Color.DarkCyan;
            checkBox8.Location = new Point(143, 279);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(85, 19);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "מיץ תפוזים ";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
    }
}