namespace ComputerGames.ForRedactor
{
    partial class GamesPlatformsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gamesBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.computerGamesDataSet = new ComputerGames.ComputerGamesDataSet();
            this.gamesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cGDataSet = new ComputerGames.CGDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.platformsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.platformsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.platformsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.gamesBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamePlatformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamePlatformTableAdapter = new ComputerGames.CGDataSetTableAdapters.GamePlatformTableAdapter();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new ComputerGames.CGDataSetTableAdapters.GamesTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.platformsTableAdapter = new ComputerGames.CGDataSetTableAdapters.PlatformsTableAdapter();
            this.gamesTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.GamesTableAdapter();
            this.platformsTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.PlatformsTableAdapter();
            this.gamesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.platformsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gamePlatformBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamePlatformTableAdapter1 = new ComputerGames.ComputerGamesDataSetTableAdapters.GamePlatformTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlatformBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlatformBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Платформа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Описание";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 50);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gamesBindingSource6;
            this.comboBox1.DisplayMember = "name_";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gamesBindingSource6
            // 
            this.gamesBindingSource6.DataMember = "Games";
            this.gamesBindingSource6.DataSource = this.computerGamesDataSet;
            // 
            // computerGamesDataSet
            // 
            this.computerGamesDataSet.DataSetName = "ComputerGamesDataSet";
            this.computerGamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource3
            // 
            this.gamesBindingSource3.DataMember = "Games";
            this.gamesBindingSource3.DataSource = this.computerGamesDataSet;
            // 
            // gamesBindingSource2
            // 
            this.gamesBindingSource2.DataMember = "Games";
            this.gamesBindingSource2.DataSource = this.cGDataSet;
            // 
            // cGDataSet
            // 
            this.cGDataSet.DataSetName = "CGDataSet";
            this.cGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.platformsBindingSource2;
            this.comboBox2.DisplayMember = "name_";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(259, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "id";
            // 
            // platformsBindingSource2
            // 
            this.platformsBindingSource2.DataMember = "Platforms";
            this.platformsBindingSource2.DataSource = this.computerGamesDataSet;
            // 
            // platformsBindingSource1
            // 
            this.platformsBindingSource1.DataMember = "Platforms";
            this.platformsBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // platformsBindingSource
            // 
            this.platformsBindingSource.DataMember = "Platforms";
            this.platformsBindingSource.DataSource = this.cGDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(504, 227);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.OliveDrab;
            this.button1.Location = new System.Drawing.Point(13, 93);
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
            this.button2.Location = new System.Drawing.Point(122, 93);
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
            this.button3.Location = new System.Drawing.Point(216, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Goldenrod;
            this.button4.Location = new System.Drawing.Point(327, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "Просмотр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Firebrick;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(533, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 41);
            this.button5.TabIndex = 13;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.gamesBindingSource7;
            this.comboBox3.DisplayMember = "name_";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(13, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(308, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "id";
            // 
            // gamesBindingSource7
            // 
            this.gamesBindingSource7.DataMember = "Games";
            this.gamesBindingSource7.DataSource = this.computerGamesDataSet;
            // 
            // gamesBindingSource4
            // 
            this.gamesBindingSource4.DataMember = "Games";
            this.gamesBindingSource4.DataSource = this.computerGamesDataSet;
            // 
            // gamesBindingSource1
            // 
            this.gamesBindingSource1.DataMember = "Games";
            this.gamesBindingSource1.DataSource = this.cGDataSet;
            // 
            // gamePlatformBindingSource
            // 
            this.gamePlatformBindingSource.DataMember = "GamePlatform";
            this.gamePlatformBindingSource.DataSource = this.cGDataSet;
            // 
            // gamePlatformTableAdapter
            // 
            this.gamePlatformTableAdapter.ClearBeforeFill = true;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.cGDataSet;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Gray;
            this.button6.Location = new System.Drawing.Point(415, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 29);
            this.button6.TabIndex = 15;
            this.button6.Text = "Показать все";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // platformsTableAdapter
            // 
            this.platformsTableAdapter.ClearBeforeFill = true;
            // 
            // gamesTableAdapter1
            // 
            this.gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // platformsTableAdapter1
            // 
            this.platformsTableAdapter1.ClearBeforeFill = true;
            // 
            // gamesBindingSource5
            // 
            this.gamesBindingSource5.DataMember = "Games";
            this.gamesBindingSource5.DataSource = this.computerGamesDataSet;
            // 
            // platformsBindingSource3
            // 
            this.platformsBindingSource3.DataMember = "Platforms";
            this.platformsBindingSource3.DataSource = this.computerGamesDataSet;
            // 
            // gamePlatformBindingSource1
            // 
            this.gamePlatformBindingSource1.DataMember = "GamePlatform";
            this.gamePlatformBindingSource1.DataSource = this.computerGamesDataSet;
            // 
            // gamePlatformTableAdapter1
            // 
            this.gamePlatformTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Поиск по игре";
            // 
            // GamesPlatformsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 436);
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
            this.Name = "GamesPlatformsForm";
            this.Text = "Игры и платформы";
            this.Load += new System.EventHandler(this.GamesPlatformsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlatformBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlatformBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox3;
        private CGDataSet cGDataSet;
        private System.Windows.Forms.BindingSource gamePlatformBindingSource;
        private CGDataSetTableAdapters.GamePlatformTableAdapter gamePlatformTableAdapter;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private CGDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource gamesBindingSource1;
        private System.Windows.Forms.BindingSource gamesBindingSource2;
        private System.Windows.Forms.BindingSource platformsBindingSource;
        private CGDataSetTableAdapters.PlatformsTableAdapter platformsTableAdapter;
        private ComputerGamesDataSet computerGamesDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource3;
        private ComputerGamesDataSetTableAdapters.GamesTableAdapter gamesTableAdapter1;
        private System.Windows.Forms.BindingSource platformsBindingSource1;
        private ComputerGamesDataSetTableAdapters.PlatformsTableAdapter platformsTableAdapter1;
        private System.Windows.Forms.BindingSource gamesBindingSource4;
        private System.Windows.Forms.BindingSource gamesBindingSource5;
        private System.Windows.Forms.BindingSource gamesBindingSource6;
        private System.Windows.Forms.BindingSource platformsBindingSource2;
        private System.Windows.Forms.BindingSource platformsBindingSource3;
        private System.Windows.Forms.BindingSource gamePlatformBindingSource1;
        private ComputerGamesDataSetTableAdapters.GamePlatformTableAdapter gamePlatformTableAdapter1;
        private System.Windows.Forms.BindingSource gamesBindingSource7;
        private System.Windows.Forms.Label label5;
    }
}