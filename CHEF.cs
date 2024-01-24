using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.INHERITANCE
{
    internal class CHEF
    {
        public void makeschicken() 
        {
            Console.WriteLine("the chef makes chicken");
        }
        public void makesalad() 
        {
            Console.WriteLine("the chef makes salad");
        }
        public virtual void makespecialitalian()
        {
            Console.WriteLine("the chef makes special dish");
        }
    }
}
