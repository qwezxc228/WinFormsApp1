using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Hero
    {
        public string  name = {get; protected set}
        public int hp={get; protected set}
        public int damage= {get; protected set}
        public int heal= {get; protected set}

        public Hero(string name, int hp, int damage,int heal)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;

        }
    }
}
