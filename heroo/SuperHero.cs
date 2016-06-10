using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroo
{
   class SuperHero : Hero
    {   //++++++++++++++++++++++++++++++++++++ Private instace variables +++++++++++++++++++++++++++
        /// <summary>
        /// Private instace variables 
        /// @list
        /// </summary>
        private List<string> _superPowers = new List<string>();

        //+++++++++++++++++++++++++++++++++++++ public Properties +++++++++++++++++++++++++++++++++++
        /// <summary>
        /// public property for list
        /// </summary>
        public List<string> SuperPowers
        {
            get
            {
                return this._superPowers;
            }
            set
            {
                this._superPowers = value;
            }
        }

        //+++++++++++++++++++++++++++++++++++++++ contructors ++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// This is the constructor for the Superhero class
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name) : base(name)
        {
            
            this._superPowers = SuperPowers;
            _generateRandomPowers();
        }
        //++++++++++++++++++++++++++++++++++++++ Private Methods +++++++++++++++++++++++++++++++++++++++
        private void _generateRandomPowers()
        {
            _superPowers.Add("Super Speed");
            _superPowers.Add("Super	Strength");
            _superPowers.Add("Body	Armour");
            _superPowers.Add("Flight");
            _superPowers.Add("Fire	Generation");
            _superPowers.Add("Weather	Control");

            Random randomClassifier = new Random();
           

            for (int index = 0; index < 3; index++)
            {
                int randomPoint = randomClassifier.Next(0, _superPowers.Count);
                _superPowers[index] = _superPowers.ElementAt(randomPoint);
                _superPowers.RemoveAt(randomPoint);
                Console.WriteLine(" These are your Super powers :     " + _superPowers[index]);

               
                

            }
            
            Console.WriteLine();
        }
        /// <summary>
        /// Thia method displays the powers
        /// </summary>
        public void ShowPowers()
        {
            Console.WriteLine();
            Console.WriteLine("==================== SUPER POWERS ==============");
            Console.WriteLine(".");
            Console.WriteLine();
           _generateRandomPowers();
            Console.WriteLine();
            Console.WriteLine("==================================================");
         
            


        }
        
        
    }
    
}
