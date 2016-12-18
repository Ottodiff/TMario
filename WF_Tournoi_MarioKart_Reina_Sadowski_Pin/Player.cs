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
using System.Text;
using System.Threading.Tasks;



namespace WF_Tournoi_MarioKart_Reina_Sadowski_Pin
{     
    public class Player : Object
    {
        //declaration variables
        const int TEAMCOUNT = 5;
        private string _joueur;
        private List<string> _eleve = new List<string> { "Ilias", "Dylan", "Ricardo", "Christophe", "Guillaume", "Kilian", "Miguel", "Guntram", "David", "Tiago" };
        Random rdm;
        private Team[] _teams = new Team[TEAMCOUNT];

        public string Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }
        
        /// <summary>
        /// Retourne la team en fonction de son numéro
        /// </summary>
        /// <param name="InTeamNumber">Numéro de team entre 1 et TEAMCOUNT</param>
        /// <returns>Team</returns>
        public Team getTeam(int InTeamNumber){
            return (InTeamNumber > 0 && InTeamNumber <= _teams.Count()) ? _teams[InTeamNumber-1] : new Team();
        }

        /// <summary>
        /// creer des team random en fonction de la list _eleve
        /// </summary>
        /// <returns>true si l equipe est bien creer, sinon false</returns>
        public bool CreateTeams()
        {
            for (int i = 0; i < TEAMCOUNT; ++i)
            {
                int idx = rdm.Next(_eleve.Count());
                string name1 = _eleve[idx];
                _eleve.Remove(_eleve[idx]);
                idx = rdm.Next(_eleve.Count());
                string name2 = _eleve[idx];
                _eleve.Remove(_eleve[idx]);

                _teams[i] = new Team(name1, name2);

            }
            // Done
            return true;
        }
        
        //constructeur
        public Player()
        {
            this.Joueur = _joueur;
            rdm = new Random();
        }

        /// <summary>
        /// choisit un eleve random dans la list _eleve
        /// </summary>
        /// <returns>retourne le nom d un joueur</returns>
        public string GetMapJockey()
        {
            int r = rdm.Next(_eleve.Count());

            return Joueur = _eleve[r].ToString();
        }
    }
}
