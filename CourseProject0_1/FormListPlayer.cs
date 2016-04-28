using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void SelectPlayerInDoat2List(object sender, EventArgs e)
        {
            string SelectedPlayerMajorInfo = (string)ListDota2Player.SelectedItem;
            string SelectedPlayerName = "";
            string SelectedPlayerNickname = "";
            string SelectedPlayerSurname = "";
            //string SelectedPlayerAllInfo = 
            string SelectedPlayerTeam = "";
            string SelectedPlayerCountry = "";
            string SelectedPlayerCity = "";
            string SelectedPlayerAge = "";
            string SelectedPlayerRole = "";
            string SelectedPlayerSignature = "";
            string SelectedPlayerNumberGames = "";
            string SelectedPlayerProcentWin = "";
            string SelectedPlayerMMR = "";
            int[] SelectedPlayerPentagon = new int[5];

            string SelectedPlayer2MajorInfo = (string)ListDota2Player2.SelectedItem;
            int[] SelectedPlayer2Pentagon = new int[5];

            string SelectedPlayerPhotoProfile = "";
            foreach (List<Player> ListPlayer in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player Player in ListPlayer)
                {
                    if (Player.MajorInfo() == SelectedPlayerMajorInfo)
                    {
                        //SelectedPlayerAllInfo = Player.AllInfo();
                        SelectedPlayerName = Player.Name;
                        SelectedPlayerNickname = Player.Nickname;
                        SelectedPlayerSurname = Player.Surname;

                        SelectedPlayerTeam = Player.Team;
                        SelectedPlayerTeam = Player.Team;
                        SelectedPlayerCountry = Player.Country;
                        SelectedPlayerCity = Player.City;
                        SelectedPlayerAge = Player.Age.ToString();
                        SelectedPlayerRole = Player.Role;
                        SelectedPlayerSignature = String.Join(", ", Player.Signature);
                        SelectedPlayerNumberGames = Player.NumberGames.ToString();
                        SelectedPlayerProcentWin = Player.ProcentWinGames.ToString();
                        SelectedPlayerMMR = Player.MMR;
                        SelectedPlayerPentagon = Player.Pentagon;

                        SelectedPlayerPhotoProfile = Player.PhotoProfile;
                    }
                    if (Player.MajorInfo() == SelectedPlayer2MajorInfo)
                    {
                        SelectedPlayer2Pentagon = Player.Pentagon;
                    }
                }
            }
            //textBoxExample.Text = SelectedPlayerAllInfo;
            LabelNameSelectedPlayer.Text = SelectedPlayerName;
            LabelNickameSelectedPlayer.Text = SelectedPlayerNickname;
            LabelSurnameSelectedPlayer.Text = SelectedPlayerSurname;

            LabelTeam.Text = "Команда: " + SelectedPlayerTeam;
            LabelCountry.Text = "Страна: " + SelectedPlayerCountry;
            LabelCity.Text = "Город: " + SelectedPlayerCity;
            LabelAge.Text = "Возраст: " + SelectedPlayerAge;
            LabelRole.Text = "Роль: " + SelectedPlayerRole;
            LabelSignature.Text = "Герои: " + SelectedPlayerSignature;
            LabelNumberGames.Text = "Количество игр: " + SelectedPlayerNumberGames;
            LabelProcentWin.Text = "Процент побед: " + SelectedPlayerProcentWin;
            LabelMMR.Text = "MMR: " + SelectedPlayerMMR;

            LabelPentagon.ForeColor = Color.Red;
            LabelPentagon2.ForeColor = Color.Aqua;
            LabelPentagon.Text = string.Join(", ", SelectedPlayerPentagon);
            if (string.Join(" ,", SelectedPlayer2Pentagon) == string.Join(" ,", SelectedPlayerPentagon))
            {
                LabelPentagon2.ForeColor = Color.DarkGray;
                LabelPentagon.ForeColor = Color.DarkGray;
            }
            /*textBoxExample.Text = string.Join("; ", GlobalVariables.ArrayCoordsPentagons[0]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[1]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[2]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[3]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[4]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[5]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[6]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[7]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[8]);
            textBoxExample.Text += "\n";
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[9]);*/

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

            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\" + SelectedPlayerPhotoProfile, true);
            PictureSelectedPlayer.Image = tempImage;
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

        private void ListDota2Player2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedPlayer2MajorInfo = (string)ListDota2Player2.SelectedItem;
            string SelectedPlayer2Name = "";
            string SelectedPlayer2Nickname = "";
            string SelectedPlayer2Surname = "";
            string SelectedPlayer2Team = "";
            string SelectedPlayer2Country = "";
            string SelectedPlayer2City = "";
            string SelectedPlayer2Age = "";
            string SelectedPlayer2Role = "";
            string SelectedPlayer2Signature = "";
            string SelectedPlayer2NumberGames = "";
            string SelectedPlayer2ProcentWin = "";
            string SelectedPlayer2MMR = "";
            int[] SelectedPlayer2Pentagon = new int[5];

            string SelectedPlayerMajorInfo = (string)ListDota2Player.SelectedItem;
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
                        SelectedPlayer2Signature = String.Join(", ", Player.Signature);
                        SelectedPlayer2NumberGames = Player.NumberGames.ToString();
                        SelectedPlayer2ProcentWin = Player.ProcentWinGames.ToString();
                        SelectedPlayer2MMR = Player.MMR;
                        SelectedPlayer2Pentagon = Player.Pentagon;

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
            LabelSignature2.Text = "Герои: " + SelectedPlayer2Signature;
            LabelNumberGames2.Text = "Количество игр: " + SelectedPlayer2NumberGames;
            LabelProcentWin2.Text = "Процент побед: " + SelectedPlayer2ProcentWin;
            LabelMMR2.Text = "MMR: " + SelectedPlayer2MMR;

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

            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\" + SelectedPlayerPhotoProfile, true);
            PictureSelectedPlayer2.Image = tempImage;
        }
    }
}
