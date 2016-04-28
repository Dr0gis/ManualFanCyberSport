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
            textBoxExample.Text = string.Join("; ", GlobalVariables.ArrayCoordsPentagons[0]);
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
            textBoxExample.Text += string.Join("; ", GlobalVariables.ArrayCoordsPentagons[9]);

            // Прорисовка отрезков сторон пятиугольника игрока

            Graphics g = PictureBoxPentagon.CreateGraphics();

            /*g.DrawLine(Pens.Red, 5F, 77F, 100F, 18.1F);
            g.DrawLine(Pens.Red, 100F, 18.1F, 176F, 81.6F);
            g.DrawLine(Pens.Red, 176F, 81.6F, 140.6F, 163.7F);
            g.DrawLine(Pens.Red, 140.6F, 163.7F, 66.2F, 154.6F);
            g.DrawLine(Pens.Red, 66.2F, 154.6F, 5F, 77F);*/

            
            g.DrawLine
            (
                Pens.Red, 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][0], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][1], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][2], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][3]
            );
            g.DrawLine
            (
                Pens.Red, 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][2], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][3], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][4], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][5]
            );
            g.DrawLine
            (
                Pens.Red, 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][4], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][5], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][6], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][7]
            );
            g.DrawLine
            (
                Pens.Red, 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][6], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][7], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][8], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][9]
            );
            g.DrawLine
            (
                Pens.Red, 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][8], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][9], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][0], 
                GlobalVariables.ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][1]
            );
            //TextBoxPentagonTemp.Text = SelectedPlayerPentagon;

            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\" + SelectedPlayerPhotoProfile, true);
            PictureSelectedPlayer.Image = tempImage;
        }

        private void Form2Dota2_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariables.MainFormObject.Show();
        }

        private void PictureBoxPentagon_Paint(object sender, PaintEventArgs e)
        {
            float[][] ArrayCoordsPentagons = new float[10][];
            Graphics g = e.Graphics;
            GlobalVariables.graphic = g;
            float kooficient = 10F;
            float slagaemoe = 90F;
            for (int i = 2; i <= 11; i++)
            {
                ArrayCoordsPentagons[i - 2] = new float[10];
                g.DrawLine(Pens.DarkGray, 5F / kooficient + slagaemoe, 77F / kooficient + slagaemoe, 100F / kooficient + slagaemoe, 9F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][0] = 5F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][1] = 77F / kooficient + slagaemoe;

                g.DrawLine(Pens.DarkGray, 100F / kooficient + slagaemoe, 9F / kooficient + slagaemoe, 195F / kooficient + slagaemoe, 77F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][2] = 100F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][3] = 9F / kooficient + slagaemoe;

                g.DrawLine(Pens.DarkGray, 195F / kooficient + slagaemoe, 77F / kooficient + slagaemoe, 158F / kooficient + slagaemoe, 191F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][4] = 195F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][5] = 77F / kooficient + slagaemoe;

                g.DrawLine(Pens.DarkGray, 158F / kooficient + slagaemoe, 191F / kooficient + slagaemoe, 42F / kooficient + slagaemoe, 191F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][6] = 158F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][7] = 191F / kooficient + slagaemoe;

                g.DrawLine(Pens.DarkGray, 42F / kooficient + slagaemoe, 191F / kooficient + slagaemoe, 5F / kooficient + slagaemoe, 77F / kooficient + slagaemoe);
                ArrayCoordsPentagons[i - 2][8] = 42F / kooficient + slagaemoe;
                ArrayCoordsPentagons[i - 2][9] = 191F / kooficient + slagaemoe;

                kooficient = 10F / i;
                slagaemoe -= 10F;
            }
            GlobalVariables.ArrayCoordsPentagons = ArrayCoordsPentagons;
            /*
            // Прорисовка отрезков сторон 10 пятиугольника 
            g.DrawLine(Pens.DarkGray, 5, 77, 100, 9);
            g.DrawLine(Pens.DarkGray, 100, 9, 195, 77);
            g.DrawLine(Pens.DarkGray, 195, 77, 158, 191);
            g.DrawLine(Pens.DarkGray, 158, 191, 42, 191);
            g.DrawLine(Pens.DarkGray, 42, 191, 5, 77);
            
            // Прорисовка отрезков сторон 2 пятиугольника 
            g.DrawLine(Pens.DarkGray, 5 / 3.33F + 70, 77 / 3.33F + 70, 100 / 3.5F + 70, 9 / 3.5F + 70);
            g.DrawLine(Pens.DarkGray, 100 / 3.5F + 70, 9 / 3.5F + 70, 195 / 3.5F + 70, 77 / 3.5F + 70);
            g.DrawLine(Pens.DarkGray, 195 / 3.5F + 70, 77 / 3.5F + 70, 158 / 3.5F + 70, 191 / 3.5F + 70);
            g.DrawLine(Pens.DarkGray, 158 / 3.5F + 70, 191 / 3.5F + 70, 42 / 3.5F + 70, 191 / 3.5F + 70);
            g.DrawLine(Pens.DarkGray, 42 / 3.5F + 70, 191 / 3.5F + 70, 5 / 3.5F + 70, 77 / 3.5F + 70);

            // Прорисовка отрезков сторон 2 пятиугольника 
            g.DrawLine(Pens.DarkGray, 5 /5 + 80, 77 / 5 + 80, 100 / 5 + 80, 9 / 5 + 80);
            g.DrawLine(Pens.DarkGray, 100 / 5 + 80, 9 / 5 + 80, 195 / 5 + 80, 77 / 5 + 80);
            g.DrawLine(Pens.DarkGray, 195 / 5 + 80, 77 / 5 + 80, 158 / 5 + 80, 191 / 5 + 80);
            g.DrawLine(Pens.DarkGray, 158 / 5 + 80, 191 / 5 + 80, 42 / 5 + 80, 191 / 5 + 80);
            g.DrawLine(Pens.DarkGray, 42 / 5 + 80, 191 / 5 + 80, 5 / 5 + 80, 77 / 5 + 80);

            // Прорисовка отрезков сторон 1 пятиугольника 
            g.DrawLine(Pens.DarkGray, 5 / 10 + 90, 77 / 10 + 90, 100 / 10 + 90, 9 / 10 + 90);
            g.DrawLine(Pens.DarkGray, 100 / 10 + 90, 9 / 10 + 90, 195 / 10 + 90, 77 / 10 + 90);
            g.DrawLine(Pens.DarkGray, 195 / 10 + 90, 77 / 10 + 90, 158 / 10 + 90, 191 / 10 + 90);
            g.DrawLine(Pens.DarkGray, 158 / 10 + 90, 191 / 10 + 90, 42 / 10 + 90, 191 / 10 + 90);
            g.DrawLine(Pens.DarkGray, 42 / 10 + 90, 191 / 10 + 90, 5 / 10 + 90, 77 / 10 + 90);
            */

            g.DrawLine(Pens.DarkGray, 100, 100, 5, 77);
            g.DrawLine(Pens.DarkGray, 100, 100, 100, 9);
            g.DrawLine(Pens.DarkGray, 100, 100, 195, 77);
            g.DrawLine(Pens.DarkGray, 100, 100, 158, 191);
            g.DrawLine(Pens.DarkGray, 100, 100, 42, 191);
        }
    }
}
