namespace ComputerGames.ForRedactor
{
    partial class GamesForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ageLimitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computerGamesDataSet = new ComputerGames.ComputerGamesDataSet();
            this.ageLimitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cGDataSet = new ComputerGames.CGDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.genresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.storesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.cGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageLimitsTableAdapter = new ComputerGames.CGDataSetTableAdapters.AgeLimitsTableAdapter();
            this.genresTableAdapter = new ComputerGames.CGDataSetTableAdapters.GenresTableAdapter();
            this.publishersTableAdapter = new ComputerGames.CGDataSetTableAdapters.PublishersTableAdapter();
            this.storesTableAdapter = new ComputerGames.CGDataSetTableAdapters.StoresTableAdapter();
            this.ageLimitsTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.AgeLimitsTableAdapter();
            this.genresTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.GenresTableAdapter();
            this.publishersTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.PublishersTableAdapter();
            this.storesTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.StoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(87, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(770, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ageLimitsBindingSource1;
            this.comboBox1.DisplayMember = "type_";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id";
            // 
            // ageLimitsBindingSource1
            // 
            this.ageLimitsBindingSource1.DataMember = "AgeLimits";
            this.ageLimitsBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // computerGamesDataSet
            // 
            this.computerGamesDataSet.DataSetName = "ComputerGamesDataSet";
            this.computerGamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ageLimitsBindingSource
            // 
            this.ageLimitsBindingSource.DataMember = "AgeLimits";
            this.ageLimitsBindingSource.DataSource = this.cGDataSet;
            // 
            // cGDataSet
            // 
            this.cGDataSet.DataSetName = "CGDataSet";
            this.cGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.genresBindingSource1;
            this.comboBox2.DisplayMember = "genre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(389, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "id";
            // 
            // genresBindingSource1
            // 
            this.genresBindingSource1.DataMember = "Genres";
            this.genresBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.cGDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.publishersBindingSource1;
            this.comboBox3.DisplayMember = "name_";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(516, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "id";
            // 
            // publishersBindingSource1
            // 
            this.publishersBindingSource1.DataMember = "Publishers";
            this.publishersBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.cGDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.storesBindingSource1;
            this.comboBox4.DisplayMember = "name_";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(643, 70);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.ValueMember = "id";
            // 
            // storesBindingSource1
            // 
            this.storesBindingSource1.DataMember = "Stores";
            this.storesBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.cGDataSet;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(876, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.OliveDrab;
            this.button1.Location = new System.Drawing.Point(22, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(146, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Goldenrod;
            this.button3.Location = new System.Drawing.Point(272, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Размер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Возрастное ограничение";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Жанр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Издатель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Магазин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(892, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Дата выпуска";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Поиск по названию игры";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(22, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 20);
            this.textBox6.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Goldenrod;
            this.button4.Location = new System.Drawing.Point(272, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 23;
            this.button4.Text = "Просмотр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(981, 199);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Firebrick;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(876, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 47);
            this.button5.TabIndex = 25;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cGDataSetBindingSource
            // 
            this.cGDataSetBindingSource.DataSource = this.cGDataSet;
            this.cGDataSetBindingSource.Position = 0;
            // 
            // ageLimitsTableAdapter
            // 
            this.ageLimitsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // ageLimitsTableAdapter1
            // 
            this.ageLimitsTableAdapter1.ClearBeforeFill = true;
            // 
            // genresTableAdapter1
            // 
            this.genresTableAdapter1.ClearBeforeFill = true;
            // 
            // publishersTableAdapter1
            // 
            this.publishersTableAdapter1.ClearBeforeFill = true;
            // 
            // storesTableAdapter1
            // 
            this.storesTableAdapter1.ClearBeforeFill = true;
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "GamesForm";
            this.Text = "Игры";
            this.Load += new System.EventHandler(this.GamesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource cGDataSetBindingSource;
        private CGDataSet cGDataSet;
        private System.Windows.Forms.BindingSource ageLimitsBindingSource;
        private CGDataSetTableAdapters.AgeLimitsTableAdapter ageLimitsTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private CGDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private CGDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private CGDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private ComputerGamesDataSet computerGamesDataSet;
        private System.Windows.Forms.BindingSource ageLimitsBindingSource1;
        private ComputerGamesDataSetTableAdapters.AgeLimitsTableAdapter ageLimitsTableAdapter1;
        private System.Windows.Forms.BindingSource genresBindingSource1;
        private ComputerGamesDataSetTableAdapters.GenresTableAdapter genresTableAdapter1;
        private System.Windows.Forms.BindingSource publishersBindingSource1;
        private ComputerGamesDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter1;
        private System.Windows.Forms.BindingSource storesBindingSource1;
        private ComputerGamesDataSetTableAdapters.StoresTableAdapter storesTableAdapter1;
    }
}