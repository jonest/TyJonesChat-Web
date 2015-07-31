using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace TyJonesChat
{
   public class TyJonesChatHub : Hub
   {
      public void Send( string name, string message )
      {
         var chatJson = JsonConvert.SerializeObject( new ChatMessage
         {
            Name = name,
            Message = message
         } );
         Clients.All.broadcastMessage( chatJson );
      }
   }
}