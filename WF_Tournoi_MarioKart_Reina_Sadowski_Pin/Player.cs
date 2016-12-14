using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WF_Tournoi_MarioKart_Reina_Sadowski_Pin
{     
    public class Player : Object
    {
        const int TEAMCOUNT = 5;

        private string _joueur;
        private List<string> _eleve = new List<string> { "Ilias", "Dylan", "Ricardo", "Christophe", "Guillaume", "Kilian", "Miguel", "Guntram", "David", "Tiago" };
        Random rdm;

        private Team[] _teams = new Team[TEAMCOUNT];


        /// <summary>
        /// Retourne la team en fonction de son numéro
        /// </summary>
        /// <param name="InTeamNumber">Numéro de team entre 1 et TEAMCOUNT</param>
        /// <returns>Team</returns>
        public Team getTeam(int InTeamNumber){
            return (InTeamNumber > 0 && InTeamNumber <= _teams.Count()) ? _teams[InTeamNumber-1] : new Team();
        }

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

        public string Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }

        public Player()
        {
            this.Joueur = _joueur;
            rdm = new Random();
        }

        public string GetMapJockey()
        {
            int r = rdm.Next(_eleve.Count());

            return Joueur = _eleve[r].ToString();
        }
    }
}
