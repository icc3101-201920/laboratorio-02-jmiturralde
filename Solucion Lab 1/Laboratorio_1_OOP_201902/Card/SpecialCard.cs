using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard : Card
    {
        protected const string DEFAULT_BUFFTYPE = "BUFFTYPE";

        private string buffType;



        //Constructor
        public SpecialCard() : this(DEFAULT_NAME, DEFAULT_TYPE) { }

        public SpecialCard(string name, string type) : this(name, type, DEFAULT_EFFECT)
        {
        }
        public SpecialCard(string name, string type, string effect) : base(name, type, effect)
        {
            BuffType = DEFAULT_BUFFTYPE;
        }

        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
       


    }
}
