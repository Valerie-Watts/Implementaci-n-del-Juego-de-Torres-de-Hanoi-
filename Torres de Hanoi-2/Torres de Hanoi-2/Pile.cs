using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Torres_de_Hanoi_2
{
    class Pile
    {
        private Node top; //el nodo de el tope


        public Pile()
        {
            this.top = null; //empieza vacio 
        }

        public void Push(int block) //empujar el dato a la pila, nuevo nodo = al tope
        {
            Node newNode = new Node(block, top);

            top = newNode;

        }

        public int Pop() //borrar un elemento, si no hay elementos manda error, si no el siguiente dato pasa a ser el nuevo tope y te regresa el dato borrado
        {
            if (top == null)
            {
                throw new EmptyERROR();
            }
            else
            {
                int block = top.Dato;
                top = top.Next;
                return block;
            }
        }

        public int Peek() // ver cual es el dato del tope
        {
            if (top == null)
            {
                throw new EmptyERROR();
            }
            else
            {
                return top.Dato;
            }

        }

        public bool Empty() //esta vacio
        {
            return top == null;
        }

        public List<int> GetBlocks() //obtener el orden de los bloques 
        {
            List<int> blocks = new List<int>();
            Node current = top;
            while (current != null)
            {
                blocks.Add(current.Dato);
                current = current.Next;
            }
            return blocks;
        }

        public void Print() //imrpimir la lista sin la torre, no se va a usar 
        {
            if (Empty())
            {
                Console.WriteLine("The stack is empty.");
                return;
            }

            Node current = top;
            Console.WriteLine("Order of blocks: ");

            while (current != null)
            {
                Console.WriteLine(current.Dato);
                current = current.Next;
            }
            Console.WriteLine("---");
        }



    }
}
