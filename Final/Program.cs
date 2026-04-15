namespace itm.csharp.basic
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}! por favor, elige un ejercicio del siguiente menú:");
            Menu.MostrarMenu();
            while (true)
            {
                string entrada = Console.ReadLine().ToLower();
                if (entrada == "q" || entrada == "exit")
                {
                    break; // salir del bucle
                }

                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    // agregar la lógica del switch con las funciones de los ejercicios...

                    switch (eleccion)
                    {
                        case 1: new challenge1().Run(); break;
                        case 2: new challenge2().Run(); break;
                        case 3: new challenge3().Run(); break;
                        case 4: new challenge4().Run(); break;
                        case 5: new challenge5().Run(); break;
                        case 6: new challenge6().Run(); break;
                        case 7: new challenge7().Run(); break;
                        case 8: new challenge8().Run(); break;
                        case 9: new challenge9().Run(); break;
                        case 10: new challenge10().Run(); break;
                        case 11: new challenge11().Run(); break;
                        case 12: new challenge12().Run(); break;
                        case 13: new challenge13().Run(); break;
                        case 14: new challenge14().Run(); break;
                        case 15: new challenge15().Run(); break;
                        default:
                            Console.WriteLine("Opción no válida. por favor , ingrese un número del 1 al 15 o 'q' para salir.");
                            continue;
                    }
                    Console.WriteLine("Presion una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MostrarMenu();


                }

                else
                {
                    Console.WriteLine("Opción no válida. por favor , ingrese un número del 1 al 15 o 'q' para salir.");
                }


            }
            Console.WriteLine("¡Hasta luego!");
        }
    }


}