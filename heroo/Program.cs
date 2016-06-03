using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroo
{/**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     * version 3
     */
    public class Program
    { /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            Hero jay = new Hero("jay");
            jay.Name = "jay";
            jay.Show();
            jay.Fight();

        }
    }
}
