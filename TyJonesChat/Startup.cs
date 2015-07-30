using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using TyJonesChat;

[assembly: OwinStartup( typeof( Startup ) )]

namespace TyJonesChat
{
   public class Startup
   {
      public void Configuration( IAppBuilder app )
      {
         app.Map( "/signalr", map =>
         {
            map.UseCors( CorsOptions.AllowAll );
            var hubConfiguration = new HubConfiguration
            {
               EnableJSONP = true
            };
            map.RunSignalR( hubConfiguration );
         } );
      }
   }
}
