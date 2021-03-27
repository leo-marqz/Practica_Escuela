using System;
using System.Collections;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
  class Escuela
  {

    List<Hashtable> ListaEstudiantes = new List<Hashtable>();

    public int Id { get; }
    public string Nombre { get; }
    public tipoEscuela TipoEscuela { get; }
    public int CantidadEstudiantes { get; }

    public void AgregarEstudiante(Estudiante estudiante){
      Hashtable e = new Hashtable();
      e.Add("Id",estudiante.Id);
      e.Add("Nombre",estudiante.Nombre);
      e.Add("Apellido",estudiante.Apellido);
      e.Add("Edad",estudiante.Edad);
      e.Add("Año", estudiante.AñoEstudio);

      this.ListaEstudiantes.Add(e);
    }

    public void PrintListaEstudiantes(){
      System.Console.WriteLine("\tLISTA DE ESTUDIANTES DE LA ESCUELA : " + this.Nombre + "\n");
      foreach(var e in this.ListaEstudiantes){
        System.Console.WriteLine("\tId: " + e["Id"] + "   Nombre: " + e["Nombre"] + "   Apellido: " + e["Apellido"] + "   Edad: " + e["Edad"] + "   Año de estudiante: " + e["Año"]);
      }
    }


    public override string ToString()
    {
      return "\n\tDATOS DE ESCUELA\n" + "\tId: " + this.Id + "\tNombre: " + this.Nombre + "\tTipo de escuela: " + this.TipoEscuela + "\tCantidad de estudiantes: " + this.CantidadEstudiantes + "\n";
    }
    public Escuela(int id, string nombre, tipoEscuela tipoEscuela, int cantidadEstudiantes)
    {
      this.Nombre = nombre;
      this.Id = id;
      this.Nombre = nombre;
      this.TipoEscuela = tipoEscuela;
      this.CantidadEstudiantes = cantidadEstudiantes;
    }
    public Escuela(){}
  }

}


