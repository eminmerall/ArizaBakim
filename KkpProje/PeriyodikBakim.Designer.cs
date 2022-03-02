namespace KkpProje
{
    partial class PeriyodikBakim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriyodikBakim));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.talepNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevliBakimciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamParcaUcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataKaynagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cezaUcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periyodikBakimBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet14 = new KkpProje.grupOdeviDataSet14();
            this.periyodikBakimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet10 = new KkpProje.grupOdeviDataSet10();
            this.periyodikBakimTableAdapter = new KkpProje.grupOdeviDataSet10TableAdapters.PeriyodikBakimTableAdapter();
            this.periyodikBakimTableAdapter1 = new KkpProje.grupOdeviDataSet14TableAdapters.PeriyodikBakimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepNoDataGridViewTextBoxColumn,
            this.gorevliBakimciDataGridViewTextBoxColumn,
            this.toplamParcaUcretiDataGridViewTextBoxColumn,
            this.HataKaynagi,
            this.cezaUcretiDataGridViewTextBoxColumn,
            this.baslangicTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.periyodikBakimBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // talepNoDataGridViewTextBoxColumn
            // 
            this.talepNoDataGridViewTextBoxColumn.DataPropertyName = "TalepNo";
            this.talepNoDataGridViewTextBoxColumn.HeaderText = "TalepNo";
            this.talepNoDataGridViewTextBoxColumn.Name = "talepNoDataGridViewTextBoxColumn";
            // 
            // gorevliBakimciDataGridViewTextBoxColumn
            // 
            this.gorevliBakimciDataGridViewTextBoxColumn.DataPropertyName = "GorevliBakimci";
            this.gorevliBakimciDataGridViewTextBoxColumn.HeaderText = "GorevliBakimci";
            this.gorevliBakimciDataGridViewTextBoxColumn.Name = "gorevliBakimciDataGridViewTextBoxColumn";
            // 
            // toplamParcaUcretiDataGridViewTextBoxColumn
            // 
            this.toplamParcaUcretiDataGridViewTextBoxColumn.DataPropertyName = "ToplamParcaUcreti";
            this.toplamParcaUcretiDataGridViewTextBoxColumn.HeaderText = "ToplamParcaUcreti";
            this.toplamParcaUcretiDataGridViewTextBoxColumn.Name = "toplamParcaUcretiDataGridViewTextBoxColumn";
            // 
            // HataKaynagi
            // 
            this.HataKaynagi.DataPropertyName = "HataKaynagi";
            this.HataKaynagi.HeaderText = "HataKaynagi";
            this.HataKaynagi.Name = "HataKaynagi";
            // 
            // cezaUcretiDataGridViewTextBoxColumn
            // 
            this.cezaUcretiDataGridViewTextBoxColumn.DataPropertyName = "CezaUcreti";
            this.cezaUcretiDataGridViewTextBoxColumn.HeaderText = "CezaUcreti";
            this.cezaUcretiDataGridViewTextBoxColumn.Name = "cezaUcretiDataGridViewTextBoxColumn";
            // 
            // baslangicTarihiDataGridViewTextBoxColumn
            // 
            this.baslangicTarihiDataGridViewTextBoxColumn.DataPropertyName = "BaslangicTarihi";
            this.baslangicTarihiDataGridViewTextBoxColumn.HeaderText = "BaslangicTarihi";
            this.baslangicTarihiDataGridViewTextBoxColumn.Name = "baslangicTarihiDataGridViewTextBoxColumn";
            // 
            // bitisTarihiDataGridViewTextBoxColumn
            // 
            this.bitisTarihiDataGridViewTextBoxColumn.DataPropertyName = "BitisTarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.HeaderText = "BitisTarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.Name = "bitisTarihiDataGridViewTextBoxColumn";
            // 
            // periyodikBakimBindingSource1
            // 
            this.periyodikBakimBindingSource1.DataMember = "PeriyodikBakim";
            this.periyodikBakimBindingSource1.DataSource = this.grupOdeviDataSet14;
            // 
            // grupOdeviDataSet14
            // 
            this.grupOdeviDataSet14.DataSetName = "grupOdeviDataSet14";
            this.grupOdeviDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periyodikBakimBindingSource
            // 
            this.periyodikBakimBindingSource.DataMember = "PeriyodikBakim";
            this.periyodikBakimBindingSource.DataSource = this.grupOdeviDataSet10;
            // 
            // grupOdeviDataSet10
            // 
            this.grupOdeviDataSet10.DataSetName = "grupOdeviDataSet10";
            this.grupOdeviDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periyodikBakimTableAdapter
            // 
            this.periyodikBakimTableAdapter.ClearBeforeFill = true;
            // 
            // periyodikBakimTableAdapter1
            // 
            this.periyodikBakimTableAdapter1.ClearBeforeFill = true;
            // 
            // PeriyodikBakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 250);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeriyodikBakim";
            this.Text = "Tamamlanmış Bakımlar";
            this.Load += new System.EventHandler(this.PeriyodikBakim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet10 grupOdeviDataSet10;
        private System.Windows.Forms.BindingSource periyodikBakimBindingSource;
        private grupOdeviDataSet10TableAdapters.PeriyodikBakimTableAdapter periyodikBakimTableAdapter;
        private grupOdeviDataSet14 grupOdeviDataSet14;
        private System.Windows.Forms.BindingSource periyodikBakimBindingSource1;
        private grupOdeviDataSet14TableAdapters.PeriyodikBakimTableAdapter periyodikBakimTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevliBakimciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamParcaUcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataKaynagi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cezaUcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
    }
}