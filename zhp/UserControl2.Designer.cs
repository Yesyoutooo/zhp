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
            előadásIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            premierDátumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            előadásokSzámaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            városDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kezdésIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            kezdésAdatokBindingSource = new BindingSource(components);
            évadIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            évadAdatokBindingSource = new BindingSource(components);
            rendezésIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            rendezésAdatokBindingSource = new BindingSource(components);
            operaIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            operaAdatokBindingSource = new BindingSource(components);
            előadáBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kezdésAdatokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)évadAdatokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendezésAdatokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)operaAdatokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)előadáBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { előadásIdDataGridViewTextBoxColumn, premierDátumDataGridViewTextBoxColumn, előadásokSzámaDataGridViewTextBoxColumn, városDataGridViewTextBoxColumn, kezdésIdDataGridViewTextBoxColumn, évadIdDataGridViewTextBoxColumn, rendezésIdDataGridViewTextBoxColumn, operaIdDataGridViewTextBoxColumn });
            dataGridView1.DataSource = előadáBindingSource;
            dataGridView1.Location = new Point(0, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(840, 515);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            kezdésIdDataGridViewTextBoxColumn.DataSource = kezdésAdatokBindingSource;
            kezdésIdDataGridViewTextBoxColumn.DisplayMember = "KezdésTípus";
            kezdésIdDataGridViewTextBoxColumn.HeaderText = "KezdésId";
            kezdésIdDataGridViewTextBoxColumn.Name = "kezdésIdDataGridViewTextBoxColumn";
            kezdésIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            kezdésIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            kezdésIdDataGridViewTextBoxColumn.ValueMember = "KezdésId";
            // 
            // kezdésAdatokBindingSource
            // 
            kezdésAdatokBindingSource.DataSource = typeof(Models.KezdésAdatok);
            // 
            // évadIdDataGridViewTextBoxColumn
            // 
            évadIdDataGridViewTextBoxColumn.DataPropertyName = "ÉvadId";
            évadIdDataGridViewTextBoxColumn.DataSource = évadAdatokBindingSource;
            évadIdDataGridViewTextBoxColumn.DisplayMember = "ÉvadMegnevezése";
            évadIdDataGridViewTextBoxColumn.HeaderText = "ÉvadId";
            évadIdDataGridViewTextBoxColumn.Name = "évadIdDataGridViewTextBoxColumn";
            évadIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            évadIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            évadIdDataGridViewTextBoxColumn.ValueMember = "ÉvadId";
            // 
            // évadAdatokBindingSource
            // 
            évadAdatokBindingSource.DataSource = typeof(Models.ÉvadAdatok);
            // 
            // rendezésIdDataGridViewTextBoxColumn
            // 
            rendezésIdDataGridViewTextBoxColumn.DataPropertyName = "RendezésId";
            rendezésIdDataGridViewTextBoxColumn.DataSource = rendezésAdatokBindingSource;
            rendezésIdDataGridViewTextBoxColumn.DisplayMember = "RendezésTípus";
            rendezésIdDataGridViewTextBoxColumn.HeaderText = "RendezésId";
            rendezésIdDataGridViewTextBoxColumn.Name = "rendezésIdDataGridViewTextBoxColumn";
            rendezésIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            rendezésIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            rendezésIdDataGridViewTextBoxColumn.ValueMember = "RendezésId";
            // 
            // rendezésAdatokBindingSource
            // 
            rendezésAdatokBindingSource.DataSource = typeof(Models.RendezésAdatok);
            // 
            // operaIdDataGridViewTextBoxColumn
            // 
            operaIdDataGridViewTextBoxColumn.DataPropertyName = "OperaId";
            operaIdDataGridViewTextBoxColumn.DataSource = operaAdatokBindingSource;
            operaIdDataGridViewTextBoxColumn.DisplayMember = "OperaCíme";
            operaIdDataGridViewTextBoxColumn.HeaderText = "OperaId";
            operaIdDataGridViewTextBoxColumn.Name = "operaIdDataGridViewTextBoxColumn";
            operaIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            operaIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            operaIdDataGridViewTextBoxColumn.ValueMember = "OperaId";
            // 
            // operaAdatokBindingSource
            // 
            operaAdatokBindingSource.DataSource = typeof(Models.OperaAdatok);
            // 
            // előadáBindingSource
            // 
            előadáBindingSource.DataSource = typeof(Models.Előadá);
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
            ((System.ComponentModel.ISupportInitialize)kezdésAdatokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)évadAdatokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendezésAdatokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)operaAdatokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)előadáBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource előadáBindingSource;
        private DataGridViewTextBoxColumn előadásIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn premierDátumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn előadásokSzámaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn városDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn kezdésIdDataGridViewTextBoxColumn;
        private BindingSource kezdésAdatokBindingSource;
        private DataGridViewComboBoxColumn évadIdDataGridViewTextBoxColumn;
        private BindingSource évadAdatokBindingSource;
        private DataGridViewComboBoxColumn rendezésIdDataGridViewTextBoxColumn;
        private BindingSource rendezésAdatokBindingSource;
        private DataGridViewComboBoxColumn operaIdDataGridViewTextBoxColumn;
        private BindingSource operaAdatokBindingSource;
    }
}
