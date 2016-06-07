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
            _generateRandomPowers();
        }
        //++++++++++++++++++++++++++++++++++++++ Private Methods +++++++++++++++++++++++++++++++++++++++
        private void _generateRandomPowers()
        {

        }
    }
}
