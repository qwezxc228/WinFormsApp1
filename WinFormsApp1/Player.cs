using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Player:Hero
    {
        public Player(string name):base(newPlayer(name), 100,10,5)
        {
            
        }
        private static string newPlayer(string name)
        {
            return "Knight " + name;
        }
    }
}
