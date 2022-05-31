// See https://aka.ms/new-console-template for more information

public class Tarea
{
    private int TareaID;
    private String Descripcion;
    private int Duracion;

    public Tarea(int tareaID, string descripcion, int duracion)
    {
        TareaID = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public int TareaID1 { get => TareaID; set => TareaID = value; }
    public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    public int Duracion1 { get => Duracion; set => Duracion = value; }



    public void MostrarTarea(){
        System.Console.WriteLine("TAREA ID: " + TareaID);
        System.Console.WriteLine("Descripcion: " + Descripcion);
        System.Console.WriteLine("Tiempo empleado(Minutos): " + Duracion);
    }
}
