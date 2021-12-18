using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Observer
{
    interface Subject
    {
    //El siguiente metodo permite agregar clientes-seguidores al objeto el cual va a ser observador
        void agg(Observer cliente);
    // Elimina al cliente de la lista
        void eliminar(Observer cliente);
    // Ultimo metodo para notificar los cambios
        void Notificacion();
    }
}
