using System;
using C = System.Console;

namespace _9_Matriz
{
    class Program
    {
        /// Practica 9
        /// 9.- Matrice.
        /// 
        /// Chávez Pérez Melissa
        /// #M21210035
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;
            Matriz ma = new Matriz();
            ma.Ingresar();
            ma.Imprimir();

        }
        class Matriz
        {
            private int[,] mat;

            public void Ingresar()
            {
                mat = new int[3, 4];
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        C.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                        string linea;
                        linea = C.ReadLine();
                        mat[f, c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        C.Write(mat[f, c] + " ");
                    }
                    C.WriteLine();
                }
                C.ReadKey();
            }
    }
}
}

