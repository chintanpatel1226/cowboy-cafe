using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        public double Price
        {
            get { return 5.99; }
        }

        public uint Calories
        {
            get { return 190; }
        }

        private bool bread = true;

        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;

        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
