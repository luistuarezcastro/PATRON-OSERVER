using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Observer
{
    class Observador_cliente: Observer
    {
        //creamon un nombre de usuario
        private string Usuario;
        private Sujeto_cliente sujeto_;
        //creamos un constructor para el cliente-seguidor
        public Observador_cliente(string Cliente_Seguidor, Sujeto_cliente Nombre)
        {
            //asignamos la variable
            Usuario = Cliente_Seguidor;
            sujeto_ = Nombre;
        }
        //metodo que actualiza cambios de estado
        public void actualizacion(string salida)
        {
            Console.WriteLine("Notificar a: {0} - {1}", Usuario, salida );
        }



    }
}
