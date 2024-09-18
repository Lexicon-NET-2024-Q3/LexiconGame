
internal class Game
{
    private Map map = null!;
    private Hero hero = null!;

    internal void Run()
    {
        Initialize();
        Play();
    }

    private void Play()
    {
       //DrawMap

       //GetCommand

       //Act

       //DrawMap

       //EnemyAction

       //DrawMap
    }

    private void Initialize()
    {
        //ToDo: Read from config maybe
        map = new Map(width: 10, height: 10);
        hero = new Hero(); 
    }
}