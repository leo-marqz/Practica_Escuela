using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ejecutar = true;
            string nombre = "";
            string apellido = "";
            int edad = 0;
            int año = 0;

            var miEscuela = new Escuela(1001,"Itca-Fepade", tipoEscuela.Superior, 250);
            Console.WriteLine(miEscuela);

            System.Console.WriteLine("\tINGRESE LOS DATOS SOLICITADOS PARA AGREGAR EL ESTUDIANTE AL SISTEMA\n");
            int x = 1;
            while(ejecutar){
                System.Console.Write("\tNombre: ");
                nombre = Console.ReadLine();
                System.Console.Write("\tApellido: ");
                apellido = Console.ReadLine();
                System.Console.Write("\tEdad: ");
                edad = Int32.Parse(Console.ReadLine());     
                System.Console.Write("\tAño de estudio: "); 
                año = Int32.Parse(Console.ReadLine());

                var e = new Estudiante(x,nombre,apellido,edad,año);
                x++;

                miEscuela.AgregarEstudiante(e);

                System.Console.Write("\n\tQuieres ingresar datos de otro estudiante: [si = s,si,SI,Si] [no = n,no,NO,No]: ");
                string respuesta = Console.ReadLine();
                if(respuesta == "si" || respuesta == "s" || respuesta == "SI" || respuesta == "Si"){
                    System.Console.WriteLine("\n\t-----------------------------------------------------");
                }
                else if(respuesta == "no" || respuesta == "n" || respuesta == "NO" || respuesta == "No"){
                    miEscuela.PrintListaEstudiantes();
                    break;
                }
                else{
                    System.Console.WriteLine("Error.....");
                    break;
                }
            }
            

        }
    }
}
