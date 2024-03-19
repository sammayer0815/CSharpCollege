namespace Opdracht_2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 90F);
            button1.Location = new Point(10, 90);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 90F);
            button2.Location = new Point(210, 90);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(200, 200);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Font = new Font("Segoe UI", 90F);
            button3.Location = new Point(410, 90);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(200, 200);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.Font = new Font("Segoe UI", 90F);
            button4.Location = new Point(9, 290);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(200, 200);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDarkDark;
            button5.Font = new Font("Segoe UI", 90F);
            button5.Location = new Point(212, 291);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(200, 200);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDarkDark;
            button6.Font = new Font("Segoe UI", 90F);
            button6.Location = new Point(410, 291);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(200, 200);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDarkDark;
            button7.Font = new Font("Segoe UI", 90F);
            button7.Location = new Point(9, 490);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(200, 200);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDarkDark;
            button8.Font = new Font("Segoe UI", 90F);
            button8.Location = new Point(212, 491);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(200, 200);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDarkDark;
            button9.Font = new Font("Segoe UI", 90F);
            button9.Location = new Point(412, 491);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(200, 200);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(225, 38);
            label1.TabIndex = 9;
            label1.Text = "Current player: X";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 695);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
    }
}
