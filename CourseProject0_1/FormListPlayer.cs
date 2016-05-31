using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject0_1
{
    public partial class FormListPlayer : Form
    {
        public FormListPlayer()
        {
            InitializeComponent();
        }

        private void Form2Dota2_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariables.MainFormObject.Show();
        }

        private void PictureBoxPentagon_Paint(object sender, PaintEventArgs e)
        {
            GlobalVariables.CheckOnRefreshPicturePentagonLeft = 0;
            GlobalVariables.CheckOnRefreshPicturePentagonRight = 0;
            float[][] ArrayCoordsPentagons = new float[10][];
            Graphics g = e.Graphics;
            float kooficient = 10F;
            float slagaemoe = 90F;
            for (int i = 2; i <= 11; i++)
            {
                ArrayCoordsPentagons[i - 2] = new float[10];
                g.DrawLine(Pens.Black, 5F / kooficient + slagaemoe, 77F / kooficient + slagaemoe, 100F / kooficient + slagaemoe, 9F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][0] = 5F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][1] = 77F / kooficient + slagaemoe;

                g.DrawLine(Pens.Black, 100F / kooficient + slagaemoe, 9F / kooficient + slagaemoe, 195F / kooficient + slagaemoe, 77F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][2] = 100F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][3] = 9F / kooficient + slagaemoe;

                g.DrawLine(Pens.Black, 195F / kooficient + slagaemoe, 77F / kooficient + slagaemoe, 158F / kooficient + slagaemoe, 191F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][4] = 195F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][5] = 77F / kooficient + slagaemoe;

                g.DrawLine(Pens.Black, 158F / kooficient + slagaemoe, 191F / kooficient + slagaemoe, 42F / kooficient + slagaemoe, 191F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][6] = 158F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][7] = 191F / kooficient + slagaemoe;

                g.DrawLine(Pens.Black, 42F / kooficient + slagaemoe, 191F / kooficient + slagaemoe, 5F / kooficient + slagaemoe, 77F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][8] = 42F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][9] = 191F / kooficient + slagaemoe;

                kooficient = 10F / i;
                slagaemoe -= 10F;
            }
            GlobalVariables.ArrayCoordsPentagons = ArrayCoordsPentagons;

            // Прорисовка отрезков сторон 10 пятиугольника 
            g.DrawLine(Pens.DarkGray, 5, 77, 100, 9);
            g.DrawLine(Pens.DarkGray, 100, 9, 195, 77);
            g.DrawLine(Pens.DarkGray, 195, 77, 158, 191);
            g.DrawLine(Pens.DarkGray, 158, 191, 42, 191);
            g.DrawLine(Pens.DarkGray, 42, 191, 5, 77);

            // Прорисовка отрезков сторон 1 пятиугольника
            g.DrawLine(Pens.DarkGray, 90.5F, 97.7F, 100, 90.5F);
            g.DrawLine(Pens.DarkGray, 100, 90.5F, 109.5F, 97.7F);
            g.DrawLine(Pens.DarkGray, 109.5F, 97.7F, 105.8F, 109.1F);
            g.DrawLine(Pens.DarkGray, 105.8F, 109.1F, 94.2F, 109.1F);
            g.DrawLine(Pens.DarkGray, 94.2F, 109.1F, 90.5F, 97.7F);

            // Прорисовка отрезков
            g.DrawLine(Pens.Black, 90.5F, 97.7F, 5, 77);
            g.DrawLine(Pens.Black, 100, 90.5F, 100, 9);
            g.DrawLine(Pens.Black, 109.5F, 97.7F, 195, 77);
            g.DrawLine(Pens.Black, 105.8F, 109.1F, 158, 191);
            g.DrawLine(Pens.Black, 94.2F, 109.1F, 42, 191);
        }

        public Image ResizeImg(Image b, int nWidth, int nHeight)
        {
            Image result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(b, 0, 0, nWidth, nHeight);
                g.Dispose();
            }
            return result;
        }
        private void ListPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideEditField();

            if (ListPlayer.SelectedIndex == -1)
            {
                ListPlayer.SelectedIndex = 0;
            }
            string SelectedPlayerMajorInfo = (string)ListPlayer.SelectedItem;
            string SelectedPlayerName = "";
            string SelectedPlayerNickname = "";
            string SelectedPlayerSurname = "";
            string SelectedPlayerTeam = "";
            string SelectedPlayerCountry = "";
            string SelectedPlayerCity = "";
            string SelectedPlayerAge = "";
            string SelectedPlayerRole = "";
            string[] SelectedPlayerSignatureArray = new string[3];
            string SelectedPlayerNumberGames = "";
            string SelectedPlayerProcentWin = "";
            string SelectedPlayerMMR = "";
            int[] SelectedPlayerPentagon = new int[5];
            bool SelectedPlayerEdit = false;

            string SelectedPlayer2MajorInfo = (string)List2Player.SelectedItem;
            int[] SelectedPlayer2Pentagon = new int[5];

            string SelectedPlayerPhotoProfile = "";
            //foreach (List<Player> ListPlayer in GlobalVariables.ListPlayerInDiscypline)
            //{
                foreach (Player Player in GlobalVariables.ListPlayerInDiscypline[GlobalVariables.SelectedDiscypline == "Dota2" ? 0 : 1])
                {
                    if (Player.MajorInfo() == SelectedPlayerMajorInfo)
                    {
                        SelectedPlayerName = Player.Name;
                        SelectedPlayerNickname = Player.Nickname;
                        SelectedPlayerSurname = Player.Surname;
                        SelectedPlayerTeam = Player.Team;
                        SelectedPlayerTeam = Player.Team;
                        SelectedPlayerCountry = Player.Country;
                        SelectedPlayerCity = Player.City;
                        SelectedPlayerAge = Player.Age.ToString();
                        SelectedPlayerRole = Player.Role;
                        SelectedPlayerSignatureArray = Player.Signature;
                        SelectedPlayerNumberGames = Player.NumberGames.ToString();
                        SelectedPlayerProcentWin = Player.ProcentWinGames.ToString();
                        SelectedPlayerMMR = Player.MMR;
                        SelectedPlayerPentagon = Player.Pentagon;
                        SelectedPlayerEdit = Player.Edit;

                        SelectedPlayerPhotoProfile = Player.PhotoProfile;
                    }
                    if (Player.MajorInfo() == SelectedPlayer2MajorInfo)
                    {
                        SelectedPlayer2Pentagon = Player.Pentagon;
                    }
                }
            //}
            LabelNameSelectedPlayer.Text = SelectedPlayerName;
            LabelNickameSelectedPlayer.Text = SelectedPlayerNickname;
            LabelSurnameSelectedPlayer.Text = SelectedPlayerSurname;

            LabelTeam.Text = "Команда: " + SelectedPlayerTeam;
            LabelCountry.Text = "Страна: " + SelectedPlayerCountry;
            LabelCity.Text = "Город: " + SelectedPlayerCity;
            LabelAge.Text = "Возраст: " + SelectedPlayerAge;
            LabelRole.Text = "Роль: " + SelectedPlayerRole;

            PictureBoxSignature1.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + SelectedPlayerSignatureArray[0] + "_icon.png", true);
            PictureBoxSignature2.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + SelectedPlayerSignatureArray[1] + "_icon.png", true);
            PictureBoxSignature3.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + SelectedPlayerSignatureArray[2] + "_icon.png", true);

            LabelNumberGames.Text = "Количество игр: " + SelectedPlayerNumberGames;
            LabelProcentWin.Text = "Процент побед: " + SelectedPlayerProcentWin;
            LabelMMR.Text = "MMR: " + SelectedPlayerMMR;

            ButtonEditPlayer.Enabled = SelectedPlayerEdit;
            buttonDelete.Enabled = SelectedPlayerEdit;

            LabelPentagon.ForeColor = Color.Red;
            LabelPentagon2.ForeColor = Color.Aqua;
            LabelPentagon.Text = string.Join(", ", SelectedPlayerPentagon);
            if (string.Join(" ,", SelectedPlayer2Pentagon) == string.Join(" ,", SelectedPlayerPentagon))
            {
                LabelPentagon2.ForeColor = Color.DarkGray;
                LabelPentagon.ForeColor = Color.DarkGray;
            }

            // Прорисовка отрезков сторон пятиугольника игрока
            if (GlobalVariables.CheckOnRefreshPicturePentagonRight == 0 && GlobalVariables.CheckOnRefreshPicturePentagonLeft == 1)
            {
                PictureBoxPentagon.Refresh();
            }
            if (GlobalVariables.CheckOnRefreshPicturePentagonRight == 1 && GlobalVariables.CheckOnRefreshPicturePentagonLeft == 1)
            {
                PictureBoxPentagon.Refresh();
                GlobalVariables.DrawingPentagonPlayer(PictureBoxPentagon, SelectedPlayer2Pentagon, Pens.Aqua);
                GlobalVariables.CheckOnRefreshPicturePentagonRight = 1;
            }
            GlobalVariables.DrawingPentagonPlayer(PictureBoxPentagon, SelectedPlayerPentagon, Pens.Red);
            GlobalVariables.CheckOnRefreshPicturePentagonLeft = 1;
            if (string.Join(" ,", SelectedPlayer2Pentagon) == string.Join(" ,", SelectedPlayerPentagon))
            {
                GlobalVariables.DrawingPentagonPlayer(PictureBoxPentagon, SelectedPlayerPentagon, Pens.DarkGray);
            }
            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\photoProfiles\" + SelectedPlayerPhotoProfile, true);
            PictureSelectedPlayer.Image = ResizeImg(tempImage, 100, 100);
            tempImage.Dispose();
        }

        private void List2Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideEditField2();

            if (List2Player.SelectedIndex == -1)
            {
                List2Player.SelectedIndex = 0;
            }
            string SelectedPlayer2MajorInfo = (string)List2Player.SelectedItem;
            string SelectedPlayer2Name = "";
            string SelectedPlayer2Nickname = "";
            string SelectedPlayer2Surname = "";
            string SelectedPlayer2Team = "";
            string SelectedPlayer2Country = "";
            string SelectedPlayer2City = "";
            string SelectedPlayer2Age = "";
            string SelectedPlayer2Role = "";
            string[] SelectedPlayer2SignatureArray = new string[3];
            string SelectedPlayer2NumberGames = "";
            string SelectedPlayer2ProcentWin = "";
            string SelectedPlayer2MMR = "";
            int[] SelectedPlayer2Pentagon = new int[5];
            bool SelectedPlayerEdit = false;

            string SelectedPlayerMajorInfo = (string)ListPlayer.SelectedItem;
            int[] SelectedPlayerPentagon = new int[5];

            string SelectedPlayerPhotoProfile = "";
            foreach (List<Player> ListPlayer in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player Player in ListPlayer)
                {
                    if (Player.MajorInfo() == SelectedPlayer2MajorInfo)
                    {
                        SelectedPlayer2Name = Player.Name;
                        SelectedPlayer2Nickname = Player.Nickname;
                        SelectedPlayer2Surname = Player.Surname;
                        SelectedPlayer2Team = Player.Team;
                        SelectedPlayer2Team = Player.Team;
                        SelectedPlayer2Country = Player.Country;
                        SelectedPlayer2City = Player.City;
                        SelectedPlayer2Age = Player.Age.ToString();
                        SelectedPlayer2Role = Player.Role;
                        SelectedPlayer2SignatureArray = Player.Signature;
                        SelectedPlayer2NumberGames = Player.NumberGames.ToString();
                        SelectedPlayer2ProcentWin = Player.ProcentWinGames.ToString();
                        SelectedPlayer2MMR = Player.MMR;
                        SelectedPlayer2Pentagon = Player.Pentagon;
                        SelectedPlayerEdit = Player.Edit;

                        SelectedPlayerPhotoProfile = Player.PhotoProfile;
                    }
                    if (Player.MajorInfo() == SelectedPlayerMajorInfo)
                    {
                        SelectedPlayerPentagon = Player.Pentagon;
                    }
                }
            }
            LabelNameSelectedPlayer2.Text = SelectedPlayer2Name;
            LabelNickameSelectedPlayer2.Text = SelectedPlayer2Nickname;
            LabelSurnameSelectedPlayer2.Text = SelectedPlayer2Surname;

            LabelTeam2.Text = "Команда: " + SelectedPlayer2Team;
            LabelCountry2.Text = "Страна: " + SelectedPlayer2Country;
            LabelCity2.Text = "Город: " + SelectedPlayer2City;
            LabelAge2.Text = "Возраст: " + SelectedPlayer2Age;
            LabelRole2.Text = "Роль: " + SelectedPlayer2Role;

            PictureBox2Signature1.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + SelectedPlayer2SignatureArray[0] + "_icon.png", true);
            PictureBox2Signature2.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + SelectedPlayer2SignatureArray[1] + "_icon.png", true);
            PictureBox2Signature3.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + SelectedPlayer2SignatureArray[2] + "_icon.png", true);

            LabelNumberGames2.Text = "Количество игр: " + SelectedPlayer2NumberGames;
            LabelProcentWin2.Text = "Процент побед: " + SelectedPlayer2ProcentWin;
            LabelMMR2.Text = "MMR: " + SelectedPlayer2MMR;

            ButtonEdit2Player.Enabled = SelectedPlayerEdit;
            buttonDelete2.Enabled = SelectedPlayerEdit;

            LabelPentagon2.ForeColor = Color.Aqua;
            LabelPentagon.ForeColor = Color.Red;
            LabelPentagon2.Text = string.Join(" ,", SelectedPlayer2Pentagon);
            if (string.Join(" ,", SelectedPlayer2Pentagon) == string.Join(" ,", SelectedPlayerPentagon))
            {
                LabelPentagon2.ForeColor = Color.DarkGray;
                LabelPentagon.ForeColor = Color.DarkGray;
            }

            // Прорисовка отрезков сторон пятиугольника игрока
            if (GlobalVariables.CheckOnRefreshPicturePentagonLeft == 0 && GlobalVariables.CheckOnRefreshPicturePentagonRight == 1)
            {
                PictureBoxPentagon.Refresh();
            }
            if (GlobalVariables.CheckOnRefreshPicturePentagonLeft == 1 && GlobalVariables.CheckOnRefreshPicturePentagonRight == 1)
            {
                PictureBoxPentagon.Refresh();
                GlobalVariables.DrawingPentagonPlayer(PictureBoxPentagon, SelectedPlayerPentagon, Pens.Red);
                GlobalVariables.CheckOnRefreshPicturePentagonLeft = 1;
            }
            GlobalVariables.DrawingPentagonPlayer(PictureBoxPentagon, SelectedPlayer2Pentagon, Pens.Aqua);
            GlobalVariables.CheckOnRefreshPicturePentagonRight = 1;
            if (string.Join(" ,", SelectedPlayer2Pentagon) == string.Join(" ,", SelectedPlayerPentagon))
            {
                GlobalVariables.DrawingPentagonPlayer(PictureBoxPentagon, SelectedPlayer2Pentagon, Pens.DarkGray);
            }

            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\photoProfiles\" + SelectedPlayerPhotoProfile, true);
            PictureSelectedPlayer2.Image = ResizeImg(tempImage, 100, 100);
            tempImage.Dispose();
        }


        private void SearchPlayer(TextBox TextBoxSearch, ListBox ListBoxSearched)
        {
            string TextSearch = TextBoxSearch.Text;
            List<Player> ListSearchedPlayer = new List<Player>();

            foreach (Player Player in GlobalVariables.ListPlayerInDiscypline[(GlobalVariables.SelectedDiscypline == "Dota2") ? 0 : 1])
            {
                if (Player.AllInfo().IndexOf(TextSearch) != -1)
                {
                    if (Player.Nickname != "")
                    {
                        ListSearchedPlayer.Add(Player);
                    }
                }
            }

            GlobalVariables.ListPlayerInDiscyplineSearched[GlobalVariables.SelectedDiscypline == "Dota2" ? 0 : 1] = new List<Player>(ListSearchedPlayer);

            ListBoxSearched.Items.Clear();

            foreach (Player Player in ListSearchedPlayer)
            {
                ListBoxSearched.Items.Add(Player.MajorInfo());
            }
            GlobalVariables.ListPlayerInDiscyplineSearched[GlobalVariables.SelectedDiscypline == "Dota2" ? 0 : 1] = ListSearchedPlayer;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchPlayer(TextBoxSearch, ListPlayer);
            buttonFilterApply_Click(null, null);
        }

        private void TextBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            SearchPlayer(TextBoxSearch2, List2Player);
            buttonFilterApply2_Click(null, null);
        }


        private void FilterPlayer(ListBox ListBoxSearched, ComboBox comboBoxFilterTeam, ComboBox comboBoxFilterCountry, ComboBox comboBoxFilterCity, ComboBox comboBoxFilterRole, ComboBox comboBoxFilterHero, NumericUpDown numericUpDownAgeOt, NumericUpDown numericUpDownAgeDo, NumericUpDown numericUpDownNumberGamesOt, NumericUpDown numericUpDownNumberGamesDo, NumericUpDown numericUpDownProcentWinOt, NumericUpDown numericUpDownProcentWinDo, NumericUpDown numericUpDownMMROt, NumericUpDown numericUpDownMMRDo)
        {
            ListBoxSearched.Visible = true;

            List<Player> listPlayer = new List<Player>();

            foreach (Player player in GlobalVariables.ListPlayerInDiscyplineSearched[GlobalVariables.SelectedDiscypline == "Dota2" ? 0 : 1])
            {
                if ((string)comboBoxFilterTeam.SelectedItem != "All")
                {
                    if ((string)comboBoxFilterTeam.SelectedItem != player.Team)
                    {
                        continue;
                    }
                }
                if ((string)comboBoxFilterCountry.SelectedItem != "All")
                {
                    if ((string)comboBoxFilterCountry.SelectedItem != player.Country)
                    {
                        continue;
                    }
                }
                if ((string)comboBoxFilterCity.SelectedItem != "All")
                {
                    if ((string)comboBoxFilterCity.SelectedItem != player.City)
                    {
                        continue;
                    }
                }
                if ((string)comboBoxFilterRole.SelectedItem != "All")
                {
                    if ((string)comboBoxFilterRole.SelectedItem != player.Role)
                    {
                        continue;
                    }
                }
                if ((string)comboBoxFilterHero.SelectedItem != "All")
                {
                    if (!((string)comboBoxFilterHero.SelectedItem == player.Signature[0] || (string)comboBoxFilterHero.SelectedItem == player.Signature[1] || (string)comboBoxFilterHero.SelectedItem == player.Signature[2]))
                    {
                        continue;
                    }
                }
                if (numericUpDownAgeOt.Value != 0 && numericUpDownAgeDo.Value != 0)
                {
                    if (!(numericUpDownAgeOt.Value < player.Age && numericUpDownAgeDo.Value > player.Age))
                    {
                        continue;
                    }
                }
                if (numericUpDownNumberGamesOt.Value != 0 && numericUpDownNumberGamesDo.Value != 0)
                {
                    if (!(numericUpDownNumberGamesOt.Value < player.NumberGames && numericUpDownNumberGamesDo.Value > player.NumberGames))
                    {
                        continue;
                    }
                }
                if (numericUpDownProcentWinOt.Value != 0 && numericUpDownProcentWinDo.Value != 0)
                {
                    if (!(Convert.ToDouble(numericUpDownProcentWinOt.Value) < player.ProcentWinGames && Convert.ToDouble(numericUpDownProcentWinDo.Value) > player.ProcentWinGames))
                    {
                        continue;
                    }
                }
                if (numericUpDownMMROt.Value != 0 && numericUpDownMMRDo.Value != 0)
                {
                    if (!(Convert.ToInt32(numericUpDownMMROt.Value) < Convert.ToInt32(player.MMR) && Convert.ToInt32(numericUpDownMMRDo.Value) > Convert.ToInt32(player.MMR)))
                    {
                        continue;
                    }
                }
                listPlayer.Add(player);
            }

            ListBoxSearched.Items.Clear();
            foreach (Player Player in listPlayer)
            {
                if (Player.Nickname != "")
                {
                    ListBoxSearched.Items.Add(Player.MajorInfo());
                }
            }
            if (ListBoxSearched.Items.Count == 0)
            {
                ListBoxSearched.Items.Add(GlobalVariables.SelectedDiscypline == "Dota2" ? GlobalVariables.PlayerDota2Clear.MajorInfo() : GlobalVariables.PlayerCSGOClear.MajorInfo());
            }
            ListBoxSearched.SelectedIndex = 0;
        }

        private void buttonFilterApply_Click(object sender, EventArgs e)
        {
            FilterPlayer(ListPlayer, comboBoxFilterTeam, comboBoxFilterCountry, comboBoxFilterCity, comboBoxFilterRole, comboBoxFilterHero, numericUpDownAgeOt, numericUpDownAgeDo, numericUpDownNumberGamesOt, numericUpDownNumberGamesDo, numericUpDownProcentWinOt, numericUpDownProcentWinDo, numericUpDownMMROt, numericUpDownMMRDo);
        }

        private void buttonFilterApply2_Click(object sender, EventArgs e)
        {
            FilterPlayer(List2Player, comboBoxFilterTeam2, comboBoxFilterCountry2, comboBoxFilterCity2, comboBoxFilterRole2, comboBoxFilterHero2, numericUpDownAgeOt2, numericUpDownAgeDo2, numericUpDownNumberGamesOt2, numericUpDownNumberGamesDo2, numericUpDownProcentWinOt2, numericUpDownProcentWinDo2, numericUpDownMMROt2, numericUpDownMMRDo2);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            ListPlayer.Visible = false;
        }

        private void buttonFilter2_Click(object sender, EventArgs e)
        {
            List2Player.Visible = false;
        }

        private void FilterClear()
        {
            comboBoxFilterTeam.SelectedIndex = 0;
            comboBoxFilterCountry.SelectedIndex = 0;
            comboBoxFilterCity.SelectedIndex = 0;
            comboBoxFilterRole.SelectedIndex = 0;
            comboBoxFilterHero.SelectedIndex = 0;
            numericUpDownAgeOt.Value = 0;
            numericUpDownAgeDo.Value = 0;
            numericUpDownNumberGamesOt.Value = 0;
            numericUpDownNumberGamesDo.Value = 0;
            numericUpDownProcentWinOt.Value = 0;
            numericUpDownProcentWinDo.Value = 0;
            numericUpDownMMROt.Value = 0;
            numericUpDownMMRDo.Value = 0;
            
        }
        private void FilterClear2()
        {
            comboBoxFilterTeam2.SelectedIndex = 0;
            comboBoxFilterCountry2.SelectedIndex = 0;
            comboBoxFilterCity2.SelectedIndex = 0;
            comboBoxFilterRole2.SelectedIndex = 0;
            comboBoxFilterHero2.SelectedIndex = 0;
            numericUpDownAgeOt2.Value = 0;
            numericUpDownAgeDo2.Value = 0;
            numericUpDownNumberGamesOt2.Value = 0;
            numericUpDownNumberGamesDo2.Value = 0;
            numericUpDownProcentWinOt2.Value = 0;
            numericUpDownProcentWinDo2.Value = 0;
            numericUpDownMMROt2.Value = 0;
            numericUpDownMMRDo2.Value = 0;
        }

        private void buttonFilterClear_Click(object sender, EventArgs e)
        {
            FilterClear();
            buttonFilterApply_Click(null, null);
        }

        private void buttonFilterClear2_Click(object sender, EventArgs e)
        {
            FilterClear2();
            buttonFilterApply2_Click(null, null);
        }

        private void buttonFilterProfile_Click(object sender, EventArgs e)
        {

            List<Player> listPlayer = new List<Player>();

            bool temp1 = false;
            bool temp2 = false;
            bool temp3 = false;

            foreach (Player player in GlobalVariables.ListPlayerInDiscyplineSearched[GlobalVariables.SelectedDiscypline == "Dota2" ? 0 : 1])
            {
                if (GlobalVariables.MyProfileDota2.Country != player.Country)
                {
                    continue;
                }
                if (GlobalVariables.MyProfileDota2.City != player.City)
                {
                    continue;
                }
                if (GlobalVariables.MyProfileDota2.Role != player.Role)
                {
                    continue;
                }
                if (!(GlobalVariables.MyProfileDota2.Signature[0] == player.Signature[0] || GlobalVariables.MyProfileDota2.Signature[0] == player.Signature[1] || GlobalVariables.MyProfileDota2.Signature[0] == player.Signature[2]))
                {
                    temp1 = true;
                }
                if (!(GlobalVariables.MyProfileDota2.Signature[1] == player.Signature[0] || GlobalVariables.MyProfileDota2.Signature[1] == player.Signature[1] || GlobalVariables.MyProfileDota2.Signature[1] == player.Signature[2]))
                {
                    temp2 = true;
                }
                if (!(GlobalVariables.MyProfileDota2.Signature[2] == player.Signature[0] || GlobalVariables.MyProfileDota2.Signature[2] == player.Signature[1] || GlobalVariables.MyProfileDota2.Signature[2] == player.Signature[2]))
                {
                    temp3 = true;
                }
                if (!(temp1 || temp2 || temp3))
                {
                    continue;
                }
                listPlayer.Add(player);
            }

            ListPlayer.Items.Clear();
            foreach (Player Player in listPlayer)
            {
                if (Player.Nickname != "")
                {
                    ListPlayer.Items.Add(Player.MajorInfo());
                }
            }
            if (ListPlayer.Items.Count == 0)
            {
                ListPlayer.Items.Add(GlobalVariables.SelectedDiscypline == "Dota2" ? GlobalVariables.PlayerDota2Clear.MajorInfo() : GlobalVariables.PlayerCSGOClear.MajorInfo());
            }
            ListPlayer.SelectedIndex = 0;
            ListPlayer.Visible = true;
        }

        private void buttonFilterProfile2_Click(object sender, EventArgs e)
        {
            List<Player> listPlayer = new List<Player>();

            bool temp1 = false;
            bool temp2 = false;
            bool temp3 = false;

            foreach (Player player in GlobalVariables.ListPlayerInDiscyplineSearched[GlobalVariables.SelectedDiscypline == "Dota2" ? 0 : 1])
            {
                if (GlobalVariables.MyProfileDota2.Country != player.Country)
                {
                    continue;
                }
                if (GlobalVariables.MyProfileDota2.City != player.City)
                {
                    continue;
                }
                if (GlobalVariables.MyProfileDota2.Role != player.Role)
                {
                    continue;
                }
                if (!(GlobalVariables.MyProfileDota2.Signature[0] == player.Signature[0] || GlobalVariables.MyProfileDota2.Signature[0] == player.Signature[1] || GlobalVariables.MyProfileDota2.Signature[0] == player.Signature[2]))
                {
                    temp1 = true;
                }
                if (!(GlobalVariables.MyProfileDota2.Signature[1] == player.Signature[0] || GlobalVariables.MyProfileDota2.Signature[1] == player.Signature[1] || GlobalVariables.MyProfileDota2.Signature[1] == player.Signature[2]))
                {
                    temp2 = true;
                }
                if (!(GlobalVariables.MyProfileDota2.Signature[2] == player.Signature[0] || GlobalVariables.MyProfileDota2.Signature[2] == player.Signature[1] || GlobalVariables.MyProfileDota2.Signature[2] == player.Signature[2]))
                {
                    temp3 = true;
                }
                if (!(temp1 || temp2 || temp3))
                {
                    continue;
                }
                listPlayer.Add(player);
            }

            List2Player.Items.Clear();
            foreach (Player Player in listPlayer)
            {
                if (Player.Nickname != "")
                {
                    List2Player.Items.Add(Player.MajorInfo());
                }
            }
            if (List2Player.Items.Count == 0)
            {
                List2Player.Items.Add(GlobalVariables.SelectedDiscypline == "Dota2" ? GlobalVariables.PlayerDota2Clear.MajorInfo() : GlobalVariables.PlayerCSGOClear.MajorInfo());
            }
            List2Player.SelectedIndex = 0;
            List2Player.Visible = true;
        }

        private void FormListPlayer_Load(object sender, EventArgs e)
        {
            //MethodsReadFile.WriteFile((Dota2Player)GlobalVariables.ListPlayerInDiscypline[0][0]);
            if (GlobalVariables.SelectedDiscypline == "CSGO")
            {
                LabelSignature.Text = "Оружие:";
                LabelSignature2.Text = "Оружие:";
            }

            ListPlayer.Items.Clear();
            List2Player.Items.Clear();

            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[GlobalVariables.SelectedDiscypline == "Dota2" ? 0: 1])
            {
                if (player.Name != "")
                {
                    ListPlayer.Items.Add(player.MajorInfo());
                    List2Player.Items.Add(player.MajorInfo());
                }
            }

            comboBoxFilterTeam.DataSource = new List<string>(GlobalVariables.ListTeam);
            comboBoxFilterCountry.DataSource = new List<string>(GlobalVariables.ListCountry);
            comboBoxFilterCity.DataSource = new List<string>(GlobalVariables.ListCity);
            comboBoxFilterRole.DataSource = new List<string>(GlobalVariables.ListRole);
            comboBoxFilterHero.DataSource = new List<string>(GlobalVariables.ListHero);

            //FilterClear();

            comboBoxFilterTeam2.DataSource = new List<string>(GlobalVariables.ListTeam);
            comboBoxFilterCountry2.DataSource = new List<string>(GlobalVariables.ListCountry);
            comboBoxFilterCity2.DataSource = new List<string>(GlobalVariables.ListCity);
            comboBoxFilterRole2.DataSource = new List<string>(GlobalVariables.ListRole);
            comboBoxFilterHero2.DataSource = new List<string>(GlobalVariables.ListHero);

            //FilterClear2();
        }

        private void FormListPlayer_Shown(object sender, EventArgs e)
        {
            PictureBoxPentagon.Refresh();
            ListPlayer.SelectedIndex = 0;
            List2Player.SelectedIndex = 0;
            List2Player_SelectedIndexChanged(null, null);
        }

        private void ButtonEditPlayer_Click(object sender, EventArgs e)
        {
            buttonEditPhotoPrifile.Visible = true;
            buttonCancel.Visible = true;
            buttonDelete.Visible = false;

            TextBoxEditName.Visible = true;
            TextBoxEditSurname.Visible = true;
            TextBoxEditNickname.Visible = true;
            TextBoxEditTeam.Visible = true;
            TextBoxEditCity.Visible = true;
            TextBoxEditCountry.Visible = true;
            TextBoxEditCity.Visible = true;
            dateTimeEditDateBirth.Visible = true;
            TextBoxEditRole.Visible = true;

            comboBoxEditHero1.Visible = true;
            comboBoxEditHero2.Visible = true;
            comboBoxEditHero3.Visible = true;

            TextBoxEditNumberGames.Visible = true;
            TextBoxEditProcentWin.Visible = true;
            TextBoxEditMMR.Visible = true;

            comboBoxPentagon1.Visible = true;
            comboBoxPentagon2.Visible = true;
            comboBoxPentagon3.Visible = true;
            comboBoxPentagon4.Visible = true;
            comboBoxPentagon5.Visible = true;

            PictureBoxSignature1.Visible = false;
            PictureBoxSignature2.Visible = false;
            PictureBoxSignature3.Visible = false;

            ButtonEditPlayerSend.Visible = true;

            comboBoxEditHero1.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBoxEditHero2.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBoxEditHero3.DataSource = new List<string>(GlobalVariables.ListHero);
        }

        private void HideEditField()
        {
            buttonEditPhotoPrifile.Visible = false;
            buttonCancel.Visible = false;
            buttonDelete.Visible = true;

            TextBoxEditName.Visible = false;
            TextBoxEditSurname.Visible = false;
            TextBoxEditNickname.Visible = false;
            TextBoxEditTeam.Visible = false;
            TextBoxEditCity.Visible = false;
            TextBoxEditCountry.Visible = false;
            TextBoxEditCity.Visible = false;
            dateTimeEditDateBirth.Visible = false;
            TextBoxEditRole.Visible = false;

            comboBoxEditHero1.Visible = false;
            comboBoxEditHero2.Visible = false;
            comboBoxEditHero3.Visible = false;

            TextBoxEditNumberGames.Visible = false;
            TextBoxEditProcentWin.Visible = false;
            TextBoxEditMMR.Visible = false;

            comboBoxPentagon1.Visible = false;
            comboBoxPentagon2.Visible = false;
            comboBoxPentagon3.Visible = false;
            comboBoxPentagon4.Visible = false;
            comboBoxPentagon5.Visible = false;

            PictureBoxSignature1.Visible = true;
            PictureBoxSignature2.Visible = true;
            PictureBoxSignature3.Visible = true;

            ButtonEditPlayerSend.Visible = false;
        }
        private void ButtonEditPlayerSend_Click(object sender, EventArgs e)
        {
            HideEditField();

            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                Dota2Player tempPlayer = null;
                foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
                {
                    if (player.MajorInfo() == (string)ListPlayer.SelectedItem)
                    {
                        tempPlayer = new Dota2Player(player);
                        break;
                    }
                }
                string tempName = String.Copy(tempPlayer.Name);
                string tempNickname = String.Copy(tempPlayer.Nickname);
                string tempSurname = String.Copy(tempPlayer.Surname);

                string tempTeam = String.Copy(tempPlayer.Team);
                string tempCountry = String.Copy(tempPlayer.Country);
                string tempCity = String.Copy(tempPlayer.City);
                string tempNationality = tempCountry;
                string tempDateBirth = ((tempPlayer.DateBirth.Day < 10) ? ("0" + tempPlayer.DateBirth.Day) : (Convert.ToString(tempPlayer.DateBirth.Day))) + "." + ((tempPlayer.DateBirth.Month < 10) ? ("0" + tempPlayer.DateBirth.Month) : (Convert.ToString(tempPlayer.DateBirth.Month))) + "." + tempPlayer.DateBirth.Year;
                string tempRole = String.Copy(tempPlayer.Role);
                string[] tempSignature = tempPlayer.Signature;
                string tempNumberGames = Convert.ToString(tempPlayer.NumberGames);
                string tempProcentWin = Convert.ToString(tempPlayer.ProcentWinGames);
                string tempMMR = String.Copy(tempPlayer.MMR);
                int[] tempPentagon = tempPlayer.Pentagon;
                string tempPhotoProfile = tempPlayer.PhotoProfile;
                bool tempEdit = true;

                string TempOldNickname = "";

                if (TextBoxEditName.Text != "")
                {
                    tempName = TextBoxEditName.Text;
                }
                if (TextBoxEditSurname.Text != "")
                {
                    tempSurname = TextBoxEditSurname.Text;
                }
                if (TextBoxEditNickname.Text != "")
                {
                    TempOldNickname = string.Copy(tempNickname);
                    tempNickname = TextBoxEditNickname.Text;
                }
                if (TextBoxEditTeam.Text != "")
                {
                    tempTeam = TextBoxEditTeam.Text;
                }
                if (TextBoxEditCity.Text != "")
                {
                    tempCity = TextBoxEditCity.Text;
                }
                if (TextBoxEditCountry.Text != "")
                {
                    tempCountry = TextBoxEditCountry.Text;
                }
                if (((dateTimeEditDateBirth.Value.Day < 10) ? ("0" + dateTimeEditDateBirth.Value.Day) : (Convert.ToString(dateTimeEditDateBirth.Value.Day))) + "." + ((dateTimeEditDateBirth.Value.Month < 10) ? ("0" + dateTimeEditDateBirth.Value.Month) : (Convert.ToString(dateTimeEditDateBirth.Value.Month))) + "." + dateTimeEditDateBirth.Value.Year != "01.01.1900")
                {
                    tempDateBirth = ((dateTimeEditDateBirth.Value.Day < 10) ? ("0" + dateTimeEditDateBirth.Value.Day) : (Convert.ToString(dateTimeEditDateBirth.Value.Day))) + "." + ((dateTimeEditDateBirth.Value.Month < 10) ? ("0" + dateTimeEditDateBirth.Value.Month) : (Convert.ToString(dateTimeEditDateBirth.Value.Month))) + "." + dateTimeEditDateBirth.Value.Year;
                }
                if (TextBoxEditRole.Text != "")
                {
                    tempRole = TextBoxEditRole.Text;
                }

                if (comboBoxEditHero1.Text != "All")
                {
                    tempSignature[0] = comboBoxEditHero1.Text;
                }
                if (comboBoxEditHero2.Text != "All")
                {
                    tempSignature[1] = comboBoxEditHero2.Text;
                }
                if (comboBoxEditHero3.Text != "All")
                {
                    tempSignature[2] = comboBoxEditHero3.Text;
                }

                if (TextBoxEditNumberGames.Text != "")
                {
                    tempNumberGames = TextBoxEditNumberGames.Text;
                }
                if (TextBoxEditProcentWin.Text != "")
                {
                    tempProcentWin = TextBoxEditProcentWin.Text;
                }
                if (TextBoxEditMMR.Text != "")
                {
                    tempMMR = TextBoxEditMMR.Text;
                }
                if (openFileDialogEditPhotoProfile.FileName != "")
                {
                    tempPhotoProfile = tempNickname + ".png";
                }

                if (comboBoxPentagon1.SelectedItem != null)
                {
                    tempPentagon[0] = (int)comboBoxPentagon1.SelectedItem;
                }
                if (comboBoxPentagon2.SelectedItem != null)
                {
                    tempPentagon[1] = (int)comboBoxPentagon2.SelectedItem;
                }
                if (comboBoxPentagon3.SelectedItem != null)
                {
                    tempPentagon[2] = (int)comboBoxPentagon3.SelectedItem;
                }
                if (comboBoxPentagon4.SelectedItem != null)
                {
                    tempPentagon[3] = (int)comboBoxPentagon4.SelectedItem;
                }
                if (comboBoxPentagon5.SelectedItem != null)
                {
                    tempPentagon[4] = (int)comboBoxPentagon5.SelectedItem;
                }

                if (TempOldNickname != "")
                {
                    try
                    {
                        File.Copy(Environment.CurrentDirectory + @"\image\photoProfiles\" + TempOldNickname + ".png", Environment.CurrentDirectory + @"\image\photoProfiles\" + tempNickname + ".png");
                        File.Delete(Environment.CurrentDirectory + @"\image\photoProfiles\" + TempOldNickname + ".png");
                    }
                    catch (FileNotFoundException ex)
                    {
                        File.Copy(Environment.CurrentDirectory + @"\image\photoProfiles\default.png", Environment.CurrentDirectory + @"\image\photoProfiles\" + tempNickname + ".png");
                    }
                }
                //buttonSave.Visible = false;
                //MyProfiles[0] = new Dota2Player(new object[] { Dota2Name, Dota2Nickname, Dota2Surname, Dota2Team, Dota2Country, Dota2City, Dota2Nationality, Dota2DateBirth, Dota2Role, Dota2Signature, Dota2NumberGames, Dota2ProcentWinGames, Dota2MMR, Dota2Pentagon, Dota2PhotoProfile });

                Dota2Player EditedPlayer = new Dota2Player(new object[] { tempName, tempNickname, tempSurname, tempTeam, tempCountry, tempCity, tempNationality, tempDateBirth, tempRole, tempSignature, tempNumberGames, tempProcentWin, tempMMR, tempPentagon, tempPhotoProfile, tempEdit });

                MethodsWorkWithFile.EditFile(tempPlayer, EditedPlayer, "ListPlayer.txt");

                GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

                MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
                GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

                //FormListPlayer_Load(null, null);
                this.Close();
                GlobalVariables.MainFormObject.labelDota2_Click(null, null);
            }
            else
            {
                CSGOPlayer tempPlayer = new CSGOPlayer(GlobalVariables.MyProfileCSGO);
            }
        }

        private void ButtonEdit2Player_Click(object sender, EventArgs e)
        {
            buttonEditPhotoPrifile2.Visible = true;
            buttonCancel2.Visible = true;
            buttonDelete2.Visible = false;

            TextBoxEditName2.Visible = true;
            TextBoxEditSurname2.Visible = true;
            TextBoxEditNickname2.Visible = true;
            TextBoxEditTeam2.Visible = true;
            TextBoxEditCity2.Visible = true;
            TextBoxEditCountry2.Visible = true;
            TextBoxEditCity2.Visible = true;
            dateTimeEditDateBirth2.Visible = true;
            TextBoxEditRole2.Visible = true;

            comboBox2EditHero1.Visible = true;
            comboBox2EditHero2.Visible = true;
            comboBox2EditHero3.Visible = true;

            TextBoxEditNumberGames2.Visible = true;
            TextBoxEditProcentWin2.Visible = true;
            TextBoxEditMMR2.Visible = true;

            comboBox2Pentagon1.Visible = true;
            comboBox2Pentagon2.Visible = true;
            comboBox2Pentagon3.Visible = true;
            comboBox2Pentagon4.Visible = true;
            comboBox2Pentagon5.Visible = true;

            PictureBox2Signature1.Visible = false;
            PictureBox2Signature2.Visible = false;
            PictureBox2Signature3.Visible = false;

            ButtonEdit2PlayerSend.Visible = true;

            comboBox2EditHero1.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBox2EditHero2.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBox2EditHero3.DataSource = new List<string>(GlobalVariables.ListHero);
        }

        private void HideEditField2()
        {
            buttonEditPhotoPrifile2.Visible = false;
            buttonCancel2.Visible = false;
            buttonDelete2.Visible = true;

            TextBoxEditName2.Visible = false;
            TextBoxEditSurname2.Visible = false;
            TextBoxEditNickname2.Visible = false;
            TextBoxEditTeam2.Visible = false;
            TextBoxEditCity2.Visible = false;
            TextBoxEditCountry2.Visible = false;
            TextBoxEditCity2.Visible = false;
            dateTimeEditDateBirth2.Visible = false;
            TextBoxEditRole2.Visible = false;

            comboBox2EditHero1.Visible = false;
            comboBox2EditHero2.Visible = false;
            comboBox2EditHero3.Visible = false;

            TextBoxEditNumberGames2.Visible = false;
            TextBoxEditProcentWin2.Visible = false;
            TextBoxEditMMR2.Visible = false;

            comboBox2Pentagon1.Visible = false;
            comboBox2Pentagon2.Visible = false;
            comboBox2Pentagon3.Visible = false;
            comboBox2Pentagon4.Visible = false;
            comboBox2Pentagon5.Visible = false;

            PictureBox2Signature1.Visible = true;
            PictureBox2Signature2.Visible = true;
            PictureBox2Signature3.Visible = true;

            ButtonEdit2PlayerSend.Visible = false;
        }
        private void ButtonEdit2PlayerSend_Click(object sender, EventArgs e)
        {
            HideEditField2();

            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                Dota2Player tempPlayer = null;
                foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
                {
                    if (player.MajorInfo() == (string)List2Player.SelectedItem)
                    {
                        tempPlayer = new Dota2Player(player);
                        break;
                    }
                }
                string tempName = String.Copy(tempPlayer.Name);
                string tempNickname = String.Copy(tempPlayer.Nickname);
                string tempSurname = String.Copy(tempPlayer.Surname);

                string tempTeam = String.Copy(tempPlayer.Team);
                string tempCountry = String.Copy(tempPlayer.Country);
                string tempCity = String.Copy(tempPlayer.City);
                string tempNationality = tempCountry;
                string tempDateBirth = ((tempPlayer.DateBirth.Day < 10) ? ("0" + tempPlayer.DateBirth.Day) : (Convert.ToString(tempPlayer.DateBirth.Day))) + "." + ((tempPlayer.DateBirth.Month < 10) ? ("0" + tempPlayer.DateBirth.Month) : (Convert.ToString(tempPlayer.DateBirth.Month))) + "." + tempPlayer.DateBirth.Year;
                string tempRole = String.Copy(tempPlayer.Role);
                string[] tempSignature = tempPlayer.Signature;
                string tempNumberGames = Convert.ToString(tempPlayer.NumberGames);
                string tempProcentWin = Convert.ToString(tempPlayer.ProcentWinGames);
                string tempMMR = String.Copy(tempPlayer.MMR);
                int[] tempPentagon = tempPlayer.Pentagon;
                string tempPhotoProfile = tempPlayer.PhotoProfile;
                bool tempEdit = true;

                string TempOldNickname = "";

                if (TextBoxEditName2.Text != "")
                {
                    tempName = TextBoxEditName2.Text;
                }
                if (TextBoxEditSurname2.Text != "")
                {
                    tempSurname = TextBoxEditSurname2.Text;
                }
                if (TextBoxEditNickname2.Text != "")
                {
                    TempOldNickname = string.Copy(tempNickname);
                    tempNickname = TextBoxEditNickname2.Text;
                }
                if (TextBoxEditTeam2.Text != "")
                {
                    tempTeam = TextBoxEditTeam2.Text;
                }
                if (TextBoxEditCity2.Text != "")
                {
                    tempCity = TextBoxEditCity2.Text;
                }
                if (TextBoxEditCountry2.Text != "")
                {
                    tempCountry = TextBoxEditCountry2.Text;
                }
                if (((dateTimeEditDateBirth2.Value.Day < 10) ? ("0" + dateTimeEditDateBirth2.Value.Day) : (Convert.ToString(dateTimeEditDateBirth2.Value.Day))) + "." + ((dateTimeEditDateBirth2.Value.Month < 10) ? ("0" + dateTimeEditDateBirth2.Value.Month) : (Convert.ToString(dateTimeEditDateBirth2.Value.Month))) + "." + dateTimeEditDateBirth2.Value.Year != "01.01.1900")
                {
                    tempDateBirth = ((dateTimeEditDateBirth2.Value.Day < 10) ? ("0" + dateTimeEditDateBirth2.Value.Day) : (Convert.ToString(dateTimeEditDateBirth2.Value.Day))) + "." + ((dateTimeEditDateBirth2.Value.Month < 10) ? ("0" + dateTimeEditDateBirth2.Value.Month) : (Convert.ToString(dateTimeEditDateBirth2.Value.Month))) + "." + dateTimeEditDateBirth2.Value.Year;
                }
                if (TextBoxEditRole.Text != "")
                {
                    tempRole = TextBoxEditRole2.Text;
                }

                if (comboBox2EditHero1.Text != "All")
                {
                    tempSignature[0] = comboBox2EditHero1.Text;
                }
                if (comboBox2EditHero2.Text != "All")
                {
                    tempSignature[1] = comboBox2EditHero2.Text;
                }
                if (comboBox2EditHero3.Text != "All")
                {
                    tempSignature[2] = comboBox2EditHero3.Text;
                }

                if (TextBoxEditNumberGames2.Text != "")
                {
                    tempNumberGames = TextBoxEditNumberGames2.Text;
                }
                if (TextBoxEditProcentWin2.Text != "")
                {
                    tempProcentWin = TextBoxEditProcentWin2.Text;
                }
                if (TextBoxEditMMR2.Text != "")
                {
                    tempMMR = TextBoxEditMMR2.Text;
                }
                if (openFileDialogEditPhotoProfile2.FileName != "")
                {
                    tempPhotoProfile = tempNickname + ".png";
                }

                if (comboBox2Pentagon1.SelectedItem != null)
                {
                    tempPentagon[0] = (int)comboBox2Pentagon1.SelectedItem;
                }
                if (comboBox2Pentagon2.SelectedItem != null)
                {
                    tempPentagon[1] = (int)comboBox2Pentagon2.SelectedItem;
                }
                if (comboBox2Pentagon3.SelectedItem != null)
                {
                    tempPentagon[2] = (int)comboBox2Pentagon3.SelectedItem;
                }
                if (comboBox2Pentagon4.SelectedItem != null)
                {
                    tempPentagon[3] = (int)comboBox2Pentagon4.SelectedItem;
                }
                if (comboBox2Pentagon5.SelectedItem != null)
                {
                    tempPentagon[4] = (int)comboBox2Pentagon5.SelectedItem;
                }

                if (TempOldNickname != "")
                {
                    try
                    {
                        File.Copy(Environment.CurrentDirectory + @"\image\photoProfiles\" + TempOldNickname + ".png", Environment.CurrentDirectory + @"\image\photoProfiles\" + tempNickname + ".png");
                        File.Delete(Environment.CurrentDirectory + @"\image\photoProfiles\" + TempOldNickname + ".png");
                    }
                    catch (FileNotFoundException ex)
                    {
                        File.Copy(Environment.CurrentDirectory + @"\image\photoProfiles\default.png", Environment.CurrentDirectory + @"\image\photoProfiles\" + tempNickname + ".png");
                    }
                }
                //buttonSave.Visible = false;
                //MyProfiles[0] = new Dota2Player(new object[] { Dota2Name, Dota2Nickname, Dota2Surname, Dota2Team, Dota2Country, Dota2City, Dota2Nationality, Dota2DateBirth, Dota2Role, Dota2Signature, Dota2NumberGames, Dota2ProcentWinGames, Dota2MMR, Dota2Pentagon, Dota2PhotoProfile });

                Dota2Player EditedPlayer = new Dota2Player(new object[] { tempName, tempNickname, tempSurname, tempTeam, tempCountry, tempCity, tempNationality, tempDateBirth, tempRole, tempSignature, tempNumberGames, tempProcentWin, tempMMR, tempPentagon, tempPhotoProfile, tempEdit });

                MethodsWorkWithFile.EditFile(tempPlayer, EditedPlayer, "ListPlayer.txt");

                GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

                MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
                GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

                //FormListPlayer_Load(null, null);
                this.Close();
                GlobalVariables.MainFormObject.labelDota2_Click(null, null);
            }
            else
            {
                CSGOPlayer tempPlayer = new CSGOPlayer(GlobalVariables.MyProfileCSGO);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            HideEditField();
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            HideEditField2();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                Dota2Player tempPlayer = null;
                foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
                {
                    if (player.MajorInfo() == (string)ListPlayer.SelectedItem)
                    {
                        tempPlayer = new Dota2Player(player);
                        break;
                    }
                }
                MethodsWorkWithFile.RemovePlayerInFile(tempPlayer, "ListPlayer.txt");

                GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

                MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
                GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

                this.Close();
                GlobalVariables.MainFormObject.labelDota2_Click(null, null);
            }
            else
            {
                
            }
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                Dota2Player tempPlayer = null;
                foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
                {
                    if (player.MajorInfo() == (string)List2Player.SelectedItem)
                    {
                        tempPlayer = new Dota2Player(player);
                        break;
                    }
                }
                MethodsWorkWithFile.RemovePlayerInFile(tempPlayer, "ListPlayer.txt");

                GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

                MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
                GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

                this.Close();
                GlobalVariables.MainFormObject.labelDota2_Click(null, null);
            }
            else
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ButtonEditPlayer_Click(null, null);

            for (int i = 1; i <= 10; i++)
            {
                comboBoxPentagon1.Items.Add(i);
                comboBoxPentagon2.Items.Add(i);
                comboBoxPentagon3.Items.Add(i);
                comboBoxPentagon4.Items.Add(i);
                comboBoxPentagon5.Items.Add(i);
            }
            comboBoxEditHero1.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBoxEditHero2.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBoxEditHero3.DataSource = new List<string>(GlobalVariables.ListHero);

            buttonAddSend.Visible = true;
        }

        private void buttonAddSend_Click(object sender, EventArgs e)
        {
            HideEditField();

            string tempName = "";
            string tempNickname = "";
            string tempSurname = "";

            string tempTeam = "";
            string tempCountry = "";
            string tempCity = "";
            string tempNationality = tempCountry;
            string tempDateBirth = "";
            string tempRole = "";
            string[] tempSignature = new string[3];
            string tempNumberGames = "";
            string tempProcentWin = "";
            string tempMMR = "";
            int[] tempPentagon = new int[5];
            string tempPhotoProfile = "default.png";
            bool tempEdit = true;

            if (TextBoxEditName.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempName = TextBoxEditName.Text;
            }
            if (TextBoxEditSurname.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempSurname = TextBoxEditSurname.Text;
            }
            if (TextBoxEditNickname.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempNickname = TextBoxEditNickname.Text;
            }
            if (TextBoxEditTeam.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempTeam = TextBoxEditTeam.Text;
            }
            if (TextBoxEditCity.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempCity = TextBoxEditCity.Text;
            }
            if (TextBoxEditCountry.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempCountry = TextBoxEditCountry.Text;
                tempNationality = tempCountry;
            }
            if (((dateTimeEditDateBirth.Value.Day < 10) ? ("0" + dateTimeEditDateBirth.Value.Day) : (Convert.ToString(dateTimeEditDateBirth.Value.Day))) + "." + ((dateTimeEditDateBirth.Value.Month < 10) ? ("0" + dateTimeEditDateBirth.Value.Month) : (Convert.ToString(dateTimeEditDateBirth.Value.Month))) + "." + dateTimeEditDateBirth.Value.Year == "01.01.1900")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempDateBirth = ((dateTimeEditDateBirth.Value.Day < 10) ? ("0" + dateTimeEditDateBirth.Value.Day) : (Convert.ToString(dateTimeEditDateBirth.Value.Day))) + "." + ((dateTimeEditDateBirth.Value.Month < 10) ? ("0" + dateTimeEditDateBirth.Value.Month) : (Convert.ToString(dateTimeEditDateBirth.Value.Month))) + "." + dateTimeEditDateBirth.Value.Year;
            }
            if (TextBoxEditRole.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempRole = TextBoxEditRole.Text;
            }

            if (comboBoxEditHero1.Text == "All")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempSignature[0] = comboBoxEditHero1.Text;
            }
            if (comboBoxEditHero2.Text == "All")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempSignature[1] = comboBoxEditHero2.Text;
            }
            if (comboBoxEditHero3.Text == "All")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempSignature[2] = comboBoxEditHero3.Text;
            }

            if (TextBoxEditNumberGames.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempNumberGames = TextBoxEditNumberGames.Text;
            }
            if (TextBoxEditProcentWin.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempProcentWin = TextBoxEditProcentWin.Text;
            }
            if (TextBoxEditMMR.Text == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempMMR = TextBoxEditMMR.Text;
            }
            if (openFileDialogEditPhotoProfile.FileName == "")
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempPhotoProfile = tempNickname + ".png";
            }

            if (comboBoxPentagon1.SelectedItem == null)
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempPentagon[0] = (int)comboBoxPentagon1.SelectedItem;
            }
            if (comboBoxPentagon2.SelectedItem == null)
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempPentagon[1] = (int)comboBoxPentagon2.SelectedItem;
            }
            if (comboBoxPentagon3.SelectedItem == null)
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempPentagon[2] = (int)comboBoxPentagon3.SelectedItem;
            }
            if (comboBoxPentagon4.SelectedItem == null)
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempPentagon[3] = (int)comboBoxPentagon4.SelectedItem;
            }
            if (comboBoxPentagon5.SelectedItem == null)
            {
                GlobalVariables.MessageErrorData();
                return;
            }
            else
            {
                tempPentagon[4] = (int)comboBoxPentagon5.SelectedItem;
            }

            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                //Dota2Player tempPlayer = null;
                Dota2Player tempPlayer = new Dota2Player(new object[] { tempName, tempNickname, tempSurname, tempTeam, tempCountry, tempCity, tempNationality, tempDateBirth, tempRole, tempSignature, tempNumberGames, tempProcentWin, tempMMR, tempPentagon, tempPhotoProfile, tempEdit });
                MethodsWorkWithFile.WriteFile(tempPlayer, "ListPlayer.txt");

                GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

                MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
                GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

                this.Close();
                GlobalVariables.MainFormObject.labelDota2_Click(null, null);
            }
            else
            {

            }
        }

        private void buttonEditPhotoPrifile_Click(object sender, EventArgs e)
        {
            if (TextBoxEditNickname.Text == "")
            {
                MessageBox.Show("Внимание", "Введите сначала Nickname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (openFileDialogEditPhotoProfile.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string selectedFile = openFileDialogEditPhotoProfile.FileName;
            try
            {
                File.Copy(selectedFile, Environment.CurrentDirectory + @"\image\photoProfiles\" + TextBoxEditNickname.Text + ".png");
            }
            catch (IOException ex)
            {
                File.Delete(Environment.CurrentDirectory + @"\image\photoProfiles\" + TextBoxEditNickname.Text + ".png");
                File.Copy(selectedFile, Environment.CurrentDirectory + @"\image\photoProfiles\" + TextBoxEditNickname.Text + ".png");
            }
        }
    }
}
