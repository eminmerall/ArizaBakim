namespace KkpProje
{
    partial class BakimTalepleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.talepNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezgahAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakimSebebiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arizaSeviyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakimTalebiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet9 = new KkpProje.grupOdeviDataSet9();
            this.bakimTalebiTableAdapter = new KkpProje.grupOdeviDataSet9TableAdapters.BakimTalebiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepNoDataGridViewTextBoxColumn,
            this.tezgahAdDataGridViewTextBoxColumn,
            this.bakimSebebiDataGridViewTextBoxColumn,
            this.operatorAdDataGridViewTextBoxColumn,
            this.arizaSeviyesiDataGridViewTextBoxColumn,
            this.talepTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bakimTalebiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // talepNoDataGridViewTextBoxColumn
            // 
            this.talepNoDataGridViewTextBoxColumn.DataPropertyName = "TalepNo";
            this.talepNoDataGridViewTextBoxColumn.HeaderText = "TalepNo";
            this.talepNoDataGridViewTextBoxColumn.Name = "talepNoDataGridViewTextBoxColumn";
            this.talepNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tezgahAdDataGridViewTextBoxColumn
            // 
            this.tezgahAdDataGridViewTextBoxColumn.DataPropertyName = "TezgahAd";
            this.tezgahAdDataGridViewTextBoxColumn.HeaderText = "TezgahAd";
            this.tezgahAdDataGridViewTextBoxColumn.Name = "tezgahAdDataGridViewTextBoxColumn";
            // 
            // bakimSebebiDataGridViewTextBoxColumn
            // 
            this.bakimSebebiDataGridViewTextBoxColumn.DataPropertyName = "BakimSebebi";
            this.bakimSebebiDataGridViewTextBoxColumn.HeaderText = "BakimSebebi";
            this.bakimSebebiDataGridViewTextBoxColumn.Name = "bakimSebebiDataGridViewTextBoxColumn";
            // 
            // operatorAdDataGridViewTextBoxColumn
            // 
            this.operatorAdDataGridViewTextBoxColumn.DataPropertyName = "OperatorAd";
            this.operatorAdDataGridViewTextBoxColumn.HeaderText = "OperatorAd";
            this.operatorAdDataGridViewTextBoxColumn.Name = "operatorAdDataGridViewTextBoxColumn";
            // 
            // arizaSeviyesiDataGridViewTextBoxColumn
            // 
            this.arizaSeviyesiDataGridViewTextBoxColumn.DataPropertyName = "ArizaSeviyesi";
            this.arizaSeviyesiDataGridViewTextBoxColumn.HeaderText = "ArizaSeviyesi";
            this.arizaSeviyesiDataGridViewTextBoxColumn.Name = "arizaSeviyesiDataGridViewTextBoxColumn";
            // 
            // talepTarihiDataGridViewTextBoxColumn
            // 
            this.talepTarihiDataGridViewTextBoxColumn.DataPropertyName = "TalepTarihi";
            this.talepTarihiDataGridViewTextBoxColumn.HeaderText = "TalepTarihi";
            this.talepTarihiDataGridViewTextBoxColumn.Name = "talepTarihiDataGridViewTextBoxColumn";
            // 
            // bakimTalebiBindingSource
            // 
            this.bakimTalebiBindingSource.DataMember = "BakimTalebi";
            this.bakimTalebiBindingSource.DataSource = this.grupOdeviDataSet9;
            // 
            // grupOdeviDataSet9
            // 
            this.grupOdeviDataSet9.DataSetName = "grupOdeviDataSet9";
            this.grupOdeviDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakimTalebiTableAdapter
            // 
            this.bakimTalebiTableAdapter.ClearBeforeFill = true;
            // 
            // BakimTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BakimTalepleri";
            this.Text = "Bakım Talepleri";
            this.Load += new System.EventHandler(this.BakimTalepleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet9 grupOdeviDataSet9;
        private System.Windows.Forms.BindingSource bakimTalebiBindingSource;
        private grupOdeviDataSet9TableAdapters.BakimTalebiTableAdapter bakimTalebiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezgahAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakimSebebiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arizaSeviyesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepTarihiDataGridViewTextBoxColumn;
    }
}