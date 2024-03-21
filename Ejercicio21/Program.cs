using System;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

            //Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
            //Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
            //Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
            //Si el IMC es mayor de 29.9 entonces tiene obesidad.
            //Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcula


            bool calcularNuevo = true;
            while (calcularNuevo)
            {
                Console.WriteLine("Calculadora de IMC");
                


                //Ingresar Datos

                Console.Write("Ingrese su peso en kilogramos: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese su altura en metros: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine($"Su IMC es: {imc}");

                if (imc < 18.5)
                    Console.WriteLine("Tiene peso insuficiente");
                else if (imc < 25.0)
                    Console.WriteLine("Tiene un peso saludable");
                else if (imc < 30.0)
                    Console.WriteLine("Tiene sobrepeso");
                else
                    Console.WriteLine("Tiene obesidad");

                Console.Write("\n¿Desea calcular el IMC de otra persona? (s/n): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                    calcularNuevo = false;

                Console.WriteLine(); 
            }
        }
    }
