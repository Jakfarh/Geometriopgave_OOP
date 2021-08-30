using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriopgave_OOP
{
   //Denne class skal definere side A i vores firkant. 
    public class Square
    {
        //Dette er den faste værdi af Side A
        private int side_A;

        //Her kan værdien "Side A" manipuleres via. get og set
        public int Side_A
        {
            get
            {
                return this.side_A;
            }
            set
            {
                this.side_A = value;
            }
        }
        //Her skal vi udregne omkredsen af kvadraten
        public int Perimeter()
        {
            return this.side_A * 4;
        }

        public int Area()
        {
            return this.side_A * side_A;
        }
        public Square()
        {

        }
    }

}
