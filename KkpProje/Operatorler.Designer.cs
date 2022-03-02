namespace KkpProje
{
    partial class Operatorler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operatorler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorTCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorTelefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet7 = new KkpProje.grupOdeviDataSet7();
            this.operatorlerTableAdapter = new KkpProje.grupOdeviDataSet7TableAdapters.OperatorlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatorIDDataGridViewTextBoxColumn,
            this.operatorTCNoDataGridViewTextBoxColumn,
            this.operatorAdDataGridViewTextBoxColumn,
            this.operatorYasDataGridViewTextBoxColumn,
            this.operatorTelefonNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operatorlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // operatorIDDataGridViewTextBoxColumn
            // 
            this.operatorIDDataGridViewTextBoxColumn.DataPropertyName = "OperatorID";
            this.operatorIDDataGridViewTextBoxColumn.HeaderText = "OperatorID";
            this.operatorIDDataGridViewTextBoxColumn.Name = "operatorIDDataGridViewTextBoxColumn";
            // 
            // operatorTCNoDataGridViewTextBoxColumn
            // 
            this.operatorTCNoDataGridViewTextBoxColumn.DataPropertyName = "OperatorTCNo";
            this.operatorTCNoDataGridViewTextBoxColumn.HeaderText = "OperatorTCNo";
            this.operatorTCNoDataGridViewTextBoxColumn.Name = "operatorTCNoDataGridViewTextBoxColumn";
            // 
            // operatorAdDataGridViewTextBoxColumn
            // 
            this.operatorAdDataGridViewTextBoxColumn.DataPropertyName = "OperatorAd";
            this.operatorAdDataGridViewTextBoxColumn.HeaderText = "OperatorAd";
            this.operatorAdDataGridViewTextBoxColumn.Name = "operatorAdDataGridViewTextBoxColumn";
            // 
            // operatorYasDataGridViewTextBoxColumn
            // 
            this.operatorYasDataGridViewTextBoxColumn.DataPropertyName = "OperatorYas";
            this.operatorYasDataGridViewTextBoxColumn.HeaderText = "OperatorYas";
            this.operatorYasDataGridViewTextBoxColumn.Name = "operatorYasDataGridViewTextBoxColumn";
            // 
            // operatorTelefonNoDataGridViewTextBoxColumn
            // 
            this.operatorTelefonNoDataGridViewTextBoxColumn.DataPropertyName = "OperatorTelefonNo";
            this.operatorTelefonNoDataGridViewTextBoxColumn.HeaderText = "OperatorTelefonNo";
            this.operatorTelefonNoDataGridViewTextBoxColumn.Name = "operatorTelefonNoDataGridViewTextBoxColumn";
            // 
            // operatorlerBindingSource
            // 
            this.operatorlerBindingSource.DataMember = "Operatorler";
            this.operatorlerBindingSource.DataSource = this.grupOdeviDataSet7;
            // 
            // grupOdeviDataSet7
            // 
            this.grupOdeviDataSet7.DataSetName = "grupOdeviDataSet7";
            this.grupOdeviDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorlerTableAdapter
            // 
            this.operatorlerTableAdapter.ClearBeforeFill = true;
            // 
            // Operatorler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 351);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operatorler";
            this.Text = "Operatörler";
            this.Load += new System.EventHandler(this.Operatorler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet7 grupOdeviDataSet7;
        private System.Windows.Forms.BindingSource operatorlerBindingSource;
        private grupOdeviDataSet7TableAdapters.OperatorlerTableAdapter operatorlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorTCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorTelefonNoDataGridViewTextBoxColumn;
    }
}