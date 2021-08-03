using System;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    public static class Program
    {
        static void Main(string[] args)
        {
            new Usuarios().Menu();
        }
    }

    public class Usuarios
    {

        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
            this.PersonaNegocio = new PersonaLogic();
        }

        public UsuarioLogic UsuarioNegocio { get; set; }
        public PersonaLogic PersonaNegocio { get; set; }
        public void Menu()
        {
            int opc = 0;
            do
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine(" 1 – Listado General");
                    Console.WriteLine(" 2 – Consulta");
                    Console.WriteLine(" 3 – Agregar");
                    Console.WriteLine(" 4 - Modificar");
                    Console.WriteLine(" 5 - Eliminar");
                    Console.WriteLine(" 6 - Salir");
                    Console.Write("\n Ingrese una opcion: ");
                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                        if (opc < 1 || opc > 6) throw new ArgumentOutOfRangeException();
                        break;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Debes ingresar un numero.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El numero ingresado no esta dentro del rango permitido.");
                    }

                } while (true);

                switch (opc)
                {
                    case 1:
                        ListadoGeneral();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Agregar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    case 5:
                        Eliminar();
                        break;
                    default: break;
                }
            } while (opc != 6);

        }
        private void MostrarDatos(Usuario usr)
        {
            Console.WriteLine($"\nUsuario: {usr.ID}");
            Console.WriteLine($"\t\tNombre: {usr.MiPersona.Nombre}");
            Console.WriteLine($"\t\tApellido: {usr.MiPersona.Apellido}");
            Console.WriteLine($"\t\tNombre de usuario: {usr.NombreUsuario}");
            Console.WriteLine($"\t\tClave: {usr.Clave}");
            Console.WriteLine($"\t\tEmail: {usr.MiPersona.EMail}");
            Console.WriteLine($"\t\tHabilitado: {usr.Habilitado}");
        }
        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int id = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(id);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("\nPresione una tecla para volver al menu.");
                Console.ReadKey();
            }
        }

        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del Usuario a modificar: ");
                int id = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(id);

                Console.Write("\nIngrese Nombre: ");
                usuario.MiPersona.Nombre = Console.ReadLine();

                Console.Write("\nIngrese Apellido: ");
                usuario.MiPersona.Apellido = Console.ReadLine();

                Console.Write("\nIngrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();

                Console.Write("\nIngrese Clave: ");
                usuario.Clave = Console.ReadLine();

                Console.Write("\nIngrese Email: ");
                usuario.MiPersona.EMail = Console.ReadLine();

                Console.Write("\nIngrese Habilitacion de Usuario (1 = Si / Otro = No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");

                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);

            }
            catch (FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("\nPresione una tecla para volver al menu.");
                Console.ReadKey();
            }

        }

        private void Agregar()
        {
            Usuario usuario = new Usuario();


            Console.Clear();

            Console.Write("Ingrese ID Persona: ");
            Persona persona = PersonaNegocio.GetOne(int.Parse(Console.ReadLine()));
            usuario.MiPersona = persona;

            Console.Write("Ingrese Nombre: ");
            usuario.MiPersona.Nombre = Console.ReadLine();

            Console.Write("\nIngrese Apellido: ");
            usuario.MiPersona.Apellido = Console.ReadLine();

            Console.Write("\nIngrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();

            Console.Write("\nIngrese Clave: ");
            usuario.Clave = Console.ReadLine();

            Console.Write("\nIngrese Email: ");
            usuario.MiPersona.EMail = Console.ReadLine();

            Console.Write("\nIngrese Habilitacion de Usuario (1 = Si / Otro = No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");

            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine($"\nID: {usuario.ID}");

            Console.Write("\nPresione una tecla para volver al menu.");
            Console.ReadKey();
        }

        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(id));
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("\nPresione una tecla para volver al menu.");
                Console.ReadKey();
            }

        }

        private void ListadoGeneral()
        {
            Console.Clear();

            foreach (Usuario user in UsuarioNegocio.GetAll())
            {
                MostrarDatos(user);
            }
            Console.Write("\nPresione una tecla para volver al menu.");
            Console.ReadKey();
        }
    }
}
