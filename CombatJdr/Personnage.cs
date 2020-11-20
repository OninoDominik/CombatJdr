using System;
using System.Collections.Generic;
using System.Text;

namespace CombatJdr
{
    public class Personnage
    {

        public int pointDeVie;
        public int valeurAttaque;
        public int classeArmure;

        public Personnage()
        {
            pointDeVie = 10;
            valeurAttaque = 2;
            classeArmure = 15;
        }
        public Personnage(int pdv,int va,int ca)
        {
            pointDeVie = pdv;
            valeurAttaque = va;
            classeArmure = ca;
        }

        public virtual bool Attaque(Personnage Ennemi)
        {
            Random rand = new Random();
            int des = rand.Next(20) + 1;
            if (valeurAttaque + des >= Ennemi.classeArmure)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public virtual int InfligerDegats(Personnage Ennemi)
        {
            Random rand = new Random();
            int des = rand.Next(4) + 1;
            return Ennemi.pointDeVie - des;
        }

    }
}
