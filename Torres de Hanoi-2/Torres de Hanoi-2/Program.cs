using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //insertando torres
                Tower Tower1 = new Tower();
                Tower Tower2 = new Tower();
                Tower Tower3 = new Tower();

                int blocks = 0;

                Tower[] towers = { Tower1, Tower2, Tower3 };

                Console.WriteLine("Insert the number of disks from 1-7: ");
                blocks = Convert.ToInt32(Console.ReadLine());

                if (blocks < 1 || blocks > 7)
                {
                    Console.WriteLine("Invalid number! Please enter a value between 1 and 7.");
                    return;
                }

                //orden decreciente de bloques
                for (int i = blocks; i >= 1; i--)
                {
                    Tower1.AddBlocks(i * 2 - 1); 
                }

               
                Tower1.PrintTowers(towers);

            while (true)
            {
                //pedir que elija de que torre quiere mover el bloque

                Console.WriteLine("\nMove a disk from one tower to another.");
                Console.WriteLine("Enter from what tower you want to move the disk (1, 2, or 3): ");
                int fromTowerIndex = Convert.ToInt32(Console.ReadLine())-1;
                //pedir que ingrese a que torre se va a mover
                Console.WriteLine("Enter the tower you want to move it to (1, 2, or 3): ");
                int toTowerIndex = Convert.ToInt32(Console.ReadLine())-1;

                if (fromTowerIndex < 0 || fromTowerIndex > 2 || toTowerIndex < 0 || toTowerIndex > 2)
                {
                    Console.WriteLine("Invalid tower. Please enter 1, 2 or 3."); //no existe esa torre
                    continue;
                }

                if (towers[fromTowerIndex].Move(towers[toTowerIndex]))
                {
                    Console.WriteLine("Moved a disk from tower " + fromTowerIndex + " to tower " + toTowerIndex); //escribe de que torre se mueve el bloque
                    Tower1.PrintTowers(towers);
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again."); //no se puede mover ahi
                }

                if (Tower3.blocks.Count == blocks)
                {
                    Console.WriteLine("\nCongratulations! You've solved the Tower of Hanoi!"); //ganar
                    break;
                }
            }
            }
    }
}
