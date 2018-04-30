namespace ComputerGames.ForRedactor
{
    partial class PublisherDevsForm
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
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.computerGamesDataSet = new ComputerGames.ComputerGamesDataSet();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cGDataSet = new ComputerGames.CGDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.developersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.developersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.developersTableAdapter = new ComputerGames.CGDataSetTableAdapters.DevelopersTableAdapter();
            this.publisherDevsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherDevsTableAdapter = new ComputerGames.CGDataSetTableAdapters.PublisherDevsTableAdapter();
            this.publishersTableAdapter = new ComputerGames.CGDataSetTableAdapters.PublishersTableAdapter();
            this.developersTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.DevelopersTableAdapter();
            this.publishersTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.PublishersTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDevsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Gray;
            this.button6.Location = new System.Drawing.Point(414, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 29);
            this.button6.TabIndex = 31;
            this.button6.Text = "Показать все";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.publishersBindingSource2;
            this.comboBox3.DisplayMember = "name_";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(308, 21);
            this.comboBox3.TabIndex = 30;
            this.comboBox3.ValueMember = "id";
            // 
            // publishersBindingSource2
            // 
            this.publishersBindingSource2.DataMember = "Publishers";
            this.publishersBindingSource2.DataSource = this.computerGamesDataSet;
            // 
            // computerGamesDataSet
            // 
            this.computerGamesDataSet.DataSetName = "ComputerGamesDataSet";
            this.computerGamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.cGDataSet;
            // 
            // cGDataSet
            // 
            this.cGDataSet.DataSetName = "CGDataSet";
            this.cGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Firebrick;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(532, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 41);
            this.button5.TabIndex = 29;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Goldenrod;
            this.button4.Location = new System.Drawing.Point(326, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 28;
            this.button4.Text = "Просмотр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Goldenrod;
            this.button3.Location = new System.Drawing.Point(215, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(121, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.OliveDrab;
            this.button1.Location = new System.Drawing.Point(12, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(504, 227);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.publishersBindingSource1;
            this.comboBox2.DisplayMember = "name_";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(258, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "id";
            // 
            // publishersBindingSource1
            // 
            this.publishersBindingSource1.DataMember = "Publishers";
            this.publishersBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.developersBindingSource1;
            this.comboBox1.DisplayMember = "name_";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "id";
            // 
            // developersBindingSource1
            // 
            this.developersBindingSource1.DataMember = "Developers";
            this.developersBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // developersBindingSource
            // 
            this.developersBindingSource.DataMember = "Developers";
            this.developersBindingSource.DataSource = this.cGDataSet;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 50);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Издатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Разработчик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // developersTableAdapter
            // 
            this.developersTableAdapter.ClearBeforeFill = true;
            // 
            // publisherDevsBindingSource
            // 
            this.publisherDevsBindingSource.DataMember = "PublisherDevs";
            this.publisherDevsBindingSource.DataSource = this.cGDataSet;
            // 
            // publisherDevsTableAdapter
            // 
            this.publisherDevsTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // developersTableAdapter1
            // 
            this.developersTableAdapter1.ClearBeforeFill = true;
            // 
            // publishersTableAdapter1
            // 
            this.publishersTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Поиск по издателю ";
            // 
            // PublisherDevsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 426);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PublisherDevsForm";
            this.Text = "Издатели и разработчики";
            this.Load += new System.EventHandler(this.PublisherDevsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDevsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CGDataSet cGDataSet;
        private System.Windows.Forms.BindingSource developersBindingSource;
        private CGDataSetTableAdapters.DevelopersTableAdapter developersTableAdapter;
        private System.Windows.Forms.BindingSource publisherDevsBindingSource;
        private CGDataSetTableAdapters.PublisherDevsTableAdapter publisherDevsTableAdapter;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private CGDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private ComputerGamesDataSet computerGamesDataSet;
        private System.Windows.Forms.BindingSource developersBindingSource1;
        private ComputerGamesDataSetTableAdapters.DevelopersTableAdapter developersTableAdapter1;
        private System.Windows.Forms.BindingSource publishersBindingSource1;
        private ComputerGamesDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter1;
        private System.Windows.Forms.BindingSource publishersBindingSource2;
        private System.Windows.Forms.Label label5;
    }
}