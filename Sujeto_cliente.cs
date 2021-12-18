using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Observer
{
    class Sujeto_cliente : Subject
    {
        // lista que nos permite almacenar los observadores que se agg al sujeto observador
        private List<Observer> clientes = new List<Observer>();
        private string salida;
        //metodo para agregar un cliente-Seguidor
        public void agg(Observer cliente)
        {
            Console.WriteLine("Se ha agregado un nuevo Cliente a tu tienda");
            clientes.Add(cliente);
        }
        //metodo para eliminar un cliente-Seguidor
        public void eliminar(Observer cliente)
        {
            Console.WriteLine("Se ha eliminado un Cliente a tu tienda");
            clientes.Remove(cliente);
        }
        public void Notificacion()
        {
            //Notificamos el cambio de estado de la pagina web a cada Cliente-Seguidor
            foreach (Observer observer in clientes)
            {
                observer.actualizacion(salida);
            }
        }
        //Este metodo es para realizar un cambio de estado que se notifica a cada Cliente-Seguidor
        // cada que añadimos algo a la tiende este notifica a los clientes - seguidores
        public void Cambio()
        {
            Console.WriteLine("Hemos agregado nuevos productos a nuestra tienda");
            salida = "ahora disponemos de mas productos, visitanos para comprar";
            Notificacion();
        }
    }
}
