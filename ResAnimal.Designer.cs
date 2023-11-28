namespace Shantir_Nir
{
    partial class ResAnimal
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
            textBox1 = new TextBox();
            label1 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 116);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(137, 15);
            label1.TabIndex = 17;
            label1.Text = "Contact Person's Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 90);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(81, 15);
            label8.TabIndex = 30;
            label8.Text = "Animal Type : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cat", "Dog" });
            comboBox1.Location = new Point(341, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 214);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(58, 15);
            label6.TabIndex = 32;
            label6.Text = "Address : ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(341, 187);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 52);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 158);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(139, 15);
            label2.TabIndex = 33;
            label2.Text = "Contact Person's Phone :";
            // 
            // button1
            // 
            button1.Location = new Point(370, 279);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 35;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 320);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 47;
            button2.Text = "Back To Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ResAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ResAnimal";
            Text = "ResAnimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Label label8;
        private ComboBox comboBox1;
        private Label label6;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}