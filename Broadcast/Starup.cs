using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Broadcast.Starup))]

// LADO DEL SERVIDOR

namespace Broadcast
{
    public class Starup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(); // Por defecto tomara la ruta "/signalr" aunque no se pongo como parametro
        }
    }
}
