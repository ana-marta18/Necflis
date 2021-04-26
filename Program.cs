using System;

namespace Necflis
{
    class Program
    {
        static void Main(string[] args)
        {
                NecflisClientes clientes = new NecflisClientes(null, null, 0);
                NecflisClientes[] nuevocliente = new NecflisClientes[20];
                NecflisPeliculas peliculas = new NecflisPeliculas(null, null, null, null);
                NecflisPeliculas[] lista2 = new NecflisPeliculas[20];
                NecflisUsuarios usuarios = new NecflisUsuarios(null, null, 0);
                NecflisUsuarios[] lista3 = new NecflisUsuarios[40];
                string[] Lista = new string[15];
                int Cont = 0;
                int numeracion = 1 ;
                int Control = 0;
                int Play = 1;
                int numero = 0;
                int s1 = 0;
            do
            {
                //Bienvenida al programa 
                Console.WriteLine("           ╔══════════════════════════════════════╗                    ");
                Console.WriteLine("           ╠═══════  Bienvenido a Necflis  ═══════╣                    ");
                Console.WriteLine("           ╚══════════════════════════════════════╝                    ");
                Console.WriteLine("");
                //Creamos el menú Principal
                Console.WriteLine("Puedes elegir una de las tres opciones que aparecen a continuacion: \n"+
                "\n1.---Clientes"+
                "\n2.---Peliculas"+
                "\n3.---Salir");
                Console.WriteLine("");
                s1 = Convert.ToInt16(Console.ReadLine()); 
                switch(s1)
                {
                    case 1:
                    int s2 = 0;
                        do
                        {
                            //Creamos el menú para clientes
                            Console.WriteLine("Puedes elegir una de las cuatro opciones que aparecen a continuacion: \n"+
                            "\n1.---Ver listado de Clientes"+
                            "\n2.---crear nuevo Cliente"+
                            "\n3.---Seleccionar Cliente"+
                            "\n4.---Atras");
                            Console.WriteLine("");
                            s2 = Convert.ToInt16(Console.ReadLine());
                            switch(s2)
                            {

                                case 1:
                                    Console.WriteLine("Bienvenido a las opción Ver listado de Clientes");
                                    Console.WriteLine("═══════════════════════════════════════════════");
                                    Console.WriteLine("");
                                    Console.WriteLine("               Listado de Clientes             ");
                                    Console.WriteLine("***********************************************");
                                    Console.WriteLine("");
                                    for (int i = 0; i < Cont; i++)
                                    {
                                        clientes = nuevocliente[i];
                                        Console.WriteLine(numeracion + ". " + clientes.Nombre);
                                        numeracion++;
                                    }
                                        numeracion= 1;
                                    break;

                                case 2:
                                    Console.WriteLine("Bienvenido a las opcion Crear nuevo Cliente");
                                    Console.WriteLine("═══════════════════════════════════════════");
                                    clientes = new NecflisClientes();
                                    nuevocliente[Cont] = clientes;
                                    Cont++; 
                                    Console.WriteLine("");
                                break;

                                case 3:
                                    Console.WriteLine("  Bienvenido a las opcion seleccionar cliente");
                                    Console.WriteLine("");
                                    Console.WriteLine("*************************************************");
                                    Console.WriteLine("Ingrese el numero del cliente para seleccionarlo:");
                                    int primervalor = Int32.Parse(Console.ReadLine());
                                    NecflisClientes primercliente = nuevocliente[primervalor -1];
                                    Console.WriteLine("      Informacion del cliente");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Nombre: "+ primercliente.Nombre);
                                    Console.WriteLine("Direccion: " + primercliente.Direccion);
                                    Console.WriteLine("Edad: " + primercliente.Edad);
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("");
                                while(true)
                                {
                                    Console.WriteLine("═══════════════════════════════════");
                                    Console.WriteLine("     Elija una de las opciones");
                                    Console.WriteLine("1. Playlist");
                                    Console.WriteLine("2. Agregar pelicula");
                                    Console.WriteLine("3. Atras");
                                    Console.WriteLine("═══════════════════════════════════");
                                    int op = Int32.Parse(Console.ReadLine());
                                    if (op ==1)
                                    {
                                        for (int i = 0; i < Control; i++)
                                        {
                                            string valores = usuarios.Listas[i];
                                            Console.WriteLine( Play +" " + valores);
                                            Play++;
                                        }
                                        Play = 1;
                                    }
                                    if (op ==2)
                                    {
                                        while(true)
                                                {
                                                Console.WriteLine("**************************************");
                                                Console.WriteLine("            Lista de Peliculas        ");
                                                for (int i = 0; i < numero; i++)
                                                {
                                                    peliculas = lista2[i];
                                                    Console.WriteLine( Play +" " + peliculas.Nombre);
                                                    Play++;
                                                }
                                                Play = 1;
                                                Console.WriteLine("******************************************");
                
                                                Console.WriteLine("Escoja la pelicula que desea agregar");
                                                int escojer = Int32.Parse(Console.ReadLine());
                                                if(escojer==0)
                                                {

                                                    usuarios = new NecflisUsuarios(primercliente.Nombre,Lista);
                                                    break;
                                                    
                                                }
                                                
                                                else{
                                                    peliculas = lista2[escojer-1];
                                                    string pelis = peliculas.Nombre; 
                                                    usuarios =new NecflisUsuarios(primercliente.Nombre,pelis,Control);
                                                    lista3[Control] = usuarios;
                                                    Control++;

                                                }

                                                for (int i = 0; i < Control; i++)
                                                {
                                                    usuarios=lista3[i];
                                                    Lista[i] = usuarios.NombrePeliculas;
                                                }

                                                }
                                    }
                                    if (op ==3)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                    Console.WriteLine("Escoja uno de los valores");
                                    }
                                }
                                break;
                                case 4:
                                Console.WriteLine("Presiona Enter para volver atras");
                                Console.ReadKey();
                                break; 
                            } 
                        } while(s2 !=4);
                            break;

                            case 2:
                                Console.WriteLine("Bienvenido a las opcion Peliculas");
                                Console.WriteLine("═════════════════════════════════");
                                int s4 = 0;
                                do
                                {
                                    //Creamos el menú para Peliculas
                                    Console.WriteLine("Puedes elegir una de las tres opciones que aparecen a continuacion: \n"+
                                    "\n1.---Ver listado de Peliculas"+
                                    "\n2.---crear Pelicula"+
                                    "\n3.---Atras");
                                    Console.WriteLine("");
                                    s4 = Convert.ToInt16(Console.ReadLine());
                                        switch(s4)
                                        {
                                            case 1:
                                            Console.WriteLine("Bienvenido a las opcion ver listado de Peliculas");
                                            Console.WriteLine("════════════════════════════════════════════════");
                                            Console.WriteLine("");
                                            //Opcion para ver el listado de peliculas
                                            Console.WriteLine("               Listado de Peliculas             ");
                                            Console.WriteLine("************************************************");
                                            Console.WriteLine("");
                                            for (int i = 0; i < Cont; i++)
                                            {
                                                peliculas = lista2[i];
                                                System.Console.WriteLine(numeracion +". " + peliculas.Nombre);
                                                numeracion++;
                                            }
                                            numeracion= 1;
                                            Console.WriteLine("");
                                            break;

                                            case 2:
                                            //Opcion para crear las peliculas
                                            Console.WriteLine("Bienvenido a la opcion Crear Pelicula");
                                            Console.WriteLine("══════════════════════════════════════");
                                            peliculas = new NecflisPeliculas();
                                            lista2[Cont] = peliculas;
                                            Cont++; 
                                            Console.WriteLine("");
                                                break;

                                            case 3 :
                                            //Opcion para volver atras 
                                            Console.WriteLine("Presiona Enter para volver atras");
                                            Console.ReadKey();
                                            break;
                                            default:
                                            Console.WriteLine("Esa opcion no existe, elija otra.");
                                            Console.ReadKey();
                                            break;
                                        }
                                } while(s4 !=3);
                            break;

                            case 3:
                            //Despedida del programa
                            Console.WriteLine("Gracias por registrarte y usar nuestra servicio");
                            Console.WriteLine("No olvides descargar nuestra aplicacion");
                            Console.WriteLine("Hasta la proxima...");
                            break;
                            default:
                            Console.WriteLine("Esa opcion no existe");
                            Console.ReadKey();
                            break;
                }           
            } while(s1 !=3);

            { 
                Console.ReadKey();
            }
        }
    }
}


