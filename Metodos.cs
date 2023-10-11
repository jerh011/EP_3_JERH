using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EP_3_JERH
{

    internal class Metodos
    {
        Random random = new Random();
        public void ActividadExtraclase()
        {
            int[] Array1 = new int[15];
            int[] Array2 = new int[20];
            for (int I = 0; I < Array1.Length; I++)
            {
                Array1[I] = (I + 1) * 5;
            }
            Array2 = ActividadExtraclase(Array1, Array2);
            ImprecionesExtraClase(Array1);
            ImprecionesExtraClase(Array2);
        }
        public int[] ActividadExtraclase(int[] Array1, int[] Array2)
        {

            for (int J = Array2.Length - 10; J < 20; J++)
            {
                Array2[J] = Array1[J - 5];
            }
            return Array2;
        }
        public void ImprecionesExtraClase(int[] Array1)
        {
            for (int Z = 0; Z < Array1.Length; Z++)
            {

                Console.WriteLine(Array1[Z]);
            }
            Console.WriteLine("");
        }

        /// /////////////////////////////////////////////////////////////////

        public void Ejercicio1()
        {
            int[,] Ejercicio1 = new int[3, 3];

            for (int I = 0, X = 1; I < 3; I++)
            {

                for (int Z = 0; Z < 3; Z++, X++)
                {
                    Ejercicio1[I, Z] = X;

                }
            }
            Impreciones(Ejercicio1);
        }
        public void Impreciones(int[,] Array1)
        {
            for (int I = 0; I < 3; I++)
            {

                for (int Z = 0; Z < 3; Z++)
                {
                    Console.Write(" {0,-1} |", Array1[I, Z]);

                }
                Console.WriteLine("");
            }
        }

        ////////////////////////////////////////////////////////////////////
        public void Ejercicio2()
        {
            string[,] color = { { "Rojo", "Verde" }, { "Azul", "Amarillo" } };
            ImprecionesEje2(color);
        }
        public void ImprecionesEje2(string[,] color)
        {

            for (int I = 0; I < 2; I++)
            {
                for (int Z = 0; Z < 2; Z++)
                    Console.Write(color[I, Z] + " ");
                Console.WriteLine(" ");
            }
        }
        ////////////////////////////////////////////////////////////////////
        public void Ejercicio3()
        {
            decimal[,] Array2 = new decimal[4, 3];
            for (int I = 0; I < 4; I++)
            {
                for (int Z = 0; Z < 3; Z++)
                    Array2[I, Z] = Convert.ToDecimal(random.NextDouble());
            }
            ImprecionesEje3(Array2);

        }
        public void ImprecionesEje3(decimal[,] Array2)
        {
            Console.WriteLine("+--------------------------+---------------------------+---------------------------+");
            for (int I = 0; I < 4; I++)
            {
                for (int Z = 0; Z < 3; Z++)
                {
                    Console.Write(" {0,-25} |", Array2[I, Z]);
                }
                Console.WriteLine(" ");
                Console.WriteLine("+--------------------------+---------------------------+---------------------------+");

            }
        }
        ////////////////////////////////////////////////////////////////////
        public void Ejercicio4()
        {
            char[,] array = new char[2, 4];
            Random random = new Random();

            for (int I = 0; I < 2; I++)
            {
                for (int J = 0; J < 4; J++)
                {
                    int numeroAleatorio = random.Next(64,91);
                    char letra = (char)(numeroAleatorio);

                    array[I, J] = letra;
                }
            }
            ImprecionesEje4(array);
        }

        public void ImprecionesEje4(char[,] array)
        {
            Console.WriteLine("+---+----+----+----+");
            for (int I = 0; I < 2; I++)
            {
                for (int J = 0; J < 4; J++)
                {
                    Console.Write(" {0,-3}|", array[I, J]);

                }
                Console.WriteLine(" ");
                Console.WriteLine("+---+----+----+----+");
            }
        }
    }
}