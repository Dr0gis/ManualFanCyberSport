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
            List<Player> ListTopPlayersDota2 = GlobalVariables.ListPlayerInDiscypline[0];
            List<Player> ListTopPlayersCSGO = GlobalVariables.ListPlayerInDiscypline[1];

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
        }

        private void labelDota2_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDiscypline = "Dota2";
            FormListPlayer FormDota2 = new FormListPlayer();
            FormDota2.Show();
            this.Hide();
            FormDota2.Text = "Список профессиональных игроков Dota 2";
            FormDota2.PictureBoxLogoGame.Image = Properties.Resources.dota2logo100;
            /*foreach (List<Player> discypline in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player player in discypline)
                {
                    FormDota2.textBoxExample.Text += player.MajorInfo();
                    FormDota2.textBoxExample.Text += '\n';
                }
            }*/
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
            {
                FormDota2.ListDota2Player.Items.Add(player.MajorInfo());
                FormDota2.ListDota2Player2.Items.Add(player.MajorInfo());
            }
            //FormDota2.ListDota2Player.SelectedIndex = 0;
            //FormDota2.ListDota2Player2.SelectedIndex = 0;
        }

        private void labelCSGO_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDiscypline = "CSGO";
            FormListPlayer FormCSGO = new FormListPlayer();
            FormCSGO.Show();
            this.Hide();
            FormCSGO.PictureBoxLogoGame.Image = Properties.Resources.csgologo43;
            FormCSGO.Text = "Список профессиональных игроков CS:GO";
            /*foreach (List<Player> discypline in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player player in discypline)
                {
                    FormCSGO.textBoxExample.Text += player.MajorInfo();
                    FormCSGO.textBoxExample.Text += '\n';
                }
            }*/
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[1])
            {
                FormCSGO.ListDota2Player.Items.Add(player.MajorInfo());
                FormCSGO.ListDota2Player2.Items.Add(player.MajorInfo());
            }
            //FormCSGO.ListDota2Player.SelectedIndex = 0;
            //FormCSGO.ListDota2Player2.SelectedIndex = 0;
        }
    }
}
