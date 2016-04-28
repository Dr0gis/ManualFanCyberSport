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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<Player>> ListPlayerInDiscypline = MethodsReadFile.CreateListPlayer();
            foreach (List<Player> discypline in ListPlayerInDiscypline)
            {
                foreach (Player player in discypline)
                {
                    textBoxExample.Text += player.MajorInfo();
                    textBoxExample.Text += '\n';
                }
            }
            foreach (Player player in ListPlayerInDiscypline[0])
            {
                ListDota2Player.Items.Add(player.MajorInfo());
            }
            foreach (Player player in ListPlayerInDiscypline[1])
            {
                ListCSGOPlayer.Items.Add(player.MajorInfo());
            }
        }
    }
}
