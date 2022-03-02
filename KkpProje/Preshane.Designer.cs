namespace KkpProje
{
    partial class Preshane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preshane));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.presTezgahiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezgahAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preshaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet11 = new KkpProje.grupOdeviDataSet11();
            this.preshaneTableAdapter = new KkpProje.grupOdeviDataSet11TableAdapters.PreshaneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preshaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.presTezgahiNoDataGridViewTextBoxColumn,
            this.operatorIDDataGridViewTextBoxColumn,
            this.tezgahAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.preshaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // presTezgahiNoDataGridViewTextBoxColumn
            // 
            this.presTezgahiNoDataGridViewTextBoxColumn.DataPropertyName = "PresTezgahiNo";
            this.presTezgahiNoDataGridViewTextBoxColumn.HeaderText = "PresTezgahiNo";
            this.presTezgahiNoDataGridViewTextBoxColumn.Name = "presTezgahiNoDataGridViewTextBoxColumn";
            // 
            // operatorIDDataGridViewTextBoxColumn
            // 
            this.operatorIDDataGridViewTextBoxColumn.DataPropertyName = "OperatorID";
            this.operatorIDDataGridViewTextBoxColumn.HeaderText = "OperatorID";
            this.operatorIDDataGridViewTextBoxColumn.Name = "operatorIDDataGridViewTextBoxColumn";
            // 
            // tezgahAdDataGridViewTextBoxColumn
            // 
            this.tezgahAdDataGridViewTextBoxColumn.DataPropertyName = "TezgahAd";
            this.tezgahAdDataGridViewTextBoxColumn.HeaderText = "TezgahAd";
            this.tezgahAdDataGridViewTextBoxColumn.Name = "tezgahAdDataGridViewTextBoxColumn";
            // 
            // preshaneBindingSource
            // 
            this.preshaneBindingSource.DataMember = "Preshane";
            this.preshaneBindingSource.DataSource = this.grupOdeviDataSet11;
            // 
            // grupOdeviDataSet11
            // 
            this.grupOdeviDataSet11.DataSetName = "grupOdeviDataSet11";
            this.grupOdeviDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preshaneTableAdapter
            // 
            this.preshaneTableAdapter.ClearBeforeFill = true;
            // 
            // Preshane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 432);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preshane";
            this.Text = "Preshane";
            this.Load += new System.EventHandler(this.Preshane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preshaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet11 grupOdeviDataSet11;
        private System.Windows.Forms.BindingSource preshaneBindingSource;
        private grupOdeviDataSet11TableAdapters.PreshaneTableAdapter preshaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn presTezgahiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezgahAdDataGridViewTextBoxColumn;
    }
}