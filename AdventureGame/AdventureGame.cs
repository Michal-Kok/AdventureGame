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

            Location location = new Location(1, "Home", "This is your new Home.", null, null, null);

            player = new Player(20, 200, 2, 20, 30);


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
