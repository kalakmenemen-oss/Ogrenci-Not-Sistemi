namespace WinFormsApp2
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
            sayılar = new ListBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 179);
            button1.Name = "button1";
            button1.Size = new Size(78, 44);
            button1.TabIndex = 0;
            button1.Text = "buton";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // sayılar
            // 
            sayılar.FormattingEnabled = true;
            sayılar.Location = new Point(421, 149);
            sayılar.Name = "sayılar";
            sayılar.Size = new Size(130, 204);
            sayılar.TabIndex = 2;
            sayılar.SelectedIndexChanged += sayılar_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(sayılar);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox sayılar;
        private TextBox textBox2;
    }
}
