
var map = new Map(10, 10); 
var game = new Game(new ConsoleUI(), map);
game.Run();

Console.WriteLine("Game over");
Console.ReadKey(); 