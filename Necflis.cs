namespace Necflis
{
    public class NecflisClientes
    {
        public string Nombre;

        public string Direccion;

        public int Edad; 


        public NecflisClientes (string Nombre, string Direccion, int Edad )
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Edad = Edad;


        }

        public NecflisClientes ()
        {
            System.Console.WriteLine("Ingrese su Nombre: ");
            Nombre = System.Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("Ingrese su Dirección: ");
            Direccion = System.Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("Ingrese su Edad: ");
            Edad = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("");

        }
    }

    public class NecflisPeliculas
    {
        public string Nombre;

        public string Tipo;

        public string Genero;

        public string Sinopsis;

         public NecflisPeliculas (string Nombre, string Tipo, string Genero, string Sinopsis)
        {
            this.Nombre = Nombre;
            this.Tipo = Tipo;
            this.Genero = Genero;
            this.Sinopsis = Sinopsis;

        }

        public NecflisPeliculas()
        {
            System.Console.WriteLine("Ingrese el Nombre: ");
            Nombre = System.Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("Escoja el Tipo ");
            System.Console.WriteLine("* Serie");
            System.Console.WriteLine("* Pelicula");
            Tipo = System.Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("Escoja el Genero: ");
            System.Console.WriteLine("* Drama");
            System.Console.WriteLine("* Romace");
            System.Console.WriteLine("* Comedia");
            System.Console.WriteLine("* Suspenso");
            System.Console.WriteLine("* Terror");
            Genero = System.Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine("Ingrese una pequeña sinopsis: ");
            Sinopsis = System.Console.ReadLine();
            System.Console.WriteLine("");

        }

    }

    public class NecflisUsuarios
    {
        public string NombreCliente;

        public string NombrePeliculas;

        public int Can;

        public string [] Listas;

        public NecflisUsuarios(string NombreCliente, string NombrePeliculas, int Can )
        {
            this.NombreCliente = NombreCliente;
            this.NombrePeliculas = NombrePeliculas;
            this.Can= Can;
        }

        public NecflisUsuarios(string NombreCliente, string[] Listas)
        {
            this.NombreCliente = NombreCliente;
            this.Listas =Listas;
        }
    }   
}