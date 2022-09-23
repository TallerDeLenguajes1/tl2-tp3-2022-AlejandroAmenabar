public class Persona
{
    public int id{get;set;}
    public string nombre{get;set;}
    public string direccion{get;set;}
    public string telefono{get;set;}

    public Persona(){
        this.nombre="xxxx";
        this.direccion="xxxx";
        this.telefono="xxxx";
    }
    public Persona(int id, string nombre, string direccion, string telefono)
    {
        this.id=id;
        this.nombre=nombre;
        this.direccion=direccion;
        this.telefono=telefono;
    }
}

public class Cliente : Persona
{   
    Cliente(int id, string nombre, string direccion, string telefono, string datosReferencia): base(id,nombre,direccion,telefono)
    {
        this.datosReferencia = datosReferencia;
    }
    public string datosReferencia;
}

public class Cadete : Persona
{
    public Cadete(int id, string nombre, string direccion, string telefono,List<pedidos> pedidos) : base(id,nombre,direccion,telefono)
    {
        listaPedidos = pedidos;
    }
    public List<pedidos> listaPedidos;
    
    public void listarPedidos()
    {
        foreach (pedidos pedido in listaPedidos)
        {
            Console.WriteLine("pedido numero: "+pedido.numero);
            Console.WriteLine("Observacion: "+pedido.observacion);
            Console.WriteLine("Cliente ID: "+pedido.cliente.id);
            Console.WriteLine("Cliente: "+pedido.cliente.nombre);
            Console.WriteLine("Direccion: "+pedido.cliente.direccion);
            Console.WriteLine("Telefono: "+pedido.cliente.telefono);
        }
    }

    public float jornalAPagar()
    {   
        float total=0;
        foreach (pedidos pedido in listaPedidos)
        {
            if(pedido.entregado){
                total+=300;
            }
        }
        return total;
    }
    
}