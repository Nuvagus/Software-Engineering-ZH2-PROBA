namespace excel_prog
{
    partial class listboxData
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
            tbNyersanyag = new TextBox();
            tbFogas = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // tbNyersanyag
            // 
            tbNyersanyag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNyersanyag.Location = new Point(22, 38);
            tbNyersanyag.Name = "tbNyersanyag";
            tbNyersanyag.Size = new Size(228, 27);
            tbNyersanyag.TabIndex = 0;
            tbNyersanyag.TextChanged += tbNyersanyag_TextChanged;
            // 
            // tbFogas
            // 
            tbFogas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbFogas.Location = new Point(455, 38);
            tbFogas.Name = "tbFogas";
            tbFogas.Size = new Size(228, 27);
            tbFogas.TabIndex = 1;
            tbFogas.TextChanged += tbFogas_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(22, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 264);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(455, 71);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(228, 264);
            listBox2.TabIndex = 3;
            // 
            // listboxData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(tbFogas);
            Controls.Add(tbNyersanyag);
            Name = "listboxData";
            Size = new Size(854, 460);
            Load += listboxData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNyersanyag;
        private TextBox tbFogas;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}
