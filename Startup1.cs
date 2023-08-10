using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(chat2Prueba.Startup1))]

namespace chat2Prueba
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(); // este inicializa en caso de que tenga varios hubs  pero como solo hay uno inicializa uno 
        }
    }
}
