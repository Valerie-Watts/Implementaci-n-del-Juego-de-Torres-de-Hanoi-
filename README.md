# Implementación del Juego de Torres de Hanoi en C#

Este repositorio contiene una implementación del clásico juego de Torres de Hanoi utilizando C#. El objetivo del juego es mover todos los discos desde la torre inicial hasta la torre de destino siguiendo ciertas reglas.

## Características
- Permite ingresar el número de discos con los que se jugará.
- Utiliza recursión para resolver el problema.
- Muestra el estado de las torres en cada paso.
- Implementado en C# con una interfaz de consola sencilla.

## Reglas del Juego
1. Solo se puede mover un disco a la vez.
2. Un disco solo puede colocarse sobre un disco más grande o en una torre vacía.
3. Se deben trasladar todos los discos desde la torre de origen hasta la torre de destino utilizando la torre auxiliar.

## Ejemplo de Uso
```
Insert the number of disks from 1-7: 3
  ^     ^     ^   
  |     |     |   
 ***    |     |   
*****   |     |   
******* |     |   

Move a disk from one tower to another.
Enter from what tower you want to move the disk (1, 2, or 3): 1
Enter the tower you want to move it to (1, 2, or 3): 3

Moved a disk from tower 1 to tower 3
  ^     ^     ^   
  |     |     |   
 ***    |    ***  
*****   |     |   
******* |     |   
...

Congratulations! You've solved the Tower of Hanoi!
```



