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

            ListTopPlayersDota2.Sort(delegate (Player a, Player b) { return b.MMR.CompareTo(a.MMR); });
            for (int i = 0; i < (ListTopPlayersDota2.Count() < 10 ? ListTopPlayersDota2.Count() : 10); i++)
            {
                ListDota2TopPlayer.Items.Add(ListTopPlayersDota2[i].MMRInfo());
            }

            ListTopPlayersCSGO.Sort(delegate (Player a, Player b) { return b.MMR.CompareTo(a.MMR); });
            for (int i = 0; i < (ListTopPlayersCSGO.Count() < 10 ? ListTopPlayersCSGO.Count() : 10); i++)
            {
                ListCSGOTopPlayer.Items.Add(ListTopPlayersCSGO[i].MMRInfo());
            }

            ListDota2TopPlayer.Refresh();
        }

        private void labelDota2_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDiscypline = "Dota2";
            FormListPlayer FormDota2 = new FormListPlayer();
            FormDota2.Show();
            this.Hide();
            FormDota2.Text = "Список профессиональных игроков Dota 2";
            FormDota2.PictureBoxLogoGame.Image = Properties.Resources.dota2_100_100;
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
            {
                FormDota2.ListPlayer.Items.Add(player.MajorInfo());
                FormDota2.List2Player.Items.Add(player.MajorInfo());
            }

            //FormDota2.PictureBoxPentagon.Refresh();
            //FormDota2.ListPlayer.SelectedIndex = 0;
            //FormDota2.List2Player.SelectedIndex = 0;
        }

        private void labelCSGO_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDiscypline = "CSGO";
            FormListPlayer FormCSGO = new FormListPlayer();
            FormCSGO.Show();
            this.Hide();
            FormCSGO.PictureBoxLogoGame.Image = Properties.Resources.csgo_100_100;
            FormCSGO.Text = "Список профессиональных игроков CS:GO";
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[1])
            {
                FormCSGO.ListPlayer.Items.Add(player.MajorInfo());
                FormCSGO.List2Player.Items.Add(player.MajorInfo());
            }

            //FormCSGO.PictureBoxPentagon.Refresh();
            //FormCSGO.ListPlayer.SelectedIndex = 0;
            //FormCSGO.List2Player.SelectedIndex = 0;
        }
    }
}
