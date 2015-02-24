using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace KatanaIntro
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app">Owin Component which gives access to Katana components</param>
        public void Configuration(IAppBuilder app)
        {
            app..Run(ctx => {ctx.});
        }
    }
}
