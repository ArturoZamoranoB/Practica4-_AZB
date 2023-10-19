using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4__AZB.Clases
{
    internal class Ejercicios
    {
       


        public void problema1()
        {
           
            int[,] t = new int[2, 3];

          
            int filas = t.GetLength(0);
            Console.WriteLine("Filas: " + filas);

            int columnas = t.GetLength(1);
            Console.WriteLine("Columnas: " + columnas);

            int totalElementos = t.Length;
            Console.WriteLine("Total de elementos: " + totalElementos);

           
            Console.WriteLine("Elementos de la fila 1:");
            Console.WriteLine(t[1, 0]);
            Console.WriteLine(t[1, 1]);
            Console.WriteLine(t[1, 2]);

            
            Console.WriteLine("Elementos de la columna 2:");
            Console.WriteLine(t[0, 2]);
            Console.WriteLine(t[1, 2]);

            t[0, 1] = 0;

          
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    t[i, j] = 0;
                }
            }

         
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el valor para t[" + i + "," + j + "]:");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

          
            int valorMinimo = t[0, 0];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (t[i, j] < valorMinimo)
                    {
                        valorMinimo = t[i, j];
                    }
                }
            }
            Console.WriteLine("Valor mínimo: " + valorMinimo);

          
            Console.WriteLine("Elementos de la primera fila:");
            Console.WriteLine(t[0, 0]);
            Console.WriteLine(t[0, 1]);
            Console.WriteLine(t[0, 2]);

            
            int sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += t[i, 2];
            }
            Console.WriteLine("Suma de la tercera columna: " + sumaColumna);

            Console.WriteLine("Índices de columna:");
            Console.WriteLine("\t0\t1\t2");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("Índice de fila " + i + ":\t");
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}

