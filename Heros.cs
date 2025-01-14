﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Heros
    {
        private string _nomHeros;
        private Tenue _tenue;
        private int _nvVie;
        private int _vitesseAttaque;
        private int _agilite;      
        private Arme _arme1;
        private Arme _arme2;
        private Compagnie _compagnie;

        public string NomHeros { get => _nomHeros; set => _nomHeros = value; }
        public int NvVie { get => _nvVie; set => _nvVie = value; }
        public int Agilite { get => _agilite; set => _agilite = value; }
        public int VitesseAttaque { get => _vitesseAttaque; set => _vitesseAttaque = value; }
        internal Tenue Tenue { get => _tenue; set => _tenue = value; }
        internal Arme Arme1 { get => _arme1; set => _arme1 = value; }
        internal Arme Arme2 { get => _arme2; set => _arme2 = value; }
        internal Compagnie Compagnie { get => _compagnie; set => _compagnie = value; }


        public void Heros1(string nomHeros)
        {
            Agilite = 70;
            VitesseAttaque = 60;
            NvVie = 100;
            NomHeros = nomHeros;
        }
        public void Heros2(string nomHeros)
        {
            Agilite = 50;
            VitesseAttaque = 40;
            NvVie = 100;
            NomHeros = nomHeros;
        }
        public void Heros3(string nomHeros)
        {
            Agilite = 40;
            VitesseAttaque = 30;
            NvVie = 100;
            NomHeros = nomHeros;
        }
    }
}
