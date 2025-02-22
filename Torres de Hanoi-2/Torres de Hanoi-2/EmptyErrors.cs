using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi_2
{
    class EmptyERROR : ApplicationException
    {
        public EmptyERROR()
            : base("La pila está vacía.") //esta vacio 
        {

        }


    }
}
