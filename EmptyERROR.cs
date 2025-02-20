using System;


    class EmptyERROR : ApplicationException
    {
        public EmptyERROR()
            : base("La pila está vacía.")
        {

        }


    }

