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
        public void ActividadExtraclase() {
            int[] Array1 = new int[ 15];
            int[] Array2 = new int[ 20];
            for (int I=0;I<Array1.Length;I++) 
            {
                Array1[I] = (I + 1) *5 ;
            }

            Impreciones(Array1); 



        }
        public void ActividadExtraclase(int[,] Array1,int[,] Array2) {

            for (int I = 0; I < 15; I++)
            {
                for (int J = 0; J < 15; J++)
                {
                    Array2[I, J] = Array1[I, J];
                }
            }
            Impreciones(,Array2);

        }  



        public void Ejercicio1() {
            int[,] Ejercicio1 = new int[3,3];
            
            for (int I = 0,X = 1; I <3;I++) {

                for (int Z = 0; Z < 3; Z++, X++) {
                    Ejercicio1[I, Z] = X;
                    
                }


            }

            Impreciones(Ejercicio1);

        }
        public void Impreciones(int[] Array2 = null,int[,] Array1 = null )
        {
            if (Array1 != null && Array2 == null)
            {
                for (int I = 0; I < 3; I++)
                {

                    for (int Z = 0; Z < 3; Z++)
                    {
                        Console.Write(Array1[I, Z] + " ");

                    }
                    Console.WriteLine("");

                }
            }
            else if (Array1 == null && Array2 != null) {


                for (int I = 0; I < Array2.Length; I++)
                {
                    Array2[I] = (I + 1) * 5;
                }

            }
        }
    }
}
