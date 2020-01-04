using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Broadcast.Hub
{
    // LADO DEL SERVIDOR

    public class BroadcastHub : Microsoft.AspNet.SignalR.Hub
    {
        // Cada vez que los clientes que invoquen este metodo , internamente
        // se llamara al metodo "displaytext· de los clientes para que reciban la informacion.
        // Ahora hay que crear el metodo del lado del cliente
        public void BroadcastMessage(string message)
        {
            Clients.All.displayText(message);
        }
    }
}