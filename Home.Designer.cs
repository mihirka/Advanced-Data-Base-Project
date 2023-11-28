namespace Shantir_Nir
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            richTextBox1 = new RichTextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.main_puppies_1280p;
            pictureBox1.Location = new Point(370, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(280, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Shantir Nir ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(370, 73);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 2;
            button1.Text = "Adopt A baby ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(492, 73);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 3;
            button2.Text = "Adopt A Pet ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(610, 73);
            button3.Name = "button3";
            button3.Size = new Size(154, 23);
            button3.TabIndex = 4;
            button3.Text = "Request For Rescue";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(541, 339);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Donate Us ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(50, 339);
            button5.Name = "button5";
            button5.Size = new Size(111, 23);
            button5.TabIndex = 6;
            button5.Text = "Be A Volunteer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.Location = new Point(31, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(250, 206);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(667, 12);
            button6.Name = "button6";
            button6.Size = new Size(121, 23);
            button6.TabIndex = 8;
            button6.Text = "Switch To Admin";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(richTextBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private RichTextBox richTextBox1;
        private Button button6;
    }
}