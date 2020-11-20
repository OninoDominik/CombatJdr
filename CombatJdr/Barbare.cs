using System;
using System.Collections.Generic;
using System.Text;

namespace CombatJdr
{
    class Barbare : Personnage
    {
        public int rage;
        
        public Barbare()
        {
            pointDeVie = 32;
            valeurAttaque = 5;
            classeArmure = 16;
            rage = 4;
        }

        public void Regenerer()
        {
            pointDeVie = pointDeVie + rage;
            rage--;
        }
        public override int InfligerDegats(Personnage Ennemi)
        {
            Random rand = new Random();
            int des = rand.Next(12) + 1;
            return Ennemi.pointDeVie - des;
        }
    }
}
