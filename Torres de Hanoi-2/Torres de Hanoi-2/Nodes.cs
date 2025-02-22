using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Torres_de_Hanoi_2
{
    class Node
    {
        private int dato; //el dato de el tope y el dato siguiente del tope
        private Node next;


        public Node(int block) 
        {
            this.dato = block;
            this.next = null;
        }


        public Node(int block, Node nextNode)
        {
            this.dato = block; // asignando valores de inicio
            this.next = nextNode;
        }

        public int Dato
        {
            get { return this.dato; }
            set { this.dato = value; }  // get y set los dos
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
