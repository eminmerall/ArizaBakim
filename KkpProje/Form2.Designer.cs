namespace KkpProje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.talepNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevliBakimciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamParcaUcreti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataKaynagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periyodikBakimBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet13 = new KkpProje.grupOdeviDataSet13();
            this.periyodikBakimBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet5 = new KkpProje.grupOdeviDataSet5();
            this.periyodikBakimBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet4 = new KkpProje.grupOdeviDataSet4();
            this.periyodikBakimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupOdeviDataSet3 = new KkpProje.grupOdeviDataSet3();
            this.periyodikBakimTableAdapter = new KkpProje.grupOdeviDataSet3TableAdapters.PeriyodikBakimTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.periyodikBakimTableAdapter1 = new KkpProje.grupOdeviDataSet4TableAdapters.PeriyodikBakimTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.periyodikBakimTableAdapter2 = new KkpProje.grupOdeviDataSet5TableAdapters.PeriyodikBakimTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.periyodikBakimTableAdapter3 = new KkpProje.grupOdeviDataSet13TableAdapters.PeriyodikBakimTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakım Talebi Seç";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görevli Bakımcı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(310, 128);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(245, 24);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bitiş Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(310, 259);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(44, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(153, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Bakım Talebini Tamamla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(597, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepNoDataGridViewTextBoxColumn,
            this.gorevliBakimciDataGridViewTextBoxColumn,
            this.ToplamParcaUcreti,
            this.HataKaynagi,
            this.dataGridViewTextBoxColumn1,
            this.baslangicTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.periyodikBakimBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(153, 517);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 127);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // ToplamParcaUcreti
            // 
            this.ToplamParcaUcreti.DataPropertyName = "ToplamParcaUcreti";
            this.ToplamParcaUcreti.HeaderText = "ToplamParcaUcreti";
            this.ToplamParcaUcreti.Name = "ToplamParcaUcreti";
            // 
            // HataKaynagi
            // 
            this.HataKaynagi.DataPropertyName = "HataKaynagi";
            this.HataKaynagi.HeaderText = "HataKaynagi";
            this.HataKaynagi.Name = "HataKaynagi";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CezaUcreti";
            this.dataGridViewTextBoxColumn1.HeaderText = "CezaUcreti";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // periyodikBakimBindingSource3
            // 
            this.periyodikBakimBindingSource3.DataMember = "PeriyodikBakim";
            this.periyodikBakimBindingSource3.DataSource = this.grupOdeviDataSet13;
            // 
            // grupOdeviDataSet13
            // 
            this.grupOdeviDataSet13.DataSetName = "grupOdeviDataSet13";
            this.grupOdeviDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periyodikBakimBindingSource2
            // 
            this.periyodikBakimBindingSource2.DataMember = "PeriyodikBakim";
            this.periyodikBakimBindingSource2.DataSource = this.grupOdeviDataSet5;
            // 
            // grupOdeviDataSet5
            // 
            this.grupOdeviDataSet5.DataSetName = "grupOdeviDataSet5";
            this.grupOdeviDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periyodikBakimBindingSource1
            // 
            this.periyodikBakimBindingSource1.DataMember = "PeriyodikBakim";
            this.periyodikBakimBindingSource1.DataSource = this.grupOdeviDataSet4;
            // 
            // grupOdeviDataSet4
            // 
            this.grupOdeviDataSet4.DataSetName = "grupOdeviDataSet4";
            this.grupOdeviDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periyodikBakimBindingSource
            // 
            this.periyodikBakimBindingSource.DataMember = "PeriyodikBakim";
            this.periyodikBakimBindingSource.DataSource = this.grupOdeviDataSet3;
            // 
            // grupOdeviDataSet3
            // 
            this.grupOdeviDataSet3.DataSetName = "grupOdeviDataSet3";
            this.grupOdeviDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periyodikBakimTableAdapter
            // 
            this.periyodikBakimTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Pres Bıçakları";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Motor";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(126, 29);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Volan Dişli";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(27, 177);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(158, 29);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Kavrama Fren";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(27, 218);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(120, 29);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Krank Mili";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(224, 34);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(109, 29);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Kam Mili";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(224, 80);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(142, 29);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Işık Sensörü";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(224, 128);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(147, 29);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Emniyet Valfi";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(224, 177);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(90, 29);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Civata";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(224, 218);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(69, 29);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Yağ";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(128, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "Hesapla";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(618, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 457);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yedek Parçalar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 30);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(128, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 42);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sıfırla";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // periyodikBakimTableAdapter1
            // 
            this.periyodikBakimTableAdapter1.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(23, 406);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 60);
            this.button6.TabIndex = 22;
            this.button6.Text = "Ceza Ücretini Hesapla";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // periyodikBakimTableAdapter2
            // 
            this.periyodikBakimTableAdapter2.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(371, 753);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 38);
            this.button3.TabIndex = 24;
            this.button3.Text = "Rapor Sayfasına Giriş";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Hata Kaynağı";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bakımcı Firma",
            "Operatör"});
            this.comboBox2.Location = new System.Drawing.Point(310, 323);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 24);
            this.comboBox2.TabIndex = 26;
            // 
            // periyodikBakimTableAdapter3
            // 
            this.periyodikBakimTableAdapter3.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1060, 823);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Periyodik/Arıza Bakım";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periyodikBakimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupOdeviDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private grupOdeviDataSet3 grupOdeviDataSet3;
        private System.Windows.Forms.BindingSource periyodikBakimBindingSource;
        private grupOdeviDataSet3TableAdapters.PeriyodikBakimTableAdapter periyodikBakimTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private grupOdeviDataSet4 grupOdeviDataSet4;
        private System.Windows.Forms.BindingSource periyodikBakimBindingSource1;
        private grupOdeviDataSet4TableAdapters.PeriyodikBakimTableAdapter periyodikBakimTableAdapter1;
        private System.Windows.Forms.Button button6;
        private grupOdeviDataSet5 grupOdeviDataSet5;
        private System.Windows.Forms.BindingSource periyodikBakimBindingSource2;
        private grupOdeviDataSet5TableAdapters.PeriyodikBakimTableAdapter periyodikBakimTableAdapter2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private grupOdeviDataSet13 grupOdeviDataSet13;
        private System.Windows.Forms.BindingSource periyodikBakimBindingSource3;
        private grupOdeviDataSet13TableAdapters.PeriyodikBakimTableAdapter periyodikBakimTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevliBakimciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamParcaUcreti;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataKaynagi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}