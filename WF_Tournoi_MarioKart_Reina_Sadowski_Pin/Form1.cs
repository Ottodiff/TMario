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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMapJockey_Click(object sender, EventArgs e)
        {
            lblNomMapJockey.Text = pl.GetMapJockey();
            btnMapJockey.Enabled = false;
        }

        private void btnCreationEquipe_Click(object sender, EventArgs e)
        {
            List<string> E1 = pl.GetPlayerE1();
            lblNomEquipe1.Text = E1[0] + " " + E1[1];
            List<string> E2 = pl.GetPlayerE2();
            lblNomEquipe2.Text = E2[0] + " " + E2[1];
            List<string> E3 = pl.GetPlayerE2();
            lblNomEquipe3.Text = E3[0] + " " + E3[1];
            List<string> E4 = pl.GetPlayerE3();
            lblNomEquipe4.Text = E4[0] + " " + E4[1];
            List<string> E5 = pl.GetPlayerE4();
            lblNomEquipe5.Text = E5[0] + " " + E5[1];
        }
    }
}
