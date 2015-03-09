using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Owin;

namespace KatanaIntro001
{
    class Program
    {
        /// <summary>
        /// Here we are starting our self hosted OWIN host rather than an IIS host.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //http://www.codeguru.com/csharp/.net/net_asp/overview-of-owin-and-katana.htm
            const string uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started!");
                Console.ReadKey();
                Console.WriteLine("Stopping");
            }
        }
    }

    public class Startup
    {
        /// <summary>
        /// When a request comes on the define URI, you'll get this response.
        /// </summary>
        /// <param name="app">Provides behavior for </param>
        public void Configuration(IAppBuilder app)
        {
            app.Run(ctx => ctx.Response.WriteAsync("Hello World"));
        }
    }
}
