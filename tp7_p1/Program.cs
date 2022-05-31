// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var ListaARealizar = new List<Tarea>();
var ListaTerminadas = new List<Tarea>();
crearTareas(ListaARealizar);
var opcion = 0;
String aux;
do
{
    System.Console.WriteLine("1-Control de Tareas");
    System.Console.WriteLine("2-Buscar Tarea");
    System.Console.WriteLine("3-Horas trabajadas");
    System.Console.WriteLine("Ingrese una opcion: ");
    aux = System.Console.ReadLine();
    opcion = Convert.ToInt32(aux);
    switch (opcion)
    {
        case 1:
            CambiarARealizada(ListaTerminadas ,ListaARealizar);
            break;
        case 2:

            break;
        case 3:

            break;
        default:

            break;
    }
} while (opcion != 5);















void CambiarARealizada(List<Tarea> ListaTerminadas, List<Tarea> ListaARealizar)
{
    var bandera = 0;
    String aux;
    foreach (var item in ListaARealizar)
    {
        System.Console.WriteLine("Realizo la:");
        item.MostrarTarea();
        do
        {
            System.Console.WriteLine("1-Se realizo");
            System.Console.WriteLine("2-No se realizo");
            System.Console.WriteLine("Ingrese una opcion: ");
            aux = System.Console.ReadLine();
            bandera = Convert.ToInt32(aux);
            if (bandera != 1 || bandera != 2)
            {
                System.Console.WriteLine("Eligio una opcion no valida... Elija una correcta.");
            }
        } while (bandera != 1 || bandera != 2);
        if (bandera == 1)
        {
            ListaARealizar.Remove(item);
            ListaTerminadas.Add(item);
            bandera = 0;
            System.Console.WriteLine("Se movio la tarea a realizadas.");
        }
    }
}

void crearTareas(List<Tarea> Lista)
{
    int nTareas = new Random().Next(3, 10);
    for (int i = 0; i < nTareas; i++)
    {
        Tarea Taux = new Tarea(i, "Esta es la descripcion de la tarea numero " + i, new Random().Next(15, 60));
        Lista.Add(Taux);
    }
}

Tarea BuscarTarea(List<Tarea>Lista, String Buscado){
    int bandera;
foreach (var item in Lista)
{
    bandera=item.Descripcion1.CompareTo(Buscado);
}

    return
}
