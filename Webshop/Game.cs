using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Game
    {
        public string GameName { get; set; }
        public int Price { get; set; }
        public string Id { get; set; }

        public Game()
        {

        }
        public Game(string gameName, int price, string id)
        {
            GameName = gameName;
            Price = price;
            Id = id;
        }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}
