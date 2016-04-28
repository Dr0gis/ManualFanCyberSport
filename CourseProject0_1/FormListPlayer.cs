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
            string SelectedPlayerPhotoProfile = "";
            string SelectedPlayerRole = "";
            string SelectedPlayerSignature = "";
            string SelectedPlayerNumberGames = "";
            string SelectedPlayerProcentWin = "";
            string SelectedPlayerMMR = "";
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
                        SelectedPlayerSignature = String.Join(",", Player.Signature);
                        SelectedPlayerNumberGames = Player.NumberGames.ToString();
                        SelectedPlayerProcentWin = Player.ProcentWinGames.ToString();
                        SelectedPlayerMMR = Player.MMR;

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

            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\" + SelectedPlayerPhotoProfile, true);
            PictureSelectedPlayer.Image = tempImage;
        }

        private void Form2Dota2_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariables.MainFormObject.Show();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            // Создаем локальную версию графического объекта для PictureBox
            Graphics g = e.Graphics;

            // Прорисовка отрезков сторон треугольника
            g.DrawLine(Pens.Red, 80, 37, 127, 166);
            g.DrawLine(Pens.Red, 127, 166, 36, 167);
            g.DrawLine(Pens.Red, 36, 167, 80, 37);
        }
    }
}
