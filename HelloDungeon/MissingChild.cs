using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class MissingChild : Character
    {
        public string _DrinkName;
        public float _Volume;
        MissingChild(string drinkname, string name, float health, float volume) : base (health, name)
        {
            _DrinkName = drinkname;
            _Volume = volume;
        }

        public void Name()
        {
            //do stuff
        }
    }
}
