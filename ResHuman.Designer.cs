namespace Shantir_Nir
{
    partial class ResHuman
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
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(373, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 44;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 147);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(139, 15);
            label2.TabIndex = 42;
            label2.Text = "Contact Person's Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 203);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(58, 15);
            label6.TabIndex = 41;
            label6.Text = "Address : ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(344, 176);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 52);
            richTextBox1.TabIndex = 40;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 79);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(79, 15);
            label8.TabIndex = 39;
            label8.Text = "Person Type : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baby", "Old" });
            comboBox1.Location = new Point(344, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 105);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(137, 15);
            label1.TabIndex = 36;
            label1.Text = "Contact Person's Name :";
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
            // ResHuman
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
            Name = "ResHuman";
            Text = "ResHuman";
            Load += ResHuman_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label6;
        private RichTextBox richTextBox1;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}