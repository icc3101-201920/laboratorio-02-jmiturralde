using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class CombatCard :Card
    {
        //Atributos

        protected const int DEFAULT_ATTACKPOINTS = 1;
        protected const bool DEFAULT_HERO = false;

        private int attackPoints;
        private bool hero;

        //Constructor
        public CombatCard() : this(DEFAULT_NAME, DEFAULT_TYPE) { }

        public CombatCard(string name, string type) : this(name, type, DEFAULT_EFFECT)
        {
        }
        public CombatCard(string name, string type, string effect) : base(name, type, effect)
        {
            AttackPoints = DEFAULT_ATTACKPOINTS;
            Hero = DEFAULT_HERO;
        }

        //Propiedades

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }
        public bool Hero
        { get
            {
                return this.hero;
            }
            set
            {
                this.hero = value;
            }
        }


    }
}
