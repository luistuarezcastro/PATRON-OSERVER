using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Observer
{
    //Primero creamos una interface la cual nos va a permitir actualizar los clientes
    interface Observer
    {
        //recibe la notificacion del cambio de estado cuando suceda una actualizacion
        void actualizacion(string Notificacion);
    }
}
