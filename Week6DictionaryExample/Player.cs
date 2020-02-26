using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6DictionaryExample
{
    public class Player
    {
        public int id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Player ID: " + id.ToString() + " Name: " + Name ;
        }

    }
}
