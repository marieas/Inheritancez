using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class PokemonLetsGoEvee : Game, IPhysical
    {
        public PokemonLetsGoEvee()
        {
            this.Price = 400;
            this.GameName = "Pokemon lets go evee";
            this.Id = "3";
        }
    }
}
