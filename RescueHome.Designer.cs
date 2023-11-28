namespace Shantir_Nir
{
    partial class RescueHome
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
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(330, 257);
            button1.Name = "button1";
            button1.Size = new Size(169, 23);
            button1.TabIndex = 0;
            button1.Text = "Back To Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(143, 150);
            button2.Name = "button2";
            button2.Size = new Size(188, 23);
            button2.TabIndex = 1;
            button2.Text = "Request For A Human Rescue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(404, 150);
            button3.Name = "button3";
            button3.Size = new Size(193, 23);
            button3.TabIndex = 2;
            button3.Text = "Resuest For an Animal Rescue";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RescueHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RescueHome";
            Text = "RescueHome";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}