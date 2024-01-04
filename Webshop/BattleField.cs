using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class BattleField : Game, IDownloadable
    {
        public BattleField()
        {
            this.Id = "1";
            this.Price = 150;
            this.GameName = "Battlefield";
        }
    }
}
