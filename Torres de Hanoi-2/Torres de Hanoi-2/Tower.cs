using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi_2
{
    class Tower
    {
        public Stack<int> blocks = new Stack<int>();

        public void AddBlocks(int blocks) //agregar bloques
        {
            if (this.blocks.Count > 0 && this.blocks.Peek() < blocks)
            {
                throw new InvalidOperationException("Cannot place a larger disk on a smaller one."); //un bloque mas grande no puede estar arriba de uno mas pequeño
            }
            this.blocks.Push(blocks); //agregar el bloque a la torre
        }
        public bool Move(Tower tower) // para mover uno de los bloques a otra torre
        {

            if (blocks.Count == 0) { return false; }
                 
            
            if (tower.blocks.Count > 0 && blocks.Peek() > tower.blocks.Peek())
            {
                return false;
            }

            tower.blocks.Push(blocks.Pop());
            return true;
        }

        const int numTowers = 3; //asignar un valor total de torres
        public Pile Pile { get; set; }
        //usar la pila 
        public Tower()
        {
            Pile = new Pile();
        }
        public int MaxHeight(Tower[] towers) //altura de la torre
        {
            int res = 0;
            foreach (var tower in towers)
            {
                res = Math.Max(res, tower.blocks.Count);
            }
            return res;
        }

        public int BaseWidth(Tower[] towers) //calcula el ancho de la base mas grande entre las torres
        {
            int res = 0;
            foreach (var tower in towers)
            {
                int baseWidth = tower.blocks.Count > 0 ? tower.blocks.Last() : 1;
                res = Math.Max(res, baseWidth);
            }
            return res;
        }

        public void PrintTowers(Tower[] towers) //imprimir las torres 
        {
            int height = MaxHeight(towers);
            int baseWidth = BaseWidth(towers);

            for (int i = 0; i < towers.Length; i++) //para que inicie en 1 y no en 0 
            {
                Console.Write(new string(' ', baseWidth / 2) + "^" + new string(' ', (baseWidth - 1) / 2) + "   ");
            }
            Console.WriteLine();

            for (int i = 0; i < towers.Length; i++)
            {
                Console.Write(new string(' ', baseWidth / 2) + "|" + new string(' ', (baseWidth - 1) / 2) + "   ");
            }
            Console.WriteLine();

            for (int j = 0; j < height; j++) //para que se imprima de el mas pequeño a el mas grande
            {
                foreach (var tower in towers)
                {
                    int plateIndex = j; //imprimir de el mas pequeño a el mas grande
                    int count = (plateIndex < tower.blocks.Count) ? tower.blocks.ElementAt(plateIndex) : 0;

                    //pone los puntos que representan los discos de la torre y lo hace verse como el juego 
                    Console.Write(new string(' ', baseWidth / 2 - count / 2) + 
                                  new string('*', count / 2) +
                                  (count == 1 ? "*" : "|") +
                                  new string('*', (count - 1) / 2) +
                                  new string(' ', (baseWidth - 1) / 2 - (count - 1) / 2) + "   ");
                }
                Console.WriteLine(); //espacio

            }
        }

    }
}
