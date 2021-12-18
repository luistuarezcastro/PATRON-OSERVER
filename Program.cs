using System;

namespace Patron_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de Sujeto_Cliente de nuestra paguina o nuestra tienda
            Sujeto_cliente tienda = new Sujeto_cliente();
            // instancia de Observador_cliente, los clientes que se agg a nuestra web
            Observador_cliente Primer_Cliente = new Observador_cliente("Don Alfredo", tienda);
            tienda.agg(Primer_Cliente);
            Observador_cliente Segundo_Cliente = new Observador_cliente("Jean Carlos", tienda);
            tienda.agg(Segundo_Cliente);
            Observador_cliente Tercer_Cliente = new Observador_cliente("Martha Gonzales", tienda);
            tienda.agg(Tercer_Cliente);
            Observador_cliente Cuarto_Cliente = new Observador_cliente("Joel Miller", tienda);
            tienda.agg(Cuarto_Cliente);
            Observador_cliente Quinto_Cliente = new Observador_cliente("Maria Jose", tienda);
            tienda.agg(Quinto_Cliente);
            //ciclo para cambiar de estado del observable
            //sirve para notificar si se agrego o se elimino un cliente
            for (int x=0; x < 2; x++)
            {
                tienda.Cambio();
            }
            // eliminamos clientes
            Console.WriteLine();
            tienda.eliminar(Primer_Cliente);
            tienda.eliminar(Cuarto_Cliente);
            // cambiamos el estado del observable para que notifique las y los clientes eliminados
            for (int x = 0; x < 1; x++)
            {
                tienda.Cambio();
            }
            Console.WriteLine();
            //de igual manera podemos añadir nuevos cientes
            Observador_cliente Sexto_Cliente = new Observador_cliente("Silene Oliveira", tienda);
            tienda.agg(Sexto_Cliente);
            //cambio de estado para actualizar
            tienda.Cambio();
        }
    }
}
