using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroo
{
 public   class Program
    {
    public    static void Main(string[] args)
        {
            Hero jay = new Hero("jay");
            jay.Name = "jay";
            jay.Show();
            jay.Fight();

        }
    }
}
