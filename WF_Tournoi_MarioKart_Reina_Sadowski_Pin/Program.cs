/*
 * Auteurs : Sadowski Christophe, Reina Ricardo, Pin Guillaume
 * version : 1.0
 * Description :
 *                  "Application créer pour le tournoi de Mario Kart,
 *                   permet de gerer la generation d equipe, et du déroulement
 *                   du tournoi dans son intégralité.                         " 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Tournoi_MarioKart_Reina_Sadowski_Pin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
