using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace CourseProject0_1
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void MyProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                GlobalVariables.FormMyProfileDota2Opened = false;
            }
            else
            {
                GlobalVariables.FormMyProfileCSGOOpened = false;
            }
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            comboBoxPentagon1.Items.Clear();
            comboBoxPentagon2.Items.Clear();
            comboBoxPentagon3.Items.Clear();
            comboBoxPentagon4.Items.Clear();
            comboBoxPentagon5.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                comboBoxPentagon1.Items.Add(i);
                comboBoxPentagon2.Items.Add(i);
                comboBoxPentagon3.Items.Add(i);
                comboBoxPentagon4.Items.Add(i);
                comboBoxPentagon5.Items.Add(i);
            }
            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                PictureBoxLogoGame.Image = Properties.Resources.dota2_100_100;
            }
            else
            {
                PictureBoxLogoGame.Image = Properties.Resources.csgo_100_100;
            }
            Player MyProfileTemp = GlobalVariables.SelectedDiscypline == "Dota2" ? (Player)GlobalVariables.MyProfileDota2 : (Player)GlobalVariables.MyProfileCSGO;
            LabelNameSelectedPlayer.Text = MyProfileTemp.Name;
            LabelNickameSelectedPlayer.Text = MyProfileTemp.Nickname;
            LabelSurnameSelectedPlayer.Text = MyProfileTemp.Surname;

            LabelTeam.Text = "Команда: " + MyProfileTemp.Team;
            LabelCountry.Text = "Страна: " + MyProfileTemp.Country;
            LabelCity.Text = "Город: " + MyProfileTemp.City;

            LabelDateBirth.Text = "Дата Рождения: " + ((MyProfileTemp.DateBirth.Day < 10) ? ("0" + MyProfileTemp.DateBirth.Day) : (Convert.ToString(MyProfileTemp.DateBirth.Day))) + "." + ((MyProfileTemp.DateBirth.Month < 10) ? ("0" + MyProfileTemp.DateBirth.Month) : (Convert.ToString(MyProfileTemp.DateBirth.Month))) + "." + MyProfileTemp.DateBirth.Year;
            labelAge.Text = "Возраст: " + MyProfileTemp.Age;
            LabelRole.Text = "Роль: " + MyProfileTemp.Role;

            PictureBoxSignature1.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + MyProfileTemp.Signature[0] + "_icon.png", true);
            PictureBoxSignature2.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + MyProfileTemp.Signature[1] + "_icon.png", true);
            PictureBoxSignature3.Image = new Bitmap(Environment.CurrentDirectory + ((GlobalVariables.SelectedDiscypline == "Dota2") ? @"\image\heroes\" : @"\image\weapons\") + MyProfileTemp.Signature[2] + "_icon.png", true);

            LabelNumberGames.Text = "Количество игр: " + MyProfileTemp.NumberGames;
            LabelProcentWin.Text = "Процент побед: " + MyProfileTemp.ProcentWinGames;
            LabelMMR.Text = "MMR: " + MyProfileTemp.MMR;
            labelPentagon.Text = string.Join(" ,", MyProfileTemp.Pentagon);

            //LabelPentagon.ForeColor = Color.Red;
            //LabelPentagon2.ForeColor = Color.Aqua;
            //LabelPentagon.Text = string.Join(", ", SelectedPlayerPentagon);
            Bitmap tempImage = new Bitmap(Environment.CurrentDirectory + @"\image\photoProfiles\" + MyProfileTemp.PhotoProfile, true);
            PictureSelectedPlayer.Image = ResizeImg(tempImage, 100, 100);
            tempImage.Dispose();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            comboBoxPentagon1.Visible = false;
            comboBoxPentagon2.Visible = false;
            comboBoxPentagon3.Visible = false;
            comboBoxPentagon4.Visible = false;
            comboBoxPentagon5.Visible = false;

            labelPentagon.Visible = true;

            PictureBoxSignature1.Visible = true;
            PictureBoxSignature2.Visible = true;
            PictureBoxSignature3.Visible = true;

            dateTimeDateBirth.Visible = false;
            comboBoxEditHero1.Visible = false;
            comboBoxEditHero2.Visible = false;
            comboBoxEditHero3.Visible = false;

            TextBoxEditName.Visible = false;
            TextBoxEditSurname.Visible = false;
            TextBoxEditNickname.Visible = false;
            TextBoxEditTeam.Visible = false;
            TextBoxEditCity.Visible = false;
            TextBoxEditCountry.Visible = false;
            //TextBoxEditCity.Visible = false;
            //TextBoxEditAge.Visible = false;
            TextBoxEditRole.Visible = false;
            TextBoxEditNumberGames.Visible = false;
            TextBoxEditProcentWin.Visible = false;
            TextBoxEditMMR.Visible = false;

            buttonSave.Visible = false;
            buttonEditPhotoPrifile.Visible = false;

            if (GlobalVariables.SelectedDiscypline == "Dota2")
            {
                Dota2Player tempPlayer = new Dota2Player(GlobalVariables.MyProfileDota2);
                string tempName = String.Copy(tempPlayer.Name);
                string tempNickname = String.Copy(tempPlayer.Nickname);
                string tempSurname = String.Copy(tempPlayer.Surname);
                
                string tempTeam = String.Copy(tempPlayer.Team);
                string tempCountry = String.Copy(tempPlayer.Country);
                string tempCity = String.Copy(tempPlayer.City);
                string tempNationality = tempCountry;
                string tempDateBirth = ((tempPlayer.DateBirth.Day < 10) ? ("0" + tempPlayer.DateBirth.Day) : (Convert.ToString(tempPlayer.DateBirth.Day))) + "." + ((tempPlayer.DateBirth.Month < 10) ? ("0" + tempPlayer.DateBirth.Month) : (Convert.ToString(tempPlayer.DateBirth.Month))) + "." + tempPlayer.DateBirth.Year;
                //string tempAge = Convert.ToString(tempPlayer.Age);
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
                if (((dateTimeDateBirth.Value.Day < 10) ? ("0" + dateTimeDateBirth.Value.Day) : (Convert.ToString(dateTimeDateBirth.Value.Day))) + "." + ((dateTimeDateBirth.Value.Month < 10) ? ("0" + dateTimeDateBirth.Value.Month) : (Convert.ToString(dateTimeDateBirth.Value.Month))) + "." + dateTimeDateBirth.Value.Year != "01.01.1900")
                {
                    tempDateBirth = ((dateTimeDateBirth.Value.Day < 10) ? ("0" + dateTimeDateBirth.Value.Day) : (Convert.ToString(dateTimeDateBirth.Value.Day))) + "." + ((dateTimeDateBirth.Value.Month < 10) ? ("0" + dateTimeDateBirth.Value.Month) : (Convert.ToString(dateTimeDateBirth.Value.Month))) + "." + dateTimeDateBirth.Value.Year;
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
                buttonSave.Visible = false;

                if (TempOldNickname != "")
                {
                    File.Copy(Environment.CurrentDirectory + @"\image\photoProfiles\" + TempOldNickname + ".png", Environment.CurrentDirectory + @"\image\photoProfiles\" + tempNickname + ".png");
                    File.Delete(Environment.CurrentDirectory + @"\image\photoProfiles\" + TempOldNickname + ".png");
                }
                //MyProfiles[0] = new Dota2Player(new object[] { Dota2Name, Dota2Nickname, Dota2Surname, Dota2Team, Dota2Country, Dota2City, Dota2Nationality, Dota2DateBirth, Dota2Role, Dota2Signature, Dota2NumberGames, Dota2ProcentWinGames, Dota2MMR, Dota2Pentagon, Dota2PhotoProfile });

                GlobalVariables.MyProfileDota2 = new Dota2Player(new object[] { tempName, tempNickname, tempSurname, tempTeam, tempCountry, tempCity, tempNationality, tempDateBirth, tempRole, tempSignature, tempNumberGames, tempProcentWin, tempMMR, tempPentagon, tempPhotoProfile, tempEdit });

                MethodsWorkWithFile.EditFile(tempPlayer, GlobalVariables.MyProfileDota2, "MyProfile.txt");

                GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

                MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

                Player[] MyProfiles = MethodsWorkWithFile.ReadMyProfile();
                GlobalVariables.MyProfileDota2 = (Dota2Player)MyProfiles[0];
                GlobalVariables.MyProfileCSGO = (CSGOPlayer)MyProfiles[1];

                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
                GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
                GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
                GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

                MyProfile_Load(null, null);
                
            }
            else
            {
                CSGOPlayer tempPlayer = new CSGOPlayer(GlobalVariables.MyProfileCSGO);
            }
                //MethodsWorkWithFile.EditFile(GlobalVariables.MyProfileDota2, GlobalVariables.MyProfileDota2);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            labelPentagon.Visible = false;
            comboBoxPentagon1.Visible = true;
            comboBoxPentagon2.Visible = true;
            comboBoxPentagon3.Visible = true;
            comboBoxPentagon4.Visible = true;
            comboBoxPentagon5.Visible = true;

            PictureBoxSignature1.Visible = false;
            PictureBoxSignature2.Visible = false;
            PictureBoxSignature3.Visible = false;

            dateTimeDateBirth.Visible = true;
            comboBoxEditHero1.Visible = true;
            comboBoxEditHero2.Visible = true;
            comboBoxEditHero3.Visible = true;

            TextBoxEditName.Visible = true;
            TextBoxEditSurname.Visible = true;
            TextBoxEditNickname.Visible = true;
            TextBoxEditTeam.Visible = true;
            TextBoxEditCity.Visible = true;
            TextBoxEditCountry.Visible = true;
            TextBoxEditCity.Visible = true;
            //TextBoxEditAge.Visible = true;
            TextBoxEditRole.Visible = true;
            TextBoxEditNumberGames.Visible = true;
            TextBoxEditProcentWin.Visible = true;
            TextBoxEditMMR.Visible = true;

            buttonSave.Visible = true;
            buttonEditPhotoPrifile.Visible = true;

            dateTimeDateBirth.Value = new DateTime(1900, 1, 1);

            comboBoxEditHero1.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBoxEditHero2.DataSource = new List<string>(GlobalVariables.ListHero);
            comboBoxEditHero3.DataSource = new List<string>(GlobalVariables.ListHero);
        }

        private void buttonEditPhotoPrifile_Click(object sender, EventArgs e)
        {
            if (openFileDialogEditPhotoProfile.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string selectedFile = openFileDialogEditPhotoProfile.FileName;
            try
            {
                File.Copy(selectedFile, Environment.CurrentDirectory + @"\image\photoProfiles\" + GlobalVariables.MyProfileDota2.Nickname + ".png");
            }
            catch (IOException ex)
            {
                File.Delete(Environment.CurrentDirectory + @"\image\photoProfiles\" + GlobalVariables.MyProfileDota2.Nickname + ".png");
                File.Copy(selectedFile, Environment.CurrentDirectory + @"\image\photoProfiles\" + GlobalVariables.MyProfileDota2.Nickname + ".png");
            }
        }
    }
}
