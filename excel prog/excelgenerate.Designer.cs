namespace excel_prog
{
    partial class excelgenerate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            masodikTb = new TextBox();
            elsoTB = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 172);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 15;
            label4.Text = "Megjelenítendő utolsó kérdés";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 172);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 14;
            label3.Text = "Megjelenítendő 1. kérdés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 40);
            label2.Name = "label2";
            label2.Size = new Size(691, 20);
            label2.TabIndex = 13;
            label2.Text = "A két textboxban szűrhetővé válik a kérdésenként a helyes válasz, mely egy pontdiagramon jelenik meg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(463, 20);
            label1.TabIndex = 12;
            label1.Text = "Ez a uc a hajós adatbázis kérdéseit és válaszait jeleníti meg excelben";
            label1.Click += label1_Click;
            // 
            // masodikTb
            // 
            masodikTb.Location = new Point(452, 105);
            masodikTb.Name = "masodikTb";
            masodikTb.Size = new Size(94, 27);
            masodikTb.TabIndex = 11;
            // 
            // elsoTB
            // 
            elsoTB.Location = new Point(50, 127);
            elsoTB.Name = "elsoTB";
            elsoTB.Size = new Size(94, 27);
            elsoTB.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(236, 81);
            button1.Name = "button1";
            button1.Size = new Size(124, 51);
            button1.TabIndex = 9;
            button1.Text = "Excel Generálása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // excelgenerate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(masodikTb);
            Controls.Add(elsoTB);
            Controls.Add(button1);
            Name = "excelgenerate";
            Size = new Size(719, 242);
            Load += excelgenerate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox masodikTb;
        private TextBox elsoTB;
        private Button button1;
    }
}
