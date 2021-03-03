using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadplanner
{
    public class Objeto 
    {
        public string Name;
        public string ShortName;

        public int Space;

        public float Weights;

        

        public Objeto(string Name, string ShortName, int Space, float Weights)
        {
            this.Name = Name;
            this.ShortName = ShortName;
            this.Space = Space;
            this.Weights = Weights; 
            

        }
    }

        
}