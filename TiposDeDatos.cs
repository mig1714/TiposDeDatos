using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos//Separa un espacio en memoria
{
    internal class Program
    {

        struct Auto//es casi una clase es un poco mas simple
        {
            public string marca;
            public int modelo;
            public string tipo;

        }
        static void Main(string[] args)
        {
            byte numByte = 255;
            byte numByte2 = 1; //no negativos
            short numero1 = 32358;
            short numero2 = -32588;
            int num1;
            int num2;//variable entera

            double doble = 25.8923853253d; //mas decimales que el flotante

            decimal deci = 2555.32m;

            Boolean boleano= false;
            char caracter = 'a';


            long larga = 15425; //enteros grandes

            float flotante1 = 3.14f;//cuando hay decimales

            string fecha = "Hoy es lunes";

            var variable = 5;

           
            
            Console.WriteLine("Esta es la variable: "+ variable);

            dynamic dinamico = 20;

            dinamico = "Hola dinamico";

            dinamico = true;
            Console.WriteLine(dinamico);




            Auto carro = new Auto();

            carro.tipo = "4x4";
            carro.modelo = 1;
            carro.marca = "Toyota";
            /*
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Marca: "+carro.marca+" "+"Modelo: "+carro.modelo+" "+"Tipo: "+carro.tipo);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");*/

            Console.WriteLine("{0}, {1}, {2}", carro.marca, carro.tipo, carro.modelo);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{carro.marca}");

            num1 = 20; num2 = 5;
            Console.WriteLine($"El resultado de la suma es: {num1 + num2}");

            Console.WriteLine("La multiplicación es: {0}",  num1 * num2);//transfiere la operacion
            Console.WriteLine("Digite un numero");

            num1 = Int32.Parse( Console.ReadLine());//indica error
            //num1 = Convert.ToInt32(Console.ReadLine());//devuelvo un 0 o un null trata que el programa no se detenga

            Console.WriteLine("Digite un numero");

            num2 = Int32.Parse(Console.ReadLine());//indica error
            //num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado: {0}", num1 - num2);

            //se puede hacer alguna operacion dos estructuras diferentes pero si el resultado no cumple con alguno de los limites da error
            //ejemplo resultado flotante = flotante +doble
            //el error es por el doble
            float resultado3 = flotante1 + float.Parse(doble.ToString());
            Console.WriteLine(resultado3);

            //Arreglos

            int[] notas = new int[] { 100, 110, 45, 30};
            
            string[] estudiantes = new string[4];
            estudiantes[0] = "Jorge";
            estudiantes[1] = "Miguel";
            estudiantes[2] = "Juan";
            estudiantes[3] = "Rocío";
            /*
            foreach (string estudiante in estudiantes) {

                Console.WriteLine("Estudiante: "+ estudiante);
            }*/

            for (int i = 0; i < estudiantes.Length; i++) {

                Console.WriteLine("Estudiante: "+ estudiantes[i]+" "+"Nota: " + notas[i]);
            }


            Console.ReadLine();


            






        }
    }
}
