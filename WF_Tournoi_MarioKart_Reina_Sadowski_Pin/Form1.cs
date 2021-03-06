﻿/*
 * Auteurs : Sadowski Christophe, Reina Ricardo, Pin Guillaume
 * version : 1.0
 * Description :
 *                  "Application créer pour le tournoi de Mario Kart,
 *                   permet de gerer la generation d equipe, et du déroulement
 *                   du tournoi dans son intégralité.                         " 
 */

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
        //initialisation
        Player pl = new Player();

        public Form1()
        {
            InitializeComponent();
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

        private void btnMapJockey_Click(object sender, EventArgs e)
        {
            //choisit un map jokey
            lblNomMapJockey.Text = pl.GetMapJockey();

            //affichage
            btnMapJockey.Enabled = false;
            btnCreationEquipe.Enabled = true;
        }

        private void btnCreationEquipe_Click(object sender, EventArgs e)
        {
            //creer les équipes
            pl.CreateTeams();


            //affiche les noms des equipes
            lblNomEquipe1.Text = pl.getTeam(1).getName();
            lblNomEquipe2.Text = pl.getTeam(2).getName();
            lblNomEquipe3.Text = pl.getTeam(3).getName();
            lblNomEquipe4.Text = pl.getTeam(4).getName();
            lblNomEquipe5.Text = pl.getTeam(5).getName();
            lblE1M1.Text = pl.getTeam(1).getName();
            lblE2M1.Text = pl.getTeam(2).getName();

            //affichage
            lblE1M1.Visible = true;
            nudE1M1.Visible = true;
            lblE2M1.Visible = true;
            nudE2M1.Visible = true;
            btnLock1.Visible = true;

            btnCreationEquipe.Enabled = false;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            //met les score dans un tableau
            int[] scoresList = { pl.getTeam(1).Score, pl.getTeam(2).Score, pl.getTeam(3).Score, pl.getTeam(4).Score, pl.getTeam(5).Score };
            //trie le tableau
            Array.Sort(scoresList);
            //inverse le tableau
            Array.Reverse(scoresList);

            //compare les resultat pour afficher correctement les equipes dans l onglet tournoi
            for (int i = 1; i < scoresList.Count()+1; i++)
            {
                if (scoresList[0] == pl.getTeam(i).Score)
                {
                    btn1er.Text = pl.getTeam(i).getName();
                }
                else if (scoresList[1] == pl.getTeam(i).Score)
                {
                    btn2eme.Text = pl.getTeam(i).getName();
                }
                else if (scoresList[2] == pl.getTeam(i).Score)
                {
                    btn3eme.Text = pl.getTeam(i).getName();
                }
                else if (scoresList[3] == pl.getTeam(i).Score)
                {
                    btn4eme.Text = pl.getTeam(i).getName();
                }
                else if (scoresList[4] == pl.getTeam(i).Score)
                {
                    btn5eme.Text = pl.getTeam(i).getName();
                }
            }

            //affichage
            btnValider.Enabled = false;

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;

            btn1er.Enabled = true;
            btn2eme.Enabled = true;
            btn3eme.Enabled = true;
            btn4eme.Enabled = true;
            btn5eme.Enabled = true;
        }

        private void btnLock1_Click(object sender, EventArgs e)
        {
            //rentre les score pour les equipe ayant participer
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M1.Value));
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M1.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE3M2.Text = pl.getTeam(3).getName();
            lblE4M2.Text = pl.getTeam(4).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M2.Value));
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M2.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE5M3.Text = pl.getTeam(5).getName();
            lblE1M3.Text = pl.getTeam(1).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M3.Value));
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M3.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE2M4.Text = pl.getTeam(2).getName();
            lblE3M4.Text = pl.getTeam(3).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M4.Value));
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M4.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE4M5.Text = pl.getTeam(4).getName();
            lblE5M5.Text = pl.getTeam(5).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M5.Value));
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M5.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE1M6.Text = pl.getTeam(1).getName();
            lblE3M6.Text = pl.getTeam(3).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M6.Value));
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M6.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE2M7.Text = pl.getTeam(2).getName();
            lblE4M7.Text = pl.getTeam(4).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M7.Value));
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M7.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE3M8.Text = pl.getTeam(3).getName();
            lblE5M8.Text = pl.getTeam(5).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(3).incScore(Convert.ToInt32(nudE3M8.Value));
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M8.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE1M9.Text = pl.getTeam(1).getName();
            lblE4M9.Text = pl.getTeam(4).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(1).incScore(Convert.ToInt32(nudE1M9.Value));
            pl.getTeam(4).incScore(Convert.ToInt32(nudE4M9.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            lblE2M10.Text = pl.getTeam(2).getName();
            lblE5M10.Text = pl.getTeam(5).getName();

            //affichage
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
            //rentre les score pour les equipe ayant participer
            pl.getTeam(2).incScore(Convert.ToInt32(nudE2M10.Value));
            pl.getTeam(5).incScore(Convert.ToInt32(nudE5M10.Value));
            //rafraichie les scores
            RefreshTeamScore();

            //affiche les noms des equipes
            btnValider.Visible = true;
            nudE2M10.Enabled = false;
            nudE5M10.Enabled = false;
            btnLock10.Enabled = false;

            //affichage
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
        }        

        private void btn1er_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM1.Text = btn1er.Text;
            btnLM1.Text = btn3eme.Text;

            //affichage
            btn1er.Enabled = false;
            btn3eme.Enabled = false;
            btnWM1.Enabled = true;
            btnLM1.Enabled = true;
        }

        private void btn3eme_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM1.Text = btn3eme.Text;
            btnLM1.Text = btn1er.Text;

            //affichage
            btn1er.Enabled = false;
            btn3eme.Enabled = false;
            btnWM1.Enabled = true;
            btnLM1.Enabled = true;
        }

        private void btn2eme_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM2.Text = btn2eme.Text;
            btnLM2.Text = btn4eme.Text;

            //affichage
            btn2eme.Enabled = false;
            btn4eme.Enabled = false;
            btnWM2.Enabled = true;
            btnLM2.Enabled = true;
        }

        private void btn4eme_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM2.Text = btn4eme.Text;
            btnLM2.Text = btn2eme.Text;

            //affichage
            btn2eme.Enabled = false;
            btn4eme.Enabled = false;
            btnWM2.Enabled = true;
            btnLM2.Enabled = true;
        }

        private void btn5eme_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM3.Text = btn5eme.Text;

            //affichage
            btnLM1.Enabled = false;
            btn5eme.Enabled = false;
            btnWM3.Enabled = true;
        }

        private void btnLM1_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM3.Text = btnLM1.Text;

            //affichage
            btnLM1.Enabled = false;
            btn5eme.Enabled = false;
            btnWM3.Enabled = true;
        }

        private void btnWM1_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM4.Text = btnWM1.Text;

            //affichage
            btnWM1.Enabled = false;
            btnWM2.Enabled = false;
            btnWM4.Enabled = true;
        }

        private void btnWM2_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM4.Text = btnWM2.Text;

            //affichage
            btnWM1.Enabled = false;
            btnWM2.Enabled = false;
            btnWM4.Enabled = true;
        }

        private void btnWM3_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM5.Text = btnWM3.Text;

            //affichage
            btnWM3.Enabled = false;
            btnLM2.Enabled = false;
            btnWM5.Enabled = true;
        }

        private void btnLM2_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWM5.Text = btnLM2.Text;

            //affichage
            btnWM3.Enabled = false;
            btnLM2.Enabled = false;
            btnWM5.Enabled = true;
        }

        private void btnWM4_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWinner.Text = btnWM4.Text;

            //affichage
            btnWM4.Enabled = false;
            btnWM5.Enabled = false;
        }

        private void btnWM5_Click(object sender, EventArgs e)
        {
            //reporte les noms des equipes
            btnWinner.Text = btnWM5.Text;

            //affichage
            btnWM4.Enabled = false;
            btnWM5.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //incremente le score de l equipe de 1
            pl.getTeam(1).incScore(1);
            //rafraichie les score
            RefreshTeamScore();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //incremente le score de l equipe de 1
            pl.getTeam(2).incScore(1);
            //rafraichie les score
            RefreshTeamScore();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //incremente le score de l equipe de 1
            pl.getTeam(3).incScore(1);
            //rafraichie les score
            RefreshTeamScore();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //incremente le score de l equipe de 1
            pl.getTeam(4).incScore(1);
            //rafraichie les score
            RefreshTeamScore();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //incremente le score de l equipe de 1
            pl.getTeam(5).incScore(1);
            //rafraichie les score
            RefreshTeamScore();
        }
    }
}
