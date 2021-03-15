using System;

namespace Ejercicios01Practico02.Consola
{
    /*Ingresar 10 temperaturas comprendidas entre -20 y 50 grados,
     al final informar la mayor y la menor y el promedio. 
    Mostrar las temperaturas y marcar aquellas superiores al promedio*/
    class Program
    {
        static void Main(string[] args)
        {
            /*En la variable mayorTemperatura se guardará la mayor temperatura registrada
             Se la inicializa con un valor muy chico para que el primer valor que se ingrese
            automáticamente sea el nuevo mayor*/
            Console.Title = "Ingreso de temperaturas";
            double mayorTemperatura = double.MinValue;
            double menorTemperatura = double.MaxValue;
            double promedioTemperatura = 0;
            double[] arrayTemperatura = new double[10];
            for (int i = 0; i < 10; i++)
            {
                bool esError = true;
                double temperatura;
                do
                {
                    Console.Write($"Ingrese {i + 1}º temperatura:");
                    if (double.TryParse(Console.ReadLine(), out temperatura))
                    {
                        if (temperatura>=-20 && temperatura<=50)
                        {
                            Console.WriteLine($"La temperatura es {temperatura}");
                            //Asigno la temperatura al array
                            arrayTemperatura[i] = temperatura;
                            esError = false;
                        }
                        else
                        {
                            Console.WriteLine("Temperatura fuera del rango permitido -20 y 50");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Temperatura mal ingresada");
                    }
                } while (esError);

                if (temperatura > mayorTemperatura)
                {
                    mayorTemperatura = temperatura;
                }
                if (temperatura < menorTemperatura)
                {
                    menorTemperatura = temperatura;
                }

                promedioTemperatura += temperatura;
                //promedioTemperatura = promedioTemperatura + temperatura;
            }

            promedioTemperatura = promedioTemperatura / 10;

            foreach (var temperatura in arrayTemperatura)
            {
                if (temperatura>promedioTemperatura)
                {
                    Console.WriteLine($"{temperatura}*");
                }
                else
                {
                    Console.WriteLine($"{temperatura}");
                }
            }
            Console.WriteLine($"La mayor temperatura es {mayorTemperatura}");
            Console.WriteLine($"La menor temperatura es {menorTemperatura}");
            Console.WriteLine($"El promedio de temperatura es {promedioTemperatura}");

            Console.ReadLine();

        }
    }
}
