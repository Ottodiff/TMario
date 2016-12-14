using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Tournoi_MarioKart_Reina_Sadowski_Pin
{
    public partial class Form1 : Form
    {

        Player pl = new Player();

        public Form1()
        {
            InitializeComponent();

            btnCreationEquipe.Enabled = false;
            btnCalculer.Visible = false;

            #region ligne

            //ligne 1
            lblE1M1.Visible = false;
            nudE1M1.Visible = false;
            lblE2M1.Visible = false;
            nudE2M1.Visible = false;
            btnLock1.Visible = false;

            //ligne 2
            lblE3M2.Visible = false;
            nudE3M2.Visible = false;
            lblE4M2.Visible = false;
            nudE4M2.Visible = false;
            btnLock2.Visible = false;

            //ligne 3
            lblE5M3.Visible = false;
            nudE5M3.Visible = false;
            lblE1M3.Visible = false;
            nudE1M3.Visible = false;
            btnLock3.Visible = false;

            //ligne 4
            lblE2M4.Visible = false;
            nudE2M4.Visible = false;
            lblE3M4.Visible = false;
            nudE3M4.Visible = false;
            btnLock4.Visible = false;

            //ligne 5
            lblE4M5.Visible = false;
            nudE4M5.Visible = false;
            lblE5M5.Visible = false;
            nudE5M5.Visible = false;
            btnLock5.Visible = false;

            //ligne 6
            lblE1M6.Visible = false;
            nudE1M6.Visible = false;
            lblE3M6.Visible = false;
            nudE3M6.Visible = false;
            btnLock6.Visible = false;

            //ligne 7
            lblE2M7.Visible = false;
            nudE2M7.Visible = false;
            lblE4M7.Visible = false;
            nudE4M7.Visible = false;
            btnLock7.Visible = false;

            //ligne 8
            lblE3M8.Visible = false;
            nudE3M8.Visible = false;
            lblE5M8.Visible = false;
            nudE5M8.Visible = false;
            btnLock8.Visible = false;

            //ligne 9
            lblE1M9.Visible = false;
            nudE1M9.Visible = false;
            lblE4M9.Visible = false;
            nudE4M9.Visible = false;
            btnLock9.Visible = false;

            //ligne 10
            lblE2M10.Visible = false;
            nudE2M10.Visible = false;
            lblE5M10.Visible = false;
            nudE5M10.Visible = false;
            btnLock10.Visible = false;
            #endregion
        }

        private void btnMapJockey_Click(object sender, EventArgs e)
        {
            lblNomMapJockey.Text = pl.GetMapJockey();
            btnMapJockey.Enabled = false;
            btnCreationEquipe.Enabled = true;
        }

        private void btnCreationEquipe_Click(object sender, EventArgs e)
        {
            pl.CreateTeams();

            lblNomEquipe1.Text = pl.getTeam(1).getName();
            lblNomEquipe2.Text = pl.getTeam(2).getName();
            lblNomEquipe3.Text = pl.getTeam(3).getName();
            lblNomEquipe4.Text = pl.getTeam(4).getName();
            lblNomEquipe5.Text = pl.getTeam(5).getName();


            lblE1M1.Text = pl.getTeam(1).getName();
            lblE2M1.Text = pl.getTeam(2).getName();            

            //ligne 1
            lblE1M1.Visible = true;
            nudE1M1.Visible = true;
            lblE2M1.Visible = true;
            nudE2M1.Visible = true;
            btnLock1.Visible = true;
            btnCreationEquipe.Enabled = false;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            //faire passer au ecran suivant ici
            btnCalculer.Enabled = false;
        }

        private void btnLock1_Click(object sender, EventArgs e)
        {

            pl.getTeam(1).incScore( Convert.ToInt32(nudE1M1.Value) );
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M1.Value));
            RefreshTeamScore();

            lblE3M2.Text = pl.getTeam(3).getName();
            lblE4M2.Text = pl.getTeam(4).getName();

            //ligne 2
            lblE3M2.Visible = true;
            nudE3M2.Visible = true;
            lblE4M2.Visible = true;
            nudE4M2.Visible = true;
            btnLock2.Visible = true;
            nudE1M1.Enabled = false;
            nudE2M1.Enabled = false;
            btnLock1.Enabled = false;
        }

        private void btnLock2_Click(object sender, EventArgs e)
        {
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M2.Value));
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M2.Value));
            RefreshTeamScore();

            lblE5M3.Text = pl.getTeam(5).getName();
            lblE1M3.Text = pl.getTeam(1).getName();

            //ligne 3
            lblE5M3.Visible = true;
            nudE5M3.Visible = true;
            lblE1M3.Visible = true;
            nudE1M3.Visible = true;
            btnLock3.Visible = true;
            nudE3M2.Enabled = false;
            nudE4M2.Enabled = false;
            btnLock2.Enabled = false;
        }

        private void btnLock3_Click(object sender, EventArgs e)
        {
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M3.Value));
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M3.Value));
            RefreshTeamScore();

            lblE2M4.Text = pl.getTeam(2).getName();
            lblE3M4.Text = pl.getTeam(3).getName();

            //ligne 4
            lblE2M4.Visible = true;
            nudE2M4.Visible = true;
            lblE3M4.Visible = true;
            nudE3M4.Visible = true;
            btnLock4.Visible = true;
            nudE5M3.Enabled = false;
            nudE1M3.Enabled = false;
            btnLock3.Enabled = false;
        }

        private void btnLock4_Click(object sender, EventArgs e)
        {
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M4.Value));
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M4.Value));
            RefreshTeamScore();

            lblE4M5.Text = pl.getTeam(4).getName();
            lblE5M5.Text = pl.getTeam(5).getName();

            //ligne 5
            lblE4M5.Visible = true;
            nudE4M5.Visible = true;
            lblE5M5.Visible = true;
            nudE5M5.Visible = true;
            btnLock5.Visible = true;
            nudE2M4.Enabled = false;
            nudE3M4.Enabled = false;
            btnLock4.Enabled = false;
        }

        private void btnLock5_Click(object sender, EventArgs e)
        {
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M5.Value));
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M5.Value));
            RefreshTeamScore();

            lblE1M6.Text = pl.getTeam(1).getName();
            lblE3M6.Text = pl.getTeam(3).getName();

            //ligne 6
            lblE1M6.Visible = true;
            nudE1M6.Visible = true;
            lblE3M6.Visible = true;
            nudE3M6.Visible = true;
            btnLock6.Visible = true;
            nudE4M5.Enabled = false;
            nudE5M5.Enabled = false;
            btnLock5.Enabled = false;
        }

        private void btnLock6_Click(object sender, EventArgs e)
        {
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M6.Value));
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M6.Value));
            RefreshTeamScore();

            lblE2M7.Text = pl.getTeam(2).getName();
            lblE4M7.Text = pl.getTeam(4).getName();

            //ligne 7
            lblE2M7.Visible = true;
            nudE2M7.Visible = true;
            lblE4M7.Visible = true;
            nudE4M7.Visible = true;
            btnLock7.Visible = true;
            nudE1M6.Enabled = false;
            nudE3M6.Enabled = false;
            btnLock6.Enabled = false;
        }

        private void btnLock7_Click(object sender, EventArgs e)
        {
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M7.Value));
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M7.Value));
            RefreshTeamScore();

            lblE3M8.Text = pl.getTeam(3).getName();
            lblE5M8.Text = pl.getTeam(5).getName();

            //ligne 8
            lblE3M8.Visible = true;
            nudE3M8.Visible = true;
            lblE5M8.Visible = true;
            nudE5M8.Visible = true;
            btnLock8.Visible = true;
            nudE2M7.Enabled = false;
            nudE4M7.Enabled = false;
            btnLock7.Enabled = false;
        }

        private void btnLock8_Click(object sender, EventArgs e)
        {
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M8.Value));
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M8.Value));
            RefreshTeamScore();

            lblE1M9.Text = pl.getTeam(1).getName();
            lblE4M9.Text = pl.getTeam(4).getName();

            //ligne 9
            lblE1M9.Visible = true;
            nudE1M9.Visible = true;
            lblE4M9.Visible = true;
            nudE4M9.Visible = true;
            btnLock9.Visible = true;
            nudE3M8.Enabled = false;
            nudE5M8.Enabled = false;
            btnLock8.Enabled = false;
        }

        private void btnLock9_Click(object sender, EventArgs e)
        {
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M9.Value));
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M9.Value));
            RefreshTeamScore();

            lblE2M10.Text = pl.getTeam(2).getName();
            lblE5M10.Text = pl.getTeam(5).getName();

            //ligne 10
            lblE2M10.Visible = true;
            nudE2M10.Visible = true;
            lblE5M10.Visible = true;
            nudE5M10.Visible = true;
            btnLock10.Visible = true;
            nudE1M9.Enabled = false;
            nudE4M9.Enabled = false;
            btnLock9.Enabled = false;
        }

        private void btnLock10_Click(object sender, EventArgs e)
        {
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M10.Value));
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M10.Value));
            RefreshTeamScore();

            btnCalculer.Visible = true;
            nudE2M10.Enabled = false;
            nudE5M10.Enabled = false;
            btnLock10.Enabled = false;
        }

        /// <summary>
        /// Prend les scores de chaque équipe et les place dans la forme
        /// </summary>
        private void RefreshTeamScore()
        {
            lblPointsE1.Text = Convert.ToString(pl.getTeam(1).Score);
            lblPointsE2.Text = Convert.ToString(pl.getTeam(2).Score);
            lblPointsE3.Text = Convert.ToString(pl.getTeam(3).Score);
            lblPointsE4.Text = Convert.ToString(pl.getTeam(4).Score);
            lblPointsE5.Text = Convert.ToString(pl.getTeam(5).Score);

        }
    }
}
