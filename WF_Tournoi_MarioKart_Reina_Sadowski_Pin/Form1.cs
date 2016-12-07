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
            List<string> E1; 
            List<string> E2 = new List<string>(pl.GetPlayerE2());
            List<string> E3 = new List<string>(pl.GetPlayerE3());
            List<string> E4 = new List<string>(pl.GetPlayerE4());
            List<string> E5 = new List<string>(pl.GetPlayerE5());
        public Form1()
        {
            InitializeComponent();

            labelmapJokey.Text = pl.GetMapJockey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E1 = new List<string>(pl.GetPlayerE1());
            
            label1.Text = E1[0];
            label2.Text = E1[1];

            label3.Text = E2[0];
            label4.Text = E2[1]; 

            label5.Text = E3[0];
            label6.Text = E3[1];

            label7.Text = E4[0];
            label8.Text = E4[1];

            label9.Text = E5[0];
            label10.Text = E5[1];

            }
    }
}
