namespace KkpProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.bakimTalebiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet = new KkpProje.grupOdeviDataSet();
            this.bakimTalebiTableAdapter = new KkpProje.grupOdeviDataSetTableAdapters.BakimTalebiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TalepNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezgahAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakimSebebiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arizaSeviyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakimTalebiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet2 = new KkpProje.grupOdeviDataSet2();
            this.bakimTalebiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet1 = new KkpProje.grupOdeviDataSet1();
            this.bakimTalebiTableAdapter1 = new KkpProje.grupOdeviDataSet1TableAdapters.BakimTalebiTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.bakimTalebiTableAdapter2 = new KkpProje.grupOdeviDataSet2TableAdapters.BakimTalebiTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tezgah";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bakım Sebebi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arızayı Bildiren Operatör";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arıza Seviyesi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(307, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Periyodik",
            "Arıza"});
            this.comboBox2.Location = new System.Drawing.Point(307, 109);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(307, 165);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Çok Acil",
            "Acil",
            "Normal"});
            this.comboBox4.Location = new System.Drawing.Point(307, 225);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(217, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Talep Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(307, 281);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(56, 561);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Talebi Bildir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bakimTalebiBindingSource
            // 
            this.bakimTalebiBindingSource.DataMember = "BakimTalebi";
            this.bakimTalebiBindingSource.DataSource = this.grupOdeviDataSet;
            // 
            // grupOdeviDataSet
            // 
            this.grupOdeviDataSet.DataSetName = "grupOdeviDataSet";
            this.grupOdeviDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakimTalebiTableAdapter
            // 
            this.bakimTalebiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TalepNo,
            this.tezgahAdDataGridViewTextBoxColumn,
            this.bakimSebebiDataGridViewTextBoxColumn,
            this.operatorAdDataGridViewTextBoxColumn,
            this.arizaSeviyesiDataGridViewTextBoxColumn,
            this.talepTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bakimTalebiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(56, 357);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 143);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TalepNo
            // 
            this.TalepNo.DataPropertyName = "TalepNo";
            this.TalepNo.HeaderText = "TalepNo";
            this.TalepNo.Name = "TalepNo";
            this.TalepNo.ReadOnly = true;
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
            // bakimTalebiBindingSource2
            // 
            this.bakimTalebiBindingSource2.DataMember = "BakimTalebi";
            this.bakimTalebiBindingSource2.DataSource = this.grupOdeviDataSet2;
            // 
            // grupOdeviDataSet2
            // 
            this.grupOdeviDataSet2.DataSetName = "grupOdeviDataSet2";
            this.grupOdeviDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakimTalebiBindingSource1
            // 
            this.bakimTalebiBindingSource1.DataMember = "BakimTalebi";
            this.bakimTalebiBindingSource1.DataSource = this.grupOdeviDataSet1;
            // 
            // grupOdeviDataSet1
            // 
            this.grupOdeviDataSet1.DataSetName = "grupOdeviDataSet1";
            this.grupOdeviDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakimTalebiTableAdapter1
            // 
            this.bakimTalebiTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(449, 561);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bakimTalebiTableAdapter2
            // 
            this.bakimTalebiTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(242, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Rapor Sayfasına Giriş";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(762, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Bakım Talebi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakimTalebiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private grupOdeviDataSet grupOdeviDataSet;
        private System.Windows.Forms.BindingSource bakimTalebiBindingSource;
        private grupOdeviDataSetTableAdapters.BakimTalebiTableAdapter bakimTalebiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet1 grupOdeviDataSet1;
        private System.Windows.Forms.BindingSource bakimTalebiBindingSource1;
        private grupOdeviDataSet1TableAdapters.BakimTalebiTableAdapter bakimTalebiTableAdapter1;
        private System.Windows.Forms.Button button3;
        private grupOdeviDataSet2 grupOdeviDataSet2;
        private System.Windows.Forms.BindingSource bakimTalebiBindingSource2;
        private grupOdeviDataSet2TableAdapters.BakimTalebiTableAdapter bakimTalebiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalepNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezgahAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakimSebebiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arizaSeviyesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

