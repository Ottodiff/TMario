using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Tournoi_MarioKart_Reina_Sadowski_Pin
{
    public class Score
    {
        #region Champs
        private string _equipeA;
        private string _equipeB;
        private int _pointsEquipeA;
        private int _pointsEquipeB;
        private bool _Winner;
        #endregion

        #region Propriétés
        public string EquipeA
        {
            get { return _equipeA; }
            set { _equipeA = value; }
        }
        public string EquipeB
        {
            get { return _equipeB; }
            set { _equipeB = value; }
        }
        public int PointsEquipeA
        {
            get { return _pointsEquipeA; }
            set { _pointsEquipeA = value; }
        }
        public int PointsEquipeB
        {
            get { return _pointsEquipeB; }
            set { _pointsEquipeB = value; }
        }
        public bool Winner
        {
            get { return _Winner; }
            set { _Winner = value; }
        }
        #endregion

        #region Constructeurs
        public Score():this("","",0,0)
        {

        }
        public Score(string equipeA):this(equipeA,"",0,0)
        {

        }
        public Score(string equipeA, string equipeB):this(equipeA,equipeB,0,0)
        {
                
        }
        public Score(string equipeA, string equipeB, int pointsEquipeA): this(equipeA, equipeB, pointsEquipeA, 0)
        {
            
        }
        public Score(string equipeA, string equipeB, int pointsEquipeA, int pointsEquipeB)
        {
            this.EquipeA = equipeA;
            this.EquipeB = equipeB;
            this.PointsEquipeA = pointsEquipeA;
            this.PointsEquipeB = pointsEquipeB;
            this.Winner = false;
        }
        #endregion

        #region Méthodes

        public string Vainqueur()
        {

            if (PointsEquipeA > PointsEquipeB)
            {
                Winner = true;
                return EquipeA;
            }
            else
            {
                return EquipeB;
            }
        }

        #endregion
    }
}
