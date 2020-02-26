using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6DictionaryExample
{
    
    class Program
    {
        public static List<Player> playerList = new List<Player>();
        public static Dictionary<int, Player> PlayerDictionary
                                = new Dictionary<int, Player>();
        public static LinkedList<Player> playerLinkedList = new LinkedList<Player>();


        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                playerList.Add(new Player { id = i, Name = "Player " + i.ToString() });

            }

            foreach (var player in playerList)
            {
                PlayerDictionary[player.id] = player;
                playerLinkedList.AddLast(player);
            }

            foreach (var entry in PlayerDictionary)
            {
                Console.WriteLine("Dictionary Key is {0} Dictionary Entry is a Player {1}"
                    , entry.Key, entry.Value.ToString());
            }
            // Dynamically retrieve a player object from teh dictionary based on the key
            Player p0 = PlayerDictionary[0];
            Console.WriteLine("Found player in Dictionary at position 0 {0}", p0.ToString());
            // Try get value returns true if an object can be found at the key location
            // We need to supply an out object to store the object if the object is found

            Player p3;
            if (PlayerDictionary.TryGetValue(3, out p3))
                Console.WriteLine("Found player in Dictionary at position 3 {0}", p3.ToString());
            else Console.WriteLine("Object not found");

            // Find returns a linked list node that matches the object reference passed down
            LinkedListNode<Player> node = playerLinkedList.Find(p3);
            // print the conents of the Linked list node found
            Console.WriteLine("Node found value {0}", node.Value.ToString() );
            // print the contents of the previous node to the found node 
            Console.WriteLine("previous Node value {0}", node.Previous.Value.ToString());
            // print the contents of the next node to the found node
            Console.WriteLine("Next Node value {0}", node.Next.Value.ToString());


            Console.ReadKey();
        }
    }
}
