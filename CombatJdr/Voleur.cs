using System;
using System.Collections.Generic;
using System.Text;

namespace CombatJdr
{
    public class Voleur : Personnage
    {
        public int ComptenceFurtivité;

        public Voleur()
        {
            pointDeVie = 12;
            valeurAttaque = 8;
            classeArmure = 16;
            ComptenceFurtivité = 8;
        }
        public Voleur(int vie, int attaque, int armure)
        {
            pointDeVie = vie;
            valeurAttaque = attaque;
            classeArmure = armure;
        }

    }
}
