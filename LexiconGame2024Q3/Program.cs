
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Environment.CurrentDirectory)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .Build();

//var ui = config.GetSection("game:ui").Value; 
//var x = config.GetSection("game:mapsettings:x").Value; 
//var y = config.GetSection("game:mapsettings:y").Value; 

//var mapSettings = config.GetSection("game:mapsettings").GetChildren(); 

var game = new Game(new ConsoleUI(), config);
game.Run();

Console.WriteLine("Game over");
Console.ReadKey(); 