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

        }

        private void labelDota2_Click(object sender, EventArgs e)
        {
            FormListPlayer FormDota2 = new FormListPlayer();
            FormDota2.Show();
            this.Hide();
            FormDota2.Text = "Список профессиональных игроков Dota 2";
            FormDota2.PictureBoxLogoGame.Image = Properties.Resources.dota2logo100;
            foreach (List<Player> discypline in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player player in discypline)
                {
                    FormDota2.textBoxExample.Text += player.MajorInfo();
                    FormDota2.textBoxExample.Text += '\n';
                }
            }
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
            {
                FormDota2.ListDota2Player.Items.Add(player.MajorInfo());
            }
        }

        private void labelCSGO_Click(object sender, EventArgs e)
        {
            FormListPlayer FormCSGO = new FormListPlayer();
            FormCSGO.Show();
            this.Hide();
            FormCSGO.PictureBoxLogoGame.Image = Properties.Resources.csgologo43;
            FormCSGO.Text = "Список профессиональных игроков CS:GO";
            foreach (List<Player> discypline in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player player in discypline)
                {
                    FormCSGO.textBoxExample.Text += player.MajorInfo();
                    FormCSGO.textBoxExample.Text += '\n';
                }
            }
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[1])
            {
                FormCSGO.ListDota2Player.Items.Add(player.MajorInfo());
            }
        }
    }
}
