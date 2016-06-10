using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace heroo
{   /// <summary>
/// This is the Hero class.
/// </summary>
    class Hero
    {
        //++++++++++++++++++++++++++++++++++private instance variable ++++++++++++++++++++++
        private int _streangth;
        private int _speed ;
        private int _health;
        private string _name;

        //++++++++++++++++++++++++++++++++++++  PUBLIC PROPERTIES +++++++++++++++++++++++++++
        /// <summary>
        /// Public properties for streanghth,health and speed
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int streangth
        {
            get
            {
                return this._streangth;
            }
            set
            {
                this._streangth = value;
            }
        }
        public int health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        public int speed { get { return this._speed; } set { _speed = value; } }
        //+++++++++++++++++++++++++++++++++++++  CONSTRUCTOR +++++++++++++++++++++++++++++++++
        /// <summary>
        /// This is the constructor 
        /// @Calls generateAbilities method
        /// </summary>
        /// <param name="name"></param>
        public Hero(string name)
        {
            speed = this._speed;
            streangth = this._streangth;
            health = this._health;

            name = this._name;
            generateAbilities();
        }
        
        //++++++++++++++++++++++++++++++++++++++ PRIVATE METHODS ++++++++++++++++++++++++++++++
        //private method for gerating abilities
        //returns void
        
        private void generateAbilities()
        {
            Random r = new Random();
             speed = r.Next(1, 100);
            
             health = r.Next(1, 100);
          
             streangth = r.Next(1, 100);
      
        }
        
        //This is the private method for hit attempt
        //@param bool hitter
        //returns bool hitter
        private static bool hitAttempt(bool hitter)
        {
            Random rr = new Random();
          int randomVar =    rr.Next(1, 5);
            //Console.WriteLine(randomVar + " is random number ");
            if (randomVar == 1)
            {
                hitter = true;
                Console.WriteLine("the Hero has hit");
            }
            else 
            {
                hitter = false;
                Console.WriteLine("the player did not hit");
            }
            return hitter;
        }
        //this is the private method for hit attempt
        //@param int attempt
        //returns attempt
        private int hitDamage(int attempt)
        {
            Random rd = new Random();
            int randomDamage = rd.Next(1, 6);
            int x = streangth * randomDamage;
            x = attempt;
            
            return attempt;
        }

        //++++++++++++++++++++++++++++++++++++++++ PUBLIC METHODS ++++++++++++++++++++++++++++++++++
        /// <summary>
        ///  This is the public method for Fight 
        ///  returns void.
        /// </summary>
        
        public void Fight()
        {
            
            if (hitAttempt(true))
            {

                Random rd = new Random();
                int randomDamage = rd.Next(1, 7);
                Console.WriteLine("random damage        : " + randomDamage);
                int x = streangth * randomDamage;


                Console.WriteLine(x + ": is the damage done by " + Name);
                hitDamage(x);

            }
            else
                Console.WriteLine();

            
            
        }
        // this is the public metthod for show
        //retuns nothing
        //Displays scores.
        public void Show()
        {
            Console.WriteLine("\n+============== SHOW ABILITIES ==================");
            Console.WriteLine("Streangth Ability    : " + streangth);
            Console.WriteLine();
            Console.WriteLine("Health Ability       : " + health);
            Console.WriteLine();
            Console.WriteLine("Speed Ability        : " + speed);
            Console.WriteLine();
            Console.WriteLine("\n+==================================================");
        }
    }
}