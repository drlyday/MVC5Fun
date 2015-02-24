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
        static void Main(string[] args)
        {
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
        /// 
        /// </summary>
        /// <param name="app">Provides behavior for </param>
        public void Configuration(IAppBuilder app)
        {
            app.Run(ctx => ctx.Response.WriteAsync("Hellow World"));
        }
    }
}
