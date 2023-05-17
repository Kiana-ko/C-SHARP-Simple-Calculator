namespace WinCalculator
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
            label5 = new Label();
            button6 = new Button();
            button10 = new Button();
            button13 = new Button();
            button14 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 218);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(450, 198);
            button6.Name = "button6";
            button6.Size = new Size(28, 20);
            button6.TabIndex = 13;
            button6.Text = "/";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button10
            // 
            button10.Location = new Point(484, 165);
            button10.Name = "button10";
            button10.Size = new Size(24, 23);
            button10.TabIndex = 25;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // button13
            // 
            button13.Location = new Point(450, 165);
            button13.Name = "button13";
            button13.Size = new Size(28, 23);
            button13.TabIndex = 22;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(484, 198);
            button14.Name = "button14";
            button14.Size = new Size(24, 20);
            button14.TabIndex = 21;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 201);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 27;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 28;
            textBox3.Text = " ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(535, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(138, 139);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Button button6;
        private Button button10;
        private Button button13;
        private Button button14;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
    }
}