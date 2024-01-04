using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class StoreInventory
    {
        public List<Game> InventoryList { get; set; }   
        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }

        public List<Game> ListPhysicalItems()
        {
            return InventoryList.FindAll(x => x is IPhysical);
        }

        public List<Game> ListDownLoadable()
        {
            return InventoryList.FindAll(x => x is IDownloadable);
        }
        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownLoadable());
            }
        }

        public void Print(List<Game> gamesToPrint)
        {
            foreach (var item in gamesToPrint)
            {
                item.PrintGameNameAndPrice();
            }
        }
    }
}
