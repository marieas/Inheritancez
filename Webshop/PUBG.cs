using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class PUBG : Game, IDownloadable, IPhysical
    {
        public PUBG()
        {
            this.Id = "4";
            this.Price = 100;
            this.GameName = "PUBG";
        }
    }
}
