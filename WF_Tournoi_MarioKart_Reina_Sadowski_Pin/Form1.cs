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
            label1.Visible = false;
            numericUpDown1.Visible = false;
            label2.Visible = false;
            numericUpDown2.Visible = false;
            btnLock.Visible = false;

            //ligne 2
            label3.Visible = false;
            numericUpDown3.Visible = false;
            label4.Visible = false;
            numericUpDown4.Visible = false;
            button1.Visible = false;

            //ligne 3
            label5.Visible = false;
            numericUpDown5.Visible = false;
            label6.Visible = false;
            numericUpDown6.Visible = false;
            button2.Visible = false;

            //ligne 2
            label7.Visible = false;
            numericUpDown7.Visible = false;
            label8.Visible = false;
            numericUpDown8.Visible = false;
            button3.Visible = false;

            //ligne 2
            label9.Visible = false;
            numericUpDown9.Visible = false;
            label10.Visible = false;
            numericUpDown10.Visible = false;
            button4.Visible = false;

            //ligne 2
            label11.Visible = false;
            numericUpDown11.Visible = false;
            label12.Visible = false;
            numericUpDown12.Visible = false;
            button5.Visible = false;

            //ligne 2
            label13.Visible = false;
            numericUpDown13.Visible = false;
            label14.Visible = false;
            numericUpDown14.Visible = false;
            button6.Visible = false;

            //ligne 2
            label15.Visible = false;
            numericUpDown15.Visible = false;
            label16.Visible = false;
            numericUpDown16.Visible = false;
            button7.Visible = false;

            //ligne 2
            label17.Visible = false;
            numericUpDown17.Visible = false;
            label18.Visible = false;
            numericUpDown18.Visible = false;
            button8.Visible = false;

            //ligne 2
            label19.Visible = false;
            numericUpDown19.Visible = false;
            label20.Visible = false;
            numericUpDown20.Visible = false;
            button9.Visible = false;
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
    }
}
