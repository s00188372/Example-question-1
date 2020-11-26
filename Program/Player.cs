using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Player
    {

        public int Id { get; }
        public String PlayerName { get; set; }
        public int Score { get; private set; }

        public Player(int id, string playerName, int score)
        {

            Id = id;
            PlayerName = playerName;
            Score = score;

        }

        public void InscreaseScore(int Add)
        {
            Score += Add;
        }
        

    }
}
