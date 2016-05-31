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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            List<Player> ListTopPlayersDota2 = new List<Player>(GlobalVariables.ListPlayerInDiscypline[0]);
            List<Player> ListTopPlayersCSGO = new List<Player>(GlobalVariables.ListPlayerInDiscypline[1]);

            comboBoxPredictionSelectTeam.DataSource = new List<string>(GlobalVariables.ListFullTeam);
            comboBoxPredictionSelectTeam2.DataSource = new List<string>(GlobalVariables.ListFullTeam);

            ListTopPlayersDota2.Sort(delegate (Player a, Player b) { return b.MMR.CompareTo(a.MMR); });
            for (int i = 0; i < (ListTopPlayersDota2.Count() < 10 ? ListTopPlayersDota2.Count() : 10); i++)
            {
                ListDota2TopPlayer.Items.Add(ListTopPlayersDota2[i].MMRInfo());
            }

            ListTopPlayersCSGO.Sort(delegate (Player a, Player b) { return a.MMR.CompareTo(b.MMR); });
            for (int i = 0; i < (ListTopPlayersCSGO.Count() < 10 ? ListTopPlayersCSGO.Count() : 10); i++)
            {
                ListCSGOTopPlayer.Items.Add(ListTopPlayersCSGO[i].MMRInfo());
            }

            ListDota2TopPlayer.Refresh();
        }

        public void labelDota2_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDiscypline = "Dota2";
            FormListPlayer FormDota2 = new FormListPlayer();
            FormDota2.Show();
            this.Hide();
            FormDota2.Text = "Список профессиональных игроков Dota 2";
            FormDota2.PictureBoxLogoGame.Image = Properties.Resources.dota2_100_100;
            //foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
            //{
            //    if (player.Name != "")
            //    {
            //        FormDota2.ListPlayer.Items.Add(player.MajorInfo());
            //        FormDota2.List2Player.Items.Add(player.MajorInfo());
            //    }
            //}
        }

        public void labelCSGO_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDiscypline = "CSGO";
            FormListPlayer FormCSGO = new FormListPlayer();
            FormCSGO.Show();
            this.Hide();
            FormCSGO.PictureBoxLogoGame.Image = Properties.Resources.csgo_100_100;
            FormCSGO.Text = "Список профессиональных игроков CS:GO";
            //foreach (Player player in GlobalVariables.ListPlayerInDiscypline[1])
            //{
            //    if (player.Name != "")
            //    {
            //        FormCSGO.ListPlayer.Items.Add(player.MajorInfo());
            //        FormCSGO.List2Player.Items.Add(player.MajorInfo());
            //    }
            //}
        }

        private void buttonMyProfileDota2_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.FormMyProfileDota2Opened)
            {
                GlobalVariables.SelectedDiscypline = "Dota2";
                MyProfile FormMyProfileDota2 = new MyProfile();
                FormMyProfileDota2.Show();
                GlobalVariables.FormMyProfileDota2Opened = true;
            }
        }

        private void buttonMyProfileCSGO_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.FormMyProfileCSGOOpened)
            {
                GlobalVariables.SelectedDiscypline = "CSGO";
                MyProfile FormMyProfileCSGO = new MyProfile();
                FormMyProfileCSGO.Show();
                GlobalVariables.FormMyProfileCSGOOpened = true;
            }
        }

        private void buttonSinhronizacia_Click(object sender, EventArgs e)
        {
            if (openFileSinhronizacia.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            List<List<Player>> SelectedListPlayer =  MethodsWorkWithFile.CreateListPlayer(openFileSinhronizacia.SafeFileName);
            MethodsWorkWithFile.Sinhronizacia(GlobalVariables.ListPlayerInDiscypline, SelectedListPlayer);
            MessageBox.Show("Синхронизация прошла успешно", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

            MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

            GlobalVariables.SearchFullTeam();

            Player[] MyProfiles = MethodsWorkWithFile.ReadMyProfile();
            GlobalVariables.MyProfileDota2 = (Dota2Player)MyProfiles[0];
            GlobalVariables.MyProfileCSGO = (CSGOPlayer)MyProfiles[1];

            GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
            GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
            GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
            GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
            GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FormHelp Help1 = new FormHelp();
                Help1.Show();
            }
        }

        private void buttonCalculated_Click(object sender, EventArgs e)
        {
            labelPredictionResult.Text = "Результат: " + GlobalVariables.Prediction((string)comboBoxPredictionSelectTeam.SelectedItem, (string)comboBoxPredictionSelectTeam2.SelectedItem);
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            FormHelp Help1 = new FormHelp();
            Help1.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer("ListPlayer.txt");

            MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

            GlobalVariables.SearchFullTeam();

            Player[] MyProfiles = MethodsWorkWithFile.ReadMyProfile();
            GlobalVariables.MyProfileDota2 = (Dota2Player)MyProfiles[0];
            GlobalVariables.MyProfileCSGO = (CSGOPlayer)MyProfiles[1];

            GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
            GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
            GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
            GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.MyProfileCSGO);
            GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

        }
    }
}
