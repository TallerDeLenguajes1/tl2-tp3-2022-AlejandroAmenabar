public class cadeteria1
{
    public string nombre{get;set;}
    public string telefono{get;set;}
    public List<Cadete> Cadetes{get;set;}

    cadeteria1(string nombre, string telefono,List<Cadete> Cadetes)
    {
        this.nombre=nombre;
        this.telefono=telefono;
        this.Cadetes = Cadetes;
    }
}