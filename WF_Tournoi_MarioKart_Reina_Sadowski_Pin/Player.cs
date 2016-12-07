using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Tournoi_MarioKart_Reina_Sadowski_Pin
{
    public class Player : Object
    {
        private string _joueur;
        private List<string> _eleve = new List<string> { "Ilias", "Dylan", "Ricardo", "Christophe", "Guillaume", "Kilian", "Miguel", "Guntram", "David", "Tiago" };
        Random rdm;
        private List<string> _equipe1 = new List<string>();
        private List<string> _equipe2 = new List<string>();
        private List<string> _equipe3 = new List<string>();
        private List<string> _equipe4 = new List<string>();
        private List<string> _equipe5 = new List<string>();

        public string Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }

        public Player()
        {
            this.Joueur = _joueur;
        }

        public string GetMapJockey()
        {
            rdm = new Random();
            int r = rdm.Next(_eleve.Count());

            return Joueur = _eleve[r].ToString();
        }

        public List<string> GetPlayerE1()
        {
            int i = 1;
            int r;
            while (i <= 2)
            {
                rdm = new Random();
                r = rdm.Next(_eleve.Count());
                _equipe1.Add(_eleve[r]);
                _eleve.Remove(_eleve[r]);
                i++;
            }
            return _equipe1;
        }
        public List<string> GetPlayerE2()
        {
            int i = 1;
            int r;
            while (i <= 2)
            {
                rdm = new Random();
                r = rdm.Next(_eleve.Count());
                _equipe2.Add(_eleve[r]);
                _eleve.Remove(_eleve[r]);
                i++;
            }
            return _equipe2;
        }
        public List<string> GetPlayerE3()
        {
            int i = 1;
            int r;
            while (i <= 2)
            {
                rdm = new Random();
                r = rdm.Next(_eleve.Count());
                _equipe3.Add(_eleve[r]);
                _eleve.Remove(_eleve[r]);
                i++;
            }
            return _equipe3;
        }
        public List<string> GetPlayerE4()
        {
            int i = 1;
            int r;
            while (i <= 2)
            {
                rdm = new Random();
                r = rdm.Next(_eleve.Count());
                _equipe4.Add(_eleve[r]);
                _eleve.Remove(_eleve[r]);
                i++;
            }
            return _equipe4;
        }
        public List<string> GetPlayerE5()
        {
            int i = 1;
            int r;
            while (i <= 2)
            {
                rdm = new Random();
                r = rdm.Next(_eleve.Count());
                _equipe5.Add(_eleve[r]);
                _eleve.Remove(_eleve[r]);
                i++;
            }
            return _equipe5;
        }

    }
}
