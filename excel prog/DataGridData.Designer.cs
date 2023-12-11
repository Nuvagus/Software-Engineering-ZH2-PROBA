namespace excel_prog
{
    partial class DataGridData
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            receptekBindingSource = new BindingSource(components);
            receptIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fogasIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiseg4foDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fogasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receptekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { receptIdDataGridViewTextBoxColumn, fogasIdDataGridViewTextBoxColumn, nyersanyagIdDataGridViewTextBoxColumn, mennyiseg4foDataGridViewTextBoxColumn, fogasDataGridViewTextBoxColumn, nyersanyagDataGridViewTextBoxColumn });
            dataGridView1.DataSource = receptekBindingSource;
            dataGridView1.Location = new Point(15, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 231);
            dataGridView1.TabIndex = 0;
            // 
            // receptekBindingSource
            // 
            receptekBindingSource.DataSource = typeof(Models.Receptek);
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            receptIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            receptIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            fogasIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            fogasIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            nyersanyagIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            nyersanyagIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg4fo";
            mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg4fo";
            mennyiseg4foDataGridViewTextBoxColumn.MinimumWidth = 6;
            mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            mennyiseg4foDataGridViewTextBoxColumn.Width = 125;
            // 
            // fogasDataGridViewTextBoxColumn
            // 
            fogasDataGridViewTextBoxColumn.DataPropertyName = "Fogas";
            fogasDataGridViewTextBoxColumn.HeaderText = "Fogas";
            fogasDataGridViewTextBoxColumn.MinimumWidth = 6;
            fogasDataGridViewTextBoxColumn.Name = "fogasDataGridViewTextBoxColumn";
            fogasDataGridViewTextBoxColumn.Width = 125;
            // 
            // nyersanyagDataGridViewTextBoxColumn
            // 
            nyersanyagDataGridViewTextBoxColumn.DataPropertyName = "Nyersanyag";
            nyersanyagDataGridViewTextBoxColumn.HeaderText = "Nyersanyag";
            nyersanyagDataGridViewTextBoxColumn.MinimumWidth = 6;
            nyersanyagDataGridViewTextBoxColumn.Name = "nyersanyagDataGridViewTextBoxColumn";
            nyersanyagDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataGridData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "DataGridData";
            Size = new Size(702, 294);
            Load += DataGridData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)receptekBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagDataGridViewTextBoxColumn;
        private BindingSource receptekBindingSource;
    }
}
