using System;

namespace primerParcial
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Declaracion de Variables
            int option;
            string[] name = new string[10];
            string[] surname = new string[10];
            int[] dni = new int[10];
            int[] viaje = new int[10];
            int[] cost = new int[10];
            int viajeTotal = 0;
            int costTotal = 0;
            bool salir = false;
            string mainaux;
            int mainaux2;
            int answerValidation = 0;
            bool limitUsers = false;
            bool limitViajes = false;
            int reportMenu;
            #endregion Declaracion de Variables

            Console.WriteLine("*****Remiseria El Chimuelo - V.Beta******");
            Console.WriteLine();
            option = showMenu("Bienvenido!");

            while (!salir)
            {
                switch (option)
                {
                    #region Caso 1 Alta Cliente
                    case 1:
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (name[i] == null) //Podria usar un isnullorempty?
                            {
                                limitUsers = false;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el nombre del cliente");
                                    name[i] = Console.ReadLine();
                                    Console.WriteLine("");
                                    if (int.TryParse(name[i], out mainaux2) == true)
                                    {
                                        Console.WriteLine("Error! Presione ENTER para reintentar su carga.");

                                    }
                                    else
                                    {
                                        Console.WriteLine($"Usted ingreso: {name[i]}, es correcto?\n1.Si\n2.No");
                                        int.TryParse(Console.ReadLine(), out answerValidation);
                                    }
                                    Console.Clear();
                                } while (int.TryParse(name[i], out mainaux2) == true || answerValidation != 1);

                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el apellido del cliente");
                                    surname[i] = Console.ReadLine();
                                    Console.WriteLine("");
                                    if (int.TryParse(surname[i], out mainaux2) == true)
                                    {
                                        Console.WriteLine("Error! Presione ENTER para reintentar su carga.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Usted ingreso: {surname[i]}, es correcto?\n1.Si\n2.No");
                                        int.TryParse(Console.ReadLine(), out answerValidation);
                                    }
                                    Console.Clear();
                                } while (int.TryParse(name[i], out mainaux2) == true || answerValidation != 1);

                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el numero de DNI del cliente (Min: 1000000, Max: 100000000)");
                                    mainaux = Console.ReadLine();
                                    Console.WriteLine("");
                                    if (!int.TryParse(mainaux, out dni[i]) || dni[i] < 1000000 || dni[i] > 100000000)
                                    {
                                        Console.WriteLine("Error! Presione ENTER para reintentar su carga.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Usted ingreso: {dni[i]}, es correcto?\n1.Si\n2.No");
                                        int.TryParse(Console.ReadLine(), out answerValidation);
                                    }
                                    Console.Clear();
                                } while (!int.TryParse(mainaux, out dni[i]) || dni[i] < 1000000 || dni[i] > 100000000 || answerValidation != 1);
                                break;
                            }
                        }
                        if (limitUsers == true)
                        {
                            Console.WriteLine("Se ha alcanzado la capacidad maxima de usuarios, vuelva a intentar su carga en otro momento.");
                            Console.WriteLine();
                            Console.WriteLine("Presione ENTER para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        };
                        limitUsers = true;
                        option = showMenu("¿Qué mas desea hacer?");
                        break; //Fin del caso 1
                    #endregion Caso 1 Alta Cliente

                    #region Caso 2 Viaje
                    case 2:
                        for (int i = 0; i < viaje.Length; i++)
                        {
                            if (viaje[i] == 0)
                            {
                                limitViajes = false;
                                do
                                {
                                    Console.WriteLine("Bienvenido a su viaje. ¿Cuantos kilometros desea realizar? (Max: 10000)");
                                    mainaux = Console.ReadLine();
                                    Console.WriteLine("");
                                    if (!int.TryParse(mainaux, out viaje[i]) || viaje[i] <= 0 || viaje[i] > 10000)
                                    {
                                        Console.WriteLine("Error! Presione ENTER para reintentar su carga.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Usted ingreso: {viaje[i]}Km. ¿Es correcto?\n1.Si\n2.No");
                                        int.TryParse(Console.ReadLine(), out answerValidation);
                                        Console.Clear();
                                        if (answerValidation == 1 && 0 < viaje[i] && 5 >= viaje[i])
                                        {
                                            cost[i] = 150;
                                            costTotal = costTotal + cost[i];
                                            viajeTotal = viajeTotal + viaje[i];
                                            Console.WriteLine($"Su viaje costara aproximadamente ${cost[i]}");
                                            Console.WriteLine();
                                            Console.WriteLine("Presione ENTER para volver al menu");
                                            Console.ReadKey();
                                        }
                                        else if (answerValidation == 1 && viaje[i] > 5)
                                        {
                                            cost[i] = 150 + ((viaje[i] - 5) * 35);
                                            costTotal = costTotal + cost[i];
                                            viajeTotal = viajeTotal + viaje[i];
                                            Console.WriteLine($"Su viaje costara aproximadamente ${cost[i]}");
                                            Console.WriteLine();
                                            Console.WriteLine("Presione ENTER para volver al menu");
                                            Console.ReadKey();
                                        }
                                    }
                                    Console.Clear();
                                } while (!int.TryParse(mainaux, out viaje[i]) || viaje[i] <= 0 || viaje[i] > 10000 || answerValidation != 1);
                                break;
                            }
                        }
                        if (limitViajes == true)
                        {
                            Console.WriteLine("Se ha alcanzado la capacidad maxima de viajes, vuelva a intentar su carga en otro momento.");
                            Console.WriteLine();
                            Console.WriteLine("Presione ENTER para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        };
                        limitViajes = true;
                        option = showMenu("¿Qué mas desea hacer?");
                        break;
                    #endregion Caso 2 Viaje

                    #region Caso 3 Reporte
                    case 3:
                        Console.WriteLine("1. Clientes registrados con viajes asignados");
                        Console.WriteLine("2. Clientes registrados sin viajes asignados");
                        Console.WriteLine("3. Viajes registrados sin clientes asignados");
                        Console.WriteLine("4. Total de kilometros recorridos");
                        Console.WriteLine("5. Total recaudado");
                        Console.WriteLine();
                        int.TryParse(Console.ReadLine(), out reportMenu);
                        Console.Clear();
                        switch (reportMenu)
                        {
                            case 1:
                                Console.WriteLine("Clientes registrados y sus respectivos viajes: ");
                                Console.WriteLine();
                                for (int i = 0; i < name.Length; i++)
                                {
                                    if (name[i] != null && viaje[i] != 0)
                                    {
                                        Console.WriteLine($"{i + 1})" + "- " + name[i] + " " + surname[i] + " - " + dni[i] + " - $" + cost[i] + " - " + viaje[i] + "km. ");
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Clientes registrados SIN viajes: ");
                                for (int i = 0; i < name.Length; i++)
                                {
                                    if (name[i] != null && viaje[i] == 0)
                                    {
                                        Console.WriteLine($"{i + 1})" + "- " + name[i] + " " + surname[i] + " - " + dni[i]);
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Viajes sin clientes asignados: ");
                                for (int i = 0; i < name.Length; i++)
                                {
                                    if (name[i] == null && viaje[i] != 0)
                                    {
                                        Console.WriteLine($"{i + 1}) - $" + cost[i] + " - " + viaje[i] + "km. ");
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine($"Kilometros recorridos: {viajeTotal}");
                                break;
                            case 5:
                                Console.WriteLine($"Dinero recaudado: {costTotal}");
                                break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Presione ENTER para volver al menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        option = showMenu("¿Qué mas desea hacer?");
                        break;//Fin caso 3
                    #endregion Caso 3 Reporte

                    #region Caso 4 Salir
                    case 4:
                        do
                        {
                            Console.WriteLine("Esta seguro de que desea salir?\n1.Si\n2.No");
                            int.TryParse(Console.ReadLine(), out answerValidation);
                            Console.Clear();
                            if (answerValidation == 1)
                            {
                                Console.WriteLine("Gracias por confiar en Remiseria El Chimuelo");
                                salir = true;
                            }
                            else if (answerValidation == 2)
                            {
                                option = showMenu("¿Qué mas desea hacer?");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ERROR! Presione ENTER para reintentar");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        } while (answerValidation != 1 && answerValidation != 2);
                        break; //Fin caso 4
                        #endregion Caso 4 Salir
                }
            }
        }
        static int showMenu(string mensaje)
        {
            int aux;
            do
            {
                Console.WriteLine(mensaje);
                Console.WriteLine();
                Console.WriteLine("1. Alta Nuevo Cliente");
                Console.WriteLine("2. Hacer un Viaje");
                Console.WriteLine("3. Reporte");
                Console.WriteLine("4. Salir de la App"); ;
                int.TryParse(Console.ReadLine(), out aux);
            } while (aux != 1 && aux != 2 && aux != 3 && aux != 4);
            Console.Clear();
            return aux;
        }
    }
}