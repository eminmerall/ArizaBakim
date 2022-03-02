namespace KkpProje
{
    partial class Bakımcılar
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
            this.bakiciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiciTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiciEPostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiciKisilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet8 = new KkpProje.grupOdeviDataSet8();
            this.bakiciKisilerTableAdapter = new KkpProje.grupOdeviDataSet8TableAdapters.BakiciKisilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakiciKisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bakiciIDDataGridViewTextBoxColumn,
            this.bakiciAdDataGridViewTextBoxColumn,
            this.bakiciTelNoDataGridViewTextBoxColumn,
            this.bakiciEPostaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bakiciKisilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // bakiciIDDataGridViewTextBoxColumn
            // 
            this.bakiciIDDataGridViewTextBoxColumn.DataPropertyName = "BakiciID";
            this.bakiciIDDataGridViewTextBoxColumn.HeaderText = "BakiciID";
            this.bakiciIDDataGridViewTextBoxColumn.Name = "bakiciIDDataGridViewTextBoxColumn";
            // 
            // bakiciAdDataGridViewTextBoxColumn
            // 
            this.bakiciAdDataGridViewTextBoxColumn.DataPropertyName = "BakiciAd";
            this.bakiciAdDataGridViewTextBoxColumn.HeaderText = "BakiciAd";
            this.bakiciAdDataGridViewTextBoxColumn.Name = "bakiciAdDataGridViewTextBoxColumn";
            // 
            // bakiciTelNoDataGridViewTextBoxColumn
            // 
            this.bakiciTelNoDataGridViewTextBoxColumn.DataPropertyName = "BakiciTelNo";
            this.bakiciTelNoDataGridViewTextBoxColumn.HeaderText = "BakiciTelNo";
            this.bakiciTelNoDataGridViewTextBoxColumn.Name = "bakiciTelNoDataGridViewTextBoxColumn";
            // 
            // bakiciEPostaDataGridViewTextBoxColumn
            // 
            this.bakiciEPostaDataGridViewTextBoxColumn.DataPropertyName = "BakiciEPosta";
            this.bakiciEPostaDataGridViewTextBoxColumn.HeaderText = "BakiciEPosta";
            this.bakiciEPostaDataGridViewTextBoxColumn.Name = "bakiciEPostaDataGridViewTextBoxColumn";
            // 
            // bakiciKisilerBindingSource
            // 
            this.bakiciKisilerBindingSource.DataMember = "BakiciKisiler";
            this.bakiciKisilerBindingSource.DataSource = this.grupOdeviDataSet8;
            // 
            // grupOdeviDataSet8
            // 
            this.grupOdeviDataSet8.DataSetName = "grupOdeviDataSet8";
            this.grupOdeviDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakiciKisilerTableAdapter
            // 
            this.bakiciKisilerTableAdapter.ClearBeforeFill = true;
            // 
            // Bakımcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 237);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bakımcılar";
            this.Text = "Bakımcılar";
            this.Load += new System.EventHandler(this.Bakımcılar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakiciKisilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet8 grupOdeviDataSet8;
        private System.Windows.Forms.BindingSource bakiciKisilerBindingSource;
        private grupOdeviDataSet8TableAdapters.BakiciKisilerTableAdapter bakiciKisilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiciTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiciEPostaDataGridViewTextBoxColumn;
    }
}