using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarEjercicio
{
    public class Parcial2
    {
        public double num1;
        public double num2;
        public string nom;
        public double mul;


        public void Multi()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());


            mul = num1 * num2;

            Console.WriteLine("El resultado de la multiplicacion de los numero ingresados es: " +mul);


            Console.WriteLine("El producto de 0 por cualquier numero es 0 ");


        }



        public void Division()
        {
            Console.WriteLine("Ingrese el primero Numero:  ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primero Numero:  ");
            num1 = double.Parse(Console.ReadLine());





            Console.WriteLine("ERROR: No se puede dividir entre cero");

        }
        public void Datos()
        {

            for (i < 0; i++)
            {
                Console.WriteLine("Ingre el nombre: ");
                nom = Console.ReadLine();


            }
        
        }

    }
  }