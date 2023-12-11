namespace excel_prog
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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button1 = new Button();
            panel1 = new Panel();
            exitButton = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(140, 51);
            button1.TabIndex = 0;
            button1.Text = "Excel Generálás Panel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Location = new Point(158, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 353);
            panel1.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitButton.Location = new Point(12, 305);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 48);
            exitButton.TabIndex = 2;
            exitButton.Text = "Kilépés az alkalmazásból";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(12, 69);
            button2.Name = "button2";
            button2.Size = new Size(140, 73);
            button2.TabIndex = 3;
            button2.Text = "Adatok megjelenítése ListBoxban";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(12, 148);
            button3.Name = "button3";
            button3.Size = new Size(140, 73);
            button3.TabIndex = 4;
            button3.Text = "Adatok megjelenítése DataGridViewban";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 377);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private Panel panel1;
        private Button exitButton;
        private Button button2;
        private Button button3;
    }
}