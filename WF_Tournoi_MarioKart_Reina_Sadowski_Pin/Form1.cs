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

            //ligne 1
            lblE1M1.Visible = false;
            nudE1M1.Visible = false;
            lblE2M1.Visible = false;
            nudE2M1.Visible = false;
            btnLock.Visible = false;

            //ligne 2
            lblE3M2.Visible = false;
            nudE3M2.Visible = false;
            lblE4M2.Visible = false;
            nudE4M2.Visible = false;
            btnLock.Visible = false;

            //ligne 3
            lblE5M3.Visible = false;
            nudE5M3.Visible = false;
            lblE1M3.Visible = false;
            nudE1M3.Visible = false;
            btnLock.Visible = false;

            //ligne 4
            lblE2M4.Visible = false;
            nudE2M4.Visible = false;
            lblE3M4.Visible = false;
            nudE3M4.Visible = false;
            btnLock.Visible = false;

            //ligne 5
            lblE4M5.Visible = false;
            nudE4M5.Visible = false;
            lblE5M5.Visible = false;
            nudE5M5.Visible = false;
            btnLock.Visible = false;

            //ligne 6
            lblE1M6.Visible = false;
            nudE1M6.Visible = false;
            lblE3M6.Visible = false;
            nudE3M6.Visible = false;
            btnLock.Visible = false;

            //ligne 7
            lblE2M7.Visible = false;
            nudE2M7.Visible = false;
            lblE4M7.Visible = false;
            nudE4M7.Visible = false;
            btnLock.Visible = false;

            //ligne 8
            lblE3M8.Visible = false;
            nudE3M8.Visible = false;
            lblE5M8.Visible = false;
            nudE5M8.Visible = false;
            btnLock.Visible = false;

            //ligne 9
            lblE1M9.Visible = false;
            nudE1M9.Visible = false;
            lblE4M9.Visible = false;
            nudE4M9.Visible = false;
            btnLock.Visible = false;

            //ligne 10
            lblE2M10.Visible = false;
            nudE2M10.Visible = false;
            lblE5M10.Visible = false;
            nudE5M10.Visible = false;
            btnLock.Visible = false;
        }

        private void btnMapJockey_Click(object sender, EventArgs e)
        {
            lblNomMapJockey.Text = pl.GetMapJockey();
            btnMapJockey.Enabled = false;
            btnCreationEquipe.Enabled = true;
        }

        private void btnCreationEquipe_Click(object sender, EventArgs e)
        {
            List<string> E1 = pl.GetPlayerE1();
            lblNomEquipe1.Text = E1[0] + " " + E1[1];
            List<string> E2 = pl.GetPlayerE2();
            lblNomEquipe2.Text = E2[0] + " " + E2[1];
            List<string> E3 = pl.GetPlayerE3();
            lblNomEquipe3.Text = E3[0] + " " + E3[1];
            List<string> E4 = pl.GetPlayerE4();
            lblNomEquipe4.Text = E4[0] + " " + E4[1];
            List<string> E5 = pl.GetPlayerE5();
            lblNomEquipe5.Text = E5[0] + " " + E5[1];
            btnCreationEquipe.Enabled = false;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            Score src = new Score(lblE1M1.Text, lblE2M1.Text, Convert.ToInt32(nudE1M1.Value), Convert.ToInt32(nudE2M1.Value));
            lblPointsE1.Text = Convert.ToString(nudE1M1.Value + nudE1M3.Value + nudE1M6.Value + nudE1M9.Value);
            lblPointsE2.Text = Convert.ToString(nudE2M1.Value + nudE2M10.Value + nudE2M4.Value + nudE2M7.Value);
            lblPointsE3.Text = Convert.ToString(nudE3M2.Value + nudE3M4.Value + nudE3M6.Value + nudE3M8.Value);
            lblPointsE4.Text = Convert.ToString(nudE4M2.Value + nudE4M5.Value + nudE4M7.Value + nudE4M9.Value);
            lblPointsE5.Text = Convert.ToString(nudE5M10.Value + nudE5M3.Value + nudE5M5.Value + nudE5M8.Value);

            if (Convert.ToInt32(lblPointsE1.Text) > Convert.ToInt32(lblPointsE2.Text) || Convert.ToInt32(lblPointsE1.Text) > Convert.ToInt32(lblPointsE3.Text) || Convert.ToInt32(lblPointsE1.Text) > Convert.ToInt32(lblPointsE4.Text) || Convert.ToInt32(lblPointsE1.Text) > Convert.ToInt32(lblPointsE5.Text))
            {
                tbx1er.Text = lblNomEquipe1.Text;
            }
        }
    }
}
