public class pedidos
{
    public int numero{get;set;}
    public string observacion{get;set;}

    public Cliente cliente;
    
    public bool entregado;

    pedidos(int numero, string observacion, Cliente cliente, bool entregado)
    {
        this.numero=numero;
        this.observacion=observacion;
        this.cliente=cliente;
        this.entregado=entregado;
    }

}