namespace CourseProject0_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBoxPlayers = new System.Windows.Forms.PictureBox();
            this.labelCSGO = new System.Windows.Forms.Label();
            this.labelDota2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ListDota2TopPlayer = new System.Windows.Forms.ListBox();
            this.ListCSGOTopPlayer = new System.Windows.Forms.ListBox();
            this.LabelTop10Dota2 = new System.Windows.Forms.Label();
            this.LabelTop10CSGO = new System.Windows.Forms.Label();
            this.buttonMyProfileDota2 = new System.Windows.Forms.Button();
            this.buttonMyProfileCSGO = new System.Windows.Forms.Button();
            this.buttonSinhronizacia = new System.Windows.Forms.Button();
            this.openFileSinhronizacia = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxPredictionSelectTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxPredictionSelectTeam2 = new System.Windows.Forms.ComboBox();
            this.labelVersus = new System.Windows.Forms.Label();
            this.buttonCalculated = new System.Windows.Forms.Button();
            this.LabelPredictionGame = new System.Windows.Forms.Label();
            this.labelPredictionResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxPlayers
            // 
            this.PictureBoxPlayers.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPlayers.Image = global::CourseProject0_1.Properties.Resources._54d10b;
            this.PictureBoxPlayers.Location = new System.Drawing.Point(513, 12);
            this.PictureBoxPlayers.Name = "PictureBoxPlayers";
            this.PictureBoxPlayers.Size = new System.Drawing.Size(325, 282);
            this.PictureBoxPlayers.TabIndex = 0;
            this.PictureBoxPlayers.TabStop = false;
            // 
            // labelCSGO
            // 
            this.labelCSGO.AutoSize = true;
            this.labelCSGO.BackColor = System.Drawing.Color.Transparent;
            this.labelCSGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCSGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCSGO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCSGO.Location = new System.Drawing.Point(1043, 286);
            this.labelCSGO.Name = "labelCSGO";
            this.labelCSGO.Size = new System.Drawing.Size(83, 26);
            this.labelCSGO.TabIndex = 7;
            this.labelCSGO.Text = "CS:GO";
            this.labelCSGO.Click += new System.EventHandler(this.labelCSGO_Click);
            // 
            // labelDota2
            // 
            this.labelDota2.AutoSize = true;
            this.labelDota2.BackColor = System.Drawing.Color.Transparent;
            this.labelDota2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDota2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDota2.Location = new System.Drawing.Point(217, 283);
            this.labelDota2.Name = "labelDota2";
            this.labelDota2.Size = new System.Drawing.Size(76, 26);
            this.labelDota2.TabIndex = 6;
            this.labelDota2.Text = "Dota 2";
            this.labelDota2.Click += new System.EventHandler(this.labelDota2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CourseProject0_1.Properties.Resources.dota2_100_100;
            this.pictureBox2.Location = new System.Drawing.Point(204, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 101);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.labelDota2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CourseProject0_1.Properties.Resources.csgo_100_100;
            this.pictureBox3.Location = new System.Drawing.Point(1034, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.labelCSGO_Click);
            // 
            // ListDota2TopPlayer
            // 
            this.ListDota2TopPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ListDota2TopPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDota2TopPlayer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ListDota2TopPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListDota2TopPlayer.ForeColor = System.Drawing.Color.White;
            this.ListDota2TopPlayer.FormattingEnabled = true;
            this.ListDota2TopPlayer.HorizontalScrollbar = true;
            this.ListDota2TopPlayer.ItemHeight = 20;
            this.ListDota2TopPlayer.Location = new System.Drawing.Point(45, 382);
            this.ListDota2TopPlayer.Name = "ListDota2TopPlayer";
            this.ListDota2TopPlayer.Size = new System.Drawing.Size(422, 200);
            this.ListDota2TopPlayer.TabIndex = 10;
            // 
            // ListCSGOTopPlayer
            // 
            this.ListCSGOTopPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ListCSGOTopPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListCSGOTopPlayer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ListCSGOTopPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCSGOTopPlayer.ForeColor = System.Drawing.Color.White;
            this.ListCSGOTopPlayer.FormattingEnabled = true;
            this.ListCSGOTopPlayer.HorizontalScrollbar = true;
            this.ListCSGOTopPlayer.ItemHeight = 20;
            this.ListCSGOTopPlayer.Location = new System.Drawing.Point(865, 382);
            this.ListCSGOTopPlayer.Name = "ListCSGOTopPlayer";
            this.ListCSGOTopPlayer.Size = new System.Drawing.Size(422, 200);
            this.ListCSGOTopPlayer.TabIndex = 11;
            // 
            // LabelTop10Dota2
            // 
            this.LabelTop10Dota2.AutoSize = true;
            this.LabelTop10Dota2.BackColor = System.Drawing.Color.Transparent;
            this.LabelTop10Dota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTop10Dota2.ForeColor = System.Drawing.Color.White;
            this.LabelTop10Dota2.Location = new System.Drawing.Point(198, 336);
            this.LabelTop10Dota2.Name = "LabelTop10Dota2";
            this.LabelTop10Dota2.Size = new System.Drawing.Size(105, 33);
            this.LabelTop10Dota2.TabIndex = 12;
            this.LabelTop10Dota2.Text = "Топ 10";
            // 
            // LabelTop10CSGO
            // 
            this.LabelTop10CSGO.AutoSize = true;
            this.LabelTop10CSGO.BackColor = System.Drawing.Color.Transparent;
            this.LabelTop10CSGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTop10CSGO.ForeColor = System.Drawing.Color.White;
            this.LabelTop10CSGO.Location = new System.Drawing.Point(1028, 336);
            this.LabelTop10CSGO.Name = "LabelTop10CSGO";
            this.LabelTop10CSGO.Size = new System.Drawing.Size(105, 33);
            this.LabelTop10CSGO.TabIndex = 13;
            this.LabelTop10CSGO.Text = "Топ 10";
            // 
            // buttonMyProfileDota2
            // 
            this.buttonMyProfileDota2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonMyProfileDota2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMyProfileDota2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyProfileDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyProfileDota2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMyProfileDota2.Location = new System.Drawing.Point(141, 629);
            this.buttonMyProfileDota2.Name = "buttonMyProfileDota2";
            this.buttonMyProfileDota2.Size = new System.Drawing.Size(227, 38);
            this.buttonMyProfileDota2.TabIndex = 164;
            this.buttonMyProfileDota2.Text = "Мой профиль";
            this.buttonMyProfileDota2.UseVisualStyleBackColor = false;
            this.buttonMyProfileDota2.Click += new System.EventHandler(this.buttonMyProfileDota2_Click);
            // 
            // buttonMyProfileCSGO
            // 
            this.buttonMyProfileCSGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonMyProfileCSGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMyProfileCSGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyProfileCSGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyProfileCSGO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMyProfileCSGO.Location = new System.Drawing.Point(969, 629);
            this.buttonMyProfileCSGO.Name = "buttonMyProfileCSGO";
            this.buttonMyProfileCSGO.Size = new System.Drawing.Size(227, 38);
            this.buttonMyProfileCSGO.TabIndex = 165;
            this.buttonMyProfileCSGO.Text = "Мой профиль";
            this.buttonMyProfileCSGO.UseVisualStyleBackColor = false;
            this.buttonMyProfileCSGO.Click += new System.EventHandler(this.buttonMyProfileCSGO_Click);
            // 
            // buttonSinhronizacia
            // 
            this.buttonSinhronizacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonSinhronizacia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSinhronizacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSinhronizacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSinhronizacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSinhronizacia.Location = new System.Drawing.Point(559, 341);
            this.buttonSinhronizacia.Name = "buttonSinhronizacia";
            this.buttonSinhronizacia.Size = new System.Drawing.Size(227, 38);
            this.buttonSinhronizacia.TabIndex = 166;
            this.buttonSinhronizacia.Text = "Синхонизация";
            this.buttonSinhronizacia.UseVisualStyleBackColor = false;
            this.buttonSinhronizacia.Click += new System.EventHandler(this.buttonSinhronizacia_Click);
            // 
            // openFileSinhronizacia
            // 
            this.openFileSinhronizacia.FileName = "openFileDialog1";
            this.openFileSinhronizacia.Filter = "\"Текстовые файлы(*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // comboBoxPredictionSelectTeam
            // 
            this.comboBoxPredictionSelectTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.comboBoxPredictionSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredictionSelectTeam.ForeColor = System.Drawing.Color.White;
            this.comboBoxPredictionSelectTeam.FormattingEnabled = true;
            this.comboBoxPredictionSelectTeam.Location = new System.Drawing.Point(513, 440);
            this.comboBoxPredictionSelectTeam.Name = "comboBoxPredictionSelectTeam";
            this.comboBoxPredictionSelectTeam.Size = new System.Drawing.Size(115, 21);
            this.comboBoxPredictionSelectTeam.TabIndex = 189;
            // 
            // comboBoxPredictionSelectTeam2
            // 
            this.comboBoxPredictionSelectTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.comboBoxPredictionSelectTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredictionSelectTeam2.ForeColor = System.Drawing.Color.White;
            this.comboBoxPredictionSelectTeam2.FormattingEnabled = true;
            this.comboBoxPredictionSelectTeam2.Location = new System.Drawing.Point(723, 440);
            this.comboBoxPredictionSelectTeam2.Name = "comboBoxPredictionSelectTeam2";
            this.comboBoxPredictionSelectTeam2.Size = new System.Drawing.Size(115, 21);
            this.comboBoxPredictionSelectTeam2.TabIndex = 191;
            // 
            // labelVersus
            // 
            this.labelVersus.AutoSize = true;
            this.labelVersus.BackColor = System.Drawing.Color.Transparent;
            this.labelVersus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVersus.Location = new System.Drawing.Point(648, 440);
            this.labelVersus.Name = "labelVersus";
            this.labelVersus.Size = new System.Drawing.Size(55, 20);
            this.labelVersus.TabIndex = 192;
            this.labelVersus.Text = "versus";
            // 
            // buttonCalculated
            // 
            this.buttonCalculated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonCalculated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculated.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalculated.Location = new System.Drawing.Point(603, 488);
            this.buttonCalculated.Name = "buttonCalculated";
            this.buttonCalculated.Size = new System.Drawing.Size(145, 38);
            this.buttonCalculated.TabIndex = 193;
            this.buttonCalculated.Text = "Просчитать";
            this.buttonCalculated.UseVisualStyleBackColor = false;
            this.buttonCalculated.Click += new System.EventHandler(this.buttonCalculated_Click);
            // 
            // LabelPredictionGame
            // 
            this.LabelPredictionGame.AutoSize = true;
            this.LabelPredictionGame.BackColor = System.Drawing.Color.Transparent;
            this.LabelPredictionGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelPredictionGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPredictionGame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelPredictionGame.Location = new System.Drawing.Point(597, 398);
            this.LabelPredictionGame.Name = "LabelPredictionGame";
            this.LabelPredictionGame.Size = new System.Drawing.Size(159, 26);
            this.LabelPredictionGame.TabIndex = 194;
            this.LabelPredictionGame.Text = "Прогноз Игры:";
            // 
            // labelPredictionResult
            // 
            this.labelPredictionResult.AutoSize = true;
            this.labelPredictionResult.BackColor = System.Drawing.Color.Transparent;
            this.labelPredictionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPredictionResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPredictionResult.Location = new System.Drawing.Point(509, 544);
            this.labelPredictionResult.Name = "labelPredictionResult";
            this.labelPredictionResult.Size = new System.Drawing.Size(93, 20);
            this.labelPredictionResult.TabIndex = 195;
            this.labelPredictionResult.Text = "Результат:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1322, 721);
            this.Controls.Add(this.labelPredictionResult);
            this.Controls.Add(this.LabelPredictionGame);
            this.Controls.Add(this.buttonCalculated);
            this.Controls.Add(this.labelVersus);
            this.Controls.Add(this.comboBoxPredictionSelectTeam2);
            this.Controls.Add(this.comboBoxPredictionSelectTeam);
            this.Controls.Add(this.buttonSinhronizacia);
            this.Controls.Add(this.buttonMyProfileCSGO);
            this.Controls.Add(this.buttonMyProfileDota2);
            this.Controls.Add(this.LabelTop10CSGO);
            this.Controls.Add(this.LabelTop10Dota2);
            this.Controls.Add(this.ListCSGOTopPlayer);
            this.Controls.Add(this.ListDota2TopPlayer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCSGO);
            this.Controls.Add(this.labelDota2);
            this.Controls.Add(this.PictureBoxPlayers);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Фаната";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxPlayers;
        private System.Windows.Forms.Label labelCSGO;
        private System.Windows.Forms.Label labelDota2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.ListBox ListDota2TopPlayer;
        public System.Windows.Forms.ListBox ListCSGOTopPlayer;
        private System.Windows.Forms.Label LabelTop10Dota2;
        private System.Windows.Forms.Label LabelTop10CSGO;
        private System.Windows.Forms.Button buttonMyProfileDota2;
        private System.Windows.Forms.Button buttonMyProfileCSGO;
        private System.Windows.Forms.Button buttonSinhronizacia;
        private System.Windows.Forms.OpenFileDialog openFileSinhronizacia;
        public System.Windows.Forms.ComboBox comboBoxPredictionSelectTeam;
        public System.Windows.Forms.ComboBox comboBoxPredictionSelectTeam2;
        public System.Windows.Forms.Label labelVersus;
        private System.Windows.Forms.Button buttonCalculated;
        private System.Windows.Forms.Label LabelPredictionGame;
        public System.Windows.Forms.Label labelPredictionResult;
    }
}

