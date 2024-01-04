using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Shop
    {
        public StoreInventory Inventory { get; set; }
        public List<Game> ShoppingCart { get; set; }
        public Shop()
        {
            Inventory = new StoreInventory();
            ShoppingCart = new List<Game>();
            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");

                HandleCommand();
            }
        }

        //TODO:
        public void HandleCommand()
        {
            var userinput = Console.ReadLine();
            Inventory.PrintInventory(userinput);

            Console.WriteLine("input the ID of game you want to buy");
            var gameID = Console.ReadLine();
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == gameID);
            ShoppingCart.Add(gameToBuy);
            //Sjekk på om spillet skal shippes eller lastes ned
            if(gameToBuy is IPhysical && gameToBuy is IDownloadable)
            {
                Console.WriteLine("Do you want to download (d) or buy a disk? (f)");
                var input = Console.ReadLine();
                if(input == "d")
                {
                    PrintDownloadMessage(gameToBuy.GameName);
                }
                else
                {
                    PrintShippingMessage(gameToBuy.GameName);
                }
            }
            else if(gameToBuy is IPhysical)
            {
                PrintShippingMessage(gameToBuy.GameName);
            }
            else
            {
                PrintDownloadMessage(gameToBuy.GameName);
            }
        }
        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }
    }
}
