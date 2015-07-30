using Microsoft.AspNet.SignalR;

namespace TyJonesChat
{
   public class TyJonesChatHub : Hub
   {
      public void Send( string name, string message )
      {
         Clients.All.broadcastMessage( name, message );
      }
   }
}