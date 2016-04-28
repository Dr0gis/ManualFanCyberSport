namespace CourseProject0_1
{
    partial class FormListPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPlayer));
            this.labelDota2 = new System.Windows.Forms.Label();
            this.textBoxExample = new System.Windows.Forms.RichTextBox();
            this.ListDota2Player = new System.Windows.Forms.ListBox();
            this.PictureBoxLogoGame = new System.Windows.Forms.PictureBox();
            this.labelListPlayer = new System.Windows.Forms.Label();
            this.PictureSelectedPlayer = new System.Windows.Forms.PictureBox();
            this.LabelNameSelectedPlayer = new System.Windows.Forms.Label();
            this.LabelNickameSelectedPlayer = new System.Windows.Forms.Label();
            this.LabelSurnameSelectedPlayer = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelRole = new System.Windows.Forms.Label();
            this.LabelSignature = new System.Windows.Forms.Label();
            this.LabelNumberGames = new System.Windows.Forms.Label();
            this.LabelProcentWin = new System.Windows.Forms.Label();
            this.LabelMMR = new System.Windows.Forms.Label();
            this.PictureBoxPentagon = new System.Windows.Forms.PictureBox();
            this.TextBoxPentagonTemp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelectedPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPentagon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDota2
            // 
            this.labelDota2.AutoSize = true;
            this.labelDota2.BackColor = System.Drawing.Color.Transparent;
            this.labelDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDota2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDota2.Location = new System.Drawing.Point(-79, -99);
            this.labelDota2.Name = "labelDota2";
            this.labelDota2.Size = new System.Drawing.Size(76, 26);
            this.labelDota2.TabIndex = 10;
            this.labelDota2.Text = "Dota 2";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(259, 376);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(492, 143);
            this.textBoxExample.TabIndex = 9;
            this.textBoxExample.Text = "";
            // 
            // ListDota2Player
            // 
            this.ListDota2Player.BackColor = System.Drawing.Color.White;
            this.ListDota2Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListDota2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListDota2Player.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListDota2Player.FormattingEnabled = true;
            this.ListDota2Player.HorizontalScrollbar = true;
            this.ListDota2Player.ItemHeight = 20;
            this.ListDota2Player.Location = new System.Drawing.Point(25, 65);
            this.ListDota2Player.Name = "ListDota2Player";
            this.ListDota2Player.Size = new System.Drawing.Size(228, 404);
            this.ListDota2Player.Sorted = true;
            this.ListDota2Player.TabIndex = 8;
            this.ListDota2Player.SelectedIndexChanged += new System.EventHandler(this.SelectPlayerInDoat2List);
            // 
            // PictureBoxLogoGame
            // 
            this.PictureBoxLogoGame.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogoGame.Image = global::CourseProject0_1.Properties.Resources.dota2logo100;
            this.PictureBoxLogoGame.Location = new System.Drawing.Point(637, 21);
            this.PictureBoxLogoGame.Name = "PictureBoxLogoGame";
            this.PictureBoxLogoGame.Size = new System.Drawing.Size(105, 103);
            this.PictureBoxLogoGame.TabIndex = 7;
            this.PictureBoxLogoGame.TabStop = false;
            // 
            // labelListPlayer
            // 
            this.labelListPlayer.AutoSize = true;
            this.labelListPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelListPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListPlayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelListPlayer.Location = new System.Drawing.Point(49, 21);
            this.labelListPlayer.Name = "labelListPlayer";
            this.labelListPlayer.Size = new System.Drawing.Size(171, 26);
            this.labelListPlayer.TabIndex = 12;
            this.labelListPlayer.Text = "Список игроков";
            // 
            // PictureSelectedPlayer
            // 
            this.PictureSelectedPlayer.BackColor = System.Drawing.Color.Transparent;
            this.PictureSelectedPlayer.Image = global::CourseProject0_1.Properties.Resources.ProfileNonLogo100;
            this.PictureSelectedPlayer.Location = new System.Drawing.Point(280, 15);
            this.PictureSelectedPlayer.Name = "PictureSelectedPlayer";
            this.PictureSelectedPlayer.Size = new System.Drawing.Size(101, 103);
            this.PictureSelectedPlayer.TabIndex = 13;
            this.PictureSelectedPlayer.TabStop = false;
            // 
            // LabelNameSelectedPlayer
            // 
            this.LabelNameSelectedPlayer.AutoSize = true;
            this.LabelNameSelectedPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LabelNameSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameSelectedPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNameSelectedPlayer.Location = new System.Drawing.Point(399, 18);
            this.LabelNameSelectedPlayer.Name = "LabelNameSelectedPlayer";
            this.LabelNameSelectedPlayer.Size = new System.Drawing.Size(56, 26);
            this.LabelNameSelectedPlayer.TabIndex = 14;
            this.LabelNameSelectedPlayer.Text = "Имя";
            // 
            // LabelNickameSelectedPlayer
            // 
            this.LabelNickameSelectedPlayer.AutoSize = true;
            this.LabelNickameSelectedPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LabelNickameSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNickameSelectedPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNickameSelectedPlayer.Location = new System.Drawing.Point(399, 56);
            this.LabelNickameSelectedPlayer.Name = "LabelNickameSelectedPlayer";
            this.LabelNickameSelectedPlayer.Size = new System.Drawing.Size(51, 26);
            this.LabelNickameSelectedPlayer.TabIndex = 15;
            this.LabelNickameSelectedPlayer.Text = "Ник";
            // 
            // LabelSurnameSelectedPlayer
            // 
            this.LabelSurnameSelectedPlayer.AutoSize = true;
            this.LabelSurnameSelectedPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LabelSurnameSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurnameSelectedPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSurnameSelectedPlayer.Location = new System.Drawing.Point(399, 92);
            this.LabelSurnameSelectedPlayer.Name = "LabelSurnameSelectedPlayer";
            this.LabelSurnameSelectedPlayer.Size = new System.Drawing.Size(108, 26);
            this.LabelSurnameSelectedPlayer.TabIndex = 16;
            this.LabelSurnameSelectedPlayer.Text = "Фамилия";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(25, 484);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(228, 20);
            this.TextBoxSearch.TabIndex = 17;
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.BackColor = System.Drawing.Color.Transparent;
            this.LabelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTeam.Location = new System.Drawing.Point(275, 135);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(110, 26);
            this.LabelTeam.TabIndex = 18;
            this.LabelTeam.Text = "Команда:";
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.BackColor = System.Drawing.Color.Transparent;
            this.LabelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCountry.Location = new System.Drawing.Point(275, 175);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(92, 26);
            this.LabelCountry.TabIndex = 19;
            this.LabelCountry.Text = "Страна:";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.BackColor = System.Drawing.Color.Transparent;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCity.Location = new System.Drawing.Point(275, 220);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(79, 26);
            this.LabelCity.TabIndex = 20;
            this.LabelCity.Text = "Город:";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelAge.Location = new System.Drawing.Point(275, 263);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(101, 26);
            this.LabelAge.TabIndex = 21;
            this.LabelAge.Text = "Возраст:";
            // 
            // LabelRole
            // 
            this.LabelRole.AutoSize = true;
            this.LabelRole.BackColor = System.Drawing.Color.Transparent;
            this.LabelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelRole.Location = new System.Drawing.Point(275, 308);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.Size = new System.Drawing.Size(70, 26);
            this.LabelRole.TabIndex = 22;
            this.LabelRole.Text = "Роль:";
            // 
            // LabelSignature
            // 
            this.LabelSignature.AutoSize = true;
            this.LabelSignature.BackColor = System.Drawing.Color.Transparent;
            this.LabelSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSignature.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSignature.Location = new System.Drawing.Point(275, 355);
            this.LabelSignature.Name = "LabelSignature";
            this.LabelSignature.Size = new System.Drawing.Size(78, 26);
            this.LabelSignature.TabIndex = 23;
            this.LabelSignature.Text = "Герои:";
            // 
            // LabelNumberGames
            // 
            this.LabelNumberGames.AutoSize = true;
            this.LabelNumberGames.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNumberGames.Location = new System.Drawing.Point(275, 398);
            this.LabelNumberGames.Name = "LabelNumberGames";
            this.LabelNumberGames.Size = new System.Drawing.Size(177, 26);
            this.LabelNumberGames.TabIndex = 24;
            this.LabelNumberGames.Text = "Количество игр:";
            // 
            // LabelProcentWin
            // 
            this.LabelProcentWin.AutoSize = true;
            this.LabelProcentWin.BackColor = System.Drawing.Color.Transparent;
            this.LabelProcentWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProcentWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelProcentWin.Location = new System.Drawing.Point(275, 439);
            this.LabelProcentWin.Name = "LabelProcentWin";
            this.LabelProcentWin.Size = new System.Drawing.Size(173, 26);
            this.LabelProcentWin.TabIndex = 25;
            this.LabelProcentWin.Text = "Процент побед:";
            // 
            // LabelMMR
            // 
            this.LabelMMR.AutoSize = true;
            this.LabelMMR.BackColor = System.Drawing.Color.Transparent;
            this.LabelMMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMMR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelMMR.Location = new System.Drawing.Point(275, 484);
            this.LabelMMR.Name = "LabelMMR";
            this.LabelMMR.Size = new System.Drawing.Size(70, 26);
            this.LabelMMR.TabIndex = 26;
            this.LabelMMR.Text = "MMR:";
            // 
            // PictureBoxPentagon
            // 
            this.PictureBoxPentagon.Location = new System.Drawing.Point(542, 136);
            this.PictureBoxPentagon.Name = "PictureBoxPentagon";
            this.PictureBoxPentagon.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxPentagon.TabIndex = 27;
            this.PictureBoxPentagon.TabStop = false;
            this.PictureBoxPentagon.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPentagon_Paint);
            // 
            // TextBoxPentagonTemp
            // 
            this.TextBoxPentagonTemp.Location = new System.Drawing.Point(542, 350);
            this.TextBoxPentagonTemp.Name = "TextBoxPentagonTemp";
            this.TextBoxPentagonTemp.Size = new System.Drawing.Size(200, 20);
            this.TextBoxPentagonTemp.TabIndex = 28;
            // 
            // FormListPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.TextBoxPentagonTemp);
            this.Controls.Add(this.PictureBoxPentagon);
            this.Controls.Add(this.LabelMMR);
            this.Controls.Add(this.LabelProcentWin);
            this.Controls.Add(this.LabelNumberGames);
            this.Controls.Add(this.LabelSignature);
            this.Controls.Add(this.LabelRole);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelCountry);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.LabelSurnameSelectedPlayer);
            this.Controls.Add(this.LabelNickameSelectedPlayer);
            this.Controls.Add(this.LabelNameSelectedPlayer);
            this.Controls.Add(this.PictureSelectedPlayer);
            this.Controls.Add(this.labelListPlayer);
            this.Controls.Add(this.labelDota2);
            this.Controls.Add(this.ListDota2Player);
            this.Controls.Add(this.PictureBoxLogoGame);
            this.Name = "FormListPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2Dota2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelectedPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPentagon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDota2;
        public System.Windows.Forms.PictureBox PictureBoxLogoGame;
        public System.Windows.Forms.RichTextBox textBoxExample;
        public System.Windows.Forms.ListBox ListDota2Player;
        public System.Windows.Forms.Label labelListPlayer;
        public System.Windows.Forms.PictureBox PictureSelectedPlayer;
        public System.Windows.Forms.Label LabelNameSelectedPlayer;
        public System.Windows.Forms.Label LabelNickameSelectedPlayer;
        public System.Windows.Forms.Label LabelSurnameSelectedPlayer;
        public System.Windows.Forms.TextBox TextBoxSearch;
        public System.Windows.Forms.Label LabelTeam;
        public System.Windows.Forms.Label LabelCountry;
        public System.Windows.Forms.Label LabelCity;
        public System.Windows.Forms.Label LabelAge;
        public System.Windows.Forms.Label LabelSignature;
        public System.Windows.Forms.Label LabelNumberGames;
        public System.Windows.Forms.Label LabelProcentWin;
        public System.Windows.Forms.Label LabelMMR;
        public System.Windows.Forms.Label LabelRole;
        public System.Windows.Forms.PictureBox PictureBoxPentagon;
        public System.Windows.Forms.TextBox TextBoxPentagonTemp;
    }
}