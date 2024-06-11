using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    
    internal class Enemy:Hero
    {
        
        
        public Enemy():base(randomName(),randomHp(),randomDamahe(),random)
        {
            
        }
        private static string randomName()
        {
            string[] names = { "Zonbiii", "Ooorc", "poppaaaa", "Igor" };
            int index = new Random().Next(names.Length);
            return names[index];
          
        }
        private static string randomHp()
        {
            string[] names = {}
        }
    }
}
