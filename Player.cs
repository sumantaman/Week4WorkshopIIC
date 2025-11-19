using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Week_4
{
    public class Player
    {
        public Player() { }


        int id;
        string name ;
        int age;
        public Player(int id, string name, int age) {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
