namespace zhp
{
    partial class UserControl2
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
            előadáBindingSource = new BindingSource(components);
            előadásIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            premierDátumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            előadásokSzámaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            városDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kezdésIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            évadIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendezésIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            operaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kezdésDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            operaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendezésDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            városNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            évadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)előadáBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { előadásIdDataGridViewTextBoxColumn, premierDátumDataGridViewTextBoxColumn, előadásokSzámaDataGridViewTextBoxColumn, városDataGridViewTextBoxColumn, kezdésIdDataGridViewTextBoxColumn, évadIdDataGridViewTextBoxColumn, rendezésIdDataGridViewTextBoxColumn, operaIdDataGridViewTextBoxColumn, kezdésDataGridViewTextBoxColumn, operaDataGridViewTextBoxColumn, rendezésDataGridViewTextBoxColumn, városNavigationDataGridViewTextBoxColumn, évadDataGridViewTextBoxColumn });
            dataGridView1.DataSource = előadáBindingSource;
            dataGridView1.Location = new Point(97, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(740, 515);
            dataGridView1.TabIndex = 0;
            // 
            // előadáBindingSource
            // 
            előadáBindingSource.DataSource = typeof(Models.Előadá);
            // 
            // előadásIdDataGridViewTextBoxColumn
            // 
            előadásIdDataGridViewTextBoxColumn.DataPropertyName = "ElőadásId";
            előadásIdDataGridViewTextBoxColumn.HeaderText = "ElőadásId";
            előadásIdDataGridViewTextBoxColumn.Name = "előadásIdDataGridViewTextBoxColumn";
            // 
            // premierDátumDataGridViewTextBoxColumn
            // 
            premierDátumDataGridViewTextBoxColumn.DataPropertyName = "PremierDátum";
            premierDátumDataGridViewTextBoxColumn.HeaderText = "PremierDátum";
            premierDátumDataGridViewTextBoxColumn.Name = "premierDátumDataGridViewTextBoxColumn";
            // 
            // előadásokSzámaDataGridViewTextBoxColumn
            // 
            előadásokSzámaDataGridViewTextBoxColumn.DataPropertyName = "ElőadásokSzáma";
            előadásokSzámaDataGridViewTextBoxColumn.HeaderText = "ElőadásokSzáma";
            előadásokSzámaDataGridViewTextBoxColumn.Name = "előadásokSzámaDataGridViewTextBoxColumn";
            // 
            // városDataGridViewTextBoxColumn
            // 
            városDataGridViewTextBoxColumn.DataPropertyName = "Város";
            városDataGridViewTextBoxColumn.HeaderText = "Város";
            városDataGridViewTextBoxColumn.Name = "városDataGridViewTextBoxColumn";
            // 
            // kezdésIdDataGridViewTextBoxColumn
            // 
            kezdésIdDataGridViewTextBoxColumn.DataPropertyName = "KezdésId";
            kezdésIdDataGridViewTextBoxColumn.HeaderText = "KezdésId";
            kezdésIdDataGridViewTextBoxColumn.Name = "kezdésIdDataGridViewTextBoxColumn";
            // 
            // évadIdDataGridViewTextBoxColumn
            // 
            évadIdDataGridViewTextBoxColumn.DataPropertyName = "ÉvadId";
            évadIdDataGridViewTextBoxColumn.HeaderText = "ÉvadId";
            évadIdDataGridViewTextBoxColumn.Name = "évadIdDataGridViewTextBoxColumn";
            // 
            // rendezésIdDataGridViewTextBoxColumn
            // 
            rendezésIdDataGridViewTextBoxColumn.DataPropertyName = "RendezésId";
            rendezésIdDataGridViewTextBoxColumn.HeaderText = "RendezésId";
            rendezésIdDataGridViewTextBoxColumn.Name = "rendezésIdDataGridViewTextBoxColumn";
            // 
            // operaIdDataGridViewTextBoxColumn
            // 
            operaIdDataGridViewTextBoxColumn.DataPropertyName = "OperaId";
            operaIdDataGridViewTextBoxColumn.HeaderText = "OperaId";
            operaIdDataGridViewTextBoxColumn.Name = "operaIdDataGridViewTextBoxColumn";
            // 
            // kezdésDataGridViewTextBoxColumn
            // 
            kezdésDataGridViewTextBoxColumn.DataPropertyName = "Kezdés";
            kezdésDataGridViewTextBoxColumn.HeaderText = "Kezdés";
            kezdésDataGridViewTextBoxColumn.Name = "kezdésDataGridViewTextBoxColumn";
            // 
            // operaDataGridViewTextBoxColumn
            // 
            operaDataGridViewTextBoxColumn.DataPropertyName = "Opera";
            operaDataGridViewTextBoxColumn.HeaderText = "Opera";
            operaDataGridViewTextBoxColumn.Name = "operaDataGridViewTextBoxColumn";
            // 
            // rendezésDataGridViewTextBoxColumn
            // 
            rendezésDataGridViewTextBoxColumn.DataPropertyName = "Rendezés";
            rendezésDataGridViewTextBoxColumn.HeaderText = "Rendezés";
            rendezésDataGridViewTextBoxColumn.Name = "rendezésDataGridViewTextBoxColumn";
            // 
            // városNavigationDataGridViewTextBoxColumn
            // 
            városNavigationDataGridViewTextBoxColumn.DataPropertyName = "VárosNavigation";
            városNavigationDataGridViewTextBoxColumn.HeaderText = "VárosNavigation";
            városNavigationDataGridViewTextBoxColumn.Name = "városNavigationDataGridViewTextBoxColumn";
            // 
            // évadDataGridViewTextBoxColumn
            // 
            évadDataGridViewTextBoxColumn.DataPropertyName = "Évad";
            évadDataGridViewTextBoxColumn.HeaderText = "Évad";
            évadDataGridViewTextBoxColumn.Name = "évadDataGridViewTextBoxColumn";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(840, 593);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)előadáBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn előadásIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn premierDátumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn előadásokSzámaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn városDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kezdésIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn évadIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendezésIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kezdésDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendezésDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn városNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn évadDataGridViewTextBoxColumn;
        private BindingSource előadáBindingSource;
    }
}
