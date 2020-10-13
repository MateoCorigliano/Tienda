using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.LibreriaConsola
{
    public static class ConsolaHelper
    {
        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            string n = Console.ReadLine();

          
            return n;
        }

        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese " + msg);

           
            int c = int.Parse(Console.ReadLine());


            return c;
        }

        public static DateTime PedirFecha(string msg)
        {
            Console.WriteLine("Ingrese fecha " + msg + " solo en este formato YYYY-MM-DD");

            
            DateTime f = Convert.ToDateTime(Console.ReadLine());

            return f;
        }

        
        public static bool EsOpcionValida(string input, string opcionesValidas)
        {
            
            try
            {
                // validamos algo
                if (string.IsNullOrEmpty(input)  // es nulo o vacío
                    || input.Length > 1          // tiene más de un caracter       
                    || !opcionesValidas.ToUpper().Contains(input.ToUpper())) // no está dentro de las opciones válidas
                {
                    return false;
                }

                return true;
            }
            
            catch
            {
                

                return false;
            }
        }

        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);

            
            double c = double.Parse(Console.ReadLine());


            return c;
        }
    }
}
