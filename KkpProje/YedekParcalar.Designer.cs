namespace KkpProje
{
    partial class YedekParcalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YedekParcalar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yedekParcalarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yedekParcaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcaFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yedekParcalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet12 = new KkpProje.grupOdeviDataSet12();
            this.yedekParcalarTableAdapter = new KkpProje.grupOdeviDataSet12TableAdapters.YedekParcalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yedekParcalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yedekParcalarIDDataGridViewTextBoxColumn,
            this.yedekParcaAdiDataGridViewTextBoxColumn,
            this.parcaFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yedekParcalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // yedekParcalarIDDataGridViewTextBoxColumn
            // 
            this.yedekParcalarIDDataGridViewTextBoxColumn.DataPropertyName = "YedekParcalarID";
            this.yedekParcalarIDDataGridViewTextBoxColumn.HeaderText = "YedekParcalarID";
            this.yedekParcalarIDDataGridViewTextBoxColumn.Name = "yedekParcalarIDDataGridViewTextBoxColumn";
            // 
            // yedekParcaAdiDataGridViewTextBoxColumn
            // 
            this.yedekParcaAdiDataGridViewTextBoxColumn.DataPropertyName = "YedekParcaAdi";
            this.yedekParcaAdiDataGridViewTextBoxColumn.HeaderText = "YedekParcaAdi";
            this.yedekParcaAdiDataGridViewTextBoxColumn.Name = "yedekParcaAdiDataGridViewTextBoxColumn";
            // 
            // parcaFiyatiDataGridViewTextBoxColumn
            // 
            this.parcaFiyatiDataGridViewTextBoxColumn.DataPropertyName = "ParcaFiyati";
            this.parcaFiyatiDataGridViewTextBoxColumn.HeaderText = "ParcaFiyati";
            this.parcaFiyatiDataGridViewTextBoxColumn.Name = "parcaFiyatiDataGridViewTextBoxColumn";
            // 
            // yedekParcalarBindingSource
            // 
            this.yedekParcalarBindingSource.DataMember = "YedekParcalar";
            this.yedekParcalarBindingSource.DataSource = this.grupOdeviDataSet12;
            // 
            // grupOdeviDataSet12
            // 
            this.grupOdeviDataSet12.DataSetName = "grupOdeviDataSet12";
            this.grupOdeviDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yedekParcalarTableAdapter
            // 
            this.yedekParcalarTableAdapter.ClearBeforeFill = true;
            // 
            // YedekParcalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 320);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YedekParcalar";
            this.Text = "YedekParcalar";
            this.Load += new System.EventHandler(this.YedekParcalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yedekParcalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet12 grupOdeviDataSet12;
        private System.Windows.Forms.BindingSource yedekParcalarBindingSource;
        private grupOdeviDataSet12TableAdapters.YedekParcalarTableAdapter yedekParcalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yedekParcalarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yedekParcaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaFiyatiDataGridViewTextBoxColumn;
    }
}