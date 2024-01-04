using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class CyberPunk : Game, IPhysical,IDownloadable
    {
        public CyberPunk() :base("CyberPunk",250,"2")
        {

        }
    }
}
