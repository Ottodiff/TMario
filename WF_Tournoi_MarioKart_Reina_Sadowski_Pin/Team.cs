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
    public class Team : Object
    {
        //declaration variable
        private string _joueur1;
        private string _joueur2;
        private int _score;
        
        #region Geter Seter

        public string Joueur1
        {
            get { return _joueur1; }
            set { _joueur1 = value; }
        }

        public string Joueur2
        {
            get { return _joueur2; }
            set { _joueur2 = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        #endregion

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="?">nom joueur 1</param>
        /// <param name="?">nom joueur 2</param>
        public Team(string j1 = "", string j2 = "")
        {
            _joueur1 = j1;
            _joueur2 = j2;
            _score = 0;
        }

        /// <summary>
        /// Test si l'équipe est valide
        /// </summary>
        /// <returns>True si valide autrement False</returns>
        public bool isValid()
        {
            return (_joueur1.Length > 0 && _joueur2.Length > 0) ? true : false;
        }

        /// <summary>
        /// Retourne le nom de l'équipe
        /// </summary>
        /// <returns>Le nom de l'équipe</returns>
        public string getName()
        {
            return _joueur1 + " " + _joueur2;
        }

        /// <summary>
        /// Incrémente le score de l'équipe
        /// </summary>
        /// <param name="InValue">La valeure à ajouter au score</param>
        /// <returns>Le score de l'équipe après incrément</returns>
        public int incScore(int InValue)
        {
            _score += InValue;
            return _score;
        }
    }
}
