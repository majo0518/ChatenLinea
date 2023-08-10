using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chat2Prueba
{
    public class ChatLinea : Hub
    {
        public void chat(string nombre, string mensaje)
        {
            Clients.All.chatmaria(nombre, mensaje); // queremos que el cliente nos envie a todos la funcion que yo quiera y le ponemos el nombre que queramos en este caso chatmaria este recibe el nombre y el mensaje y se lo envia a todos los que estan en linea 
        }
    }
}