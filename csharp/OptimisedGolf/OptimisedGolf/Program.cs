using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OptimisedGolf.Models;

namespace OptimisedGolf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player fernie = new Player("fernie");
            Player moneyTree = new Player("money tree");
            Player aloe = new Player("aloe");
            Player aloeJr = new Player("aloe jr");

            //Game game = new Game(new List<Player> {fernie, moneyTree, aloe, aloeJr}, false);

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
