
LimitedList<Creature> li = new LimitedList<Creature>(4);
LimitedList<int> li2 = new LimitedList<int>(3);

List<Creature> li3 = new List<Creature>();
List<int> li4 = new List<int>(); 

var game = new Game();
game.Run();

Console.WriteLine("Game over");
Console.ReadKey(); 