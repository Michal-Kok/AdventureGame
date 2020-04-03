using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace AdventureGame
{
    public partial class AdventureGame : Form
    {
        private Player player;

        public AdventureGame()
        {
            InitializeComponent();

            player = new Player();

            player.CurrentHitPoints = 10;
            player.MaximumHitPoints = 10;
            player.Gold = 20;
            player.ExperiencePoints = 10;
            player.Level = 1;

            lbl_Experience.Text = player.ExperiencePoints.ToString();
            lbl_HitPoints.Text = player.CurrentHitPoints.ToString();
            lbl_Gold.Text = player.Gold.ToString();
            lbl_Level.Text = player.Level.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
