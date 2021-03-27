namespace CoreEscuela.Entidades{
  class Estudiante{
    public int Id { get;}
    public string Nombre { get; }
    public string Apellido { get; }
    public int Edad { get; }
    public int AñoEstudio { get; }

    public Estudiante(int id, string nombre, string apellido, int edad, int añoEstudio){
      this.Id = id;
      this.Nombre = nombre;
      this.Apellido = apellido;
      this.Edad = edad;
      this.AñoEstudio = añoEstudio;
    }
  }

}