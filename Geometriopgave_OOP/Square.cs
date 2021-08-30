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
        private int Side_A;

        //Her kan værdien "Side A" manipuleres via. get og set
        public int Side_a
        {
            get
            {
                return this.Side_A;
            }
            set
            {
                this.Side_A = value;
            }
        }
        public int Perimeter
        {
            get
            {
                return this.Perimeter;
            }
            set
            {
                this.Perimeter = Side_A * 4;
            }
        }
    }   
}
