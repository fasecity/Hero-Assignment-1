using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Subject:    Assignment 1
/// Name:       Mohamoud Mohamed
/// Student #:  300435435
/// </summary>
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
            //assigment 1  --initialization
           
            //Hero jay = new Hero("jay");
            //jay.Name = "jay";
            //jay.Show();
            //jay.Fight();

            //assignment 2 Super hero initatlization
            SuperHero Mo = new SuperHero("Mo");
           
            Mo.Show();
            Mo.ShowPowers();
            Mo.Fight();
        }
    }
}
