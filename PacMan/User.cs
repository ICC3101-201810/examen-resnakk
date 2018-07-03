using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    [Serializable]
    class User
    {
        private string nombre;
        private int score;
        
        public User(string n, int s)
        {
            nombre = n;
            score = s;
        }
        public string Get_Nombre() { return nombre; }
        public int Get_score() { return score; }
        
    }
}
