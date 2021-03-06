﻿using System;
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
            GlobalVariables.ListPlayerInDiscypline = MethodsReadFile.CreateListPlayer();
            foreach (List<Player> discypline in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player player in discypline)
                {
                    textBoxExample.Text += player.MajorInfo();
                    textBoxExample.Text += '\n';
                }
            }
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[0])
            {
                ListDota2Player.Items.Add(player.MajorInfo());
            }
            foreach (Player player in GlobalVariables.ListPlayerInDiscypline[1])
            {
                ListCSGOPlayer.Items.Add(player.MajorInfo());
            }
        }
        /*private void SelectPlayerInCSGOList(object sender, EventArgs e)
        {
            string SelectedPlayerMajorInfo = (string)ListCSGOPlayer.SelectedItem;
            string SelectedPlayerAllInfo = "";
            foreach (List<Player> ListPlayer in GlobalVariables.ListPlayerInDiscypline)
            {
                foreach (Player Player in ListPlayer)
                {
                    if (Player.MajorInfo() == SelectedPlayerMajorInfo)
                    {
                        SelectedPlayerAllInfo = Player.AllInfo();
                    }
                }
            }
            textBoxExample.Text = SelectedPlayerAllInfo;
        }*/
    }
}
