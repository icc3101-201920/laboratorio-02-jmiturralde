using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        protected const string DEFAULT_EFFECT = "EFFECT";
        protected const string DEFAULT_TYPE = "TYPE";
        protected const string DEFAULT_NAME = "Bob";
        private string name;
        private string type;
        private string effect;

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        //Propiedades
       
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }

        public Card()
           : this(DEFAULT_NAME, DEFAULT_TYPE)
        {
        }

        public Card(string name, string type)
            : this(name, type, DEFAULT_EFFECT)
        {
        }

        public Card(string name, string type, string effect)
        {
            this.Name = name;
            this.Type = type;
            this.Effect = effect;

        }
}
}
